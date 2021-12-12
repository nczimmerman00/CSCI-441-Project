using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class GuiForm : Form
    {
        ConfigManagement config;
        public event EventHandler<EventArgs> ResetArduino;
        public event EventHandler<RecordRetrievalConfiguration> GenerateGraphPressed;
        public event EventHandler<ConfigValues> ConfigChanged;

        //AForge functions
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public GuiForm(ConfigManagement x)
        {
            InitializeComponent();
            config = x;
            resetConfig();
        }

        public void OnEmptySQLQuery (object source, EventArgs args)
        {
            MessageBox.Show("No data could be found between the selected time periods.");
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
            //Detects the camera devices and adds them to the combobox selections
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cameraComboBox.Items.Add(Device.Name);
            cameraComboBox.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
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
            APBox.Text = values.arduinoPort;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigValues values = new ConfigValues(Decimal.ToInt32(SRRNumbericBox.Value), 
                Decimal.ToInt32(SDERNumbericBox.Value), APBox.Text);
            if (ConfigChanged != null)
            {
                ConfigChanged(this, values);
                MessageBox.Show("Changes saved successfully.");
            }
        }

        private void SQLSDERlabel_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Allows the cameras to be read
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CamFrame_CamFeed;
            videoCaptureDevice.Start();
        }

        private void CamFeed_Click(object sender, EventArgs e)
        {

        }

        private void CamFrame_CamFeed(object sender, NewFrameEventArgs eventArgs)
        {
            //Capture the camera's pictures
            camFeed.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
