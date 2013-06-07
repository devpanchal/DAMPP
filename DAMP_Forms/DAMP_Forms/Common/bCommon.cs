using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAMP_Forms
{
    public static class bCommon
    {
        public static void ShowButton(UserControl CurrentPage, IEnums.FormMode frmMode)
        {
            try
            {
                Button btnNew = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnNew"];
                Button btnList = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnList"];
                Button btnEdit = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnEdit"];
                Button btnSave = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnSave"];
                Button btnDelete = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnDelete"];
                Button btnClose = (Button)CurrentPage.Controls["flowLayoutPanel1"].Controls["btnClose"];

                if (IEnums.FormMode.None == frmMode)
                {
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnList.Enabled = true;
                    btnSave.Enabled = false;
                    btnClose.Enabled = true;
                }

                if (IEnums.FormMode.Add == frmMode)
                {
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnList.Enabled = true;
                    btnSave.Enabled = true;
                    btnClose.Enabled = true;
                }

                if (IEnums.FormMode.Edit == frmMode)
                {
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnList.Enabled = true;
                    btnSave.Enabled = true;
                    btnClose.Enabled = true;
                }

                if (IEnums.FormMode.View == frmMode)
                {
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnList.Enabled = true;
                    btnSave.Enabled = false;
                    btnClose.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

