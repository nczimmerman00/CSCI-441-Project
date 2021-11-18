using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Remote_Garden_Control_Gui
{
    class ArduinoEventArgs : EventArgs
    {
        public ArduinoData ArduinoData { get; set; }
    }
    
    class RecordKeeper
    {
        System.Windows.Forms.Timer guiTimer;
        System.Windows.Forms.Timer recordTimer;
        int recordTimerLength; //ms
        int guiTimerLength;
        Connector arduino = new Connector();
        public event EventHandler<ArduinoEventArgs> InfoUpdate;
        
        public RecordKeeper()
        {
            //Need to set timerLength from configuration file.
            recordTimerLength = 3600000;
            guiTimerLength = 10000;
        }

        protected virtual void OnRecordUpdate()
        {
            if (InfoUpdate != null)
            {
                ArduinoData newData = arduino.requestGardenData();
                InfoUpdate(this, new ArduinoEventArgs() { ArduinoData = newData});
            }
        }

        private void updateGuiInfo()
        {
            ArduinoData newData = arduino.requestGardenData();
        }

        public void startRecordTimer()
        {
            recordTimer = new System.Windows.Forms.Timer();
            recordTimer.Interval = recordTimerLength;
            recordTimer.Tick += new EventHandler(this.OnTimerFinished);
            recordTimer.Enabled = true;
        }

        public void startGuiTimer()
        {
            guiTimer = new System.Windows.Forms.Timer();
            guiTimer.Interval = guiTimerLength;
            recordTimer.Tick += new EventHandler(this.OnTimerFinished);
            guiTimer.Enabled = true;
        }

        private void OnTimerFinished(object source, EventArgs args)
        {
            if (source == recordTimer)
                OnRecordUpdate();
            else if (source == guiTimer)
                //Todo
                ;
            else
                throw new Exception("Unknown source object sent to OnTimerFinished function.");   
        }
    }

    class RecordRetriever
    {
        //TODO
        public void generateGraph(string measurement, string timePeriod, int max)
        {
            //Form graphForm = new Form();
            
        }
    }
}
