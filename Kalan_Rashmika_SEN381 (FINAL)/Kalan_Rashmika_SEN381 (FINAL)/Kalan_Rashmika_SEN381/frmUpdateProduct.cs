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
    public partial class frmUpdateProduct : Form
    {
        public delegate void Del(object sender, EventArgs e);
        Product prod = new Product();
        Manufacturer manuf = new Manufacturer();

        public frmUpdateProduct()
        {
            InitializeComponent();
            Del search = new Del(Search);
            btnSearch.Click += new EventHandler(search);
            Del update = new Del(Update);
            btnUpdate.Click += new EventHandler(update);
        }
        
        private void Search(object sender, EventArgs e)
        {
            try
            {
                IProduct product = prod;
                IMan manu = manuf;
                List<Product> products = product.GetProducts();
                Product result;
                if (products.Any(prod => prod.ProdID == txtID.Text.ToUpper()))
                {
                    result = products.Find(prod => prod.ProdID == txtID.Text.ToUpper());
                    MessageBox.Show("Product Found. You can now update it's details.", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = result.Name;
                    txtCost.Text = result.Cost.ToString();
                    txtVersion.Text = result.Version;
                    rtbDescription.Text = result.Desc;
                    dtpReleaseDate.Value = result.VerDate;
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    List<Manufacturer> manufacturers = manu.GetManufacturers();
                    foreach (var item in manufacturers)
                    {
                        if (item.ID==result.ManID)
                        {
                            cbManufacturer.SelectedIndex = manufacturers.IndexOf(item);
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

        private void Update(object sender, EventArgs e)
        {
            try
            {
                IProduct product = prod;
                IMan manu = manuf;
                if (string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtVersion.Text) || string.IsNullOrEmpty(rtbDescription.Text))
                {
                    throw new Exception("Please Ensure All Fields Are Filled In.");
                }
                else
                {
                    string man = cbManufacturer.GetItemText(cbManufacturer.SelectedItem);
                    int res = 0;
                    List<Manufacturer> manufacturers = manu.GetManufacturers();
                    foreach (var item in manufacturers)
                    {
                        if (item.Name == man)
                        {
                            res = item.ID;
                            break;
                        }
                    }
  
                    Product newP = new Product(txtID.Text.ToUpper(), txtName.Text, rtbDescription.Text, txtVersion.Text, double.Parse(txtCost.Text), dtpReleaseDate.Value.Date, res);
                    product.UpdateExistingProduct(newP);
                    DialogResult r = MessageBox.Show("Product Updated", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        txtID.Clear();
                        txtName.Clear();
                        txtVersion.Clear();
                        txtCost.Clear();
                        rtbDescription.Clear();
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
                frmProductMain frm = new frmProductMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
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
        private void gbxView_Enter(object sender, EventArgs e)
        {

        }

       
        #endregion
    }
}
