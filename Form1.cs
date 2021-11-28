using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Garden_Control_Gui
{
    public partial class Form1 : Form
    {
        ConfigManagement config;
        public event EventHandler<EventArgs> ResetArduino;
        public event EventHandler<RecordRetrievalConfiguration> GenerateGraphPressed;
        public event EventHandler<ConfigValues> ConfigChanged;

        public Form1(ConfigManagement x)
        {
            InitializeComponent();
            config = x;
            resetConfig();
        }

        public void OnGuiUpdate(object source, ArduinoData args)
        {
            TemperatureTextBox.Text = args.temperature.ToString();
            HumidityTextBox.Text = args.humidity.ToString();
            SoilMoistureTextbox.Text = args.moisture.ToString();
        }

        public void OnArduinoConnectionError(object source, EventArgs args)
        {
            ArduinoConnectionErrorDialog();
        }

        private void ArduinoConnectionErrorDialog()
        {
            TemperatureTextBox.Text = "ERROR";
            HumidityTextBox.Text = "ERROR";
            SoilMoistureTextbox.Text = "ERROR";
            MessageBox.Show("Error:\nFailed to connect to arduino device.\nPlease " +
                "check the COM port in the configuration settings is correct.");
            ArduinoResetButton.Visible = true;
        }

        public void OnSQLServerError(object source, String errorMessage)
        {
            MessageBox.Show("SQL Server error: " + errorMessage);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }


        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (measurementComboBox.Text == "") {
                MessageBox.Show("Please select a measurement option.");
                return;
            }
            if (axisDisplayComboBox.Text == "") {
                MessageBox.Show("Please select an x-axis display option.");
                return;
            }
            if (startDatePicker.Value.CompareTo(endDatePicker.Value) >= 0)
            {
                MessageBox.Show("The end date can't be earlier or equal to the start date.");
                return;
            }
            RecordRetrievalConfiguration config = new RecordRetrievalConfiguration(
                measurementComboBox.Text,
                startDatePicker.Value,
                endDatePicker.Value,
                axisDisplayComboBox.Text);
            if (config.measurement == "Soil Moisture")
                config.measurement = "soil_moisture";
            if (GenerateGraphPressed != null)
            {
                GenerateGraphPressed(this, config);
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void GraphMaxBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MeasurementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void ArduinoResetButton_Click(object sender, EventArgs e)
        {
            if (ResetArduino != null)
            {
                ResetArduino(this, new EventArgs());
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetConfig();
        }

        private void resetConfig()
        {
            ConfigValues values = config.getConfig();
            SRRNumbericBox.Value = values.statisticsRefreshRate;
            SDERNumbericBox.Value = values.serverDataRate;
            APTextBox.Text = values.arduinoPort;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigValues values = new ConfigValues(Decimal.ToInt32(SRRNumbericBox.Value), 
                Decimal.ToInt32(SDERNumbericBox.Value), APTextBox.Text);
            if (ConfigChanged != null)
            {
                ConfigChanged(this, values);
                MessageBox.Show("Changes saved successfully.");
            }
        }
    }
}
