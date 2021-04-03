using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmProductMain : Form
    {
        Product prod = new Product();
        AddOns adds = new AddOns();
        Manufacturer manuf = new Manufacturer();

        public frmProductMain()
        {
            InitializeComponent();
            bgwProgress.DoWork += bgwProgress_DoWork;
            bgwProgress.ProgressChanged += bgwProgress_ProgressChanged;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frl = new frmLogin();
                frl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Double Clicks
        private void txtProdID_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbAddOns_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void searchForProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductSearch frs = new frmProductSearch();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddProduct fra = new frmAddProduct();
                fra.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateExistingProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateProduct fru = new frmUpdateProduct();
                fru.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRemoveProduct frr = new frmRemoveProduct();
                frr.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        BindingSource bs = new BindingSource();
        BindingSource bsa = new BindingSource();

        private void frmProductMain_Load(object sender, EventArgs e)
        {
            try
            {
                IProduct product = prod;
                IMan manu = manuf;
                IAdd add = adds;
                int count = 0;
                List<Product> products = product.GetProducts();
                count = products.Count;
                pbProgrss.Maximum = count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bs.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                bs.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnPrevAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bsa.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bsa.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i <= pbProgrss.Maximum; i++)
                {
                    bgwProgress.ReportProgress(i);
                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void bgwProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                pbProgrss.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                IProduct product = prod;
                IMan manu = manuf;
                IAdd add = adds;
                List<Manufacturer> manufacturers = manu.GetManufacturers();
                MessageBox.Show("All Products and Add Ons Loaded.", "View Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Product> products = product.GetProducts();
                bs.DataSource = products;
                txtID.DataBindings.Add("text", bs, "ProdID");
                txtName.DataBindings.Add("text", bs, "Name");
                txtCost.DataBindings.Add("text", bs, "Cost");
                rtbDescription.DataBindings.Add("text", bs, "Desc");
                txtVersion.DataBindings.Add("text", bs, "Version");
                dtpVersion.DataBindings.Add("text", bs, "VerDate");

                var current = (Product)bs.Current;
                foreach (var item in manufacturers)
                {
                    if (item.ID == current.ManID)
                    {
                        txtManufacture.Text = item.Name;
                        break;
                    }
                }

                List<AddOns> addOns = add.GetAddOns();
                bsa.DataSource = addOns;
                txtAddID.DataBindings.Add("text", bsa, "ID");
                txtAddName.DataBindings.Add("text", bsa, "Name");
                txtAddCost.DataBindings.Add("text", bsa, "Cost");
                rtbAddDesc.DataBindings.Add("text", bsa, "Desc");

                var currenta = (Product)bs.Current;
                foreach (var item in manufacturers)
                {
                    if (item.ID == current.ManID)
                    {
                        txtManA.Text = item.Name;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
