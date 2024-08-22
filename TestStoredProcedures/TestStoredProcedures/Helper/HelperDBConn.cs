using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStoredProcedures.Helper
{
    public class HelperDBConn
    {
        private SqlConnection SqlConn { get; set; }

        public HelperDBConn()
        {
            SqlConn = new SqlConnection("Server=localhost;Database=TestCar20240815;Trusted_Connection=True;");
        }

        public void ExecuteQuery(string sqlCmd)
        {
            try
            {
                ConnectDB();

                SqlCommand c = new SqlCommand(sqlCmd, SqlConn);
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform ExecuteQuery fail.", ex);
            }
            DisconnectDB();
        }

        public DataTable GetDataTable(string sqlCmd)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlCmd, SqlConn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return dt;
        }

        public SqlConnection GetSqlConn()
        {
            return this.SqlConn;
        }

        private void ConnectDB()
        {
            try
            {
                SqlConn.Open();
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform ConnectDB fail.", ex);
            }
        }

        private void DisconnectDB()
        {
            try
            {
                if (SqlConn != null)
                {
                    SqlConn.Close();
                }
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform DisconnectDB fail.", ex);
            }
        }
    }
}

