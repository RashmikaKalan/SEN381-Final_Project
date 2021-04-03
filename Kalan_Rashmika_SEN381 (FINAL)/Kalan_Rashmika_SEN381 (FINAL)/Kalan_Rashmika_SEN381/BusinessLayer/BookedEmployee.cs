using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBook
    {
        List<BookedEmployee> GetBookedEmployees();
        void InsertApp(BookedEmployee booked);
        void UpdateExistingApp(BookedEmployee booked);
        void RemoveApp(int ID);
        List<string> Type();
        List<string> Priorities();
    }
    public class BookedEmployee : IBook
    {
        private int bookID, empID;
        private string desc, priority, clientID;
        private DateTime date;

        public int BookID { get => bookID; set => bookID = value; }
        public int EmpID { get => empID; set => empID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Desc { get => desc; set => desc = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Priority { get => priority; set => priority = value; }

        public BookedEmployee()
        {

        }

        public BookedEmployee(int bookID, int empID, string clientID, string desc, DateTime date, string priority)
        {
            this.bookID = bookID;
            this.empID = empID;
            this.clientID = clientID;
            this.desc = desc;
            this.date = date;
            this.priority = priority;
        }

        public List<BookedEmployee> GetBookedEmployees()
        {
            try
            {
                List<BookedEmployee> bookedEmployees = new List<BookedEmployee>();
                DataSet dataSet = new GeneralDataHandler().GetData("tblEmpBooking");
                foreach (DataRow item in dataSet.Tables["tblEmpBooking"].Rows)
                {
                    bookedEmployees.Add(new BookedEmployee(int.Parse(item[0].ToString()), int.Parse(item[1].ToString()), item[2].ToString(), item[3].ToString(), Convert.ToDateTime(item[4].ToString()), item[5].ToString()));
                }
                return bookedEmployees;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Business Layer Error: {0}", ex));
            }
        }

        public void InsertApp(BookedEmployee booked)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            techSupportDataHandler.AddAppointment(booked.bookID, booked.empID, booked.clientID, booked.desc, booked.date, booked.priority);      
        }

        public void UpdateExistingApp(BookedEmployee booked)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            techSupportDataHandler.UpdateAppointment(booked.bookID, booked.empID, booked.clientID, booked.desc, booked.date, booked.priority);
     
        }

        public void RemoveApp(int ID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            techSupportDataHandler.DeleteAppointment(ID);
        }
       
        public DataTable GetCApps(string ID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetClientApps(ID);
            return dt;          
        }

       public DataTable GetAppID(int ID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetAppsID(ID);
            return dt;           
        }

        public DataTable GetAppDate(DateTime date)
        {

            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetAppsDate(date);
            return dt;                
        }

        public List<string> Type()
        {
            List<string> type = new List<string>();
            type.Add("Upgrade");
            type.Add("Maintance");
            type.Add("Other");
            return type;           
        }

        public List<string> Priorities()
        {
            List<string> priorities = new List<string>();
            priorities.Add("High");
            priorities.Add("Medium");
            priorities.Add("Low");
            return priorities;            
        }
    }
}
