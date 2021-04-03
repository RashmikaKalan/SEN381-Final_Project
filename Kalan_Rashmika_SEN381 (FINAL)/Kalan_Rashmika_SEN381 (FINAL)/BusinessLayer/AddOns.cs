using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IAdd
    {
        List<AddOns> GetAddOns();
        bool Equals(object obj);
        int GetHashCode();
    }
    public class AddOns : IAdd
    {
        private int iD;
        private string name, desc;
        private double cost;
        private int manID;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public double Cost { get => cost; set => cost = value; }
        public int ManID { get => manID; set => manID = value; }

        public AddOns()
        {

        }

        public AddOns(int iD, string name, string desc, double cost, int manID)
        {
            this.iD = iD;
            this.name = name;
            this.desc = desc;
            this.cost = cost;
            this.manID = manID;
        }

        public List<AddOns> GetAddOns()
        {
            DataSet dataSet = new GeneralDataHandler().GetData("tblAddOn");
            List<AddOns> addOns = new List<AddOns>();
            foreach (DataRow item in dataSet.Tables["tblAddOn"].Rows)
            {
                addOns.Add(new AddOns(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), double.Parse(item[3].ToString()), int.Parse(item[4].ToString())));
            }
            return addOns;
        }

        public override bool Equals(object obj)
        {
            return obj is AddOns ons &&
                   ID == ons.ID &&
                   Name == ons.Name &&
                   Desc == ons.Desc &&
                   Cost == ons.Cost &&
                   ManID == ons.ManID;
        }

        public override int GetHashCode()
        {
            int hashCode = 85182416;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Desc);
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            hashCode = hashCode * -1521134295 + ManID.GetHashCode();
            return hashCode;
        }
    }
}
