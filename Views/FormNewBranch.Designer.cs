namespace Start_Up_Group.Views
{
    partial class FormNewBranch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewBranchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewBranchAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewBranchContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNewBranchManager = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.dtPickerNewBranch = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name: :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewBranchName
            // 
            this.txtNewBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewBranchName.Location = new System.Drawing.Point(24, 48);
            this.txtNewBranchName.Name = "txtNewBranchName";
            this.txtNewBranchName.Size = new System.Drawing.Size(268, 29);
            this.txtNewBranchName.TabIndex = 1;
            this.txtNewBranchName.TextChanged += new System.EventHandler(this.txtNewBranchName_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewBranchAddress
            // 
            this.txtNewBranchAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewBranchAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewBranchAddress.Location = new System.Drawing.Point(24, 117);
            this.txtNewBranchAddress.Multiline = true;
            this.txtNewBranchAddress.Name = "txtNewBranchAddress";
            this.txtNewBranchAddress.Size = new System.Drawing.Size(268, 44);
            this.txtNewBranchAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desk Phone :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewBranchContact
            // 
            this.txtNewBranchContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewBranchContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewBranchContact.Location = new System.Drawing.Point(24, 200);
            this.txtNewBranchContact.Name = "txtNewBranchContact";
            this.txtNewBranchContact.Size = new System.Drawing.Size(268, 29);
            this.txtNewBranchContact.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(24, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manager In-charge : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxNewBranchManager
            // 
            this.cbxNewBranchManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNewBranchManager.FormattingEnabled = true;
            this.cbxNewBranchManager.Location = new System.Drawing.Point(24, 278);
            this.cbxNewBranchManager.Name = "cbxNewBranchManager";
            this.cbxNewBranchManager.Size = new System.Drawing.Size(268, 29);
            this.cbxNewBranchManager.TabIndex = 4;
            this.cbxNewBranchManager.SelectedIndexChanged += new System.EventHandler(this.cbxNewBranchManager_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Location = new System.Drawing.Point(316, 54);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddBranch.Location = new System.Drawing.Point(316, 24);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(75, 23);
            this.btnAddBranch.TabIndex = 6;
            this.btnAddBranch.Text = "Add New";
            this.btnAddBranch.UseVisualStyleBackColor = false;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // dtPickerNewBranch
            // 
            this.dtPickerNewBranch.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickerNewBranch.Location = new System.Drawing.Point(24, 360);
            this.dtPickerNewBranch.Name = "dtPickerNewBranch";
            this.dtPickerNewBranch.Size = new System.Drawing.Size(268, 23);
            this.dtPickerNewBranch.TabIndex = 5;
            this.dtPickerNewBranch.Value = new System.DateTime(2021, 11, 9, 18, 28, 12, 0);
            this.dtPickerNewBranch.ValueChanged += new System.EventHandler(this.dtPickerNewBranch_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(24, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manager In-charge : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormNewBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPickerNewBranch);
            this.Controls.Add(this.btnAddBranch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxNewBranchManager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewBranchContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewBranchAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewBranchName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNewBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewBranchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewBranchAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewBranchContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNewBranchManager;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.DateTimePicker dtPickerNewBranch;
        private System.Windows.Forms.Label label5;
    }
}