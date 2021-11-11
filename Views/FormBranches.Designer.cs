namespace Start_Up_Group
{
    partial class FormBranches
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
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewBranch = new System.Windows.Forms.Button();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal_Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBranchContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBranchAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBBranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBTotalIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBOpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Branch Name";
            this.txtName.Name = "txtName";
            this.txtName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtAddress
            // 
            this.txtAddress.DataPropertyName = "Address";
            this.txtAddress.HeaderText = "Address";
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAddNewBranch
            // 
            this.btnAddNewBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnAddNewBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewBranch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddNewBranch.Location = new System.Drawing.Point(12, 13);
            this.btnAddNewBranch.Name = "btnAddNewBranch";
            this.btnAddNewBranch.Size = new System.Drawing.Size(105, 38);
            this.btnAddNewBranch.TabIndex = 1;
            this.btnAddNewBranch.Text = "New Branch";
            this.btnAddNewBranch.UseVisualStyleBackColor = false;
            this.btnAddNewBranch.Click += new System.EventHandler(this.btnAddNewBranch_Click);
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBranch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDeleteBranch.Location = new System.Drawing.Point(234, 13);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(120, 38);
            this.btnDeleteBranch.TabIndex = 1;
            this.btnDeleteBranch.Text = "Delete Branch";
            this.btnDeleteBranch.UseVisualStyleBackColor = false;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(123, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(983, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.HeaderText = "Open Since";
            this.txtOpenDate.Name = "txtOpenDate";
            // 
            // txtManagerName
            // 
            this.txtManagerName.HeaderText = "Manager";
            this.txtManagerName.Name = "txtManagerName";
            // 
            // txtTotal_Income
            // 
            this.txtTotal_Income.HeaderText = "Total Income";
            this.txtTotal_Income.Name = "txtTotal_Income";
            // 
            // txtBranchContact
            // 
            this.txtBranchContact.HeaderText = "Desk Phone";
            this.txtBranchContact.Name = "txtBranchContact";
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.HeaderText = "Address";
            this.txtBranchAddress.Name = "txtBranchAddress";
            // 
            // txtBranchName
            // 
            this.txtBranchName.HeaderText = "Branch Name";
            this.txtBranchName.Name = "txtBranchName";
            // 
            // txtBBranchId
            // 
            this.txtBBranchId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBBranchId.DataPropertyName = "BranchId";
            this.txtBBranchId.HeaderText = "#";
            this.txtBBranchId.Name = "txtBBranchId";
            this.txtBBranchId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBName
            // 
            this.txtBName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBName.DataPropertyName = "Name";
            this.txtBName.HeaderText = "Branch Name";
            this.txtBName.Name = "txtBName";
            this.txtBName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBAddress
            // 
            this.txtBAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBAddress.DataPropertyName = "Address";
            this.txtBAddress.HeaderText = "Address";
            this.txtBAddress.Name = "txtBAddress";
            this.txtBAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBContact
            // 
            this.txtBContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBContact.DataPropertyName = "Contact";
            this.txtBContact.HeaderText = "Desk Phone";
            this.txtBContact.Name = "txtBContact";
            this.txtBContact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBTotalIncome
            // 
            this.txtBTotalIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBTotalIncome.DataPropertyName = "Total_Income";
            this.txtBTotalIncome.HeaderText = "Total Income";
            this.txtBTotalIncome.Name = "txtBTotalIncome";
            this.txtBTotalIncome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBOpenDate
            // 
            this.txtBOpenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtBOpenDate.DataPropertyName = "Open_date";
            this.txtBOpenDate.HeaderText = "Open Since";
            this.txtBOpenDate.Name = "txtBOpenDate";
            this.txtBOpenDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 481);
            // 
            // dgvBranch
            // 
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtBBranchId,
            this.txtBName,
            this.txtBAddress,
            this.txtBContact,
            this.txtBTotalIncome,
            this.txtBOpenDate});
            this.dgvBranch.Location = new System.Drawing.Point(13, 58);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.Size = new System.Drawing.Size(1052, 411);
            this.dgvBranch.TabIndex = 5;
            this.dgvBranch.Text = "dataGridView1";
            this.dgvBranch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranch_CellContentClick);
            this.dgvBranch.Click += new System.EventHandler(this.dgvBranch_Click);
            this.Controls.Add(this.dgvBranch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteBranch);
            this.Controls.Add(this.btnAddNewBranch);
            this.Name = "FormBranches";
            this.Load += new System.EventHandler(this.FormBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.Button btnAddNewBranch;
        private System.Windows.Forms.Button btnDeleteBranch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBranchContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBranchAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBranchName;
        private System.Windows.Forms.DataGridView dgvBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBBranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBTotalIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBOpenDate;
    }
}