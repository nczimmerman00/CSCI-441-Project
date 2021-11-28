using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class RecordRetrievalConfiguration
    {
        public string measurement;
        public DateTime startTime;
        public DateTime endTime;
        public string xAxisDisplay;
        
        public RecordRetrievalConfiguration(string measurement, DateTime start, DateTime end, 
            string xAxisDisplay)
        {
            this.measurement = measurement;
            this.startTime = start;
            this.endTime = end;
            this.xAxisDisplay = xAxisDisplay;
        }
    }
}

public class ConfigValues
{
    public int statisticsRefreshRate { get; }
    public int serverDataRate { get; }
    public string arduinoPort { get; }
    
    public ConfigValues(int seconds, int minutes, string port)
    {
        statisticsRefreshRate = seconds;
        serverDataRate = minutes;
        arduinoPort = port;
    }
}