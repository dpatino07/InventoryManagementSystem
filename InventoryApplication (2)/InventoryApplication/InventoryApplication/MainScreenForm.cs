using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
            partsDataGridView.DataSource = Inventory.AllParts;
            productsDataGridView.DataSource = Inventory.Products;
            populateData();

        }


  /*      // Function to display Parts in datagridview
        private void displayPartsDGV()
        {
            partsDataGridView.AutoGenerateColumns = false;
            partsDataGridView.DataSource = Inventory.AllParts;
            partsDataGridView.ClearSelection();
        }

        // Function to display Products in datagridview
        private void displayProductsDGV()
        {
            productsDataGridView.AutoGenerateColumns = false;
            productsDataGridView.DataSource = Inventory.Products;
            productsDataGridView.ClearSelection();
        }

    */

        // Pre-populate inventory data 
        private void populateData()
        {
            Part part1 = new InHouse(70001, "Mouse", 60, 4.99m, 200, 2);
            Part part2 = new InHouse(70002, "Keyboard", 60, 14.99m, 200, 2);
            Part part3 = new InHouse(70003, "24\" Monitor", 50, 109.99m, 100, 2);
            Part part4 = new InHouse(70004, "Base Tower", 40, 499.99m, 100, 2);
            Part part5 = new Outsourced(2548, "29\" Ultra-Wide Monitor", 20, 249.99m, 40, 2, "Amajohns");
            Part part6 = new Outsourced(2876, "Premium Tower", 20, 599.99m, 40, 2, "Amajohns");

            Inventory.AllParts.Add(part1);
            Inventory.AllParts.Add(part2);
            Inventory.AllParts.Add(part3);
            Inventory.AllParts.Add(part4);
            Inventory.AllParts.Add(part5);
            Inventory.AllParts.Add(part6);

            Product product1 = new Product(765321, "Base PC", 40, 574.99m, 100, 2);
            product1.AddAssociatedPart(part1);
            product1.AddAssociatedPart(part2);
            product1.AddAssociatedPart(part4);

            Product product2 = new Product(765123, "Base PC /w Monitor", 40, 674.99m, 100, 2);
            product2.AddAssociatedPart(part1);
            product2.AddAssociatedPart(part2);
            product2.AddAssociatedPart(part3);
            product2.AddAssociatedPart(part4);

            Product product3 = new Product(765321, "Premium PC", 20, 674.99m, 40, 2);
            product3.AddAssociatedPart(part1);
            product3.AddAssociatedPart(part2);
            product3.AddAssociatedPart(part6);

            Product product4 = new Product(765321, "Premium PC /w Ultra-Wide Monitor", 20, 899.99m, 40, 2);
            product4.AddAssociatedPart(part1);
            product4.AddAssociatedPart(part2);
            product4.AddAssociatedPart(part5);
            product4.AddAssociatedPart(part6);

            Inventory.Products.Add(product1);
            Inventory.Products.Add(product2);
            Inventory.Products.Add(product3);
            Inventory.Products.Add(product4);
        }

        // Delete selected from Parts
        private void deletePartsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
                {
                    partsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        // Delete selected product button
        private void deleteProductsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product if it has parts associated with it.");
                    return;
                }
                foreach (DataGridViewRow row in productsDataGridView.SelectedRows)
                {
                    productsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }


        // Move through forms and classes
        private void addPartsBtn_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog();
        }
        private void addProductsBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void modifyPartsBtn_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHouse = (InHouse)partsDataGridView.CurrentRow.DataBoundItem;
                ModifyPart modifyPart = new ModifyPart(inHouse);
                modifyPart.ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                ModifyPart modifyPart = new ModifyPart(outsourced);
                modifyPart.ShowDialog();
            }
        }

        private void modifyProductsBtn_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            ModifyProduct modifyProduct = new ModifyProduct(product);
            modifyProduct.ShowDialog();
            productsDataGridView.Update();
            productsDataGridView.Refresh();
        }

        // Search parts button
        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            if (partSearchBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    bool found = false;
                    foreach (DataGridViewRow row in partsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userInput = Inventory.LookupPart(int.Parse(partSearchBox.Text));

                        if (userInput.PartID == part.PartID)
                        {
                            row.Selected = true;
                            partsDataGridView.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("Part ID not found");
                    }
                }
                catch
                {

                }
            }
        }

        // Search products button
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
                    foreach (DataGridViewRow row in productsDataGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        Product userInput = Inventory.LookupProduct(int.Parse(productSearchBox.Text));

                        if (userInput.ProductID == product.ProductID)
                        {
                            row.Selected = true;
                            productsDataGridView.CurrentCell = row.Cells[0];
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


        // Close form
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
