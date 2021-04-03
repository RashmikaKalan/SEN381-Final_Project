using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmAddProduct : Form
    { 
        public delegate void Del(object sender, EventArgs e);
        Product prod = new Product();       
        Manufacturer manuf = new Manufacturer();        

        public frmAddProduct()
        {
            InitializeComponent();
            Del add = new Del(AddClick);
            btnAddProduct.Click += new EventHandler(add);
        }

        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                IProduct product = prod;
                IMan manu = manuf;
                List<Product> products = product.GetProducts();

                List<Manufacturer> manufacturers = manu.GetManufacturers();
                string man = cbManufacturer.GetItemText(cbManufacturer.SelectedItem);
                int res = 0;

                foreach (var item in manufacturers)
                {
                    if (item.Name == man)
                    {
                        res = item.ID;
                        break;
                    }
                }

                Product check = new Product(txtID.Text.ToUpper(), txtName.Text, rtbDescription.Text, txtVersion.Text, double.Parse(txtCost.Text), dtpRelease.Value.Date, res);
                foreach (var item in products)
                {
                    if (item.Equals(check))
                    {
                        throw new Exception("Product Already Exists.");
                    }
                    else if (item.ProdID==check.ProdID)
                    {
                        throw new Exception("Product ID Already Exists.");
                    }
                }

                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCost.Text) ||
                    string.IsNullOrEmpty(rtbDescription.Text) || string.IsNullOrEmpty(txtVersion.Text))
                {
                    MessageBox.Show("Please Ensure All Fields Are Filled In.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!products.Any(prod => prod.ProdID == txtID.Text.ToUpper()))
                {     
                    Product newP = new Product(txtID.Text.ToUpper(), txtName.Text, rtbDescription.Text, txtVersion.Text, double.Parse(txtCost.Text), dtpRelease.Value.Date, res);
                    product.InsertProduct(newP);
                    DialogResult r = MessageBox.Show("Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        txtCost.Clear();
                        txtID.Clear();
                        txtName.Clear();
                        rtbDescription.Clear();
                        txtVersion.Clear();
                        frmProductMain frm = new frmProductMain();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                IMan manu = manuf;
                List<Manufacturer> manufacturers = manu.GetManufacturers();
                cbManufacturer.DataSource = manufacturers;
                cbManufacturer.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Double Clicks
        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

       
        #endregion
    }
}
