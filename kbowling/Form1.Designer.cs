namespace kbowling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonDeletePart = new System.Windows.Forms.Button();
            this.buttonModifyPart = new System.Windows.Forms.Button();
            this.tbPartSearch = new System.Windows.Forms.TextBox();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.buttonPartSearch = new System.Windows.Forms.Button();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(204, 303);
            this.buttonAddPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(68, 26);
            this.buttonAddPart.TabIndex = 2;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.Location = new System.Drawing.Point(348, 303);
            this.buttonDeletePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(68, 26);
            this.buttonDeletePart.TabIndex = 4;
            this.buttonDeletePart.Text = "Delete";
            this.buttonDeletePart.UseVisualStyleBackColor = true;
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // buttonModifyPart
            // 
            this.buttonModifyPart.Location = new System.Drawing.Point(276, 303);
            this.buttonModifyPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyPart.Name = "buttonModifyPart";
            this.buttonModifyPart.Size = new System.Drawing.Size(68, 26);
            this.buttonModifyPart.TabIndex = 3;
            this.buttonModifyPart.Text = "Modify";
            this.buttonModifyPart.UseVisualStyleBackColor = true;
            this.buttonModifyPart.Click += new System.EventHandler(this.buttonModifyPart_Click);
            // 
            // tbPartSearch
            // 
            this.tbPartSearch.Location = new System.Drawing.Point(314, 34);
            this.tbPartSearch.Name = "tbPartSearch";
            this.tbPartSearch.Size = new System.Drawing.Size(100, 20);
            this.tbPartSearch.TabIndex = 1;
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(742, 35);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(100, 20);
            this.tbProductSearch.TabIndex = 5;
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.Location = new System.Drawing.Point(702, 303);
            this.buttonModifyProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(68, 26);
            this.buttonModifyProduct.TabIndex = 7;
            this.buttonModifyProduct.Text = "Modify";
            this.buttonModifyProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(774, 303);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteProduct.TabIndex = 8;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(630, 303);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(68, 26);
            this.buttonAddProduct.TabIndex = 6;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inventory Management System";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(806, 347);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Products";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(44, 73);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 82;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(370, 225);
            this.dgvParts.TabIndex = 18;
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(467, 73);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 82;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(375, 225);
            this.dgvProducts.TabIndex = 19;
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // buttonPartSearch
            // 
            this.buttonPartSearch.Location = new System.Drawing.Point(255, 34);
            this.buttonPartSearch.Name = "buttonPartSearch";
            this.buttonPartSearch.Size = new System.Drawing.Size(53, 20);
            this.buttonPartSearch.TabIndex = 20;
            this.buttonPartSearch.TabStop = false;
            this.buttonPartSearch.Text = "Search";
            this.buttonPartSearch.UseVisualStyleBackColor = true;
            this.buttonPartSearch.Click += new System.EventHandler(this.buttonPartSearch_Click);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(683, 35);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(53, 20);
            this.buttonProductSearch.TabIndex = 21;
            this.buttonProductSearch.TabStop = false;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(kbowling.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(893, 382);
            this.Controls.Add(this.buttonProductSearch);
            this.Controls.Add(this.buttonPartSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonModifyProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.tbProductSearch);
            this.Controls.Add(this.tbPartSearch);
            this.Controls.Add(this.buttonModifyPart);
            this.Controls.Add(this.buttonDeletePart);
            this.Controls.Add(this.buttonAddPart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.Button buttonDeletePart;
        private System.Windows.Forms.Button buttonModifyPart;
        private System.Windows.Forms.TextBox tbPartSearch;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button buttonPartSearch;
        private System.Windows.Forms.Button buttonProductSearch;
    }
}

