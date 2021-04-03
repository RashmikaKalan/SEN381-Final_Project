using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client:Person
    {
        private string iDNum, location;
        private string importance;

        public string IDNum { get => iDNum; set => iDNum = value; }
        public string Location { get => location; set => location = value; }
        public string Importance { get => importance; set => importance = value; }

        public Client()
        {

        }

        public Client(string id, string fname, string lname, string IDN, string phone, string email, string loc, string import)
            :base(id, fname, lname, phone, email)
        {
            iDNum = IDN;
            location = loc;
            importance = import;
        }

        public Client(string fname, string lname, string IDN, string phone, string email, string loc, string import)
           : base(fname, lname, phone, email)
        {
            iDNum = IDN;
            location = loc;
            importance = import;
        }

        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            DataSet data = new GeneralDataHandler().GetData("tblClient");
            foreach (DataRow item in data.Tables["tblClient"].Rows)
            {
                clients.Add(new Client(item["ID"].ToString(), item["FirstName"].ToString(), 
                    item["LastName"].ToString(), item["IDNum"].ToString(), item["Phone"].ToString(), 
                    item["Email"].ToString(), item["Location"].ToString(), item["Importance"].ToString()));
            }
            return clients;             
        }

        public static void InsertClient(Client newC)
        {
            ClientDataHandler clientData = new ClientDataHandler();
            clientData.AddClient(newC.ID, newC.FirstName, newC.LastName, newC.iDNum, newC.Phone, newC.Email, newC.location, newC.importance);         
        }

        public static void UpdateClient(Client newC)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.UpdateClient(newC.ID, newC.FirstName, newC.LastName, newC.iDNum, newC.Phone, newC.Email, newC.location, newC.importance);          
        }

        public static void RemoveClient(string ID, string clientID)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.DeleteClient(ID, clientID);  
        }

        public static string GenerateClientID()
        {
            string[] letters = { "A", "B", "C", "D", "E" };
            Random r = new Random();
            int element = r.Next(0, letters.Length);
            string number = r.Next(0, 1000000).ToString();
            string last = number.PadLeft(8, '0');
            string first = letters[element];
            string ID = string.Format("{0}{1}", first, last);
            return ID;
        }
    }
}
