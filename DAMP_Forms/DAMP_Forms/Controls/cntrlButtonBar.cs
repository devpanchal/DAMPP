﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAMP_Forms
{
    public partial class cntrlButtonBar : UserControl
    {
        #region "Variable declaration"

        public delegate void btnCloseClickHandler(object sender, EventArgs e);
        public event btnCloseClickHandler btnCloseClick;

        public delegate void btnSaveClickHandler(object sender, EventArgs e);
        public event btnSaveClickHandler btnSaveClick;

        public delegate void btnEditClickHandler(object sender, EventArgs e);
        public event btnEditClickHandler btnEditClick;

        public delegate void btnNewClickHandler(object sender, EventArgs e);
        public event btnNewClickHandler btnNewClick;

        public delegate void btnListClickHandler(object sender, EventArgs e);
        public event btnListClickHandler btnListClick;

        public delegate void btnDeleteClickHandler(object sender, EventArgs e);
        public event btnDeleteClickHandler btnDeleteClick;

        #endregion

        #region "Page Level Function"

        public cntrlButtonBar()
        {
            InitializeComponent();
        }

        #endregion

        #region "Button Click Event"

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnCloseClick != null)
            {
                btnCloseClick(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSaveClick != null)
            {
                btnSaveClick(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEditClick != null)
            {
                btnEditClick(sender, e);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNewClick != null)
            {
                btnNewClick(sender, e);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (btnListClick != null)
            {
                btnListClick(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDeleteClick != null)
            {
                btnDeleteClick(sender, e);
            }
        }

        #endregion

        #region "Properties"

        public bool VisibleDeleteBtn
        {
            get
            {
                return this.btnDelete.Visible;
            }
            set
            {
                this.btnDelete.Visible = value;
            }
        }

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

        public bool VisibleCloseBtn
        {
            get
            {
                return this.btnClose.Visible;
            }
            set
            {
                this.btnClose.Visible = value;
            }
        }

        public bool VisibleEditBtn
        {
            get
            {
                return this.btnEdit.Visible;
            }
            set
            {
                this.btnEdit.Visible = value;
            }
        }

        public bool VisibleSaveBtn
        {
            get
            {
                return this.btnSave.Visible;
            }
            set
            {
                this.btnSave.Visible = value;
            }
        }

        public bool VisibleNewBtn
        {
            get
            {
                return this.btnNew.Visible;
            }
            set
            {
                this.btnNew.Visible = value;
            }
        }

        public bool VisibleListBtn
        {
            get
            {
                return this.btnList.Visible;
            }
            set
            {
                this.btnList.Visible = value;
            }
        }

        public string SetPageTitle
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
