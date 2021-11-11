using Start_Up_Group.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Start_Up_Group.Views
{
    public partial class FormNewManager : Form
    {
        private int ManagerId;
        private bool IsCreate = true;
        private string InputManagerName;
        private string InputManagerAddress;
        private string InputManagerContact;
        private string InputManagerEmail;
        private double InputManagerSalary;
        private DateTime InputManagerHiredDate;

        private string AdminUsername;

        private IManagerServices managerServices;

        public FormNewManager()
        {
            InitializeComponent();
            this.managerServices = new ManagerServies();
        }

        public void SetSelectedManagerRow(int managerId ,string name,string address,string contact,string email,double salary,string hired_date,string adminName)
        {
            this.AdminUsername = adminName;
            this.ManagerId = managerId;
            this.IsCreate = false;
            DateTime dateTimeFormat = DateTime.Parse(hired_date);
            txtManagerName.Text = name;
            txtManagerAddress.Text = address;
            txtManagerContact.Text = contact;
            txtManagerEmail.Text = email;
            txtManagerSalary.Text = salary.ToString();
            dtPickerManagerHiredDate.Value = dateTimeFormat;
            btnManagerAddNew.Text = IsCreate ? "Create" : "Update";
            
        }

        public void SetAdminName(string adminName)
        {
            this.AdminUsername = adminName;
        }

        private void FormNewManager_Load(object sender, EventArgs e)
        {
           
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEvenHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEvenHandler?.Invoke(this, args);
        }

        private void btnManagerAddNew_Click(object sender, EventArgs e)
        {
            this.InputManagerName = txtManagerName.Text;
            this.InputManagerAddress = txtManagerAddress.Text;
            this.InputManagerContact = txtManagerContact.Text;
            this.InputManagerHiredDate = dtPickerManagerHiredDate.Value;
            this.InputManagerEmail = txtManagerEmail.Text;
            this.InputManagerSalary = double.Parse(txtManagerSalary.Text);

            if (IsCreate)
            {
                var Result = this.managerServices.CreateNewManager(InputManagerEmail,InputManagerSalary,InputManagerHiredDate,InputManagerName,InputManagerAddress,InputManagerContact,AdminUsername);
                if (Result.ResponseSuccess() != null)
                {
                    FormManager formManager = new FormManager();
                    formManager.ShowSuccessDialog("Successfully Created.");
                    raiseUpdate();
                    this.Close();
                }
            }
            else
            {
                var Result = this.managerServices.UpdateManager(this.ManagerId,InputManagerName,InputManagerAddress,InputManagerContact,InputManagerEmail,InputManagerHiredDate,InputManagerSalary,this.AdminUsername);
                if (Result.ResponseSuccess() != null)
                {
                    FormManager formManager = new FormManager();
                    formManager.ShowSuccessDialog("Successfully Created.");
                    raiseUpdate();
                    this.Close();
                }
            }
        }

        private void txtManagerSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManagerSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNewManagerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
