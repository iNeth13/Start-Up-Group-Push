using Start_Up_Group.Entities;
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
    public partial class FormManagerDetail : Form
    {
        private int ManagerId;
        private IManagerServices managerServices;
        public FormManagerDetail()
        {
            InitializeComponent();
            this.managerServices = new ManagerServies();
        }

        public FormManagerDetail(int ManagerId)
        {
            this.ManagerId = ManagerId;
            InitializeComponent();
            this.managerServices = new ManagerServies();

        }

        public void FetchManagerDetailWithBranches()
        {
            Manager managerDetail = this.managerServices.GetManagerDetailWithBranches(this.ManagerId);
            lbManagerName.Text = managerDetail.Name;
            lbManagerAddress.Text = managerDetail.Address;
            lbManagerContact.Text = managerDetail.Contact;
            lbManagerHiredDate.Text = "$" + managerDetail.Hired_date.ToString();
            lbManagerSalary.Text = managerDetail.Salary.ToString();
            lbManagerBranches.Text = "Branches Managed by " + managerDetail.Name;
            if(managerDetail.Branches != null)
            {
                foreach (Branch branch in managerDetail.Branches)
                {
                    ListViewItem item = new ListViewItem(branch.Name);
                    item.SubItems.Add(branch.Address);
                    item.SubItems.Add(branch.Contact);
                    item.SubItems.Add(branch.Total_Income.ToString());
                    item.SubItems.Add(branch.Open_date.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void FormManagerDetail_Load(object sender, EventArgs e)
        {
            this.FetchManagerDetailWithBranches();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
