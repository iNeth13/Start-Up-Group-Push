using Start_Up_Group.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Start_Up_Group
{
    public partial class FormOverview : Form
    {
        private IBranchServices branchServices;
        private IManagerServices managerServices;

        public FormOverview()
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
            this.managerServices = new ManagerServies();
        }

        private void FetchTotalBranches()
        {
            var result = this.branchServices.GetBranches("").Count;
            txtTotalBranch.Text = result.ToString();
        }

        private void FetchTotalManagers()
        {
            var result = this.managerServices.GetAllManagers("").Count;
            txtTotalManagers.Text = result.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOverview_Load(object sender, EventArgs e)
        {
            this.FetchTotalBranches();
            this.FetchTotalManagers();
        }

        private void txtTotalManagers_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
