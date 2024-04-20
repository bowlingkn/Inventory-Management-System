namespace kbowling
{
    partial class ProductsForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductMin = new System.Windows.Forms.TextBox();
            this.tbProductInventory = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductMax = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.labelProductTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchPart = new System.Windows.Forms.TextBox();
            this.buttonSearchParts = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // tbProductMin
            // 
            this.tbProductMin.Location = new System.Drawing.Point(366, 479);
            this.tbProductMin.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductMin.Name = "tbProductMin";
            this.tbProductMin.Size = new System.Drawing.Size(88, 31);
            this.tbProductMin.TabIndex = 6;
            this.tbProductMin.TextChanged += new System.EventHandler(this.tbProductMin_TextChanged);
            // 
            // tbProductInventory
            // 
            this.tbProductInventory.Location = new System.Drawing.Point(202, 379);
            this.tbProductInventory.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductInventory.Name = "tbProductInventory";
            this.tbProductInventory.Size = new System.Drawing.Size(196, 31);
            this.tbProductInventory.TabIndex = 3;
            this.tbProductInventory.TextChanged += new System.EventHandler(this.tbProductInventory_TextChanged);
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(202, 429);
            this.tbProductPrice.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(196, 31);
            this.tbProductPrice.TabIndex = 4;
            this.tbProductPrice.TextChanged += new System.EventHandler(this.tbProductPrice_TextChanged);
            // 
            // tbProductMax
            // 
            this.tbProductMax.Location = new System.Drawing.Point(202, 479);
            this.tbProductMax.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductMax.Name = "tbProductMax";
            this.tbProductMax.Size = new System.Drawing.Size(88, 31);
            this.tbProductMax.TabIndex = 5;
            this.tbProductMax.TextChanged += new System.EventHandler(this.tbProductMax_TextChanged);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(202, 329);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(196, 31);
            this.tbProductName.TabIndex = 2;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(202, 279);
            this.tbProductID.Margin = new System.Windows.Forms.Padding(6);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(196, 31);
            this.tbProductID.TabIndex = 16;
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.AllowUserToAddRows = false;
            this.dgvAllParts.AllowUserToDeleteRows = false;
            this.dgvAllParts.AllowUserToResizeColumns = false;
            this.dgvAllParts.AllowUserToResizeRows = false;
            this.dgvAllParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(536, 154);
            this.dgvAllParts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAllParts.MultiSelect = false;
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.ReadOnly = true;
            this.dgvAllParts.RowHeadersVisible = false;
            this.dgvAllParts.RowHeadersWidth = 82;
            this.dgvAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllParts.Size = new System.Drawing.Size(822, 288);
            this.dgvAllParts.TabIndex = 28;
            this.dgvAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AllowUserToAddRows = false;
            this.dgvAssociatedParts.AllowUserToDeleteRows = false;
            this.dgvAssociatedParts.AllowUserToResizeColumns = false;
            this.dgvAssociatedParts.AllowUserToResizeRows = false;
            this.dgvAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(536, 517);
            this.dgvAssociatedParts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAssociatedParts.MultiSelect = false;
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.RowHeadersWidth = 82;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(822, 288);
            this.dgvAssociatedParts.TabIndex = 29;
            this.dgvAssociatedParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bindingComplete);
            // 
            // labelProductTitle
            // 
            this.labelProductTitle.AutoSize = true;
            this.labelProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductTitle.Location = new System.Drawing.Point(24, 17);
            this.labelProductTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProductTitle.Name = "labelProductTitle";
            this.labelProductTitle.Size = new System.Drawing.Size(163, 31);
            this.labelProductTitle.TabIndex = 30;
            this.labelProductTitle.Text = "Add Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 487);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "All Candidate Parts";
            // 
            // tbSearchPart
            // 
            this.tbSearchPart.Location = new System.Drawing.Point(954, 69);
            this.tbSearchPart.Margin = new System.Windows.Forms.Padding(6);
            this.tbSearchPart.Name = "tbSearchPart";
            this.tbSearchPart.Size = new System.Drawing.Size(400, 31);
            this.tbSearchPart.TabIndex = 1;
            // 
            // buttonSearchParts
            // 
            this.buttonSearchParts.Location = new System.Drawing.Point(792, 69);
            this.buttonSearchParts.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSearchParts.Name = "buttonSearchParts";
            this.buttonSearchParts.Size = new System.Drawing.Size(150, 38);
            this.buttonSearchParts.TabIndex = 34;
            this.buttonSearchParts.Text = "Search";
            this.buttonSearchParts.UseVisualStyleBackColor = true;
            this.buttonSearchParts.Click += new System.EventHandler(this.buttonSearchParts_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1286, 885);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1208, 454);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 44);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1208, 817);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 44);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1124, 885);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 44);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1460, 952);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchParts);
            this.Controls.Add(this.tbSearchPart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelProductTitle);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProductMin);
            this.Controls.Add(this.tbProductInventory);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.tbProductMax);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductID);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductMin;
        private System.Windows.Forms.TextBox tbProductInventory;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductMax;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label labelProductTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchPart;
        private System.Windows.Forms.Button buttonSearchParts;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}