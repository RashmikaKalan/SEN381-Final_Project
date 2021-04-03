using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ITerms
    {
        List<ProductTerms> GetProductTerms();
    }
    public class ProductTerms:ITerms
    {
        private string prodID, upgrade, preMaintanance, correctiveMaintanance;

        public string ProdID { get => prodID; set => prodID = value; }
        public string Upgrade { get => upgrade; set => upgrade = value; }
        public string PreMaintanance { get => preMaintanance; set => preMaintanance = value; }
        public string CorrectiveMaintanance { get => correctiveMaintanance; set => correctiveMaintanance = value; }

        public ProductTerms()
        {

        }

        public ProductTerms(string prodID, string upgrade, string preMaintanance, string correctiveMaintanance)
        {
            this.prodID = prodID;
            this.upgrade = upgrade;
            this.preMaintanance = preMaintanance;
            this.correctiveMaintanance = correctiveMaintanance;
        }

        public List<ProductTerms> GetProductTerms()
        {
            List<ProductTerms> terms = new List<ProductTerms>();
            DataSet ds = new GeneralDataHandler().GetData("tblProductTerms");
            foreach (DataRow item in ds.Tables["tblProductTerms"].Rows)
            {
                terms.Add(new ProductTerms(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString()));
            }
            return terms;
        }

        public override bool Equals(object obj)
        {
            return obj is ProductTerms terms &&
                   ProdID == terms.ProdID &&
                   Upgrade == terms.Upgrade &&
                   PreMaintanance == terms.PreMaintanance &&
                   CorrectiveMaintanance == terms.CorrectiveMaintanance;
        }

        public override int GetHashCode()
        {
            int hashCode = 1957646689;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProdID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Upgrade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PreMaintanance);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CorrectiveMaintanance);
            return hashCode;
        }
    }
}
