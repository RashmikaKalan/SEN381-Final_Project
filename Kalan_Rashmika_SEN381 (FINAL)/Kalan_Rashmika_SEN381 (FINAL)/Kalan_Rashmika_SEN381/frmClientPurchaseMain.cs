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
    public partial class frmClientPurchaseMain : Form
    {
        public frmClientPurchaseMain()
        {
            InitializeComponent();
            bgwProgress.DoWork += bgwProgressWork;
            bgwProgress.ProgressChanged += bgwProgressReport;
            bgwProgress.RunWorkerCompleted += bgwProgressComplete;
        }

        private void frmClientPurchaseMain_Load(object sender, EventArgs e)
        {
            try
            {
                List<Subscriptions> dt = Subscriptions.GetSubs();
                pbProgrss.Maximum = dt.Count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
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
                frmClientMain frm = new frmClientMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddPurchase fra = new frmAddPurchase();
                fra.Show();
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

        private void searchForPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseSearch frs = new frmPurchaseSearch();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void removePurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRemovePurchase frr = new frmRemovePurchase();
                frr.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void bgwProgressWork(object sender, DoWorkEventArgs e)
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

        private void bgwProgressReport(object sender, ProgressChangedEventArgs e)
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

        private void bgwProgressComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                MessageBox.Show("All Subscriptions Loaded.", "View All Subscriptions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Subscriptions> dt = Subscriptions.GetSubs();
                dgvDisplay.DataSource = dt;
                dgvDisplay.Columns["Cost"].DefaultCellStyle.Format = "c";
                dgvDisplay.Columns["ID"].Visible = false;
                dgvDisplay.Columns["ProdID"].Visible = false;
                dgvDisplay.Columns["ClientName"].DisplayIndex = 2;
                dgvDisplay.Columns["ProdName"].DisplayIndex = 3;
                dgvDisplay.Columns["Version"].DisplayIndex = 4;
                dgvDisplay.Columns["Cost"].DisplayIndex = 6;
                dgvDisplay.Columns["Date"].DisplayIndex = 7;
                dgvDisplay.Columns["ClientID"].DisplayIndex = 1;
                dgvDisplay.Columns["SerialNumber"].DisplayIndex = 5;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbxView_Enter(object sender, EventArgs e)
        {

        }
    }
}
