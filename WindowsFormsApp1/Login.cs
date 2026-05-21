using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string LoginFile = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\users.json"));
        private List<user> GetUsers()
        {
            if (!File.Exists(LoginFile))
            {
                return new List<user>();
            }
            string json = File.ReadAllText(LoginFile);
            return JsonSerializer.Deserialize<List<user>>(json);
        }
        private void SaveUsers(List<user> users)
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(LoginFile, json);
        }
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
            List<user> users = GetUsers();
            foreach (user u in users)
            {
                if (u.Username == Username && u.Password == Password)
                {
                    MessageBox.Show("Login successful");
                    new Form1().Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Wrong username or password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<user> users = GetUsers();

            user newUser = new user();
            newUser.Username = textBox1.Text;
            newUser.Password = textBox2.Text;

            users.Add(newUser);

            SaveUsers(users);

            MessageBox.Show("User saved");
        }
    }
}
