namespace Start_Up_Group.Views
{
    partial class FormBranchDetail
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
            this.lbBranchDetail = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbBranchDetail = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.lbManagerLocation = new System.Windows.Forms.Label();
            this.lbManagerContact = new System.Windows.Forms.Label();
            this.lbManagerName = new System.Windows.Forms.Label();
            this.lbBranchOpenSice = new System.Windows.Forms.Label();
            this.lbBranchTotalIncome = new System.Windows.Forms.Label();
            this.lbBranchContact = new System.Windows.Forms.Label();
            this.lbBranchAddress = new System.Windows.Forms.Label();
            this.lbBranchName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBranchProduct = new System.Windows.Forms.TabPage();
            this.lstBranchProduct = new System.Windows.Forms.ListView();
            this.colProductId = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colProductBuyInPrice = new System.Windows.Forms.ColumnHeader();
            this.colProductSellOutPrice = new System.Windows.Forms.ColumnHeader();
            this.colProductAmount = new System.Windows.Forms.ColumnHeader();
            this.colProductExpirationDate = new System.Windows.Forms.ColumnHeader();
            this.tbBranchDetail.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbBranchProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBranchDetail
            // 
            this.lbBranchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.lbBranchDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBranchDetail.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBranchDetail.Location = new System.Drawing.Point(-2, -1);
            this.lbBranchDetail.Name = "lbBranchDetail";
            this.lbBranchDetail.Size = new System.Drawing.Size(686, 56);
            this.lbBranchDetail.TabIndex = 0;
            this.lbBranchDetail.Text = "Branch Detail";
            this.lbBranchDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbBranchDetail
            // 
            this.tbBranchDetail.Controls.Add(this.tbInfo);
            this.tbBranchDetail.Controls.Add(this.tbBranchProduct);
            this.tbBranchDetail.Location = new System.Drawing.Point(-2, 59);
            this.tbBranchDetail.Name = "tbBranchDetail";
            this.tbBranchDetail.SelectedIndex = 2;
            this.tbBranchDetail.Size = new System.Drawing.Size(686, 353);
            this.tbBranchDetail.TabIndex = 4;
            this.tbBranchDetail.SelectedIndexChanged += new System.EventHandler(this.tbBranchDetail_SelectedIndexChanged);
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbInfo.Controls.Add(this.lbManagerLocation);
            this.tbInfo.Controls.Add(this.lbManagerContact);
            this.tbInfo.Controls.Add(this.lbManagerName);
            this.tbInfo.Controls.Add(this.lbBranchOpenSice);
            this.tbInfo.Controls.Add(this.lbBranchTotalIncome);
            this.tbInfo.Controls.Add(this.lbBranchContact);
            this.tbInfo.Controls.Add(this.lbBranchAddress);
            this.tbInfo.Controls.Add(this.lbBranchName);
            this.tbInfo.Controls.Add(this.panel1);
            this.tbInfo.Controls.Add(this.label8);
            this.tbInfo.Controls.Add(this.label7);
            this.tbInfo.Controls.Add(this.label6);
            this.tbInfo.Controls.Add(this.label5);
            this.tbInfo.Controls.Add(this.label4);
            this.tbInfo.Controls.Add(this.label3);
            this.tbInfo.Controls.Add(this.label2);
            this.tbInfo.Controls.Add(this.label1);
            this.tbInfo.Location = new System.Drawing.Point(4, 24);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(678, 325);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Info";
            // 
            // lbManagerLocation
            // 
            this.lbManagerLocation.AutoSize = true;
            this.lbManagerLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManagerLocation.Location = new System.Drawing.Point(159, 294);
            this.lbManagerLocation.Name = "lbManagerLocation";
            this.lbManagerLocation.Size = new System.Drawing.Size(105, 20);
            this.lbManagerLocation.TabIndex = 0;
            this.lbManagerLocation.Text = "Branch Name :";
            // 
            // lbManagerContact
            // 
            this.lbManagerContact.AutoSize = true;
            this.lbManagerContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManagerContact.Location = new System.Drawing.Point(159, 262);
            this.lbManagerContact.Name = "lbManagerContact";
            this.lbManagerContact.Size = new System.Drawing.Size(105, 20);
            this.lbManagerContact.TabIndex = 0;
            this.lbManagerContact.Text = "Branch Name :";
            // 
            // lbManagerName
            // 
            this.lbManagerName.AutoSize = true;
            this.lbManagerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManagerName.Location = new System.Drawing.Point(159, 229);
            this.lbManagerName.Name = "lbManagerName";
            this.lbManagerName.Size = new System.Drawing.Size(105, 20);
            this.lbManagerName.TabIndex = 0;
            this.lbManagerName.Text = "Branch Name :";
            // 
            // lbBranchOpenSice
            // 
            this.lbBranchOpenSice.AutoSize = true;
            this.lbBranchOpenSice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBranchOpenSice.Location = new System.Drawing.Point(159, 159);
            this.lbBranchOpenSice.Name = "lbBranchOpenSice";
            this.lbBranchOpenSice.Size = new System.Drawing.Size(105, 20);
            this.lbBranchOpenSice.TabIndex = 0;
            this.lbBranchOpenSice.Text = "Branch Name :";
            // 
            // lbBranchTotalIncome
            // 
            this.lbBranchTotalIncome.AutoSize = true;
            this.lbBranchTotalIncome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBranchTotalIncome.Location = new System.Drawing.Point(159, 125);
            this.lbBranchTotalIncome.Name = "lbBranchTotalIncome";
            this.lbBranchTotalIncome.Size = new System.Drawing.Size(105, 20);
            this.lbBranchTotalIncome.TabIndex = 0;
            this.lbBranchTotalIncome.Text = "Branch Name :";
            // 
            // lbBranchContact
            // 
            this.lbBranchContact.AutoSize = true;
            this.lbBranchContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBranchContact.Location = new System.Drawing.Point(159, 90);
            this.lbBranchContact.Name = "lbBranchContact";
            this.lbBranchContact.Size = new System.Drawing.Size(105, 20);
            this.lbBranchContact.TabIndex = 0;
            this.lbBranchContact.Text = "Branch Name :";
            // 
            // lbBranchAddress
            // 
            this.lbBranchAddress.AutoSize = true;
            this.lbBranchAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBranchAddress.Location = new System.Drawing.Point(159, 52);
            this.lbBranchAddress.Name = "lbBranchAddress";
            this.lbBranchAddress.Size = new System.Drawing.Size(105, 20);
            this.lbBranchAddress.TabIndex = 0;
            this.lbBranchAddress.Text = "Branch Name :";
            // 
            // lbBranchName
            // 
            this.lbBranchName.AutoSize = true;
            this.lbBranchName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBranchName.Location = new System.Drawing.Point(159, 14);
            this.lbBranchName.Name = "lbBranchName";
            this.lbBranchName.Size = new System.Drawing.Size(105, 20);
            this.lbBranchName.TabIndex = 0;
            this.lbBranchName.Text = "Branch Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 33);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(280, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Manager In-Charge:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Manager Location :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manager  Contact :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manager Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Open Since :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Income :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desk Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name :";
            // 
            // tbBranchProduct
            // 
            this.tbBranchProduct.Controls.Add(this.lstBranchProduct);
            this.tbBranchProduct.Location = new System.Drawing.Point(4, 24);
            this.tbBranchProduct.Name = "tbBranchProduct";
            this.tbBranchProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbBranchProduct.Size = new System.Drawing.Size(678, 325);
            this.tbBranchProduct.TabIndex = 1;
            this.tbBranchProduct.Text = "Branch\'s Product";
            this.tbBranchProduct.UseVisualStyleBackColor = true;
            // 
            // lstBranchProduct
            // 
            this.lstBranchProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductId,
            this.colProductName,
            this.colProductBuyInPrice,
            this.colProductSellOutPrice,
            this.colProductAmount,
            this.colProductExpirationDate});
            this.lstBranchProduct.HideSelection = false;
            this.lstBranchProduct.Location = new System.Drawing.Point(4, 4);
            this.lstBranchProduct.Name = "lstBranchProduct";
            this.lstBranchProduct.Size = new System.Drawing.Size(671, 320);
            this.lstBranchProduct.TabIndex = 0;
            this.lstBranchProduct.UseCompatibleStateImageBehavior = false;
            this.lstBranchProduct.View = System.Windows.Forms.View.Details;
            // 
            // colProductId
            // 
            this.colProductId.Text = "#";
            // 
            // colProductName
            // 
            this.colProductName.Text = "Product Name";
            this.colProductName.Width = 120;
            // 
            // colProductBuyInPrice
            // 
            this.colProductBuyInPrice.Text = "Buy-In Price";
            this.colProductBuyInPrice.Width = 120;
            // 
            // colProductSellOutPrice
            // 
            this.colProductSellOutPrice.Text = "Sell-Out Price";
            this.colProductSellOutPrice.Width = 120;
            // 
            // colProductAmount
            // 
            this.colProductAmount.Text = "Amount";
            this.colProductAmount.Width = 80;
            // 
            // colProductExpirationDate
            // 
            this.colProductExpirationDate.Text = "Expires On";
            this.colProductExpirationDate.Width = 150;
            // 
            // FormBranchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(685, 414);
            this.ControlBox = false;
            this.Controls.Add(this.tbBranchDetail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbBranchDetail);
            this.Name = "FormBranchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Detail";
            this.Load += new System.EventHandler(this.FormBranchDetail_Load);
            this.tbBranchDetail.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbBranchProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBranchDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tbBranchDetail;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.Label lbManagerLocation;
        private System.Windows.Forms.Label lbManagerContact;
        private System.Windows.Forms.Label lbManagerName;
        private System.Windows.Forms.Label lbBranchOpenSice;
        private System.Windows.Forms.Label lbBranchTotalIncome;
        private System.Windows.Forms.Label lbBranchContact;
        private System.Windows.Forms.Label lbBranchAddress;
        private System.Windows.Forms.Label lbBranchName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbBranchProduct;
        private System.Windows.Forms.ListView lstBranchProduct;
        private System.Windows.Forms.ColumnHeader colProductId;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colProductBuyInPrice;
        private System.Windows.Forms.ColumnHeader colProductSellOutPrice;
        private System.Windows.Forms.ColumnHeader colProductAmount;
        private System.Windows.Forms.ColumnHeader colProductExpirationDate;
    }
}