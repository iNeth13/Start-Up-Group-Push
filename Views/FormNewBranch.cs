using Start_Up_Group.Entities;
using Start_Up_Group.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Start_Up_Group.Views
{
    public partial class FormNewBranch : Form
    {

        private IBranchServices branchServices;
        private IManagerServices managerServices;

        private string InputBranchName;
        private DateTime InputBranchOpenDate;
        private string InputBranchContact;
        private string InputBranchAddress;
        private int SelectedManagerId;

        private string AdminUsername;

        private bool IsCreate = true;
        private int BranchId;
        private int ManagerId;

        public FormNewBranch()
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
            this.managerServices = new ManagerServies();
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

        public void SetSelectedBranch(int BranchId,string bName,string bAddress, string bContact,string bOpenDate,string admin)
        {
            DateTime newDateTimeFormat =  DateTime.Parse(bOpenDate);
            this.BranchId = BranchId;
            this.IsCreate = false;
            this.AdminUsername = admin;
            txtNewBranchName.Text = bName;
            txtNewBranchAddress.Text = bAddress;
            txtNewBranchContact.Text = bContact;
            dtPickerNewBranch.Value = newDateTimeFormat;
  

            btnAddBranch.Text = IsCreate ? "Add New" : "Update";
        }

        public void SetAdminName(string admin)
        {
            this.AdminUsername = admin;
        }

        public void FetchAllManagers()
        {
            var managers = this.managerServices.GetAllManagers("");
            //bind data to cbx
            cbxNewBranchManager.DisplayMember = "Name";
            cbxNewBranchManager.ValueMember = "ManagerId";

            cbxNewBranchManager.DataSource = managers;
        }

        private void FormNewBranch_Load(object sender, EventArgs e)
        {
            this.FetchAllManagers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNewBranchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            this.InputBranchName = txtNewBranchName.Text.ToString();
            this.InputBranchAddress = txtNewBranchAddress.Text.ToString();
            this.InputBranchContact = txtNewBranchContact.Text.ToString();
            this.InputBranchOpenDate = dtPickerNewBranch.Value;
          

            if (IsCreate)
            {
                var Result = this.branchServices.CreateNewBranch(InputBranchName, InputBranchAddress, InputBranchContact, InputBranchOpenDate,AdminUsername,this.ManagerId);
                if (Result.ResponseSuccess() != null)
                {
                    FormBranches formBranches = new FormBranches();
                    formBranches.ShowSuccessDialog("Successfully Created.");
                    raiseUpdate();
                    this.Close();
                }
            }
            else
            {
                var Result = this.branchServices.UpdateBranch(this.BranchId,InputBranchName,InputBranchAddress,InputBranchContact,InputBranchOpenDate,AdminUsername);
                if (Result.ResponseSuccess() != null)
                {
                    FormBranches formBranches = new FormBranches();
                    formBranches.ShowSuccessDialog("Successfully Updated.");
                    raiseUpdate();
                    this.Close();
                }
            }
        }

        private void dtPickerNewBranch_ValueChanged(object sender, EventArgs e)
        {
            dtPickerNewBranch.BringToFront();
        }

        private void cbxNewBranchManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ManagerId = Convert.ToInt32(cbxNewBranchManager.SelectedValue);
        }
    }
}
