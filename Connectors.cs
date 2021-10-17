using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Remote_Garden_Control_Center
{
    abstract class Connector
    {
        bool deviceIsConnected;
        public SerialPort arduinoPort;
        protected virtual bool checkConnectionStatus() {
            return false;
        }
        Connector()
        {
            
            
        }
        private void openArd()
        {
            //TODO
            arduinoPort = new SerialPort();
            arduinoPort.BaudRate = 9600;
            arduinoPort.PortName = "COM3"; //this changes with usb used, check ardiuno ide
            arduinoPort.Open();

        }

        private void closeArd()
        {
            arduinoPort.Close();
        }
    }
    /*
    class CameraConnector : Connector
    {
        

        static void sendCameraFeed()
        {
            //TODO
        }
    }

    class ValveConnector : Connector
    {
        //TODO
    }

    class LockConnector : Connector
    {
        //TODO
    }

    class HydrometerThermostatConnector : Connector
    {
        //TODO
    }


    class MoistureMeterConnector : Connector
    {
        //TODO
    }
    */
}
