using Start_Up_Group.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Start_Up_Group
{
    public partial class frmDaskboard : Form
    {

        private string AdminUsername;
        private string AdminName;
        private string Position;

        public frmDaskboard()
        {
            InitializeComponent();
        }

        public void SetLoggedInAdmin(string username,string name,string position)
        {
            this.AdminUsername = username;
            this.AdminName = name;
            this.Position = position;
            lbUsername.Text = username;
            label11.Text = position;
        }

        private void frmDaskboard_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            var newDayFormat = dateTime.ToString("dd/MMM/yyyy");
            lbTodayDate.Text = newDayFormat;
            openChildForm(new FormOverview());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = childForm;
                activeForm.TopLevel = false;
                activeForm.FormBorderStyle = FormBorderStyle.None;
                panel3.Controls.Add(childForm);
                panel3.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBranches(this.AdminUsername));
            label9.Text = "Branches";
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOverview());
            label9.Text = "Overview";
        }

        private void btnBranchManager_Click(object sender, EventArgs e)
        {
            openChildForm(new FormManager(this.AdminUsername));
            label9.Text = "Managers";
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSuppliers(this.AdminUsername));
            label9.Text = "Suppliers";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = Position;
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            lbUsername.Text = AdminName;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnProductTab_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProduct(this.AdminUsername));
            label9.Text = "Products";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Logout",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
            }
        }

       
    }
}
