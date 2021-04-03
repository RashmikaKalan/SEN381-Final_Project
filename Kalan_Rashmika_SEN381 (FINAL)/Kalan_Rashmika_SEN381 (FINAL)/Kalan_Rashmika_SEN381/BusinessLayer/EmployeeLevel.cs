using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{ 
    public interface IEmpLevel
    {
        List<EmployeeLevel> GetEmployeeLevels();
    }
    public class EmployeeLevel:IEmpLevel
    {
        private int empLevel;
        private string role;

        public int EmpLevel { get => empLevel; set => empLevel = value; }
        public string Role { get => role; set => role = value; }

        public EmployeeLevel()
        {

        }
        public EmployeeLevel(int empLevel, string role)
        {
            this.empLevel = empLevel;
            this.role = role;
        }

        public List<EmployeeLevel> GetEmployeeLevels()
        {
            List<EmployeeLevel> levels = new List<EmployeeLevel>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblEmpLevel");
            foreach (DataRow item in dataSet.Tables["tblEmpLevel"].Rows)
            {
                levels.Add(new EmployeeLevel(int.Parse(item[0].ToString()), item[1].ToString()));
            }
            return levels;            
        }
    }
}
