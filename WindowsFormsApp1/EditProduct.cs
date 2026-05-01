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
    public partial class EditProduct : UserControl
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool first_type = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //check if user typed
            if (first_type && textBox1.Text != "")
            {
                first_type = false; //so it doesn't run again
                textBox1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
