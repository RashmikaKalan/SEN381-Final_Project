using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IMan
    {
        List<Manufacturer> GetManufacturers();
    }
    public class Manufacturer:IMan
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public Manufacturer()
        {

        }

        public Manufacturer(int iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            DataSet ds = new GeneralDataHandler().GetData("tblManufacturer");
            foreach (DataRow item in ds.Tables["tblManufacturer"].Rows)
            {
                manufacturers.Add(new Manufacturer(int.Parse(item[0].ToString()), item[1].ToString()));
            }
            return manufacturers;
        }
    }
}
