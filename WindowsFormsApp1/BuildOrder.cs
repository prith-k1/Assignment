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
    public partial class BuildOrder : UserControl
    {
        private BindingList<Product> _availableProducts;
        private BindingList<OrderItem> _currentOrderItems = new BindingList<OrderItem>();
        private string _csvPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\product.csv"));
        public BuildOrder()
        {
            InitializeComponent();
            SetupOrderSystem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetupOrderSystem()
        {
            // Apply these settings to the Inventory grid
            DGavailable.ReadOnly = true;
            DGavailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGavailable.MultiSelect = false; // Prevents selecting multiple rows at once

            // Apply these settings to the Current Order grid
            DGorder.ReadOnly = true;
            DGorder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGorder.MultiSelect = false;

            // Configure Inventory Grid (Left)
            DGavailable.AutoGenerateColumns = false;
            DGavailable.Columns.Clear();
            DGavailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            DGavailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            var products = InventoryService.LoadFromCSV(_csvPath);
            _availableProducts = new BindingList<Product>(products);
            DGavailable.DataSource = _availableProducts;

            // Configure Current Order Grid (Right)
            DGorder.AutoGenerateColumns = false;
            DGorder.Columns.Clear();
            DGorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            DGorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            DGorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            DGorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            DGorder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            DGorder.DataSource = _currentOrderItems;
            DGorder.AllowDrop = true;

            SaveOrder.Click += SaveOrder_Click;
            LoadOrder.Click += LoadOrder_Click;
        }

        private void DGavailable_MouseDown(object sender, MouseEventArgs e)
        {
            if (DGavailable.SelectedRows.Count > 0)
            {
                var product = (Product)DGavailable.SelectedRows[0].DataBoundItem;
                DGavailable.DoDragDrop(product, DragDropEffects.Copy);
            }
        }

        private void DGorder_DragDrop(object sender, DragEventArgs e)
        {
            Product droppedProduct = (Product)e.Data.GetData(typeof(Product));
            AddProductToOrder(droppedProduct);

        }

        private void DGorder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Product)))
                e.Effect = DragDropEffects.Copy;
        }

        private void AddProductToOrder(Product product)
        {
            var ExistingItem = _currentOrderItems.FirstOrDefault(i => i.ProductID == product.ProductID);
            if (ExistingItem != null)
            {
                ExistingItem.Quantity++;
            }
            else
            {
                _currentOrderItems.Add(new OrderItem
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.ProductPrice,
                    Quantity = 1
                });
            }
            _currentOrderItems.ResetBindings();
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            decimal total = _currentOrderItems.Sum(i => i.Subtotal);
            label1.Text = $"Total: {total:C2}";
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            if (DGavailable.SelectedRows.Count == 0) return;
            {
                var product = (Product)DGavailable.SelectedRows[0].DataBoundItem;
                AddProductToOrder(product);
            }
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {

        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            if (_currentOrderItems.Count == 0)
            {
                MessageBox.Show("There are no items in the order to save.");
                return;
            }

            Order order = new Order
            {
                OrderName = textBox1.Text,
                Description = textBox2.Text,
                OrderDate = DateTime.Now,
                Items = _currentOrderItems.ToList(),
                TotalAmount = _currentOrderItems.Sum(i => i.Subtotal)
            };

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveDialog.FileName = "order.json";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonSerializer.Serialize(order, new JsonSerializerOptions { WriteIndented = true });
                    System.IO.File.WriteAllText(saveDialog.FileName, json);
                    MessageBox.Show("Order saved successfully.");
                }
            }
        }

        private void LoadOrder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = System.IO.File.ReadAllText(openDialog.FileName);
                    Order order = JsonSerializer.Deserialize<Order>(json);

                    if (order == null) return;

                    textBox1.Text = order.OrderName;
                    textBox2.Text = order.Description;

                    _currentOrderItems.Clear();

                    foreach (OrderItem item in order.Items)
                    {
                        _currentOrderItems.Add(item);
                    }

                    _currentOrderItems.ResetBindings();
                    UpdateTotal();
                    MessageBox.Show("Order loaded successfully.");
                }
            }
        }
    }
}
