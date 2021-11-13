namespace Start_Up_Group.Views
{
    partial class FormProduct
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
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.txtPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPBuyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPSellOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewProduct.Location = new System.Drawing.Point(13, 13);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(137, 38);
            this.btnAddNewProduct.TabIndex = 0;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(276, 13);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(137, 38);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(156, 13);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(114, 38);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnRefreshProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshProduct.Location = new System.Drawing.Point(928, 13);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(137, 38);
            this.btnRefreshProduct.TabIndex = 0;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = false;
            this.btnRefreshProduct.Click += new System.EventHandler(this.btnRefreshProduct_Click);
            // 
            // txtPId
            // 
            this.txtPId.DataPropertyName = "ProductId";
            this.txtPId.HeaderText = "#";
            this.txtPId.Name = "txtPId";
            this.txtPId.ReadOnly = true;
            this.txtPId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPName
            // 
            this.txtPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPName.DataPropertyName = "ProductName";
            this.txtPName.HeaderText = "Product Name";
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPBuyIn
            // 
            this.txtPBuyIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPBuyIn.DataPropertyName = "ProductBuyIn_Price";
            this.txtPBuyIn.HeaderText = "BuyIn Price";
            this.txtPBuyIn.Name = "txtPBuyIn";
            this.txtPBuyIn.ReadOnly = true;
            this.txtPBuyIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPSellOut
            // 
            this.txtPSellOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPSellOut.DataPropertyName = "ProductSellOut_Price";
            this.txtPSellOut.HeaderText = "SellOut Price";
            this.txtPSellOut.Name = "txtPSellOut";
            this.txtPSellOut.ReadOnly = true;
            this.txtPSellOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPCategory
            // 
            this.txtPCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPCategory.DataPropertyName = "ProductCategory";
            this.txtPCategory.HeaderText = "Category";
            this.txtPCategory.Name = "txtPCategory";
            this.txtPCategory.ReadOnly = true;
            this.txtPCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPAmount
            // 
            this.txtPAmount.DataPropertyName = "ProductAmount";
            this.txtPAmount.HeaderText = "Amount";
            this.txtPAmount.Name = "txtPAmount";
            // 
            // txtPExpiration
            // 
            this.txtPExpiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPExpiration.DataPropertyName = "ProductExpirationDate";
            this.txtPExpiration.HeaderText = "Expiration Date";
            this.txtPExpiration.Name = "txtPExpiration";
            this.txtPExpiration.ReadOnly = true;
            this.txtPExpiration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 481);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPId,
            this.txtPName,
            this.txtPBuyIn,
            this.txtPSellOut,
            this.txtPCategory,
            this.txtPAmount,
            this.txtPExpiration});
            this.dgvProduct.Location = new System.Drawing.Point(13, 58);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(1052, 411);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.Text = "dataGridView1";
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnRefreshProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Name = "FormProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPBuyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPSellOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPExpiration;
    }
}