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
                if (dttemp != null && dttemp.Rows.Count > 0)
                {
                    objILogin.dtTemp = dttemp;
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
    }
}
