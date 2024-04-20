using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbowling
{
    public partial class PartsForm : Form
    {
        public PartsForm()
        {
            InitializeComponent();
            tbID.Text = Inventory.PartCountID.ToString();  //autopopulate ID field


            if (Form1.PartModify)       //autopopulate if modifying part
            {
                int index = Part.selectedPartIndex;
                tbID.Text = Inventory.AllParts[index].PartID.ToString();
                tbName.Text = Inventory.AllParts[index].Name;
                tbInventory.Text = Inventory.AllParts[index].InStock.ToString();
                tbMax.Text = Inventory.AllParts[index].Max.ToString();
                tbMin.Text = Inventory.AllParts[index].Min.ToString();
                tbPrice.Text = Inventory.AllParts[index].Price.ToString();
                labelPartTitle.Text = "Modify Part";

                if (Inventory.AllParts[index].GetType() == typeof(InhousePart))
                {
                    InhousePart currentPart = Inventory.AllParts[index] as InhousePart;
                    tbSource.Text = currentPart.MachineID.ToString();

                }
                else
                {
                    OutsourcedPart currentPart = Inventory.AllParts[index] as OutsourcedPart;
                    tbSource.Text = currentPart.CompanyName;
                    rbOutsourced.Checked = true;
                }
            }
            else
            {
                labelPartTitle.Text = "Add Part";
            }
        }
        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelSource.Text = "Company Name";
            labelSource.Location = new Point(10, 203);
        }

        private void rbHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelSource.Text = "Machine ID";
            labelSource.Location = new Point(29, 203);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            Form1.PartModify = false;
        }
        private void PartsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.PartModify = false;
        }



        //validate user input --------------------------------------------------
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            ValidateText(tbName.Text, tbName);
        }

        private void tbInventory_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbInventory.Text, tbInventory);
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimal(tbPrice.Text, tbPrice);
        }

        private void tbMax_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbMax.Text, tbMax);
        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbMin.Text, tbMin);
        }

        private void tbSource_TextChanged(object sender, EventArgs e)
        {
            if (labelSource.Text == "Machine ID")
            {
                ValidateNumber(tbSource.Text, tbSource);
            }
            else //labelSource.Text == "Company Name"
            {
                ValidateText(tbSource.Text, tbSource);
            }
        }

        private bool ValidateText(string userInput, TextBox source)
        {
            if (int.TryParse(userInput, out _) || userInput == "")
            {
                source.BackColor = Color.IndianRed;
                return false;
            }
            else
            {
                source.BackColor = Color.White;
                return true;
            }
        }
        private bool ValidateNumber(string userInput, TextBox source)
        {
            if (!int.TryParse(userInput, out _) || userInput == "")
            {
                source.BackColor = Color.IndianRed;
                return false;
            }
            else
            {
                source.BackColor = Color.White;
                return true;
            }
        }
        private bool ValidateDecimal(string userInput, TextBox source)
        {
            if (!decimal.TryParse(userInput, out decimal _) || userInput == "")
            {
                source.BackColor = Color.IndianRed;
                return false;
            }
            else
            {
                source.BackColor = Color.White;
                return true;
            }
        }

        // Save part --------------------------------------------------------------------
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateText(tbName.Text, tbName)) 
            {
                MessageBox.Show("Name must be a string.");
                return;
            }
            if(!ValidateNumber(tbInventory.Text, tbInventory))
            {
                MessageBox.Show("Inventory must be a integer.");
                return;
            }
            if (!ValidateDecimal(tbPrice.Text, tbPrice))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }
            if(!ValidateNumber(tbMax.Text, tbMax))
            {
                MessageBox.Show("Max must be an integer.");
                return;
            }
            if (!ValidateNumber(tbMin.Text, tbMin))
            {
                MessageBox.Show("Min must be an integer.");
                return;
            }

            if (labelSource.Text == "Machine ID")
            {
                if (!ValidateNumber(tbSource.Text, tbSource))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }
            }
            else //labelSource.Text == "Company Name"
            {
                if (!ValidateText(tbSource.Text, tbSource))
                {
                    MessageBox.Show("Company name must be a string.");
                    return;
                }
            }


            int partID = Convert.ToInt32(tbID.Text);
            string partName = tbName.Text;
            int partInventory = Convert.ToInt32(tbInventory.Text);
            decimal partPrice = Convert.ToDecimal(tbPrice.Text);
            int partMax = Convert.ToInt32(tbMax.Text);
            int partMin = Convert.ToInt32(tbMin.Text);

            if (partMin > partMax)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }
            if (partInventory > partMax || partInventory < partMin)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            if (labelSource.Text == "Machine ID") //Inhouse part
            {
                int partMachineID = Convert.ToInt32(tbSource.Text);

                if (Form1.PartModify)   //updating part
                {
                    InhousePart part = new InhousePart(partID, partName, partPrice, partInventory, partMin, partMax, partMachineID);
                    Inventory.UpdatePart(part.PartID, part);
                }
                else    //new part
                {
                    InhousePart part = new InhousePart(partName, partPrice, partInventory, partMin, partMax, partMachineID);
                    Inventory.AddPart(part);
                }
            }
            else //Outsourced part
            {
                string partCompanyName = tbSource.Text;

                if (Form1.PartModify)   //updating part
                {
                    OutsourcedPart part = new OutsourcedPart(partID, partName, partPrice, partInventory, partMin, partMax, partCompanyName);
                    Inventory.UpdatePart(part.PartID, part);
                }
                else    //new part
                {
                    OutsourcedPart part = new OutsourcedPart(partName, partPrice, partInventory, partMin, partMax, partCompanyName);
                    Inventory.AddPart(part);
                }
            }

            Form1.PartModify = false;  //reset for continued use
            Close();
        }
    }
}
