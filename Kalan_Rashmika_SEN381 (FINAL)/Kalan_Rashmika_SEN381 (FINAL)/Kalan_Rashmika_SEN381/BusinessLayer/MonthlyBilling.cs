using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBill
    {
        List<MonthlyBilling> GetMonthlyBillings();
        List<MonthlyBilling> GetClientBills(string ID);
        void NewBill(MonthlyBilling monthlyBilling);
    }
    public class MonthlyBilling : IBill
    {
        private int invID, subID;
        private string month, clientID;
        private double amount;
        private DateTime date;
        private string firstName, lastName;

        public int InvID { get => invID; set => invID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Month { get => month; set => month = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public int SubID { get => subID; set => subID = value; }

        public MonthlyBilling()
        {

        }

        public MonthlyBilling(int invID,string clientID, string month, double amount, DateTime date, int subID)
        {
            this.invID = invID;
            this.subID = subID;
            this.month = month;
            this.clientID = clientID;
            this.amount = amount;
            this.date = date;
        }

        public MonthlyBilling(int invID, string clientID, string firstName, string lastName, string month, double amount, DateTime date, int subID)
        {
            this.invID = invID;
            this.clientID = clientID;
            this.month = month;
            this.amount = amount;
            this.date = date;
            this.firstName = firstName;
            this.lastName = lastName;
            this.subID = subID;
        }

        public MonthlyBilling(int invID, string month, DateTime date, double amount)
        {
            this.invID = invID;
            this.month = month;
            this.date = date;
            this.amount = amount;
        }

        public List<MonthlyBilling> GetMonthlyBillings()
        {
            List<MonthlyBilling> monthlyBillings = new List<MonthlyBilling>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblMonthlyBill");
            foreach (DataRow item in dataSet.Tables["tblMonthlyBill"].Rows)
            {
                monthlyBillings.Add(new MonthlyBilling(int.Parse(item[0].ToString()), item[1].ToString(), item[3].ToString(), double.Parse(item[4].ToString()), Convert.ToDateTime(item[2].ToString()), int.Parse(item[5].ToString())));
            }
            return monthlyBillings;           
        }

        public List<MonthlyBilling> GetClientBills(string ID)
        {
            List<MonthlyBilling> monthlyBillings = new List<MonthlyBilling>();
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            DataTable dt = clientDataHandler.GetClientBills(ID);
            foreach (DataRow item in dt.Rows)
            {
                monthlyBillings.Add(new MonthlyBilling(int.Parse(item[0].ToString()), item[1].ToString(), Convert.ToDateTime(item[2].ToString()), double.Parse(item[3].ToString())));
            }
            return monthlyBillings;             
        }

        public void NewBill(MonthlyBilling monthlyBilling)
        {
            ClientDataHandler clientDataHandler = new ClientDataHandler();
            clientDataHandler.GenerateNewBill(monthlyBilling.clientID, monthlyBilling.date, monthlyBilling.month, monthlyBilling.amount, monthlyBilling.subID);   
        }
    }
}
