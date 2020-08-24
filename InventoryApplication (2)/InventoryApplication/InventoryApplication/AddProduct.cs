using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class AddProduct : Form
    {
        BindingList<Part> Parts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();

            allPartsDataGridView.DataSource = Inventory.AllParts;
            partsAssociatedDataGridView.DataSource = Parts;
            
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int partToSearch = int.Parse(productSearchBox.Text);
                if (partToSearch < 0)
                {
                    MessageBox.Show("Please enter a valid PartID.");
                    return;
                }
                else
                {
                    Part searchPart = Inventory.LookupPart(partToSearch);
                    foreach (DataGridViewRow row in allPartsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == searchPart.PartID)
                        {
                            allPartsDataGridView.ClearSelection();
                            row.Selected = true;
                            productSearchBox.Text = "";
                            return;
                        }
                    }
                    MessageBox.Show("Error: Part not found.");
                    productSearchBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter a valid PartID.\n{ex}");
            }
        }

        private void deletePartsBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete of product
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Prevent user from deleting products with associated parts
                foreach (DataGridViewRow row in partsAssociatedDataGridView.SelectedRows)
                {
                    partsAssociatedDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void addPartsBtn_Click(object sender, EventArgs e)
        {
            Part part = (Part)allPartsDataGridView.CurrentRow.DataBoundItem;
            Parts.Add(part);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int inStock;
            decimal price;
            int max;
            int min;

            try
            {
                inStock = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                min = int.Parse(minTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please make sure each field has a valid input.\n{ex.ToString()}");
                return;
            }

            // Validate that Min is always less than Max
            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max");
                return;
            }
            // Inventory must be between min and max
            if (inStock > max || inStock < min)
            {
                if (inStock > max)
                {
                    MessageBox.Show("Invalid Number. Inventory must be less than Max");
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Number. Inventory must be greater than Min");
                    return;
                }
            }

            Product product = new Product(ProductNumber(), name, inStock, price, max, min);
            foreach (Part part in Parts)
            {
                product.AssociatedParts.Add(part);
            }
            Inventory.AddProduct(product);
            Close();
        }

        private int ProductNumber()
        {
            Random leadNum = new Random();
            Random tailNum = new Random();

            string tempString = leadNum.Next(001, 099).ToString() + tailNum.Next(000, 999).ToString() + Inventory.AllParts.Count.ToString();
            return int.Parse(tempString);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
