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
    public partial class FormNewProduct : Form
    {
        private ISupplierServices supplierServices;
        private IProductServices productServices;

        private string AdminUsername;
        private bool IsCreate = true;
        private string Category;
        private int ProductId;
        private int SupplierId;


        public FormNewProduct()
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.supplierServices = new SupplierServices();
        }

        public void SetAdminName(string adminName)
        {
            this.AdminUsername = adminName;
        }

        public void SetSelectedProductRow(int productId, string adminUsername, string pName, double pBuyIn, double pSellOut,string pCategory,string pExpiration)
        {
            this.AdminUsername = adminUsername;
            this.IsCreate = false;
            this.ProductId = productId;
            DateTime newDateTimeFormat = DateTime.Parse(pExpiration);
            txtProductName.Text = pName;
            txtBuyInPrice.Text = pBuyIn.ToString();
            txtSellOutPrice.Text = pSellOut.ToString();

            btnNewProduct.Text = "Update";
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEvenHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEvenHandler?.Invoke(this, args);
        }

        private void InitializeCbxValue()
        {
            cbxCategory.DisplayMember = "Text";
            cbxCategory.ValueMember = "Value";
            var items = new[]
            {
                new {Text="Beverage",Value="beverage"},
                new {Text="Snack",Value="snack"},
                new {Text="Beauty",Value="beauty"}
            };
            cbxCategory.DataSource = items;

            var suppliers = this.supplierServices.GetAllSuppliers("");
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "SupplierId";

            cbxSupplier.DataSource = suppliers;

        }

        private void FormNewProduct_Load(object sender, EventArgs e)
        {
            this.InitializeCbxValue();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Category = cbxCategory.SelectedValue.ToString();
        }

        private void btnProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var pName = txtProductName.Text.ToString();
            var pBuyIn = double.Parse(txtBuyInPrice.Text.ToString());
            var pSellOut = double.Parse(txtSellOutPrice.Text.ToString());
            DateTime pExpiration = dtPickerExpirationDate.Value;

            if (IsCreate)
            {
                var Result = this.productServices.CreateProduct(SupplierId,this.AdminUsername,pName,pBuyIn,pSellOut,this.Category,pExpiration);
                if (Result.ResponseSuccess() != null)
                {
                    FormBranches formBranches = new FormBranches();
                    formBranches.ShowSuccessDialog("Successfully Created.");
                    raiseUpdate();
                    this.Close();
                }
            }
            else
            {
                var Result = this.productServices.UpdateProduct(this.ProductId, this.AdminUsername, pName, pBuyIn, pSellOut, this.Category, pExpiration);
                if (Result.ResponseSuccess() != null)
                {
                    FormBranches formBranches = new FormBranches();
                    formBranches.ShowSuccessDialog("Successfully Updated.");
                    raiseUpdate();
                    this.Close();
                }
            }
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SupplierId = Convert.ToInt32(cbxSupplier.SelectedValue);
        }
    }
}
