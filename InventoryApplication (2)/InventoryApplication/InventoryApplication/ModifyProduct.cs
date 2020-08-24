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
    public partial class ModifyProduct : Form
    {

        BindingList<Part> Parts = new BindingList<Part>();
        public ModifyProduct()
        {
            InitializeComponent();

            
        }

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            partsAssociatedDataGridView.DataSource = Parts;
            allPartsDataGridView.DataSource = Inventory.AllParts;
            idTextBox.Enabled = false;
            idTextBox.Text = product.ProductID.ToString();
            nameTextBox.Text = product.Name.ToString();
            inventoryTextBox.Text = product.InStock.ToString();
            priceTextBox.Text = product.Price.ToString();
            maxTextBox.Text = product.Max.ToString();
            minTextBox.Text = product.Min.ToString();
            
            foreach(Part part in product.AssociatedParts)
            {
                Parts.Add(part);
            }
            partsAssociatedDataGridView.Update();
            partsAssociatedDataGridView.Refresh();
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            if (productSearchBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in allPartsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userInput = Inventory.LookupPart(int.Parse(productSearchBox.Text));

                        if(userInput.PartID == part.PartID)
                        {
                            row.Selected = true;
                            allPartsDataGridView.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void deletePartsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(partsAssociatedDataGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in partsAssociatedDataGridView.SelectedRows)
                    {
                        partsAssociatedDataGridView.Rows.RemoveAt(row.Index);
                    }
                }

                else
                {
                    MessageBox.Show("Please select a row to delete");
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
            int productID;
            string name = nameTextBox.Text;
            int inStock;
            decimal price;
            int max;
            int min;

            try
            {
                productID = int.Parse(idTextBox.Text);
                inStock = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                min = int.Parse(minTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please make sure all fields are filled correctly. {ex.ToString()}");
                return;
            }

            if (max < min)
            {
                MessageBox.Show("Invalid number. Max must be greater than Min");
                return;
            }
            if (inStock > max || inStock < min)
            {
                if (inStock > max)
                {
                    MessageBox.Show("Inventory must be less than Max");
                    return;
                }
                else
                {
                    MessageBox.Show("Inventory must be greater than Min");
                    return;
                }
            }

            Product product = new Product(productID, name, inStock, price, max, min);
            foreach (Part part in Parts)
            {
                product.AssociatedParts.Add(part);
            }
            Inventory.UpdateProduct(productID, product);
            MessageBox.Show($"{name} was successfully modified");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
