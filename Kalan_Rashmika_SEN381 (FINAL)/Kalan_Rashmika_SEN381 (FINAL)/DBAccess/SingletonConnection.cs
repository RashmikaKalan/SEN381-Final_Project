using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class SingletonConnection
    {
        private static string connectionString = @"Data Source= LAPTOP-J27F0985; Initial Catalog=Kalan_Rashmika_SEN381_Project; Integrated Security= true";
        private static SingletonConnection singleton;
        private static SqlConnection sqlConnection;

        public SqlConnection SqlConnectionFactory
        {
            get { return sqlConnection; }
        }

        private SingletonConnection() { }

        public static SingletonConnection Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new SingletonConnection();

                sqlConnection = new SqlConnection(connectionString);
                return singleton;
            }
        }
            
    }
}