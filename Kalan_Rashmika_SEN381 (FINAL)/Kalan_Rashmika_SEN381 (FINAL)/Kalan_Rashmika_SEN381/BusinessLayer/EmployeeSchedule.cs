using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeSchedule
    {
        private int bookID;
        private string empName, clientName, location, desc;
        private DateTime date;

        public int BookID { get => bookID; set => bookID = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string Location { get => location; set => location = value; }
        public string Desc { get => desc; set => desc = value; }
        public DateTime Date { get => date; set => date = value; }

        public EmployeeSchedule()
        {

        }

        public EmployeeSchedule(int bookID, string empName, string clientName,string desc, string location, DateTime date)
        {
            this.bookID = bookID;
            this.empName = empName;
            this.clientName = clientName;
            this.location = location;
            this.desc = desc;
            this.date = date;
        }

        public static DataTable GetSchedule(int EID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.EmployeeSchedule(EID);
            return dt;
        }
    }
}
