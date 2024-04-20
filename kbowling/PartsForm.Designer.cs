namespace kbowling
{
    partial class PartsForm
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
            this.rbHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPartTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbHouse
            // 
            this.rbHouse.AutoSize = true;
            this.rbHouse.Checked = true;
            this.rbHouse.Location = new System.Drawing.Point(118, 73);
            this.rbHouse.Margin = new System.Windows.Forms.Padding(6);
            this.rbHouse.Name = "rbHouse";
            this.rbHouse.Size = new System.Drawing.Size(129, 29);
            this.rbHouse.TabIndex = 0;
            this.rbHouse.TabStop = true;
            this.rbHouse.Text = "In-House";
            this.rbHouse.UseVisualStyleBackColor = true;
            this.rbHouse.CheckedChanged += new System.EventHandler(this.rbHouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Location = new System.Drawing.Point(346, 73);
            this.rbOutsourced.Margin = new System.Windows.Forms.Padding(6);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(154, 29);
            this.rbOutsourced.TabIndex = 1;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.rbOutsourced_CheckedChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(212, 135);
            this.tbID.Margin = new System.Windows.Forms.Padding(6);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(196, 31);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(212, 185);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 31);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(212, 335);
            this.tbMax.Margin = new System.Windows.Forms.Padding(6);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(88, 31);
            this.tbMax.TabIndex = 4;
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(212, 285);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(6);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(196, 31);
            this.tbPrice.TabIndex = 5;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(212, 235);
            this.tbInventory.Margin = new System.Windows.Forms.Padding(6);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(196, 31);
            this.tbInventory.TabIndex = 6;
            this.tbInventory.TextChanged += new System.EventHandler(this.tbInventory_TextChanged);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(376, 335);
            this.tbMin.Margin = new System.Windows.Forms.Padding(6);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(88, 31);
            this.tbMin.TabIndex = 7;
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(212, 385);
            this.tbSource.Margin = new System.Windows.Forms.Padding(6);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(196, 31);
            this.tbSource.TabIndex = 8;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price / Cost";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(58, 390);
            this.labelSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(120, 25);
            this.labelSource.TabIndex = 11;
            this.labelSource.Text = "Machine ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // labelPartTitle
            // 
            this.labelPartTitle.AutoSize = true;
            this.labelPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartTitle.Location = new System.Drawing.Point(24, 17);
            this.labelPartTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPartTitle.Name = "labelPartTitle";
            this.labelPartTitle.Size = new System.Drawing.Size(119, 31);
            this.labelPartTitle.TabIndex = 16;
            this.labelPartTitle.Text = "Add Part";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(262, 463);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 44);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(424, 463);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 531);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPartTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbHouse);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PartsForm";
            this.Text = "Part";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPartTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}