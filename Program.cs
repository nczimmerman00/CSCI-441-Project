using System;
using System.Windows.Forms;

namespace Remote_Garden_Control_Gui
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Initialize Components
            ConfigManagement configManager = new ConfigManagement();
            ConfigValues initialValues = configManager.getConfig();
            GuiForm mainForm = new GuiForm(configManager);
            LoginForm loginForm = new LoginForm();
            Connector arduino = new Connector();
            SQLServer server = new SQLServer();
            RecordKeeper recordKeeper = new RecordKeeper(arduino, 
                initialValues.serverDataRate, initialValues.statisticsRefreshRate);
            RecordRetriever recordRetriever = new RecordRetriever(server);
            // Login Form Subscriptions
            loginForm.LoginSubmitted += server.OnLoginSubmitted;
            loginForm.LoginSuccess += OnLoginSuccess;
            // Error Subscriptions
            recordKeeper.ArduinoConnectionError += mainForm.OnArduinoConnectionError;
            mainForm.ResetArduino += recordKeeper.OnResetArduino;
            server.SQLServerError += mainForm.OnSQLServerError;
            recordRetriever.EmptySQLQuery += mainForm.OnEmptySQLQuery;
            // RecordKeeper related subscriptions
            recordKeeper.InfoUpdate += server.OnRecordUpdate;
            recordKeeper.GuiUpdate += mainForm.OnGuiUpdate;
            recordKeeper.startTimers();
            // RecordRetriever related subscriptions
            mainForm.GenerateGraphPressed += recordRetriever.OnGenerateGraphPressed;
            // Config related subscriptions
            mainForm.ConfigChanged += configManager.OnConfigChanged;
            mainForm.ConfigChanged += recordKeeper.OnConfigChanged;
            mainForm.ConfigChanged += arduino.OnConfigChanged;

            loginForm.Show();
            Application.Run();

            void OnLoginSuccess(object sender, EventArgs args)
            {
                loginForm.Hide();
                mainForm.Show();
            }
        }
    }
}