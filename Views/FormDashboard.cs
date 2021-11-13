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
using System.Windows.Forms;

namespace Start_Up_Group
{
    public partial class frmDaskboard : Form
    {

        private string AdminUsername;
        private string AdminName;
        private string Position;
        private string SelectedCbxValue;

        private IProductServices productServices;
        private IBranchServices branchServices;
        private IManagerServices managerServices;
        private ISupplierServices supplierServices;

        public frmDaskboard()
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.branchServices = new BranchServices();
            this.managerServices = new ManagerServies();
            this.supplierServices = new SupplierServices();
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
            this.InitialSearchCbxValue();

            btnEntitySearch.Enabled = false;
            txtSearchValue.Enabled = false;

            openChildForm(new FormOverview());
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

        private void InitialSearchCbxValue()
        {
            cbxEntity.DisplayMember = "Text";
            cbxEntity.ValueMember = "Value";
            var items = new[]
            {
                new {Text="-Select",Value="select"},
                new {Text="Manager",Value="manager"},
                new {Text="Branch",Value="branch"},
                new {Text="Supplier",Value="supplier"},
                new {Text="Product",Value="product"},
            };
            cbxEntity.DataSource = items;

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

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDistribute(this.AdminUsername));
            label9.Text = "Product Distribution";
        }

        private void cbxEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedCbxValue = cbxEntity.SelectedValue.ToString();
            if(this.SelectedCbxValue != "select")
            {
                btnEntitySearch.Enabled = true;
                txtSearchValue.Enabled = true;
            }
            else
            {
                btnEntitySearch.Enabled = false;
                txtSearchValue.Enabled = false;
            }
        }

        private void btnEntitySearch_Click(object sender, EventArgs e)
        {
                switch (this.SelectedCbxValue)
                {
                    case "product":
                        openChildForm(new FormProduct(this.AdminName,txtSearchValue.Text));
                        label9.Text = "Products";
                        break;
                    case "supplier":
                        openChildForm(new FormSuppliers(this.AdminName, txtSearchValue.Text));
                        label9.Text = "Supplier";
                        break;
                    case "manager":
                        openChildForm(new FormManager(this.AdminName,txtSearchValue.Text));
                        label9.Text = "Manager";
                        break;
                    case "branch":
                        openChildForm(new FormBranches(this.AdminName, txtSearchValue.Text));
                        label9.Text = "Branch";
                        break;

                    default:
                        MessageBox.Show("Please select a type");
                        break;
                 }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

     
    }
}
