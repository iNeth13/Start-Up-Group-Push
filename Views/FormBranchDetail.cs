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
    public partial class FormBranchDetail : Form
    {
        private IBranchServices branchServices;
        private int BranchId;
        public FormBranchDetail()
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
        }

        public FormBranchDetail(int id)
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
            this.BranchId = id;
        }

        private void FormBranchDetail_Load(object sender, EventArgs e)
        {
            var branchDetailWithManager = this.branchServices.GetBranchDetailWithManager(this.BranchId);
            lbBranchName.Text = branchDetailWithManager.Name.ToString();
            lbManagerId.Text = branchDetailWithManager.Manager.ManagerId.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
