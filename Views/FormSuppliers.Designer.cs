namespace Start_Up_Group.Views
{
    partial class FormSuppliers
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
            this.btnAddNewSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSSupplySince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnAddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddNewSupplier.Location = new System.Drawing.Point(13, 13);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(137, 38);
            this.btnAddNewSupplier.TabIndex = 0;
            this.btnAddNewSupplier.Text = "New Supplier";
            this.btnAddNewSupplier.UseVisualStyleBackColor = false;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(157, 13);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(114, 38);
            this.btnUpdateSupplier.TabIndex = 1;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(277, 13);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(133, 38);
            this.btnDeleteSupplier.TabIndex = 1;
            this.btnDeleteSupplier.Text = " Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.Location = new System.Drawing.Point(951, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSId
            // 
            this.txtSId.DataPropertyName = "SupplierId";
            this.txtSId.HeaderText = "#";
            this.txtSId.Name = "txtSId";
            this.txtSId.ReadOnly = true;
            this.txtSId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtSName
            // 
            this.txtSName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSName.DataPropertyName = "Name";
            this.txtSName.HeaderText = "Supplier Name";
            this.txtSName.Name = "txtSName";
            this.txtSName.ReadOnly = true;
            this.txtSName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtSAddress
            // 
            this.txtSAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSAddress.DataPropertyName = "Address";
            this.txtSAddress.HeaderText = "Address";
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.ReadOnly = true;
            this.txtSAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtSContact
            // 
            this.txtSContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSContact.DataPropertyName = "Contact";
            this.txtSContact.HeaderText = "Contact";
            this.txtSContact.Name = "txtSContact";
            this.txtSContact.ReadOnly = true;
            this.txtSContact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtSType
            // 
            this.txtSType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSType.DataPropertyName = "Type";
            this.txtSType.HeaderText = "Type/Category";
            this.txtSType.Name = "txtSType";
            this.txtSType.ReadOnly = true;
            this.txtSType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtSSupplySince
            // 
            this.txtSSupplySince.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSSupplySince.DataPropertyName = "Supply_Since";
            this.txtSSupplySince.HeaderText = "Supply Since";
            this.txtSSupplySince.Name = "txtSSupplySince";
            this.txtSSupplySince.ReadOnly = true;
            this.txtSSupplySince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSId,
            this.txtSName,
            this.txtSAddress,
            this.txtSContact,
            this.txtSType,
            this.txtSSupplySince});
            this.dgvSupplier.Location = new System.Drawing.Point(13, 58);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(1052, 411);
            this.dgvSupplier.TabIndex = 2;
            this.dgvSupplier.Text = "dataGridView1";
            this.dgvSupplier.Click += new System.EventHandler(this.dgvSupplier_Click);
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1077, 481);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnAddNewSupplier);
            this.Name = "FormSuppliers";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSSupplySince;
    }
}