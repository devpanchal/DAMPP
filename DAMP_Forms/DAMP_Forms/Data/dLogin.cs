using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAMP_Forms.Interface;
using System.Data.SqlClient;
using System.Data;
using DAMP_Forms.Common;

namespace DAMP_Forms.Data
{
    
    class dLogin : dbConnection
    {
        string strSQL = "select * from D_login_table";

        public bool GetData(ILogin objILogin)
        {
            try
            {
                DataTable dttemp = new DataTable();
                strSQL = strSQL + " where user_id = '" + objILogin.user_id + "'";
                OpenDataTable(strSQL, out dttemp);
                objILogin.dtTemp = dttemp;
                if (dttemp != null && dttemp.Rows.Count > 0)
                {
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
        }

        public bool GetLoginList(out DataTable dtLoginList)
        {
            try
            {
                dtLoginList = new DataTable();
                OpenDataTable(strSQL, out dtLoginList);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveData(ILogin objILogin)
        {
            try
            {
                UpdateDataTable(strSQL, objILogin.dtTemp);   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
