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
using System.Security.Cryptography;
using System.Text;

namespace Remote_Garden_Control_Gui
{
    public partial class LoginForm : Form
    {
        public event EventHandler<LoginInfo> LoginSubmitted;
        public event EventHandler<EventArgs> LoginSuccess;
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += this.OnFormClosed;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check to ensure both username and password box are filled
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            bool verified = false;
            if (LoginSubmitted != null)
            {
                byte[] password = Encoding.ASCII.GetBytes(textBox2.Text);
                password = new SHA256Managed().ComputeHash(password);
                string hash = Encoding.ASCII.GetString(password);
                LoginInfo loginInfo = new LoginInfo(textBox1.Text, hash);
                LoginSubmitted(this, loginInfo);
                verified = loginInfo.verified;
            }
            else { return; }
            if (verified)
            {
                if (LoginSuccess != null)
                {
                    LoginSuccess(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        void OnFormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}