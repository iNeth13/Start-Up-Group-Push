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
    public partial class FormSuppliers : Form
    {

        private string adminUsername;
        private int SupplierId = -1;
        private ISupplierServices supplierServices;

        public FormSuppliers()
        {
            InitializeComponent();
            this.supplierServices = new SupplierServices();
        }

        public FormSuppliers(string admin)
        {
            InitializeComponent();
            this.adminUsername = admin;
            this.supplierServices = new SupplierServices();
        }

        public void ShowSuccessDialog(string ResultMessage)
        {
            MessageBox.Show(ResultMessage);
            btnDeleteSupplier.Enabled = false;
            btnUpdateSupplier.Enabled = false;
            this.FetchAllSupplier();
        }

        public void FetchAllSupplier()
        {
            dgvSupplier.Update();
            dgvSupplier.Refresh();
            try
            {
                dgvSupplier.AutoGenerateColumns = false;

                var response = this.supplierServices.GetAllSuppliers();

                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                bs.DataSource = response;
                dgvSupplier.DataSource = bs;

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void FormNewSupplier_UpdateEvenHandler(object sender, FormNewSupplier.UpdateEventArgs args)
        {
            this.FetchAllSupplier();
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            this.FetchAllSupplier();
            if (SupplierId != -1)
            {
                btnDeleteSupplier.Enabled = true;
                btnUpdateSupplier.Enabled = true;
            }
            else
            {
                btnDeleteSupplier.Enabled = false;
                btnUpdateSupplier.Enabled = false;
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            var rowName = dgvSupplier.CurrentRow.Cells["txtSName"].Value.ToString();
            var rowAddress = dgvSupplier.CurrentRow.Cells["txtSAddress"].Value.ToString();
            var rowContact = dgvSupplier.CurrentRow.Cells["txtSContact"].Value.ToString();
            var rowSuppySince = dgvSupplier.CurrentRow.Cells["txtSSupplySince"].Value.ToString();
            var rowType = dgvSupplier.CurrentRow.Cells["txtSType"].Value.ToString();

            FormNewSupplier formNewSupplier = new FormNewSupplier();
            formNewSupplier.SetSelectedSupplierRow(this.SupplierId,this.adminUsername,rowName,rowAddress,rowContact,rowType,rowSuppySince);
            formNewSupplier.Show();
            formNewSupplier.UpdateEvenHandler += FormNewSupplier_UpdateEvenHandler;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.FetchAllSupplier();
        }

        private void dgvSupplier_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvSupplier.CurrentRow.Cells["txtSId"].Value) != 0)
            {
                if (dgvSupplier.CurrentRow.Cells["txtSId"].Value != null)
                {
                    this.SupplierId = Convert.ToInt32(dgvSupplier.CurrentRow.Cells["txtSId"].Value);
                    btnDeleteSupplier.Enabled = true;
                    btnUpdateSupplier.Enabled = true;
                }
            }
            else
            {
                return;
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.supplierServices.DeleteSupplier(this.SupplierId,this.adminUsername);
                btnUpdateSupplier.Enabled = false;
                btnDeleteSupplier.Enabled = false;
                this.FetchAllSupplier();
            }
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            FormNewSupplier formNewSupplier = new FormNewSupplier();
            formNewSupplier.UpdateEvenHandler += FormNewSupplier_UpdateEvenHandler;
            formNewSupplier.SetAdminName(this.adminUsername);
            formNewSupplier.Show();
        }
    }
}
