using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Remote_Garden_Control_Gui
{
    public class ArduinoData
    {
        public float temperature;
        public float humidity;
        public float moisture;

        public ArduinoData(float t, float h, float m)
        {
            this.temperature = t;
            this.humidity = h;
            this.moisture = m;
        }

    }

    class Connector
    {
        bool deviceIsConnected;
        public SerialPort arduinoPort;
        protected virtual bool checkConnectionStatus()
        {
            //TODO
            return false;
        }
        private void openArd()
        {
            arduinoPort = new SerialPort();
            arduinoPort.BaudRate = 9600;
            arduinoPort.PortName = "COM5"; //this changes with usb used, check ardiuno ide
            arduinoPort.Open();

        }

        private void closeArd()
        {
            arduinoPort.Close();
        }

        //Post Condition: Return float array with [Temperature, Humidity, Soil Moisture]
        public ArduinoData requestGardenData()
        {
            float[] returnValues;   //[Temperature, Humidity, Soil Moisture]
            try
            {
                openArd();
                string input = arduinoPort.ReadLine();
                closeArd();
                return parseInputData(input);
            }
            catch (Exception e) //(if ard can't be found)
            {
                //Todo 
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
    }
}