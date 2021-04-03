using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmProductSearch : Form
    {
        public delegate void Del(object sender, EventArgs e);
  
        public frmProductSearch()
        {
            InitializeComponent();
            Del searhdel = new Del(Search);
            btnSearch.Click += new EventHandler(searhdel);
            Del searchadd = new Del(SearchAddOns);
            btnSearchA.Click += new EventHandler(searchadd);
            Del back = new Del(BackMain);
            btnBack.Click += new EventHandler(back);
            btnBackA.Click += new EventHandler(back);
        }
       
        private void Search(object sender, EventArgs e)
        {
            try
            {
                Manufacturer manu = new Manufacturer();
                Product product = new Product();
                AddOns add = new AddOns();

                List<Product> products = product.GetProducts();
                Product result = new Product();
                List<Manufacturer> manufacturers = manu.GetManufacturers();
                if (products.Any(prod => prod.ProdID == txtID.Text.ToUpper()))
                {
                    result = products.Find(prod => prod.ProdID == txtID.Text.ToUpper());
                    MessageBox.Show("Product Found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = result.Name;
                    txtCost.Text = result.Cost.ToString();
                    txtVersion.Text = result.Version;
                    txtVersionDate.Text = result.VerDate.ToString();
                    rtbDescription.Text = result.Desc;
                    foreach (var item in manufacturers)
                    {
                        if (item.ID == result.ManID)
                        {
                            txtManufacture.Text = item.Name;
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Product Does Not Exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchAddOns(object sender, EventArgs e)
        {
            try
            {
                Manufacturer manu = new Manufacturer();
                Product product = new Product();
                AddOns addo = new AddOns();

                List<AddOns> addOns = addo.GetAddOns();
                List<Manufacturer> manufacturers = manu.GetManufacturers();
                if (addOns.Any(add=>add.ID==int.Parse(txtAddID.Text)))
                {
                    AddOns an = addOns.Find(add => add.ID == int.Parse(txtAddID.Text));
                    MessageBox.Show("Add On Found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddName.Text = an.Name;
                    txtAddCost.Text = an.Cost.ToString();
                    rtbAddDesc.Text = an.Desc;
                    foreach (var item in manufacturers)
                    {
                        if (item.ID == an.ManID)
                        {
                            txtManA.Text = item.Name;
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Add On Does Not Exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackMain(object sender, EventArgs e)
        {
            try
            {
                frmProductMain frp = new frmProductMain();
                frp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductSearch_Load(object sender, EventArgs e)
        {

        }


    }
}
