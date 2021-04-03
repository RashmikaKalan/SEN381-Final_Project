using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Subscriptions
    {
        private int iD;
        private string clientID, prodID, version, clientName, prodName;
        private double cost;
        private DateTime date;

        public int ID { get => iD; set => iD = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string ProdID { get => prodID; set => prodID = value; }
        public string Version { get => version; set => version = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime Date { get => date; set => date = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ProdName { get => prodName; set => prodName = value; }

        public Subscriptions()
        {

        }

        public Subscriptions(int iD, string clientID, string prodID, string version, double cost, DateTime date)
        {
            this.ID = iD;
            this.ClientID = clientID;
            this.ProdID = prodID;
            this.Version = version;
            this.Cost = cost;
            this.Date = date;
        }

        public Subscriptions(string clientID, string clientName, string prodName, string version, double cost, DateTime date)
        {
            this.clientID = clientID;
            this.version = version;
            this.ClientName = clientName;
            this.ProdName = prodName;
            this.cost = cost;
            this.date = date;
        }

        public static void AddSub(Subscriptions subscriptions)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.AddSubscription(subscriptions.ClientID, subscriptions.ProdID, subscriptions.Date, subscriptions.Cost, subscriptions.Version);          
        }

        public static List<Subscriptions> GetSubs()
        {
            List<Subscriptions> subscriptions = new List<Subscriptions>();
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            DataTable dt = clientDataHandler.GetSubs();
            foreach (DataRow item in dt.Rows)
            {
                subscriptions.Add(new Subscriptions(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), double.Parse(item[4].ToString()), Convert.ToDateTime(item[5].ToString())));
            }
            return subscriptions;
        }

        public static List<Subscriptions> GetClientSubs(string ID)
        {
            List<Subscriptions> subscriptions = new List<Subscriptions>();
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            DataTable dt = clientDataHandler.GetClientSubs(ID);
            foreach (DataRow item in dt.Rows)
            {
                subscriptions.Add(new Subscriptions(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), double.Parse(item[4].ToString()), Convert.ToDateTime(item[5].ToString())));
            }
            return subscriptions;
        }

        public static void RemoveSub(string ID, string prodID, int subID)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.DeleteSub(ID, prodID, subID);                  
        }

        public static List<Subscriptions> GetSubscriptions()
        {
            DataSet ds = new GeneralDataHandler().GetData("tblSubscriptions");
            List<Subscriptions> subs = new List<Subscriptions>();
            foreach (DataRow item in ds.Tables["tblSubscriptions"].Rows)
            {
                subs.Add(new Subscriptions(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), double.Parse(item[5].ToString()), Convert.ToDateTime(item[4].ToString())));
            }
            return subs;
        }
    }
}
