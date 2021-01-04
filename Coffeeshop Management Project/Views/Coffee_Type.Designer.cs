namespace Coffeeshop_Management_Project.Views
{
    partial class Coffee_Type
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
            this.labelCType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.GridViewCoffee = new System.Windows.Forms.DataGridView();
            this.comboBoxCType = new System.Windows.Forms.ComboBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCType
            // 
            this.labelCType.AutoSize = true;
            this.labelCType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCType.Location = new System.Drawing.Point(72, 48);
            this.labelCType.Name = "labelCType";
            this.labelCType.Size = new System.Drawing.Size(88, 16);
            this.labelCType.TabIndex = 0;
            this.labelCType.Text = "Coffee Type";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(79, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 16);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(166, 85);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(144, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(75, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(182, 186);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(285, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // GridViewCoffee
            // 
            this.GridViewCoffee.AllowUserToAddRows = false;
            this.GridViewCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCoffee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Type,
            this.Price,
            this.Quantity});
            this.GridViewCoffee.Location = new System.Drawing.Point(28, 283);
            this.GridViewCoffee.Name = "GridViewCoffee";
            this.GridViewCoffee.Size = new System.Drawing.Size(431, 196);
            this.GridViewCoffee.TabIndex = 8;
            // 
            // comboBoxCType
            // 
            this.comboBoxCType.FormattingEnabled = true;
            this.comboBoxCType.Items.AddRange(new object[] {
            "1. CAFFE MOCHA",
            "2. CAFE AU LAIT",
            "3. CAPPUCCINO",
            "4. COLD BREW COFFEE",
            "5. Latte"});
            this.comboBoxCType.Location = new System.Drawing.Point(167, 48);
            this.comboBoxCType.Name = "comboBoxCType";
            this.comboBoxCType.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCType.TabIndex = 9;
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuantity.Location = new System.Drawing.Point(173, 132);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(144, 21);
            this.comboBoxQuantity.TabIndex = 10;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(79, 133);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 16);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "Quantity";
            // 
            // C_ID
            // 
            this.C_ID.HeaderText = "C_ID";
            this.C_ID.Name = "C_ID";
            // 
            // C_Type
            // 
            this.C_Type.HeaderText = "C_Type";
            this.C_Type.Name = "C_Type";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.Black;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(539, 368);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(112, 38);
            this.textBoxTotal.TabIndex = 12;
            // 
            // label1Total
            // 
            this.label1Total.AutoSize = true;
            this.label1Total.BackColor = System.Drawing.Color.White;
            this.label1Total.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Total.ForeColor = System.Drawing.Color.Red;
            this.label1Total.Location = new System.Drawing.Point(562, 319);
            this.label1Total.Name = "label1Total";
            this.label1Total.Size = new System.Drawing.Size(63, 25);
            this.label1Total.TabIndex = 13;
            this.label1Total.Text = "Total";
            // 
            // Coffee_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 519);
            this.Controls.Add(this.label1Total);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.comboBoxCType);
            this.Controls.Add(this.GridViewCoffee);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCType);
            this.Name = "Coffee_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee_Type";
            this.Load += new System.EventHandler(this.Coffee_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView GridViewCoffee;
        private System.Windows.Forms.ComboBox comboBoxCType;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1Total;
    }
}