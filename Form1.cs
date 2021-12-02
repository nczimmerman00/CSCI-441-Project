using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Webcam_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //AForge functions
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        /*The USB webCam works perfectly fine, but my intergated camera on my laptop doesn't display correctly. So Idk if it is something with my laptop that doesn't allow it to display
        or if it's the libaries that I'm using that are causing the issue*/
        private void Form1_Load(object sender, EventArgs e)
        {
            //Detects the camera devices and adds them to the combobox selections
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cameraComboBox.Items.Add(Device.Name);
            cameraComboBox.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Allows the cameras to be read
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CamFrame_CamFeed;
            videoCaptureDevice.Start();
        }

        private void CamFrame_CamFeed(object sender, NewFrameEventArgs eventArgs)
        {
            //Capture the camera's pictures
            camFeed.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stops using the camera when the form is closed
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }
    }
}
