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
    public partial class FormNewSupplier : Form
    {
        private string AdminUsername;
        private int SupplierId;
        private bool IsCreate = true;
        private string SelectedCbxValue;

        private ISupplierServices supplierServices;

        public FormNewSupplier()
        {
            InitializeComponent();
            this.supplierServices = new SupplierServices();
        }

        public void SetAdminName(string adminName)
        {
            this.AdminUsername = adminName;
        }

        public void SetSelectedSupplierRow(int sId,string adminName,string sName,string sAddress,string sContact,string sCategory, string sSince)
        {
            this.AdminUsername = adminName;
            this.SupplierId = sId;
            this.IsCreate = false;
            DateTime dateTimeFormat = DateTime.Parse(sSince);
           
            txtSupplierAddress.Text = sAddress;
            txtSupplierContact.Text = sContact;
            txtSupplierName.Text = sName;
            dtPickerSupplySince.Value = dateTimeFormat;

            btnAddNew.Text = "Update";
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

        private void InitCbxValue()
        {
            cbxType.DisplayMember = "Text";
            cbxType.ValueMember = "Value";

            var items = new []
            {
                new {Text="Beverage",Value="beverage"},
                new {Text="Beauty",Value="beauty"},
                new {Text="Food",Value="food"},
                new {Text="Stationary",Value="stationary"},
            };

            cbxType.DataSource = items;
        }

        private void FormNewSupplier_Load(object sender, EventArgs e)
        {
            this.InitCbxValue();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var sName = txtSupplierName.Text;
            var sAddress = txtSupplierAddress.Text;
            var sContact = txtSupplierContact.Text;
            DateTime sSince = dtPickerSupplySince.Value;
            if (IsCreate)
            {
                var Result = this.supplierServices.CreateSupplier(this.AdminUsername,sName,sAddress,sContact,this.SelectedCbxValue,sSince);
                if (Result.ResponseSuccess() != null)
                {
                    FormSuppliers formSupplier = new FormSuppliers();
                    formSupplier.ShowSuccessDialog("Successfully Created.");
                    raiseUpdate();
                    this.Close();
                }
            }
            else
            {
                var Result = this.supplierServices.UpdateSupplier(this.SupplierId,this.AdminUsername,sName,this.SelectedCbxValue,sContact,sAddress,sSince);
                if (Result.ResponseSuccess() != null)
                {
                    FormSuppliers formSupplier = new FormSuppliers();
                    formSupplier.ShowSuccessDialog("Successfully Updated.");
                    btnAddNew.Text = "Create";
                    raiseUpdate();
                    this.Close();
                }
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedCbxValue = cbxType.SelectedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
