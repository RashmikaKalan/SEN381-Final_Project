using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IProduct
    {
        List<Product> GetProducts();
        void InsertProduct(Product product);
        void UpdateExistingProduct(Product product);
        void RemoveProduct(string ID);
    }
    public class Product: IProduct
    {
        private string prodID, name, desc, version;
        private double cost;
        private DateTime verDate;
        private int manID;

        public string ProdID { get => prodID; set => prodID = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Version { get => version; set => version = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime VerDate { get => verDate; set => verDate = value; }
        public int ManID { get => manID; set => manID = value; }

        public Product()
        {

        }

        public Product(string prodID, string name, string desc, string version, double cost, DateTime verDate, int manID)
        {
            this.prodID = prodID;
            this.name = name;
            this.desc = desc;
            this.version = version;
            this.cost = cost;
            this.verDate = verDate;
            this.manID = manID;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            DataSet dataSet = new GeneralDataHandler().GetData("tblProduct");
            foreach (DataRow item in dataSet.Tables["tblProduct"].Rows)
            {
                products.Add(new Product(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[4].ToString(), double.Parse(item[3].ToString()), Convert.ToDateTime(item[5].ToString()), int.Parse(item[6].ToString())));
            }
            return products;
        }

        public void InsertProduct(Product product)
        {
            ProductDataHandler productDataHandler = new ProductDataHandler();
            productDataHandler.AddProduct(product.ProdID, product.name, product.desc, product.cost, product.version, product.verDate, product.manID);                   
        }

        public void UpdateExistingProduct(Product product)
        {
            ProductDataHandler productDataHandler = new ProductDataHandler();
            productDataHandler.UpdateProduct(product.ProdID, product.name, product.desc, product.cost, product.version, product.verDate, product.manID);                 
        }

        public void RemoveProduct(string ID)
        {
            ProductDataHandler productDataHandler = new ProductDataHandler();
            productDataHandler.DeleteProduct(ID);
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   ProdID == product.ProdID &&
                   Name == product.Name &&
                   Desc == product.Desc &&
                   Version == product.Version &&
                   Cost == product.Cost &&
                   VerDate == product.VerDate &&
                   ManID == product.ManID;
        }

        public override int GetHashCode()
        {
            int hashCode = 1576273166;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProdID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Desc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Version);
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            hashCode = hashCode * -1521134295 + VerDate.GetHashCode();
            hashCode = hashCode * -1521134295 + ManID.GetHashCode();
            return hashCode;
        }
    }
}
