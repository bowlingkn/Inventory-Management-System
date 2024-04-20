using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kbowling
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            tbProductID.Text = Inventory.ProductCountID.ToString();  //autopopulate ID field
            dgvAllParts.DataSource = Inventory.AllParts;
                        

            if (Form1.ProductModify)    //autopopulate if modifying product
            {
                labelProductTitle.Text = "Modify Product";
                int index = Product.selectedProductIndex;
                dgvAssociatedParts.DataSource = Inventory.Products[index].AssociatedParts;
                
                tbProductID.Text = Inventory.Products[index].ProductID.ToString();
                tbProductName.Text = Inventory.Products[index].Name;
                tbProductInventory.Text = Inventory.Products[index].InStock.ToString();
                tbProductPrice.Text = Inventory.Products[index].Price.ToString();
                tbProductMax.Text = Inventory.Products[index].Max.ToString();
                tbProductMin.Text = Inventory.Products[index].Min.ToString();
            }
            else    //new product
            {
                labelProductTitle.Text = "Add Product";
                dgvAssociatedParts.DataSource = Product.partList;
            }
        }
        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllParts.ClearSelection();
            dgvAssociatedParts.ClearSelection();
        }

        private void buttonAddPart_Click(object sender, EventArgs e)  //add part to associated parts list
        {
            //  add part to the product
            if (!dgvAllParts.CurrentRow.Selected)  //check for selection
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }

            Part currentPart = dgvAllParts.CurrentRow.DataBoundItem as Part;

            if (!Form1.ProductModify)  // new product
            {
                Product.partList.Add(currentPart);
            }
            else  // update product
            {
                int index = Product.selectedProductIndex;
                Inventory.Products[index].addAssociatedPart(currentPart);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)   //delete part from associated parts list
        {
            if (!dgvAssociatedParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            DialogResult userAnswer = MessageBox.Show("Are you sure you want to delete this part from the product?", "Confirm delete", MessageBoxButtons.YesNo);
            if (userAnswer == DialogResult.Yes)
            {
                Part currentPart = dgvAssociatedParts.CurrentRow.DataBoundItem as Part;

                if (!Form1.ProductModify)   // new product
                {
                    Product.partList.Remove(currentPart);
                }
                else    // update product
                {
                    int index = Product.selectedProductIndex;
                    Inventory.Products[index].removeAssociatedPart(currentPart.PartID);
                }
            }
            
        }

        // validate user input ----------------------------------------------------------
        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            ValidateText(tbProductName.Text, tbProductName);
        }
        private void tbProductInventory_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbProductInventory.Text, tbProductInventory);
        }
        private void tbProductPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimal(tbProductPrice.Text, tbProductPrice);
        }
        private void tbProductMax_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbProductMax.Text, tbProductMax);
        }
        private void tbProductMin_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(tbProductMin.Text, tbProductMin);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateText(tbProductName.Text, tbProductName))
            {
                MessageBox.Show("Name must be a string.");
                return;
            }
            if (!ValidateNumber(tbProductInventory.Text, tbProductInventory))
            {
                MessageBox.Show("Inventory must be a integer.");
                return;
            }
            if (!ValidateDecimal(tbProductPrice.Text, tbProductPrice))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }
            if (!ValidateNumber(tbProductMax.Text, tbProductMax))
            {
                MessageBox.Show("Max must be an integer.");
                return;
            }
            if (!ValidateNumber(tbProductMin.Text, tbProductMin))
            {
                MessageBox.Show("Min must be an integer.");
                return;
            }

            string productName = tbProductName.Text;
            int inStock = Convert.ToInt32(tbProductInventory.Text);
            decimal price = Convert.ToDecimal(tbProductPrice.Text); 
            int productMin = Convert.ToInt32(tbProductMin.Text);
            int productMax = Convert.ToInt32(tbProductMax.Text);

            if (productMin > productMax)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }
            if (inStock > productMax || inStock < productMin)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            if (!Form1.ProductModify)   // save new product
            {
                Product newProduct = new Product(productName, price, inStock, productMin, productMax, Product.partList);
                Inventory.AddProduct(newProduct);
            }
            else   // update product
            {
                int productID = Convert.ToInt32(tbProductID.Text);
                int index = Product.selectedProductIndex;
                BindingList<Part> associatedParts = Inventory.Products[index].AssociatedParts;
                Product updateProduct = new Product(productID, productName, price, inStock, productMin, productMax, Product.partList);
                Inventory.UpdateProduct(Inventory.Products[index].ProductID, updateProduct);
            }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();  // close window
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ProductModify = false;
        }

        private void buttonSearchParts_Click(object sender, EventArgs e)
        {
            dgvAllParts.ClearSelection();
            bool found = false;
            if (tbSearchPart.Text != "")    //checks for empty input
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().ToUpper().Contains(tbSearchPart.Text.ToUpper())
                        || Inventory.AllParts[i].Name.ToString().ToUpper().Contains(tbSearchPart.Text.ToUpper()))
                    {
                        dgvAllParts.Rows[i].Selected = true;
                        found = true;
                        return;
                    }
                }
            }

            if (!found)     //tells user if no object found
            {
                MessageBox.Show("No matching part found.");
            }
        }
    }
}
