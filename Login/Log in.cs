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
        public Log_in()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {//Connection String
            SqlConnection con = new SqlConnection(@ "Data Source=STL 4110;Initial Catalog=Practice;Intergrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Userlogins where UserName=@UserName and Password =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Passwod", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully loged in");
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
