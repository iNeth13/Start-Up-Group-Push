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
        private IBranchProduct branchProductServices;
        private int BranchId;
        public FormBranchDetail()
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
            this.branchProductServices = new BranchProductServices();
        }

        public FormBranchDetail(int id)
        {
            InitializeComponent();
            this.branchServices = new BranchServices();
            this.BranchId = id;
            this.branchProductServices = new BranchProductServices();
        }

        private void FormBranchDetail_Load(object sender, EventArgs e)
        {
            this.FetchBranchDetailWithManager();
        }

        public void FetchBranchDetailWithManager()
        {
            try
            {
                var branchDetail = this.branchServices.GetBranchDetailWithManager(this.BranchId);
                if (branchDetail.Name.Length > 0)
                {
                    lbBranchName.Text = branchDetail.Name;
                    lbBranchAddress.Text = branchDetail.Address;
                    lbBranchContact.Text = branchDetail.Contact;
                    lbBranchOpenSice.Text = branchDetail.Open_date.ToString();
                    lbBranchTotalIncome.Text = branchDetail.Total_Income.ToString();
                    lbManagerContact.Text = branchDetail.Manager.Name;
                    lbManagerLocation.Text = branchDetail.Manager.Address;
                    lbManagerContact.Text = branchDetail.Manager.Contact;
                }
                else
                {
                    MessageBox.Show("Branch not found");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong with GetBranchDetailManager method");
            }
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

        private void tbBranchDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBranchProduct.Items.Clear();
            lstBranchProduct.Refresh();
            if(tbBranchDetail.SelectedTab == tbBranchProduct)
            {
                try
                {
                    var branchProducts = this.branchProductServices.GetBranchProducts(BranchId);
                    foreach(var product in branchProducts)
                    {
                        ListViewItem row = new ListViewItem(product?.Product.ProductId.ToString());
                        row.SubItems.Add(product.Product.ProductName);
                        row.SubItems.Add(product.Product.ProductBuyIn_Price.ToString());
                        row.SubItems.Add(product.Product.ProductSellOut_Price.ToString());
                        row.SubItems.Add(product.Amount.ToString());
                        row.SubItems.Add(product.Product.ProductExpirationDate.ToString());
                        lstBranchProduct.Items.Add(row);
                    }
                   
                }
                catch (Exception err)
                {
                    MessageBox.Show("Something went wrong, please contact IT team");
                }
            }
        }
    }
}
