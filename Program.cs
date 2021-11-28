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
            Form1 mainForm = new Form1(configManager);
            Connector arduino = new Connector();
            SQLServer server = new SQLServer();
            RecordKeeper recordKeeper = new RecordKeeper(arduino, 
                initialValues.serverDataRate, initialValues.statisticsRefreshRate);
            RecordRetriever recordRetriever = new RecordRetriever(server);
            // Error Subscriptions
            recordKeeper.ArduinoConnectionError += mainForm.OnArduinoConnectionError;
            mainForm.ResetArduino += recordKeeper.OnResetArduino;
            server.SQLServerError += mainForm.OnSQLServerError;
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

            Application.Run(mainForm);
        }

    }
}