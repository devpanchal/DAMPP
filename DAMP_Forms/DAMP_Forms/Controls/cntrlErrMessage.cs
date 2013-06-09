using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAMP_Forms
{
    public partial class cntrlErrMessage : UserControl
    {
        public cntrlErrMessage()
        {
            InitializeComponent();
        }

        public void ShowErrorMsg(string strErrMsg)
        {
            try
            {
                lblValidation.ForeColor = Color.Red;
                lblValidation.Text = strErrMsg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowMsg(string strMsg)
        {
            try
            {
                lblValidation.ForeColor = Color.Green;
                lblValidation.Text = strMsg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ClearMsg()
        {
            try
            {
                lblValidation.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
