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
        private string clientName, location, desc, priority;
        private DateTime date;

        public int BookID { get => bookID; set => bookID = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string Location { get => location; set => location = value; }
        public string Desc { get => desc; set => desc = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Priority { get => priority; set => priority = value; }

        public EmployeeSchedule()
        {

        }

        public EmployeeSchedule(int bookID, string clientName, string desc, DateTime date, string location, string priority)
        {
            this.bookID = bookID;
            this.clientName = clientName;
            this.desc = desc;
            this.date = date;
            this.location = location;
            this.priority = priority;
        }

        public static List<EmployeeSchedule> GetSchedule(int EID)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.EmployeeSchedule(EID);
            List<EmployeeSchedule> employeeSchedules = new List<EmployeeSchedule>();
            foreach (DataRow item in dt.Rows)
            {
                employeeSchedules.Add(new EmployeeSchedule(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), Convert.ToDateTime(item[3].ToString()), item[4].ToString(), item[5].ToString()));
            }
            return employeeSchedules;
        }

        public override bool Equals(object obj)
        {
            return obj is EmployeeSchedule schedule &&
                   BookID == schedule.BookID &&
                   ClientName == schedule.ClientName &&
                   Location == schedule.Location &&
                   Desc == schedule.Desc &&
                   Date == schedule.Date &&
                   Priority == schedule.Priority;
        }

        public override int GetHashCode()
        {
            int hashCode = -1535387158;
            hashCode = hashCode * -1521134295 + BookID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Desc);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Priority);
            return hashCode;
        }
    }
}
