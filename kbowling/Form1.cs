using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kbowling
{
    public partial class Form1 : Form
    {
        public static bool PartModify { get; set; }
        public static bool ProductModify { get; set; }
        public Form1()  //initialize data sources for dgv
        {
            InitializeComponent();
            PartModify = false;
            ProductModify = false;
            Product.selectedProductIndex = -1;
            dgvProducts.DataSource = Inventory.Products;
            dgvParts.DataSource = Inventory.AllParts;
          //  Inventory.Products[0].addAssociatedPart(Inventory.AllParts[0]);
//        public Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

        }
        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //  clear dgv selections
            dgvParts.ClearSelection();
            dgvProducts.ClearSelection();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            //  refreshes data grid views after modification
            dgvParts.Refresh();
            dgvProducts.Refresh();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();  //  close window when exit button clicked
        }


        //  Part manipulation ----------------------------------------------------
        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            
            PartsForm partsForm = new PartsForm();
            partsForm.Show();
        }
      
        private void buttonModifyPart_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)  //check for selection
            {
                MessageBox.Show("Please select a part.");
                return;
            }
            PartModify = true;
            Part.selectedPartIndex = dgvParts.CurrentRow.Index;
            PartsForm partsForm = new PartsForm();
            partsForm.Show();
        }

        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)  //check for selection
            {
                MessageBox.Show("Please select a part.");
                return;
            }

            DialogResult userAnswer = MessageBox.Show("Are you sure you want to delete this part?", "Confirm delete", MessageBoxButtons.YesNo);
            if (userAnswer == DialogResult.Yes)
            {
                Part currentPart = dgvParts.CurrentRow.DataBoundItem as Part;
                Inventory.DeletePart(currentPart);
            }
                        
        }

        private void buttonPartSearch_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            bool found = false;
            if (tbPartSearch.Text != "")    //checks for empty input
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                { 
                    if (Inventory.AllParts[i].PartID.ToString().ToUpper().Contains(tbPartSearch.Text.ToUpper())
                        || Inventory.AllParts[i].Name.ToString().ToUpper().Contains(tbPartSearch.Text.ToUpper()))
                    {
                        dgvParts.Rows[i].Selected = true;
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


        //  Product manipulation -----------------------------------------------------
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
           
            ProductsForm productForm = new ProductsForm();
            productForm.Show();
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            if (!dgvProducts.CurrentRow.Selected)  //check for selection
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            ProductModify = true;
            Product.selectedProductIndex = dgvProducts.CurrentRow.Index;
            ProductsForm productForm = new ProductsForm();
            productForm.Show();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (!dgvProducts.CurrentRow.Selected)  //check for selection
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            Product currentProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

            if (currentProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Product cannot be delete while a part is associated with it.");
                return;
            }

            DialogResult userAnswer = MessageBox.Show("Are you sure you want to delete this product?", "Confirm delete", MessageBoxButtons.YesNo);
            if (userAnswer == DialogResult.Yes)
            {
                Inventory.RemoveProduct(currentProduct.ProductID);
            }

        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            bool found = false;
            if (tbProductSearch.Text != "")    //checks for empty input
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ProductID.ToString().ToUpper().Contains(tbProductSearch.Text.ToUpper())
                        || Inventory.Products[i].Name.ToString().ToUpper().Contains(tbProductSearch.Text.ToUpper()))
                    {
                        dgvProducts.Rows[i].Selected = true;
                        found = true;
                        return;
                    }
                }
            }
            if (!found)     //tells user if no object found
            {
                MessageBox.Show("No matching product found.");
            }
        }
    }
}
