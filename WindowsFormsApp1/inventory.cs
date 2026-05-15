using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class inventory : UserControl
    {
        private BindingList<Product> _inventorylist = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filePath = "H:/Programming/project/WindowsFormsApp1/WindowsFormsApp1/product.csv";
        public inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filePath);
            _inventorylist.Clear();

            foreach (var item in tempData) 
            {
                _inventorylist.Add(item);
            }

            dataGridView1.DataSource = _inventorylist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
     
            if (!ValidateInputs()) return;

            
            int newId = _inventorylist.Count + 1000;
            string name = productName.Text;
            string brand = productBrand.Text;
            decimal price = decimal.Parse(productPrice.Text);
            int quantity = int.Parse(productQuantity.Text);

 
            Product newProduct = new Product(newId, name, brand, price, quantity);
            _inventorylist.Add(newProduct);


            _bindingSource.ResetBindings(false);

 
            ClearFields();
        }
        private bool ValidateInputs()
        {
            // Check if Name contains invalid special characters like #, $, @
            // This regex allows only letters, numbers, and spaces
            if (!Regex.IsMatch(productName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }


            if (!decimal.TryParse(productPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            if (!int.TryParse(productQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            productID.Clear();
            productBrand.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(productID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }
            var productToUpdate = _inventorylist.FirstOrDefault(p => p.ProductID == idToUpdate);
            if (productToUpdate != null)
            {
 
                if (ValidateInputs())
                {
                    productToUpdate.ProductName = productName.Text;
                    productToUpdate.ProductBrand = productBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(productPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(productQuantity.Text);

                    _bindingSource.ResetBindings(false);
                    dataGridView1.Refresh();

                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");

                    List<Product> listToSave = _inventorylist.ToList();
                    InventoryService.SaveToCSV(filePath, listToSave);
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }

        }
    }
}
