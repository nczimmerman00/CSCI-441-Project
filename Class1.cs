using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEproject
{
    //Server password is 'csci441'
    public class SQLServer
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public event EventHandler<String> SQLServerError;

        public SQLServer()
        {
            server = "localhost";
            database = "login";
            uid = "root";
            password = "csci441";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool GetOpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException error)
            {
                switch (error.Number)
                {
                    case 0:     //0: Cannot connect to server.
                        Console.WriteLine("Cannot connect to server.");
                        break;

                    case 1045:  //1045: Invalid user name and/or password.
                        Console.WriteLine("Invalid username/password.");
                        break;
                    default:
                        Console.WriteLine("Unaddressed Error: " + error.Number);
                        break;
                }
                return false;
            }
        }

        private bool GetCloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
        }

        private bool OpenConnection()
        {
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException error)
                {


                    return false;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException error)
                {
                    SQLServerError(this, error.Message);
                    return false;
                }
            }
        }
        public bool SubmitLoginInfo(string username, string password)
        {
            string query = "select password from logininfo where username = \"" + username + "\";";
            if (this.OpenConnection() == true)
            {
                bool returnValue = false;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read()) {

                    if (password == reader.GetString("password"))
                    {
                        returnValue = true;
                    }
                }
                this.CloseConnection();
                return returnValue;
            }
            else
                throw new Exception("Connection to the SQL server failed while submitting login info.");
        }
    }

   

    class SubmitButton
    {
        private object textBox1;
        private object textBox2;
        private MySqlConnection con;
        private MySqlConnection connection;

        


        private void CloseConnection()
        {
            throw new NotImplementedException();
        }

        private bool OpenConnection()
        {
            throw new NotImplementedException();
        }
        public bool SubmitLoginInfo(string username, string password)
        {
            string query = "select password from logininfo where username = " + username + ";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                this.CloseConnection();
                if (password == reader.GetString("password"))
                {
                    return true;

                }
                else { return false; }
            }
            else
                throw new Exception("Connection to the SQL server failed while submitting login info.");
        }
    }

    /*public void submitGardenData(ArduinoData data)
    {
        string query = "INSERT INTO gardendata (recordTime, temperature, humidity, soil_moisture) " +
            "VALUES('" + getDateTimeString() + "', '" + data.temperature + "', '" + data.humidity + "', '" +
            data.moisture + "')";
        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
        else
            throw new Exception("Connection to the SQL server failed while submitting garden data.");
        string getDateTimeString()
        {
            //Turn the current date and time into a string for the query.
            string currentDateTime = DateTime.Now.ToString();
            bool isAM;
            char[] seperators = new char[] { '/', ' ', ':' };
            string[] parseString = currentDateTime.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            if (parseString[6] == "AM")
                isAM = true;
            else
                isAM = false;
            //Must add 0's before single digit numbers for the Month[0], Day[1], and Hour[3]
            int x = Int32.Parse(parseString[0]);
            if (x < 10)
                parseString[0] = "0" + x;
            x = Int32.Parse(parseString[1]);
            if (x < 10)
                parseString[1] = "0" + x;
            x = Int32.Parse(parseString[3]);
            if (isAM)
            {
                if (x < 10)
                    parseString[3] = "0" + x;
                else if (x == 12)
                    parseString[3] = "00";
            }
            else
            {
                if (x != 12)
                    parseString[3] = "" + (x + 12);
            }
            //Formatted as 'YYYY-MM-DD hh:mm:ss'
            return parseString[2] + "-" + parseString[0] + "-" + parseString[1] +
                " " + parseString[3] + ":" + parseString[4] + ":" + parseString[5];
        }
    }

    public void OnRecordUpdate(object source, ArduinoEventArgs args)
    {
        submitGardenData(args.ArduinoData);
    }
    */
    
}