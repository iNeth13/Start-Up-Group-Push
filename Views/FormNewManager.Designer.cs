namespace Start_Up_Group.Views
{
    partial class FormNewManager
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
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.lbManagerName = new System.Windows.Forms.Label();
            this.txtManagerAddress = new System.Windows.Forms.TextBox();
            this.lbManagerAddress = new System.Windows.Forms.Label();
            this.txtManagerContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManagerSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnManagerAddNew = new System.Windows.Forms.Button();
            this.btnNewManagerCancel = new System.Windows.Forms.Button();
            this.dtPickerManagerHiredDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtManagerName
            // 
            this.txtManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerName.Location = new System.Drawing.Point(23, 48);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(268, 29);
            this.txtManagerName.TabIndex = 1;
            // 
            // lbManagerName
            // 
            this.lbManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManagerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbManagerName.Location = new System.Drawing.Point(22, 22);
            this.lbManagerName.Name = "lbManagerName";
            this.lbManagerName.Size = new System.Drawing.Size(138, 23);
            this.lbManagerName.TabIndex = 1;
            this.lbManagerName.Text = " Manager Name :";
            this.lbManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtManagerAddress
            // 
            this.txtManagerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManagerAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerAddress.Location = new System.Drawing.Point(22, 119);
            this.txtManagerAddress.Name = "txtManagerAddress";
            this.txtManagerAddress.Size = new System.Drawing.Size(268, 29);
            this.txtManagerAddress.TabIndex = 2;
            // 
            // lbManagerAddress
            // 
            this.lbManagerAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbManagerAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbManagerAddress.Location = new System.Drawing.Point(23, 93);
            this.lbManagerAddress.Name = "lbManagerAddress";
            this.lbManagerAddress.Size = new System.Drawing.Size(138, 23);
            this.lbManagerAddress.TabIndex = 1;
            this.lbManagerAddress.Text = "Address :";
            this.lbManagerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtManagerContact
            // 
            this.txtManagerContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManagerContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerContact.Location = new System.Drawing.Point(23, 193);
            this.txtManagerContact.Name = "txtManagerContact";
            this.txtManagerContact.Size = new System.Drawing.Size(268, 29);
            this.txtManagerContact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManagerEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerEmail.Location = new System.Drawing.Point(23, 266);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.Size = new System.Drawing.Size(268, 29);
            this.txtManagerEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtManagerSalary
            // 
            this.txtManagerSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManagerSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManagerSalary.Location = new System.Drawing.Point(23, 341);
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.Size = new System.Drawing.Size(268, 29);
            this.txtManagerSalary.TabIndex = 5;
            this.txtManagerSalary.TextChanged += new System.EventHandler(this.txtManagerSalary_TextChanged);
            this.txtManagerSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerSalary_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salary :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnManagerAddNew
            // 
            this.btnManagerAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManagerAddNew.Location = new System.Drawing.Point(315, 24);
            this.btnManagerAddNew.Name = "btnManagerAddNew";
            this.btnManagerAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnManagerAddNew.TabIndex = 7;
            this.btnManagerAddNew.Text = "Add New";
            this.btnManagerAddNew.UseVisualStyleBackColor = true;
            this.btnManagerAddNew.Click += new System.EventHandler(this.btnManagerAddNew_Click);
            // 
            // btnNewManagerCancel
            // 
            this.btnNewManagerCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnNewManagerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewManagerCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewManagerCancel.Location = new System.Drawing.Point(315, 53);
            this.btnNewManagerCancel.Name = "btnNewManagerCancel";
            this.btnNewManagerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewManagerCancel.TabIndex = 8;
            this.btnNewManagerCancel.Text = "Cancel";
            this.btnNewManagerCancel.UseVisualStyleBackColor = false;
            this.btnNewManagerCancel.Click += new System.EventHandler(this.btnNewManagerCancel_Click);
            // 
            // dtPickerManagerHiredDate
            // 
            this.dtPickerManagerHiredDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickerManagerHiredDate.Location = new System.Drawing.Point(21, 422);
            this.dtPickerManagerHiredDate.Name = "dtPickerManagerHiredDate";
            this.dtPickerManagerHiredDate.Size = new System.Drawing.Size(270, 29);
            this.dtPickerManagerHiredDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hired Date :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormNewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(411, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPickerManagerHiredDate);
            this.Controls.Add(this.btnNewManagerCancel);
            this.Controls.Add(this.btnManagerAddNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManagerSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManagerEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManagerContact);
            this.Controls.Add(this.lbManagerAddress);
            this.Controls.Add(this.txtManagerAddress);
            this.Controls.Add(this.lbManagerName);
            this.Controls.Add(this.txtManagerName);
            this.Name = "FormNewManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager ";
            this.Load += new System.EventHandler(this.FormNewManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label lbManagerName;
        private System.Windows.Forms.TextBox txtManagerAddress;
        private System.Windows.Forms.Label lbManagerAddress;
        private System.Windows.Forms.TextBox txtManagerContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManagerSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManagerAddNew;
        private System.Windows.Forms.Button btnNewManagerCancel;
        private System.Windows.Forms.DateTimePicker dtPickerManagerHiredDate;
        private System.Windows.Forms.Label label5;
    }
}