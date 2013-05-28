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
    public partial class cntrlRegistration : UserControl
    {

        #region Variables


        #endregion

        #region Constructor

        public cntrlRegistration()
        {
            InitializeComponent();
        }

        #endregion

        #region Control Level Function

        private void cntrlRegistration_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Properties

        public string PageName
        {
            get 
            {
                return this.lblPageName.Text;
            }
            set 
            {
                this.lblPageName.Text = value;
            }

        }

        #endregion
    }
}
