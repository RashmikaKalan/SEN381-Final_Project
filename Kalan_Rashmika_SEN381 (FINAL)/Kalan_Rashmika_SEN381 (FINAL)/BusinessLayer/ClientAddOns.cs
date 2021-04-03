using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ICAdd
    {
        List<ClientAddOns> GetClientAddOns(int subID);
        void InsertAddOns(ClientAddOns cadd);
    }

    public class ClientAddOns:ICAdd
    {
        private int addID, subID, quantity;

        public int AddID { get => addID; set => addID = value; }
        public int SubID { get => subID; set => subID = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public ClientAddOns()
        {

        }

        public ClientAddOns(int addID, int subID, int quantity)
        {
            this.addID = addID;
            this.subID = subID;
            this.quantity = quantity;
        }

        public List<ClientAddOns> GetClientAddOns(int subID)
        {
            List<ClientAddOns> clientAddOns = new List<ClientAddOns>();
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            DataTable data = clientDataHandler.GetSubAddOns(subID);
            foreach (DataRow item in data.Rows)
            {
                clientAddOns.Add(new ClientAddOns(int.Parse(item[0].ToString()), int.Parse(item[1].ToString()), int.Parse(item[2].ToString())));
            }
            return clientAddOns;
        }

        public void InsertAddOns(ClientAddOns cadd)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.InsertAddOns(cadd.addID, cadd.subID, cadd.quantity);
        }

        public override bool Equals(object obj)
        {
            return obj is ClientAddOns ons &&
                   addID == ons.addID &&
                   subID == ons.subID &&
                   quantity == ons.quantity;
        }

        public override int GetHashCode()
        {
            int hashCode = 387586268;
            hashCode = hashCode * -1521134295 + addID.GetHashCode();
            hashCode = hashCode * -1521134295 + subID.GetHashCode();
            hashCode = hashCode * -1521134295 + quantity.GetHashCode();
            return hashCode;
        }
    }
}
