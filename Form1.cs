using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            string path2 = @"SavedText\\configuration2.txt";

            // Creates an folder called SavedText
            Directory.CreateDirectory("SavedText");

            // If the file doesn't exsit then display these defualt values
            if (!File.Exists(path2))
            {
                SRRNumbericBox.Value = 0;
                SDERNumbericBox.Value = 0;
                APTextBox.Text = "Enter here...";
                SHNTextBox.Text = "Enter here...";
            }

            // If the file does exsit then read and diplay the values from the file
            else
            {
                string[] lines = File.ReadAllLines(path2);

                SRRNumbericBox.Value = Convert.ToInt32(lines[0]);
                SDERNumbericBox.Value = Convert.ToInt32(lines[1]);
                APTextBox.Text = lines[2];
                SHNTextBox.Text = lines[3];
            }
        }

        /* 
        
        I was attempted something but I don't really know how to do it.
         
        class saveSettings
        {
            int SRR = 0; //Statistics Refresh Rate
            int SDER = 0; //SQL Server data entry rate
            string AP = ""; //Arduino Port
            string SQLS = ""; //SQL Server
            string path = @"SavedText\\configuration2.txt";

            public saveSettings(int srrValue, int sderValue, string apInput, string sqlsInput)
            {

                SRR = srrValue;
                SDER = sderValue;
                AP = apInput;
                SQLS = sqlsInput;
                
                // Create a file to write to
                if (!File.Exists(path))
                {
                    
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Statistics Refresh Rate: ");
                        sw.WriteLine("SQL Server data entry rate: ");
                        sw.WriteLine("Arduino Port: ");
                        sw.WriteLine("SQL Server: ");
                    }

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(SRR);
                        sw.WriteLine(SDER);
                        sw.WriteLine(AP);
                        sw.WriteLine(SQLS);
                    }
                }
            }
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string path = @"SavedText\\configuration2.txt";
            
            // Reads the file and puts the inputs into an array
            string[] lines = File.ReadAllLines(path);

            // Displays the read inputs from the array into the textboxs in the form 
            SRRNumbericBox.Value = Convert.ToInt32(lines[0]);
            SDERNumbericBox.Value = Convert.ToInt32(lines[1]);
            APTextBox.Text = lines[2];
            SHNTextBox.Text = lines[3];


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*  string path = @"SavedText\\configuration.txt";
              string temp = APTextBox.Text;
              string temp2 = ":Arduino Port";
              Directory.CreateDirectory("SavedText");

              File.WriteAllText(path, temp);
              File.AppendAllText(path, temp2);
              MessageBox.Show("Successfully saved at " + path);
            */
            string path = @"SavedText\\configuration2.txt";

            // Create a file to write to.
            if (!File.Exists(path))
            {
               // APTextBox.Text = "None";
               // SHNTextBox.Text = "None";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(SRRNumbericBox.Value);
                    sw.WriteLine(SDERNumbericBox.Value);
                    sw.WriteLine(APTextBox.Text);
                    sw.WriteLine(SHNTextBox.Text);
                }

            }

            // Overwrites the file.
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(SRRNumbericBox.Value);
                    sw.WriteLine(SDERNumbericBox.Value);
                    sw.WriteLine(APTextBox.Text);
                    sw.WriteLine(SHNTextBox.Text);
                }

            }
            /*
            string[] lines = File.ReadAllLines(path2);

             SRRNumbericBox.Value = Convert.ToInt32(lines[0]);
             SDERNumbericBox.Value = Convert.ToInt32(lines[1]);
             APTextBox.Text = lines[2];
             SHNTextBox.Text = lines[3];
            */

            
        }
    }
}
