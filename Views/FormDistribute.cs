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
    public partial class FormDistribute : Form
    {

        private IProductServices productServices;
        private IBranchServices branchServices;
        private IBranchProduct branchProductServices;
        private string AdminName;
        private string bValue;

        public FormDistribute()
        {
            InitializeComponent();

            this.productServices = new ProductServices();
            this.branchServices = new BranchServices();
            this.branchProductServices = new BranchProductServices();
        }

        public FormDistribute(string adminName)
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.branchServices = new BranchServices();
            this.AdminName = adminName;
            this.branchProductServices = new BranchProductServices();
            List<BranchProduct> branchProducts = this.branchProductServices.GetBranchProducts(1);
            List<int> pIds = new List<int>();
            foreach (var branchProduct in branchProducts)
            {
                pIds.Add(branchProduct.ProductId);
            }
            List<Product> products = this.productServices.Test(pIds);
            foreach(var product in products)
            {
                Debug.WriteLine(product.ProductName);
            }
        }

        private void LoadProductFromDB()
        {
            try
            {
                var products = this.productServices.GetAllProducts("");
                var products_1 = this.productServices.GetAllProducts("");
                var products_2 = this.productServices.GetAllProducts("");
                var products_3 = this.productServices.GetAllProducts("");
                var products_4 = this.productServices.GetAllProducts("");
                var branches = this.branchServices.GetBranches("");

                branches.Insert(0,new Branch { Name=null,BranchId=-1 });
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "BranchId";
                comboBox1.DataSource = branches;

                products.Insert(0, new Product { ProductName = "", ProductId = -1 });
                cbxFirstProduct.DisplayMember = "ProductName";
                cbxFirstProduct.ValueMember = "ProductId";
                cbxFirstProduct.DataSource = products;

                products_1.Insert(0, new Product { ProductName = "", ProductId = -1 });
                cbxSecondProduct.DisplayMember = "ProductName";
                cbxSecondProduct.ValueMember = "ProductId";
                cbxSecondProduct.DataSource = products_1;

                products_2.Insert(0, new Product { ProductName = "", ProductId = -1 });
                cbxThirdProduct.DisplayMember = "ProductName";
                cbxThirdProduct.ValueMember = "ProductId";
                cbxThirdProduct.DataSource = products_2;

                products_3.Insert(0, new Product { ProductName = "", ProductId = -1 });
                cbxFourthProduct.DisplayMember = "ProductName";
                cbxFourthProduct.ValueMember = "ProductId";
                cbxFourthProduct.DataSource = products_3;

                products_4.Insert(0, new Product { ProductName = "", ProductId = -1 });
                cbxFifthProduct.DisplayMember = "ProductName";
                cbxFifthProduct.ValueMember = "ProductId";
                cbxFifthProduct.DataSource = products_4;


            }
            catch (Exception err)
            {
                MessageBox.Show("Load Product Failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtFiP.Text = "";
            this.txtFoP.Text = "";
            this.txtFPAmount.Text = "";
            this.txtSPAmount.Text = "";
            this.txtTPAmount.Text = "";
            this.cbxFifthProduct.Text = "";
            this.cbxFirstProduct.Text = "";
            this.cbxSecondProduct.Text = "";
            this.cbxThirdProduct.Text = "";
            this.cbxFourthProduct.Text = "";
        }

        private void FormDistribute_Load(object sender, EventArgs e)
        {
            this.LoadProductFromDB();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "-1")
            {
                this.txtFiP.Enabled = true;
                this.txtFoP.Enabled = true;
                this.txtFPAmount.Enabled = true;
                this.txtSPAmount.Enabled = true;
                this.txtTPAmount.Enabled = true;
                this.cbxFifthProduct.Enabled = true;
                this.cbxFirstProduct.Enabled = true;
                this.cbxSecondProduct.Enabled = true;
                this.cbxThirdProduct.Enabled = true;
                this.cbxFourthProduct.Enabled = true;
                this.bValue = comboBox1.SelectedValue.ToString();
            }
            else
            {
                 Debug.WriteLine("Thisrun2");
                    this.txtFiP.Enabled = false;
                    this.txtFoP.Enabled = false;
                    this.txtFPAmount.Enabled = false;
                    this.txtSPAmount.Enabled = false;
                    this.txtTPAmount.Enabled = false;
                    this.cbxFifthProduct.Enabled = false;
                    this.cbxFirstProduct.Enabled = false;
                    this.cbxSecondProduct.Enabled = false;
                    this.cbxThirdProduct.Enabled = false;
                    this.cbxFourthProduct.Enabled = false;     
            }
        }

        private void cbxFirstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedValue.ToString() == "-1")
                {
                    Debug.WriteLine("if");
                    MessageBox.Show("Please select a branch");
                }
                else if (this.comboBox1?.SelectedValue?.ToString() != "-1" && this.cbxFirstProduct.SelectedValue.ToString() == "-1" && this.cbxSecondProduct.SelectedValue.ToString() == "-1" && this.cbxThirdProduct.SelectedValue.ToString() == "-1" && this.cbxFourthProduct.SelectedValue.ToString() == "-1" && this.cbxFifthProduct.SelectedValue.ToString() == "-1")
                {
                    Debug.WriteLine("else if");
                    MessageBox.Show("Please select at least one product.");
                }
                else
                {
                    Debug.WriteLine("else");
                    List<BranchProduct> branchProducts = new List<BranchProduct>();
                    var pOneAmount = txtFPAmount.Text.Length>0 ? Convert.ToInt32(txtFPAmount.Text) : 0;
                    var pTwpAmount = txtSPAmount.Text.Length>0? Convert.ToInt32(txtSPAmount.Text): 0;
                    Debug.WriteLine(pOneAmount);
                    var pThreeAmount = txtTPAmount.Text.Length>0 ? Convert.ToInt32(txtTPAmount.Text) : 0;
                    var pFourAmount = txtFoP.Text.Length>0 ? Convert.ToInt32(txtFoP.Text) : 0;
                    var pFiveAmount = txtFiP.Text.Length>0 ? Convert.ToInt32(txtFiP.Text) :0;

                    if (this.cbxFirstProduct.SelectedValue.ToString() != "-1")
                    {
                        branchProducts.Add(new BranchProduct { ProductId = Convert.ToInt32(this.cbxFirstProduct.SelectedValue.ToString()),Amount = pOneAmount });
                    }
                    if (this.cbxSecondProduct.SelectedValue.ToString() != "-1")
                    {
                        branchProducts.Add(new BranchProduct { ProductId = Convert.ToInt32(this.cbxSecondProduct.SelectedValue.ToString()),Amount = pTwpAmount  });
                    }
                    if (this.cbxThirdProduct.SelectedValue.ToString() != "-1")
                    {
                        branchProducts.Add(new BranchProduct { ProductId = Convert.ToInt32(this.cbxThirdProduct.SelectedValue.ToString()),Amount = pThreeAmount});
                    }
                    if (this.cbxFourthProduct.SelectedValue.ToString() != "-1")
                    {
                        branchProducts.Add(new BranchProduct { ProductId = Convert.ToInt32(this.cbxFourthProduct.SelectedValue.ToString()),Amount = pFourAmount });
                    }
                    if (this.cbxFifthProduct.SelectedValue.ToString() != "-1")
                    {
                        branchProducts.Add(new BranchProduct { ProductId = Convert.ToInt32(this.cbxFifthProduct.SelectedValue.ToString()), Amount = pFiveAmount });
                    }

                    try
                    {

                        foreach (BranchProduct bp in branchProducts)
                        {
                            this.branchProductServices.CreateNewBranchProduct(bp.ProductId,Convert.ToInt32(bValue.ToString()), bp.Amount);
                        }
                        MessageBox.Show("Successfully Imported Products a branch");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Couldn't perform distribution function.");
                    }
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                MessageBox.Show("Opp, something went wrong.Bug bug bug bug");
            }
        }

        private void txtFPAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
