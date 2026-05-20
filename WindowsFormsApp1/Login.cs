using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string LoginFile = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\users.csv"));
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if(validateLogin(Username, Password))
            {
                MessageBox.Show("Succesful Login");
                //form open
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and password invalid, try again.");
                return;
            }

        }
        private bool ValidInput(string Username, string Password)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter something for both the username and the password.");
                return false;
            }
        }
        private bool validateLogin(string username, string password)
        {

        }

    }
}
