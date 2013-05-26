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

        private string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private Int64 _contact_no;
        public Int64 contact_no
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

        public bool SaveData()
        {
            try
            {

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
                    this.password = dtTemp.Rows[0]["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool FillDataTable()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
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
