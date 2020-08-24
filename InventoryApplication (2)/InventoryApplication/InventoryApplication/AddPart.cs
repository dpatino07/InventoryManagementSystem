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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            idTextBox.Enabled = false;
        }


        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            machIdLabel.Text = "Machine ID";
        }

        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            machIdLabel.Text = "Company Name";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int inStock;
            decimal price;
            int max;
            int min;
            int machineID = 0;
            string companyName = "";

            try
            {
                inStock = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                min = int.Parse(minTextBox.Text);
                if (inHouseRadioBtn.Checked)
                {
                    machineID = int.Parse(machIdTextBox.Text);
                }
                if (outsourcedRadioBtn.Checked)
                {
                    companyName = machIdTextBox.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please make sure each field has a valid input {ex.ToString()}");
                return;
            }

            if (max < min)
            {
                MessageBox.Show("Min must be less than Max");
                return;
            }
            if (inStock > max || inStock < min)
            {
                if (inStock > max)
                {
                    MessageBox.Show("Invalid Number. Inventory ammount must be less than Max");
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Number. Inventory ammount must be greater than Min");
                    return;
                }
            }

            if (inHouseRadioBtn.Checked)
            {
                InHouse part = new InHouse(ProductNumber(), name, inStock, price, max, min, machineID);
                Inventory.AddPart(part);
                MessageBox.Show($"{name} was successfully added");
                Close();
            }
            if (outsourcedRadioBtn.Checked)
            {
                Outsourced part = new Outsourced(ProductNumber(), name, inStock, price, max, min, companyName);
                Inventory.AddPart(part);
                MessageBox.Show($"{name} was successfully added");
                Close();
            }
        }
        private int ProductNumber()
        {
            Random leadNum = new Random();
            Random tailNum = new Random();

            string tempString = leadNum.Next(70, 79).ToString() + tailNum.Next(000, 999).ToString() + Inventory.AllParts.Count.ToString();
            return int.Parse(tempString);
        }

        // Close Form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
