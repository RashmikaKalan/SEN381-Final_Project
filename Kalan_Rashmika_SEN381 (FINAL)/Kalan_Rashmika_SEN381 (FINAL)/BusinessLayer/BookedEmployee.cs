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
        List<BookedEmployee> GetAppDate(DateTime date);
        List<BookedEmployee> GetAppID(int ID);
        List<BookedEmployee> GetCApps(string ID);
        int CompareTo(BookedEmployee other);
        bool Equals(object obj);
        int GetHashCode();
    }
    public class BookedEmployee : IComparable<BookedEmployee>, IBook
    {
        private int bookID, empID, priority;
        private string desc, clientID, empName, clientName;
        private DateTime date;

        public int BookID { get => bookID; set => bookID = value; }
        public int EmpID { get => empID; set => empID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Desc { get => desc; set => desc = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Priority { get => priority; set => priority = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string ClientName { get => clientName; set => clientName = value; }

        public BookedEmployee()
        {

        }

        public BookedEmployee(int bookID, int empID, string clientID, string desc, DateTime date, int priority)
        {
            this.bookID = bookID;
            this.empID = empID;
            this.clientID = clientID;
            this.desc = desc;
            this.date = date;
            this.priority = priority;
        }

        public BookedEmployee(int bookID, string empName, string clientName, string desc, DateTime date, int priority)
        {
            this.bookID = bookID;
            this.empName = empName;
            this.clientName = clientName;
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
                    bookedEmployees.Add(new BookedEmployee(int.Parse(item[0].ToString()), int.Parse(item[1].ToString()), item[2].ToString(), item[3].ToString(), Convert.ToDateTime(item[4].ToString()), int.Parse(item[5].ToString())));
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
       
        public List<BookedEmployee> GetCApps(string ID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetClientApps(ID);
            List<BookedEmployee> books = new List<BookedEmployee>();
            foreach (DataRow item in dt.Rows)
            {
                books.Add(new BookedEmployee(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), Convert.ToDateTime(item[4].ToString()), int.Parse(item[5].ToString())));
            }
            return books;          
        }

       public List<BookedEmployee> GetAppID(int ID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetAppsID(ID);
            List<BookedEmployee> books = new List<BookedEmployee>();
            foreach (DataRow item in dt.Rows)
            {
                books.Add(new BookedEmployee(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), Convert.ToDateTime(item[4].ToString()), int.Parse(item[5].ToString())));
            }
            return books;
        }

        public List<BookedEmployee> GetAppDate(DateTime date)
        {

            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetAppsDate(date);
            List<BookedEmployee> books = new List<BookedEmployee>();
            foreach (DataRow item in dt.Rows)
            {
                books.Add(new BookedEmployee(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), Convert.ToDateTime(item[4].ToString()), int.Parse(item[5].ToString())));
            }
            return books;
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

        public int CompareTo(BookedEmployee other)
        {
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }

        public override string ToString()
        {
            return string.Format("Appointment ID: {0}\nEmployee ID: {1}\nClient ID: {2}\nDescription: {3}\nDate: {4}\n\n", bookID, empID, clientID, desc, date);
        }

        public override bool Equals(object obj)
        {
            return obj is BookedEmployee employee &&
                   BookID == employee.BookID &&
                   EmpID == employee.EmpID &&
                   ClientID == employee.ClientID &&
                   Desc == employee.Desc &&
                   Date == employee.Date &&
                   Priority == employee.Priority &&
                   EmpName == employee.EmpName &&
                   ClientName == employee.ClientName;
        }

        public override int GetHashCode()
        {
            int hashCode = 1517642133;
            hashCode = hashCode * -1521134295 + BookID.GetHashCode();
            hashCode = hashCode * -1521134295 + EmpID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Desc);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + Priority.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmpName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            return hashCode;
        }
    }
}
