using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Garden_Control_Gui
{
    public class ConfigManagement
    {
        private int statisticsRefreshRate { get; set; }
        private int serverDataRate { get; set; }
        private string arduinoPort { get; set; }
        private string path = @"SavedText\configuration2.txt";
        
        public ConfigManagement()
        {
            readFile();
        }

        public void OnConfigChanged(object sender, ConfigValues args)
        {
            setConfig(args);
            writeFile();
        }
        
        // Pre-Condition: statisticsRefreshRate, serverDataRate, and arduinoPort can't be null/unset
        // Post-Condition: If file doesn't exsist, create it. If the file does exsist, update it.
        private void writeFile()
        {
            if (statisticsRefreshRate <= 0 || serverDataRate <= 0 || arduinoPort == null)
                throw new Exception("Error: Can't write to file while config calues are null or less than or equal to 0");
            if (File.Exists(path))
            {
             // File Structure:
                // Statistics Refresh Rate:
                // SQL Server data entry rate:
                // Arduino Port:
                // SQL Server: 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(statisticsRefreshRate);
                    sw.WriteLine(serverDataRate);
                    sw.WriteLine(arduinoPort);
                }
            }
            else     //Create file with default values for settings
            {
                // Creates an folder called SavedText
                Directory.CreateDirectory("SavedText");

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(statisticsRefreshRate);
                    sw.WriteLine(serverDataRate);
                    sw.WriteLine(arduinoPort);
                }
            }
        }

        // Post-Condition: Set config values to the data stored in the config file.
        //                 If the config file can't be found, set to default values instead.
        private void readFile()
        {
            if (!File.Exists(path))
            {
                this.statisticsRefreshRate = 5;
                this.serverDataRate = 60;
                this.arduinoPort = "COM4";
            }
            else
            {
                string[] lines = File.ReadAllLines(path);

                statisticsRefreshRate = Convert.ToInt32(lines[0]);
                serverDataRate = Convert.ToInt32(lines[1]);
                arduinoPort = lines[2];
            }
        }

        // Post-Condition: Returns config values stored in this object.
        public ConfigValues getConfig()
        {
            return new ConfigValues(this.statisticsRefreshRate, this.serverDataRate, this.arduinoPort);
        }

        public void setConfig(ConfigValues configValues)
        {
            this.statisticsRefreshRate = configValues.statisticsRefreshRate;
            this.serverDataRate = configValues.serverDataRate;
            this.arduinoPort = configValues.arduinoPort;
        }
    }
}
