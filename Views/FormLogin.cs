using Start_Up_Group.Entities;
using Start_Up_Group.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Start_Up_Group
{
    public partial class frmLogin : Form
    {
        private IAdminServices adminServices;
        public frmLogin()
        {
            
            InitializeComponent();
            this.adminServices = new AdminServices();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var InputedUsername = txtUsername.Text.ToString();
            var InputedPassword = txtPassword.Text.ToString();
            try
            {
               var Result = this.adminServices.GetAdmin(InputedUsername, InputedPassword);
                
                if(Result != null)
                {
                 frmDaskboard formDashboard = new frmDaskboard();
                 this.Hide();
                 formDashboard.SetLoggedInAdmin(Result.Username,Result.Name,Result.Position);
                 formDashboard.Show();
                }
                else
                {
                    Debug.WriteLine("this line run");
                    MessageBox.Show("Username or Password is not correct","Please Again",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPassword.Text = "";
                }

            }
            catch(Exception err)
            {
                Debug.WriteLine(err);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
