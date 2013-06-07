using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAMP_Forms.Business;
using DAMP_Forms.Class;

namespace DAMP_Forms
{
    public partial class cntrlRegistration : UserControl
    {

        #region "Variables"

        IEnums.FormMode frmMode;
        private bLogin objbLogin = new bLogin();

        #endregion

        #region "Page Level Event"

        public cntrlRegistration()
        {
            InitializeComponent();
        }

        private void cntrlRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
                FillInitalizedata();
                frmMode = IEnums.FormMode.View;
                EDState(frmMode);
                txtUserID.Text = DAMPGlobalVar.LoginUserID;
                txtUserID_Leave(null, null);
                lblErrMsg.ClearMsg();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Common Function"

        private void FillInitalizedata()
        {
            try
            {
               
                DataTable dtGender = new DataTable();
                dtGender.Columns.Add("Key", typeof(int));
                dtGender.Columns.Add("Value", typeof(string));

                dtGender.Rows.Add(0, "Male");
                dtGender.Rows.Add(1, "Female");

                cboGender.DataSource = dtGender;
                cboGender.DisplayMember = "Value";
                cboGender.ValueMember = "Key";

                cboGender.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitalizeData()
        {
            try
            {
                objbLogin.user_id = string.Empty;
                objbLogin.name = string.Empty;
                objbLogin.password = string.Empty;
                objbLogin.email = string.Empty;
                objbLogin.gender = 0;
                objbLogin.birthday = DateTime.Now;
                objbLogin.contact_no = string.Empty;
                objbLogin.creation_date = DateTime.Now;
                objbLogin.updation_date = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearFormDetail()
        {
            try
            {
                txtUserID.Text = string.Empty;
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtRePassword.Text = string.Empty;
                txtEmailID.Text = string.Empty;
                cboGender.SelectedIndex = 0;
                dtpBirthday.Text = string.Empty;
                txtContactNo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetData()
        {
            try
            {
                objbLogin.user_id = txtUserID.Text.Trim();
                objbLogin.name = txtUserName.Text.Trim();
                objbLogin.password = txtPassword.Text.Trim();
                objbLogin.email = txtEmailID.Text.Trim();
                objbLogin.birthday = Convert.ToDateTime(dtpBirthday.Text.Trim());
                objbLogin.contact_no = txtContactNo.Text.Trim();
                objbLogin.gender = Convert.ToByte(cboGender.SelectedValue.ToString());
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FillFormDetail()
        {
            try
            {
                txtUserID.Text = objbLogin.user_id;
                txtUserName.Text = objbLogin.name;
                txtPassword.Text = objbLogin.password;
                txtRePassword.Text = objbLogin.password;
                txtEmailID.Text = objbLogin.email;
                if (objbLogin.birthday == DateTime.MinValue)
                {
                    dtpBirthday.Text = DateTime.Now.ToString();
                }
                else
                {
                    dtpBirthday.Text = objbLogin.birthday.ToString();
                }
                txtContactNo.Text = objbLogin.contact_no;
                cboGender.SelectedValue = objbLogin.gender;
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
                    lblErrMsg.ShowErrorMsg("Please enter User ID");
                    txtUserID.Focus();
                    return false;
                }

                if (txtUserName.Text.Trim() == string.Empty)
                {
                    lblErrMsg.ShowErrorMsg("Please enter User Name");
                    txtUserName.Focus();
                    return false;
                }

                if (txtPassword.Text.Trim() == string.Empty)
                {
                    lblErrMsg.ShowErrorMsg("Please enter Password");
                    txtPassword.Focus();
                    return false;
                }

                if (txtPassword.Text.Trim().Length < 5)
                {
                    lblErrMsg.ShowErrorMsg("Minimum lenght of Password is 5");
                    txtPassword.Focus();
                    return false;
                }

                if (txtRePassword.Text.Trim() == string.Empty)
                {
                    lblErrMsg.ShowErrorMsg("Please enter Re-Password");
                    txtRePassword.Focus();
                    return false;
                }

                if (!txtPassword.Text.Trim().Equals(txtRePassword.Text.Trim()))
                {
                    lblErrMsg.ShowErrorMsg("Password is not match");
                    txtRePassword.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FillGrid()
        {
            try
            {
                DataTable dtLoginList;
                objbLogin.GetLoginList(out dtLoginList);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtLoginList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EnblDsblControls(Control con, bool EnblDsblFlag)
        {
            foreach (Control c in con.Controls)
            {
                EnblDsblControls(c, EnblDsblFlag);
            }
            con.Enabled = EnblDsblFlag;
        }

        private void EDState(IEnums.FormMode frmMode)
        {
            try
            {
                //bCommon objbCommon = new bCommon();
                //objbCommon.ShowButton(cntrlButtonBar1, frmMode);

                bCommon.ShowButton(cntrlButtonBar1, frmMode);

                if (IEnums.FormMode.None == frmMode)
                {
                    EnblDsblControls(tableLayoutPanel1, false);
                    EnblDsblControls(tableLayoutPanel3, false);
                }
                else if (IEnums.FormMode.View == frmMode)
                {
                    EnblDsblControls(tableLayoutPanel1, false);
                    EnblDsblControls(tableLayoutPanel3, true);
                }
                else if (IEnums.FormMode.Edit == frmMode)
                {
                    EnblDsblControls(tableLayoutPanel1, true);
                    EnblDsblControls(tableLayoutPanel3, false);
                }
                else if (IEnums.FormMode.Add == frmMode)
                {
                    EnblDsblControls(tableLayoutPanel1, true);
                    EnblDsblControls(tableLayoutPanel3, true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Control Click Event"

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Trim() != string.Empty)
                {
                    objbLogin.user_id = txtUserID.Text.Trim();
                    if (objbLogin.GetData())
                    {

                        ClearFormDetail();
                        FillFormDetail();
                        frmMode = IEnums.FormMode.View;
                        EDState(frmMode);
                    }
                    else
                    {
                        if (frmMode != IEnums.FormMode.Add)
                        {
                            ClearFormDetail();
                            frmMode = IEnums.FormMode.View;
                            EDState(frmMode);
                            lblErrMsg.ShowErrorMsg("User ID is not exiest");
                        }
                    }
                }
                else
                {
                    if (frmMode != IEnums.FormMode.Add)
                    {
                        ClearFormDetail();
                        txtUserID.Focus();
                        frmMode = IEnums.FormMode.View;
                        EDState(frmMode);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strUserid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUserID.Text = strUserid;
                txtUserID_Leave(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Button Event"

        private void cntrlButtonBar1_btnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                InitalizeData();
                SetData();
                objbLogin.SaveData();
                FillGrid();
                frmMode = IEnums.FormMode.View;
                EDState(frmMode);
                lblErrMsg.ShowMsg(DAMPGlobalVar.SaveSuccessFully);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cntrlButtonBar1_btnNewClick(object sender, EventArgs e)
        {
            try
            {
                objbLogin.user_id = string.Empty;
                objbLogin.GetData();
                ClearFormDetail();
                txtUserID.Focus();
                frmMode = IEnums.FormMode.Add;
                EDState(frmMode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cntrlButtonBar1_btnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Trim() != string.Empty)
                {
                    objbLogin.user_id = txtUserID.Text.Trim();
                    objbLogin.GetData();

                    objbLogin.dtTemp.Rows[0].Delete();
                    objbLogin.SaveData();
                    ClearFormDetail();
                    FillGrid();
                    frmMode = IEnums.FormMode.View;
                    EDState(frmMode);
                    lblErrMsg.ShowMsg(DAMPGlobalVar.DeleteSuccessFully);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cntrlButtonBar1_btnCloseClick(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cntrlButtonBar2_btnEditClick(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Trim() != string.Empty)
                {
                    objbLogin.user_id = txtUserID.Text.Trim();
                    if (objbLogin.GetData())
                    {

                        ClearFormDetail();
                        FillFormDetail();
                        frmMode = IEnums.FormMode.Edit;
                        EDState(frmMode);
                    }
                    else
                    {
                        ClearFormDetail();
                        frmMode = IEnums.FormMode.View;
                        EDState(frmMode);
                        lblErrMsg.ShowErrorMsg("User ID is not exiest");
                    }
                }
                else
                {
                    ClearFormDetail();
                    txtUserID.Focus();
                    frmMode = IEnums.FormMode.View;
                    EDState(frmMode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
