using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IContract
    {
        List<Contracts> GetContracts();
        string GenerateContractID(string year, string prod, string clientImportance);
        void AddContract(Contracts con);
    }
    public class Contracts : IContract
    {
        private int subID;
        private string iD, clientID;

        public int SubID { get => subID; set => subID = value; }
        public string ID { get => iD; set => iD = value; }
        public string ClientID { get => clientID; set => clientID = value; }

        public Contracts()
        {

        }

        public Contracts(string iD, string clientID, int subID)
        {
            this.subID = subID;
            this.iD = iD;
            this.clientID = clientID;
        }

        public List<Contracts> GetContracts()
        {
            List<Contracts> contracts = new List<Contracts>();
            DataSet ds = new GeneralDataHandler().GetData("tblContract");
            foreach (DataRow item in ds.Tables["tblContract"].Rows)
            {
                contracts.Add(new Contracts(item[0].ToString(), item[1].ToString(), int.Parse(item[2].ToString())));
            }
            return contracts;
        }

        public string GenerateContractID(string year, string prod, string clientImportance)
        {
            Random r = new Random();
            string numbers = r.Next(0, 100000).ToString();
            string digits = numbers.PadLeft(6, '0');
            string contractID = string.Format("{0}{1}{2}{3}", year, prod[1], clientImportance[0], digits);
            return contractID;
        }

        public void AddContract(Contracts con)
        {
            ContractManagementDataHandler dataHandler = new ContractManagementDataHandler();
            dataHandler.AddContract(con.iD, con.clientID, con.subID);
        }
    }
}
