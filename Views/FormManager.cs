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
    public partial class FormManager : Form
    {
        private IManagerServices managerServices;

        private int ManagerId = -1;
        private string adminUsername;

        public FormManager()
        {
            InitializeComponent();
            this.managerServices = new ManagerServies();
        }

        public FormManager(string admin)
        {
            InitializeComponent();
            this.managerServices = new ManagerServies();
            this.adminUsername = admin;
        }

        public void ShowSuccessDialog(string message)
        {
            MessageBox.Show(message);
            this.DisableButtons();
            this.FetchAllManagers();
        }

        //disable button after delete/update
        //unless click again
        private void DisableButtons()
        {
            btnDeleteManager.Enabled = false;
            btnUpdateBranch.Enabled = false;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            this.FetchAllManagers();
            if (this.ManagerId == -1)
            {
                btnUpdateBranch.Enabled = false;
                btnDeleteManager.Enabled = false;
            }
            else
            {
                btnUpdateBranch.Enabled = true;
                btnDeleteManager.Enabled = true;
            }
        }

        private void FetchAllManagers()
        {
            try
            {
                dgvManager.AutoGenerateColumns = false;

                var response = this.managerServices.GetAllManagers();

                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                bs.DataSource = response;
                dgvManager.DataSource = bs;

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void FormNewManager_UpdateEvenHandler(object sender, FormNewManager.UpdateEventArgs args)
        {
            this.FetchAllManagers();
        }

        private void btnAddBranchManager_Click(object sender, EventArgs e)
        {
            FormNewManager formNewManager = new FormNewManager();
            formNewManager.UpdateEvenHandler += FormNewManager_UpdateEvenHandler;
            formNewManager.SetAdminName(this.adminUsername);
            formNewManager.Show();
        }

        //btn update branch manager
        private void btnUpdateBranch_Click(object sender, EventArgs e)
        {
            var rowName = dgvManager.CurrentRow.Cells["txtMManagerName"].Value.ToString();
            var rowAddress = dgvManager.CurrentRow.Cells["txtMManagerAddress"].Value.ToString();
            var rowContact = dgvManager.CurrentRow.Cells["txtMManagerContact"].Value.ToString();
            var rowEmail = dgvManager.CurrentRow.Cells["txtMManagerEmail"].Value.ToString();
            var rowHiredDate = dgvManager.CurrentRow.Cells["txtMManagerHiredDate"].Value.ToString();
            var rowSalary = double.Parse(dgvManager.CurrentRow.Cells["txtMManagerSalary"].Value.ToString());
           

            FormNewManager formNewManager = new FormNewManager();
            formNewManager.SetAdminName(this.adminUsername);
            formNewManager.SetSelectedManagerRow(ManagerId,rowName,rowAddress,rowContact,rowEmail,rowSalary,rowHiredDate,adminUsername);
            formNewManager.UpdateEvenHandler += FormNewManager_UpdateEvenHandler;
            formNewManager.Show();
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.managerServices.DeleteManager(this.ManagerId, this.adminUsername);
                this.DisableButtons();
                this.FetchAllManagers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvManager_Click(object sender, EventArgs e)
        {     
            if (Convert.ToInt32(dgvManager.CurrentRow.Cells["txtMManagerId"].Value) != 0)
            {
                if (dgvManager.CurrentRow.Cells["txtMManagerId"].Value != null)
                {
                this.ManagerId = Convert.ToInt32(dgvManager.CurrentRow.Cells["txtMManagerId"].Value);
                btnUpdateBranch.Enabled = true;
                btnDeleteManager.Enabled = true;
                }
            }
            else
            {
                return;
            }
        }

        private void dgvManager_DoubleClick(object sender, EventArgs e)
        {
            var ManagerId = Convert.ToInt32(dgvManager.CurrentRow.Cells["txtMManagerId"].Value);
            FormManagerDetail formManagerDetail = new FormManagerDetail(ManagerId);
            formManagerDetail.Show();
        }
    }
}
