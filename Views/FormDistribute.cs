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
    public partial class FormDistribute : Form
    {
        private string AdminName;
        private IProductServices productServices;
        private IBranchServices branchServices;
        public FormDistribute()
        {
            InitializeComponent();

            this.productServices = new ProductServices();
            this.branchServices = new BranchServices();
        }

        public FormDistribute(string adminName)
        {
            InitializeComponent();
            this.productServices = new ProductServices();
            this.branchServices = new BranchServices();
            this.AdminName = adminName;
        }
    }
}
