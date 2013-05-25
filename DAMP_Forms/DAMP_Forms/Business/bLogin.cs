using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAMP_Forms.Interface;
using DAMP_Forms.Data;

namespace DAMP_Forms.Business
{
    class bLogin : ILogin
    {
        #region "Properties"

        private string _userid;
        public string userid
        {
            get
            {
                return this._userid;
            }
            set
            {
                this._userid = value;
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

        #endregion

        #region "Function"

        public bool GetData()
        {
            dLogin objdLogin;
            try
            {
                objdLogin = new dLogin();
                objdLogin.GetData();

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







        #endregion
    }
}
