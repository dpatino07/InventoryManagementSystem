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
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(InHouse inHouse)
        {
            InitializeComponent();
            inHouseRadioBtn.Checked = true;
            outsourcedRadioBtn.Checked = false;
            idTextBox.Enabled = false;
            idTextBox.Text = inHouse.PartID.ToString();
            nameTextBox.Text = inHouse.Name;
            inventoryTextBox.Text = inHouse.InStock.ToString();
            priceTextBox.Text = inHouse.Price.ToString();
            maxTextBox.Text = inHouse.Max.ToString();
            minTextBox.Text = inHouse.Min.ToString();
            machIdLabel.Text = "MachineID";
            machIdTextBox.Text = inHouse.MachineID.ToString();
        }

        public ModifyPart(Outsourced outsourced)
        {
            InitializeComponent();
            inHouseRadioBtn.Checked = false;
            outsourcedRadioBtn.Checked = true;
            idTextBox.Enabled = false;
            idTextBox.Text = outsourced.PartID.ToString();
            nameTextBox.Text = outsourced.Name;
            inventoryTextBox.Text = outsourced.InStock.ToString();
            priceTextBox.Text = outsourced.Price.ToString();
            maxTextBox.Text = outsourced.Max.ToString();
            minTextBox.Text = outsourced.Min.ToString();
            machIdLabel.Text = "Company Name";
            machIdTextBox.Text = outsourced.CompanyName.ToString();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            machIdLabel.Text = "MachineID";
        }

        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            machIdLabel.Text = "Company Name";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int partID;
            string name = nameTextBox.Text;
            int inStock;
            decimal price;
            int max;
            int min;
            int machineID = 0;
            string companyName = "";

            try
            {
                partID = int.Parse(idTextBox.Text);
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
                MessageBox.Show($"Please make sure all fields are filled correctly.{ex.ToString()}");
                return;
            }

            if (inStock > max || inStock < min)
            {
                if (inStock > max)
                {
                    MessageBox.Show("Invalid input. Inventory must be less than Max");
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid input. Inventory must be greater than Min");
                    return;
                }
            }

            if (inHouseRadioBtn.Checked)
            {
                InHouse part = new InHouse(partID, name, inStock, price, max, min, machineID);
                Inventory.UpdatePart(partID, part);
                MessageBox.Show($"{Name} successfully updated.");
                this.Close();
            }

            if (outsourcedRadioBtn.Checked)
            {
                Outsourced part = new Outsourced(partID, name, inStock, price, max, min, companyName);
                Inventory.UpdatePart(partID, part);
                MessageBox.Show($"{name} successfully updated.");
                this.Close();
            }

            this.Hide();

        }

        // Close Form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
