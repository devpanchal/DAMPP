using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAMP_Forms.Common
{
    class dbConnection
    {
        SqlConnection SqlConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=DAMP_db;Integrated Security=True;Pooling=False");
        SqlDataAdapter SqlDtAdapter;
        SqlCommand SqlCmd;
        SqlCommandBuilder sqlCmdBuldr;

        public void OpenDataTable(string SQLQuery, out DataTable dtTable)
        {
            dtTable = new DataTable();
            try
            {
                if (SqlConn.State == ConnectionState.Closed)
                {
                    SqlConn.Open();
                }

                SqlDtAdapter = new SqlDataAdapter(SQLQuery, SqlConn);
                SqlDtAdapter.Fill(dtTable);

                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int dbDelete(string SQLQuery)
        {
            try
            {
                int count = 0;
                if (SqlConn.State == ConnectionState.Closed)
                {
                    SqlConn.Open();
                }

                SqlCmd = new SqlCommand(SQLQuery, SqlConn);
                count = SqlCmd.ExecuteNonQuery();

                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDataTable(string SQLQuery, DataTable dtTable)
        {
            try
            {

                if (SqlConn.State == ConnectionState.Closed)
                {
                    SqlConn.Open();
                }

                dtTable.GetChanges();

                SqlDtAdapter = new SqlDataAdapter(SQLQuery, SqlConn);
                sqlCmdBuldr = new SqlCommandBuilder(SqlDtAdapter);

                int rowEffect = SqlDtAdapter.Update(dtTable);

                //dtTable.AcceptChanges();

                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }

                return rowEffect;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
