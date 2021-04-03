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
        public DataSet GetData(string tblName)
        {
            SqlConnection sql = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataSet dataSet = new DataSet();
                using (sql)
                {
                    string qry = string.Format(@"SELECT * FROM {0}", tblName);
                    sql.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, sql);
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
                if (sql.State == ConnectionState.Open)
                {
                    sql.Close();
                }
            }
        }
    }
}
