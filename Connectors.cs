using System;
using System.IO.Ports;

namespace Remote_Garden_Control_Gui
{
    class Connector
    {
        public SerialPort arduinoPort;
        private string portName;

        public bool checkConnectionStatus()
        {
            try
            {
                openArd();
                closeArd();
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
        private void openArd()
        {
            arduinoPort = new SerialPort();
            arduinoPort.BaudRate = 9600;
            arduinoPort.PortName = this.portName; //this changes with usb used, check ardiuno ide
            arduinoPort.Open();
        }

        private void closeArd()
        {
            arduinoPort.Close();
        }

        //Post Condition: Return float array with [Temperature, Humidity, Soil Moisture]
        public ArduinoData requestGardenData()
        {
            try
            {
                openArd();
                string input = arduinoPort.ReadLine();
                closeArd();
                return parseInputData(input);
            }
            catch (Exception e) // (if ard can't be found)
            {
                return null;
            }
        }

        private static ArduinoData parseInputData(string x)
        {
            float[] returnValues = { -1, -1, -1 };
            string[] inputPieces = x.Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            /*
            if (inputPieces.length != 6) {
                throw new Exception();
            } 
            */
            for (int i = 1, k = 0; i < inputPieces.Length; i += 2, k++)
            {
                returnValues[k] = float.Parse(inputPieces[i]);
            }
            return new ArduinoData(returnValues[0], returnValues[1], returnValues[2]);
        }
        public void OnConfigChanged(object sender, ConfigValues args)
        {
            this.portName = args.arduinoPort;
        }
    }
}