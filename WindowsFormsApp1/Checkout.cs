using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Checkout : UserControl
    {
        private BindingList<OrderItem> _checkoutItems = new BindingList<OrderItem>();

        public Checkout()
        {
            InitializeComponent();
            SetupCheckoutSystem();
        }

        private void SetupCheckoutSystem()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Order Items", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "SKU", Width = 120 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Quantity", Width = 100 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Total Price", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            dataGridView1.DataSource = _checkoutItems;

            UpdateTotal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_checkoutItems.Count == 0)
            {
                MessageBox.Show("Load an order before completing a sale.");
                return;
            }

            MessageBox.Show("Sale completed.");
            ClearCheckout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCheckout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = System.IO.File.ReadAllText(openDialog.FileName);
                    Order order = JsonSerializer.Deserialize<Order>(json);

                    if (order == null)
                    {
                        MessageBox.Show("Could not load this order.");
                        return;
                    }

                    _checkoutItems.Clear();

                    foreach (OrderItem item in order.Items)
                    {
                        _checkoutItems.Add(item);
                    }

                    _checkoutItems.ResetBindings();
                    UpdateTotal();
                }
            }
        }

        private void ClearCheckout()
        {
            _checkoutItems.Clear();
            _checkoutItems.ResetBindings();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = _checkoutItems.Sum(i => i.Subtotal);
            label1.Text = $"Total: {total:C2}";
        }
    }
}
