using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employee:Person
    {
        private int level;

        public int Level { get => level; set => level = value; }

        public Employee()
        {

        }

        public Employee(string id, string fname, string lname, string phn, string email, int lev)
            :base(id, fname, lname, phn, email)
        {
            level = lev;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblEmployee");
            foreach (DataRow item in dataSet.Tables["tblEmployee"].Rows)
            {
                employees.Add(new Employee(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), int.Parse(item[5].ToString())));
            }
            return employees;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                   Phone == employee.Phone &&
                   Email == employee.Email &&
                   ID == employee.ID &&
                   Level == employee.Level;
        }

        public override int GetHashCode()
        {
            int hashCode = -185533881;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + Level.GetHashCode();
            return hashCode;
        }
    }
}
