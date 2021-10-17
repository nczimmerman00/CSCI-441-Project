using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Remote_Garden_Control_Center
{
    class UserInterface
    {
        
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        //Post Condition: Return an array of device connection status.
        private static bool[] requestDeviceConnections()
        {
            //TODO
            return new bool[1];
        }

        //Post Condition: Return float array with [Temperature, Humidity]
        private static float[] requestTemperatureAndHumidity()
        {
            //TODO
            float[] returnValues;   //   [Temperature, Humidity]


            return new float[] { 0, 0 };
        }

        //Post Condition: Returns float with soil moisure
        private static float requestSoilMoisture()
        {
            //TODO
            return 0;
        }
        
        //Post Condition: Returns camera feed to be used in the UI
        private static void requestCameraFeed()
        {
            //TODO
        }

        //Pre Condition: Water valve is successfully connected
        //Post Condition: Water valve is opened
        private static bool openValve(int valveNumber)
        {
            //TODO
            return false;
        }

        //Pre Condition: Water valve is successfully connected
        //Post Condition: Water valve is closed
        private static bool closeValve(int valveNumber)
        {
            //TODO
            return false;
        }

        //Pre Condition: Lock is successfully connected
        //Post Condition: Lock is disengaged
        private static bool unlockGate() {
            //TODO
            return false;
        }

        //Pre Condition: Lock is successfully connected
        //Post Condition: Lock is engaged
        private static bool lockGate()
        {
            //TODO
            return false;
        }

        //Pre Condition: SQL Server is successfully connected, necessary data entries are present
        //Post Condition: Data is returned in the form of a graph
        private static void viewRecords()
        {
            //TODO
        }
    }

}
