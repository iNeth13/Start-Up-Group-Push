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
    public partial class FormProduct : Form
    {
        private string adminUsername;
        private IProductServices productServices;
        private int ProductId = -1;
        private string SearchValue;

        public FormProduct()
        {
            InitializeComponent();
            this.productServices = new ProductServices();
        }

        public FormProduct(string admin)
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.adminUsername = admin;
            this.SearchValue = "";
        }

        public FormProduct(string admin,string searchValue)
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.SearchValue = searchValue;
            this.adminUsername = admin;
        }

        public void SetSearchResult(List<Product> result)
        {
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.Refresh();
            dgvProduct.DataSource = result;
        }

        public void ShowSuccessDialog(string message)
        {
            MessageBox.Show(message);
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            this.FetchAllProducts();
        }

        private void FetchAllProducts()
        {
            try
            {
                dgvProduct.AutoGenerateColumns = false;

                var response= this.productServices.GetAllProducts(this.SearchValue);

                DataSet ds = new DataSet();
                BindingSource bs = new BindingSource();
                bs.DataSource = response;
                dgvProduct.DataSource = bs;

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void FormNewManager_UpdateEvenHandler(object sender, FormNewProduct.UpdateEventArgs args)
        {
            this.FetchAllProducts();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FormNewProduct formNewProduct = new FormNewProduct();
            formNewProduct.UpdateEvenHandler += FormNewManager_UpdateEvenHandler;
            formNewProduct.SetAdminName(this.adminUsername);
            formNewProduct.Show();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.FetchAllProducts();
            if (this.ProductId == -1)
            {
                btnDeleteProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
            }
            else
            {
                btnDeleteProduct.Enabled = true;
                btnUpdateProduct.Enabled = true;
            }
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvProduct.CurrentRow.Cells["txtPId"].Value) != 0)
            {
                if (dgvProduct.CurrentRow.Cells["txtPId"].Value != null)
                {
                    this.ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["txtPId"].Value);
                    btnUpdateProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                }
            }
            else
            {
                return;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.productServices.DeleteProduct(this.ProductId, this.adminUsername);
                btnDeleteProduct.Enabled = false;
                btnUpdateProduct.Enabled = false;
                this.FetchAllProducts();
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            this.FetchAllProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            var pName = dgvProduct.CurrentRow.Cells["txtPName"].Value.ToString();
            var pBuyIn = double.Parse(dgvProduct.CurrentRow.Cells["txtPBuyIn"].Value.ToString());
            var pSellOut = double.Parse(dgvProduct.CurrentRow.Cells["txtPSellOut"].Value.ToString());
            var pCategory = dgvProduct.CurrentRow.Cells["txtPCategory"].Value.ToString();
            var pExpiration = dgvProduct.CurrentRow.Cells["txtPExpiration"].Value.ToString();


            FormNewProduct formNewProduct = new FormNewProduct();
            formNewProduct.SetSelectedProductRow(this.ProductId,this.adminUsername,pName,pBuyIn,pSellOut,pCategory,pExpiration);
            formNewProduct.UpdateEvenHandler += FormNewManager_UpdateEvenHandler;
            formNewProduct.Show();
        }
    }
}
