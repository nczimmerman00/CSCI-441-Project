using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

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

            SQLServer server = new SQLServer();
            RecordKeeper recordKeeper = new RecordKeeper();

            recordKeeper.InfoUpdate += server.OnRecordUpdate;
            recordKeeper.startRecordTimer();

            Application.Run(new Form1());
        }

        //Post Condition: Return an array of device connection status.
        private static bool[] requestDeviceConnections()
        {
            //TODO
            return new bool[1];
        }

        //Pre condition - ip? direct feed from arduino?
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
        private static bool unlockGate()
        {
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
