using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAMP_Forms.Interface;
using DAMP_Forms.Data;
using System.Data;

namespace DAMP_Forms.Business
{
    class bLogin : ILogin
    {
        #region "Properties"

        private string _user_id;
        public string user_id
        {
            get
            {
                return this._user_id;
            }
            set
            {
                this._user_id = value;
            }
        }

        private string _password;
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        private string _name;
        public string name
        {
            get {return this._name;}
            set {this._name = value;}
        }

        private DateTime _birthday;
        public DateTime birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private byte _gender;
        public byte gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _contact_no;
        public string contact_no
        {
            get { return _contact_no; }
            set { _contact_no = value; }
        }

        private DateTime _creation_date;
        public DateTime creation_date
        {
            get { return _creation_date; }
            set { _creation_date = value; }
        }

        private DateTime _updation_date;
        public DateTime updation_date
        {
            get { return _updation_date; }
            set { _updation_date = value; }
        }

        private DataTable _dtTemp;
        public DataTable dtTemp
        {
            get
            {
                return this._dtTemp;
            }
            set
            {
                this._dtTemp = value;
            }
        }

        #endregion

        #region "Function"

        public bool GetData()
        {
            dLogin objdLogin;
            try
            {
                objdLogin = new dLogin();
                if (objdLogin.GetData(this))
                {
                    FillProperties();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdLogin = null;
            }
        }

        public bool GetLoginList(out DataTable dtLoginList)
        {
            dLogin objdLogin = new dLogin();
            try
            {
                objdLogin.GetLoginList(out dtLoginList);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdLogin = null;
            }
        }

        public bool SaveData()
        {
            try
            {
                dLogin objdLogin = new dLogin();
                FillDataTable();
                objdLogin.SaveData(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool FillProperties()
        {
            try
            {
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    this.user_id = dtTemp.Rows[0]["user_id"].ToString();
                    this.name = dtTemp.Rows[0]["name"].ToString();
                    this.password = dtTemp.Rows[0]["password"].ToString();
                    this.email = dtTemp.Rows[0]["email"].ToString();
                    if (dtTemp.Rows[0]["birthday"] == DBNull.Value)
                    {
                        this.birthday = DateTime.Now;
                    }
                    else
                    {
                        this.birthday = Convert.ToDateTime(dtTemp.Rows[0]["birthday"].ToString());
                    }
                    
                    this.contact_no = dtTemp.Rows[0]["contact_no"].ToString();
                    this.user_id = dtTemp.Rows[0]["user_id"].ToString();
                    if (dtTemp.Rows[0]["gender"] == DBNull.Value)
                    {
                        this.gender = 0;
                    }
                    else
                    {
                        this.gender = Convert.ToByte(dtTemp.Rows[0]["gender"]);
                    }

                    if (dtTemp.Rows[0]["creation_date"] == DBNull.Value)
                    {
                        this.creation_date = DateTime.Now;
                    }
                    else
                    {
                        this.creation_date = Convert.ToDateTime(dtTemp.Rows[0]["creation_date"].ToString());
                    }

                    if (dtTemp.Rows[0]["updation_date"] == DBNull.Value)
                    {
                        this.updation_date = DateTime.Now;
                    }
                    else
                    {
                        this.updation_date = Convert.ToDateTime(dtTemp.Rows[0]["updation_date"].ToString());
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void FillDataTable()
        {
            try
            {
                DataRow dr;
                if (dtTemp.Rows.Count == 0)
                {
                    dr = dtTemp.NewRow();
                    dtTemp.Rows.Add(dr);
                }
                if (dtTemp.Rows[0].RowState == DataRowState.Deleted) return;
                dr = dtTemp.Rows[0];
                dr["user_id"] = this.user_id;
                dr["password"] = this.password;
                dr["name"] = this.name;
                dr["birthday"] = this.birthday;
                dr["email"] = this.email;
                dr["gender"] = this.gender;
                dr["contact_no"] = this.contact_no;
                dr["creation_date"] = this.creation_date;
                dr["updation_date"] = this.updation_date;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LoginAuthentication(string TypPassword)
        {
            dLogin objdLogin;
            try
            {
                objdLogin = new dLogin();
                if (GetData())
                {
                    if (this.password.Equals(TypPassword))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdLogin = null;
            }
            return true;
        }

        #endregion
    }
}
