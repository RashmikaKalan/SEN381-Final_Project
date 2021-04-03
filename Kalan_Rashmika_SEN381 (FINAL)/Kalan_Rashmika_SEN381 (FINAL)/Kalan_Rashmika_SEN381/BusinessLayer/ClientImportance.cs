using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IImportance
    {
        List<ClientImportance> GetClientImportances();
    }
    public class ClientImportance:IImportance
    {
        private string iD;
        private string importance;

        public string ID { get => iD; set => iD = value; }
        public string Importance { get => importance; set => importance = value; }

        public ClientImportance()
        {

        }

        public ClientImportance(string iD, string importance)
        {
            this.iD = iD;
            this.importance = importance;
        }

        public List<ClientImportance> GetClientImportances()
        {
            List<ClientImportance> clientImportances = new List<ClientImportance>();
            DataSet data = new GeneralDataHandler().GetData("tblClientImportance");
            foreach (DataRow item in data.Tables["tblClientImportance"].Rows)
            {
                clientImportances.Add(new ClientImportance(item[0].ToString(), item[1].ToString()));
            }
            return clientImportances;
        }
    }
}
