using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAMP_Forms.Forms;
using DAMP_Forms.Business;
using System.Configuration;
using System.Security.Cryptography;

namespace DAMP_Forms
{
    public partial class Form1 : Form
    {

        #region "Variable Declaration"

        bLogin objbLogin = new bLogin();

        #endregion

        #region "Page Event"

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
                this.AcceptButton = btnLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Button Event"

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;
                SetData();
                if (objbLogin.LoginAuthentication(txtPassword.Text.Trim()))
                {
                    MainFrm frm1 = new MainFrm();
                    this.Hide();
                    frm1.Show();
                }
                else
                {
                    lblMessage.Text = "Login Fail, Please try again!";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Common Function"

        private void SetData()
        {
            try
            {
                objbLogin.user_id = txtUserID.Text.Trim();
                objbLogin.password = txtPassword.Text.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Validation()
        {
            try
            {
                if (txtUserID.Text.Trim() == string.Empty)
                {
                    lblMessage.Text = "Please enter User ID";
                    return false;
                }

                if (txtPassword.Text.Trim() == string.Empty)
                {
                    lblMessage.Text = "Please enter Password";
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        #endregion

    }
}
