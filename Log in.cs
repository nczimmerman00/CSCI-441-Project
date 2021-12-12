using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEproject
{
    public partial class Log_in : Form
    {
        SQLServer server;
        public Log_in(SQLServer s)
        {
            this.server = s;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

            if(server.SubmitLoginInfo(textBox1.Text, textBox2.Text))
            {
                //success!!!
                MessageBox.Show("It works!");
            }
            else
            {
                MessageBox.Show("Inncorrect username or password");
            }
        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
