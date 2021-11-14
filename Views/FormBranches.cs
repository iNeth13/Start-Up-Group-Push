using MySql.Data.MySqlClient;
using Start_Up_Group.Entities;
using Start_Up_Group.Services;
using Start_Up_Group.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Start_Up_Group
{
    public partial class FormBranches : Form
    {

        private IBranchServices branchServies;

        private int BranchId = -1;
        private string AdminUsername;
        private string SearchValue;

        public FormBranches()
        {
            InitializeComponent();
            this.branchServies = new BranchServices();
           
        }

        public FormBranches(string admin)
        {
            InitializeComponent();
            this.AdminUsername = admin;
            this.branchServies = new BranchServices();
            this.SearchValue = "";
        }

        public FormBranches(string admin, string searchValue)
        {
            InitializeComponent();
            this.branchServies = new BranchServices();
            this.SearchValue = searchValue;
            this.AdminUsername = admin;
        }

        public void ShowSuccessDialog(string ResultMessage)
        {
            MessageBox.Show(ResultMessage);
            btnDeleteBranch.Enabled = false;
            button1.Enabled = false;
            this.FetchAllBranches();      
        }

        private void FormBranches_Load(object sender, EventArgs e)
        {
            this.FetchAllBranches();
            if(BranchId != -1)
            {
                button1.Enabled = true;
                btnDeleteBranch.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                btnDeleteBranch.Enabled = false;
            }
        }

        private void FetchAllBranches()
        {
            dgvBranch.Update();
            dgvBranch.Refresh();
            try
            {
                dgvBranch.AutoGenerateColumns = false;

                var response = this.branchServies.GetBranches(this.SearchValue);
              
                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                bs.DataSource = response;
                dgvBranch.DataSource = bs;

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void FormNewBranches_UpdateEvenHandler(object sender,FormNewBranch.UpdateEventArgs args)
        {
            this.FetchAllBranches();
        }

        private void btnAddNewBranch_Click(object sender, EventArgs e)
        {
          
            FormNewBranch frmNewBranch = new FormNewBranch();
            frmNewBranch.UpdateEvenHandler += FormNewBranches_UpdateEvenHandler;
            frmNewBranch.SetAdminName(this.AdminUsername);
            frmNewBranch.Show();         
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.branchServies.DeleteBranch(BranchId,this.AdminUsername);
                btnDeleteBranch.Enabled = false;
                button1.Enabled = false;
                this.FetchAllBranches();
            }
        }

        //refrsh btn
        private void button2_Click(object sender, EventArgs e)
        {
            this.FetchAllBranches();
        }

        private void dgvBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dgvBranch_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvBranch.CurrentRow.Cells["txtBBranchId"].Value) != 0)
            {
                if (dgvBranch.CurrentRow.Cells["txtBBranchId"].Value != null)
                {
                    this.BranchId = Convert.ToInt32(dgvBranch.CurrentRow.Cells["txtBBranchId"].Value);
                    button1.Enabled = true;
                    btnDeleteBranch.Enabled = true;
                }
            }
            else
            {
                return;
            }    
        }

        //update btn
        private void button1_Click(object sender, EventArgs e)
        {
            var rowName = dgvBranch.CurrentRow.Cells["txtBName"].Value;
            var rowAddress = dgvBranch.CurrentRow.Cells["txtBAddress"].Value;
            var rowContact = dgvBranch.CurrentRow.Cells["txtBContact"].Value;
            var rowOpenDate = dgvBranch.CurrentRow.Cells["txtBOpenDate"].Value;

            FormNewBranch formNewBranch = new FormNewBranch();
            formNewBranch.SetSelectedBranch(BranchId,rowName.ToString(),rowAddress.ToString(),rowContact.ToString(),rowOpenDate.ToString(),this.AdminUsername);
            formNewBranch.Show();
            formNewBranch.UpdateEvenHandler += FormNewBranches_UpdateEvenHandler;
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dgvBranch_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var BranchId = Convert.ToInt32(dgvBranch.CurrentRow.Cells["txtBBranchId"].Value.ToString());
                FormBranchDetail formBranchDetail = new FormBranchDetail(BranchId);
                formBranchDetail.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show("Branch doesn't exist");
            }
        }
    }
}
