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
    public partial class frmRemoveProduct : Form
    {
        public delegate void Del(object sender, EventArgs e);
    
        public frmRemoveProduct()
        {
            InitializeComponent();
            Del remove = new Del(RemoveClick);
            btnDelete.Click += new EventHandler(remove);
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                List<Product> products = product.GetProducts();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No ID Was Entered");
                }
                else if (products.Any(prod => prod.ProdID == txtIDNum.Text.ToUpper()))
                {
                    product.RemoveProduct(txtIDNum.Text.ToUpper());
                    DialogResult r = MessageBox.Show("Product Removed.", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        txtIDNum.Clear();
                        frmProductMain frm = new frmProductMain();
                        frm.Show();
                        this.Hide();
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

        private void frmRemoveProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
