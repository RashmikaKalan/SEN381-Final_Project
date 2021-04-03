using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class GeneralDataHandler
    {
        SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
        public GeneralDataHandler()
        {
            conn.DataSource = @"LAPTOP-J27F0985";
            conn.InitialCatalog = "Kalan_Rashmika_SEN381_Project";
            conn.IntegratedSecurity = true;
        }

        public DataSet GetData(string tblName)
        {
            SqlConnection connect = new SqlConnection(conn.ToString());
            try
            {
                DataSet dataSet = new DataSet();
                using (connect)
                {
                    string qry = string.Format(@"SELECT * FROM {0}", tblName);
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, connect);
                    adapter.FillSchema(dataSet, SchemaType.Source, tblName);
                    adapter.Fill(dataSet, tblName);
                }
                return dataSet;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}
