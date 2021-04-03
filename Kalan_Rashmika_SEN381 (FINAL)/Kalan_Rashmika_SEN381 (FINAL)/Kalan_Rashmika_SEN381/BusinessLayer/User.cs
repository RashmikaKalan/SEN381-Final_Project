﻿using DBAccess;
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
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid Email Address.");
            }
        } 

        public static bool ValidPhone(string phone)
        {
            if (phone.Length == 10 && phone.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid Phone Number.");
            }     
        }

        public static bool ValidID(string ID)
        {
            if (ID.Length == 13 && ID.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid ID Number");
            }
        }
    }
}
