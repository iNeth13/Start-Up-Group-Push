namespace Start_Up_Group.Views
{
    partial class FormManager
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteManager = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddBranchManager = new System.Windows.Forms.Button();
            this.btnUpdateBranch = new System.Windows.Forms.Button();
            this.txtMManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMManagerHiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BranchId";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Branch Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn4.HeaderText = "Desk Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total_Income";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Income";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Manager";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Open_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Open Since";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnDeleteManager
            // 
            this.btnDeleteManager.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteManager.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDeleteManager.Location = new System.Drawing.Point(265, 12);
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(137, 38);
            this.btnDeleteManager.TabIndex = 1;
            this.btnDeleteManager.Text = "Delete Manager";
            this.btnDeleteManager.UseVisualStyleBackColor = false;
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDeleteManager_Click);
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
            // btnAddBranchManager
            // 
            this.btnAddBranchManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnAddBranchManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranchManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBranchManager.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddBranchManager.Location = new System.Drawing.Point(13, 12);
            this.btnAddBranchManager.Name = "btnAddBranchManager";
            this.btnAddBranchManager.Size = new System.Drawing.Size(120, 38);
            this.btnAddBranchManager.TabIndex = 1;
            this.btnAddBranchManager.Text = "Add Manager";
            this.btnAddBranchManager.UseVisualStyleBackColor = false;
            this.btnAddBranchManager.Click += new System.EventHandler(this.btnAddBranchManager_Click);
            // 
            // btnUpdateBranch
            // 
            this.btnUpdateBranch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBranch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdateBranch.Location = new System.Drawing.Point(139, 12);
            this.btnUpdateBranch.Name = "btnUpdateBranch";
            this.btnUpdateBranch.Size = new System.Drawing.Size(120, 38);
            this.btnUpdateBranch.TabIndex = 1;
            this.btnUpdateBranch.Text = "Update";
            this.btnUpdateBranch.UseVisualStyleBackColor = false;
            this.btnUpdateBranch.Click += new System.EventHandler(this.btnUpdateBranch_Click);
            // 
            // txtMManagerId
            // 
            this.txtMManagerId.DataPropertyName = "ManagerId";
            this.txtMManagerId.HeaderText = "Manager ID";
            this.txtMManagerId.Name = "txtMManagerId";
            this.txtMManagerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerName
            // 
            this.txtMManagerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerName.DataPropertyName = "Name";
            this.txtMManagerName.HeaderText = "Name";
            this.txtMManagerName.Name = "txtMManagerName";
            this.txtMManagerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerAddress
            // 
            this.txtMManagerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerAddress.DataPropertyName = "Address";
            this.txtMManagerAddress.HeaderText = "Address";
            this.txtMManagerAddress.Name = "txtMManagerAddress";
            this.txtMManagerAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerContact
            // 
            this.txtMManagerContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerContact.DataPropertyName = "Contact";
            this.txtMManagerContact.HeaderText = "Contact";
            this.txtMManagerContact.Name = "txtMManagerContact";
            this.txtMManagerContact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerSalary
            // 
            this.txtMManagerSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerSalary.DataPropertyName = "Salary";
            this.txtMManagerSalary.HeaderText = "Salary";
            this.txtMManagerSalary.Name = "txtMManagerSalary";
            this.txtMManagerSalary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerEmail
            // 
            this.txtMManagerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerEmail.DataPropertyName = "Email";
            this.txtMManagerEmail.HeaderText = "Email";
            this.txtMManagerEmail.Name = "txtMManagerEmail";
            this.txtMManagerEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMManagerHiredDate
            // 
            this.txtMManagerHiredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMManagerHiredDate.DataPropertyName = "Hired_date";
            this.txtMManagerHiredDate.HeaderText = "Hired Date";
            this.txtMManagerHiredDate.Name = "txtMManagerHiredDate";
            this.txtMManagerHiredDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMManagerId,
            this.txtMManagerName,
            this.txtMManagerAddress,
            this.txtMManagerContact,
            this.txtMManagerSalary,
            this.txtMManagerEmail,
            this.txtMManagerHiredDate});
            this.dgvManager.Location = new System.Drawing.Point(13, 58);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.Size = new System.Drawing.Size(1052, 411);
            this.dgvManager.TabIndex = 5;
            this.dgvManager.Text = "dataGridView1";
            this.dgvManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManager_CellContentClick);
            this.dgvManager.Click += new System.EventHandler(this.dgvManager_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 481);
            this.Controls.Add(this.btnUpdateBranch);
            this.Controls.Add(this.btnAddBranchManager);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteManager);
            this.Controls.Add(this.dgvManager);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddBranchManager;
        private System.Windows.Forms.Button btnUpdateBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMManagerHiredDate;
    }
}