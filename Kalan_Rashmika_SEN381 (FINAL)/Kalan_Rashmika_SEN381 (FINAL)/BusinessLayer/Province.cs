using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Province
    {
        private string prov, city;

        public string Prov { get => prov; set => prov = value; }
        public string City { get => city; set => city = value; }

        public Province()
        {

        }

        public Province(string prov, string city)
        {
            this.prov = prov;
            this.city = city;
        }

        public static List<Province> GetProvinces()
        {
            List<Province> province = new List<Province>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblProvinces");
            foreach (DataRow item in dataSet.Tables["tblProvinces"].Rows)
            {
                province.Add(new Province(item[0].ToString(), item[1].ToString()));
            }
            return province;
        }

        public static List<string> ProvList()
        {
            List<string> provinces = new List<string>();
            provinces.Add("Gauteng");
            provinces.Add("Limpopo");
            provinces.Add("North West");
            provinces.Add("Eastern Cape");
            provinces.Add("Western Cape");
            provinces.Add("Free State");
            provinces.Add("Mpumalanga");
            provinces.Add("KwaZulu Natal");
            return provinces;
        }
    }
}
