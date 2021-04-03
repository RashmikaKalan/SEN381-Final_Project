using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        private string username, password;
        private int empLevel, iD;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int EmpLevel { get => empLevel; set => empLevel = value; }
        public int ID { get => iD; set => iD = value; }

        public User()
        {

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, int empLevel, int iD) : this(username, password)
        {
            this.empLevel = empLevel;
            this.iD = iD;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblEmployee");
            foreach (DataRow item in dataSet.Tables["tblEmployee"].Rows)
            {
                users.Add(new User(item[6].ToString(), item[7].ToString(), int.Parse(item[5].ToString()), int.Parse(item[0].ToString())));
            }
            return users;            
        }

        public static void AddUser(Employee em, User nUser)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            techSupportDataHandler.AddEmployee(em.FirstName, em.LastName, em.Phone, em.Email, em.Level, nUser.username, nUser.password);     
        }

        public static bool ValidEmail(string email)
        {
            bool result = (email.Contains("@")) ? true : throw new Exception("Invalid Email Address");
            return result;
        } 

        public static bool ValidPhone(string phone)
        {
            bool result = (phone.Length == 10 && phone.All(char.IsDigit)) ? true : throw new Exception("Invalid Phone Number");
            return result;    
        }

        public static bool ValidID(string ID)
        {
            bool result= (ID.Length == 13 && ID.All(char.IsDigit))?true: throw new Exception("Invalid ID Number");
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username &&
                   Password == user.Password &&
                   EmpLevel == user.EmpLevel &&
                   ID == user.ID;
        }

        public override int GetHashCode()
        {
            int hashCode = 1486084366;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EmpLevel.GetHashCode();
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            return hashCode;
        }
    }
}
