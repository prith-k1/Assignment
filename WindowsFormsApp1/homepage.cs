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

namespace WindowsFormsApp1
{
    public partial class homepage : UserControl
    {
        string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\product.csv"));
        public static class OrderTotal
        {
            public static int OrderTotalNum = 0;
        }
        public homepage()
        {
            InitializeComponent();
            int lineCount = File.ReadLines(filePath).Count();
            label2.Text = $"{lineCount}";
            label5.Text = $"{OrderTotal.OrderTotalNum}";
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
