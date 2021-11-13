namespace Start_Up_Group.Views
{
    partial class FormNewProduct
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
            this.lbLabel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnProductCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyInPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellOutPrice = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbLabel.Location = new System.Drawing.Point(25, 22);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(117, 21);
            this.lbLabel.TabIndex = 0;
            this.lbLabel.Text = "Product Name :";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(25, 46);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(259, 29);
            this.txtProductName.TabIndex = 1;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNewProduct.Location = new System.Drawing.Point(311, 23);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnNewProduct.TabIndex = 7;
            this.btnNewProduct.Text = "Add New";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnProductCancel
            // 
            this.btnProductCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnProductCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProductCancel.Location = new System.Drawing.Point(311, 52);
            this.btnProductCancel.Name = "btnProductCancel";
            this.btnProductCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProductCancel.TabIndex = 8;
            this.btnProductCancel.Text = "Cancel";
            this.btnProductCancel.UseVisualStyleBackColor = false;
            this.btnProductCancel.Click += new System.EventHandler(this.btnProductCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy In Price :";
            // 
            // txtBuyInPrice
            // 
            this.txtBuyInPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyInPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuyInPrice.Location = new System.Drawing.Point(25, 117);
            this.txtBuyInPrice.Name = "txtBuyInPrice";
            this.txtBuyInPrice.Size = new System.Drawing.Size(259, 29);
            this.txtBuyInPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(25, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sell Out Price :";
            // 
            // txtSellOutPrice
            // 
            this.txtSellOutPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellOutPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSellOutPrice.Location = new System.Drawing.Point(25, 190);
            this.txtSellOutPrice.Name = "txtSellOutPrice";
            this.txtSellOutPrice.Size = new System.Drawing.Size(259, 29);
            this.txtSellOutPrice.TabIndex = 3;
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(25, 271);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(259, 29);
            this.cbxCategory.TabIndex = 4;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(25, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category :";
            // 
            // dtPickerExpirationDate
            // 
            this.dtPickerExpirationDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickerExpirationDate.Location = new System.Drawing.Point(25, 421);
            this.dtPickerExpirationDate.Name = "dtPickerExpirationDate";
            this.dtPickerExpirationDate.Size = new System.Drawing.Size(259, 23);
            this.dtPickerExpirationDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(25, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expiration Date :";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(25, 494);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(259, 29);
            this.cbxSupplier.TabIndex = 6;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(25, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(25, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount :";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductAmount.Location = new System.Drawing.Point(25, 350);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(259, 29);
            this.txtProductAmount.TabIndex = 9;
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(411, 544);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPickerExpirationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.txtSellOutPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuyInPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductCancel);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbLabel);
            this.Name = "FormNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnProductCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuyInPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSellOutPrice;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPickerExpirationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductAmount;
    }
}