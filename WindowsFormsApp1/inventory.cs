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
        public static class QuantityTotal
        {


        }


        private BindingList<Product> _inventorylist = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filePath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\product.csv"));
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
                    MessageBox.Show("Product updated successfully in the list. CSV updated.");

                    List<Product> listToSave = _inventorylist.ToList();
                    InventoryService.SaveToCSV(filePath, listToSave);
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string SearchTerm = DelBox.Text.Trim();
            if(string.IsNullOrWhiteSpace(SearchTerm))
            {
                MessageBox.Show("Please enter a valid product ID/Name to delete.");
                return;
            }
            Product productToDelete = _inventorylist.FirstOrDefault(p => p.ProductID.ToString() == SearchTerm || p.ProductName.Equals(SearchTerm, StringComparison.OrdinalIgnoreCase));
            if(productToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?");
                if (result == DialogResult.Yes)
                {
                    _inventorylist.Remove(productToDelete);
                    DelBox.Clear();
                    MessageBox.Show("Product deleted succesfully");
                }


            }
            else
            {
                MessageBox.Show("No product found matching that name or ID.");
            }
        }

        private void DelBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
