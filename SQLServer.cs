using System;
using System.Collections.ObjectModel;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Remote_Garden_Control_Gui
{
    //Server password is 'csci441'
    class SQLServer
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
            database = "gardenproject";
            uid = "programUser";
            password = "csci441";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException error)
            {

                if (SQLServerError != null)
                {
                    switch (error.Number)
                    {
                        case 0:     //0: Cannot connect to server.
                            SQLServerError(this, "Cannot connect to server.");
                            break;
                        case 1045:  //1045: Invalid user name and/or password.
                            SQLServerError(this, "Invalid username/password.");
                            break;
                        default:
                            SQLServerError(this, "Unaddressed SQL server error: " + error.Number);
                            break;
                    }
                }
                return false;
            }
        }

        private bool CloseConnection()
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
        
        public void submitGardenData(ArduinoData data) 
        {
            string query = "INSERT INTO gardendata (recordTime, temperature, humidity, soil_moisture) " +
                "VALUES('" + getDateTimeString(DateTime.Now) + "', '" + data.temperature + "', '" + data.humidity + "', '" + 
                data.moisture +  "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void submitGardenData(ArduinoData data, DateTime dateTime)
        {
            string query = "INSERT INTO gardendata (recordTime, temperature, humidity, soil_moisture) " +
                "VALUES('" + getDateTimeString(dateTime) + "', '" + data.temperature + "', '" + data.humidity + "', '" +
                data.moisture + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public Series retriveGardenData(RecordRetrievalConfiguration config)
        {
            //Generate query
            string query = "";
            if (config.xAxisDisplay == "All Data")
            {
                query = "select recordTime, round(" + config.measurement + ", 2) from gardendata " +
                        "where recordTime >= '" + getDateTimeString(config.startTime) + 
                        "' AND recordTime <= '" + getDateTimeString(config.endTime) + "';";
            }
            else if (config.xAxisDisplay == "Daily Average")
            {
                query = "select Date(recordTime), round(avg(" + config.measurement + "), 2) from gardenData " +
                    "where recordTime >= '" + getDateTimeString(config.startTime) + 
                    "' AND recordTime <= '" + getDateTimeString(config.endTime) + "'" +
                    " group by date(recordTime);";
            }
            else
            {
                throw new Exception("Unknown RecordRetrievalConfiguration xAxisDisplay recieved: "
                    + config.xAxisDisplay);
            }
            if (this.OpenConnection() == true)
            {
                bool foundInfo = false;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Series graphPoints = new Series();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foundInfo = true;
                    string dateTime = reader.GetMySqlDateTime(0).ToString();
                    if (config.xAxisDisplay == "All Data")
                        dateTime = dateTime.Remove(dateTime.Length - 3, 3);
                    graphPoints.Points.AddXY(dateTime,
                        (double)reader.GetFloat(1));
                }
                this.CloseConnection();
                if (!foundInfo)
                    return null;
                else
                    return graphPoints;
            }
            else
            {
                return null;
            }
        }
        private bool SubmitLoginInfo(string username, string password)
        {
            string query = "select password from logininfo where username = \"" + username + "\";";
            if (this.OpenConnection() == true)
            {
                bool returnValue = false;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

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
        private string getDateTimeString(DateTime input)
        {
            //Turn the current date and time into a string for the query.
            string currentDateTime = input.ToString();
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
        public void OnRecordUpdate(object source, ArduinoData args)
        {
            submitGardenData(args);
        }
        public void OnLoginSubmitted(object source, LoginInfo login)
        {
            bool returnValue = false;
            string query = "SELECT password FROM logininfo WHERE username = '" + login.username + 
                "' AND password = '" + login.password + "';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    returnValue = true;
                }
                this.CloseConnection();
            }
            else
                throw new Exception("Connection to the SQL server failed during login attempt.");
            login.verified = returnValue;
        }
    }
}
