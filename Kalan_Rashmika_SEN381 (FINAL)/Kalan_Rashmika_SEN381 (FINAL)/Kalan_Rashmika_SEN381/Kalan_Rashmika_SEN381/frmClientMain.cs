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
    public partial class frmClientMain : Form
    {
        Client client = new Client();

        public frmClientMain()
        {
            InitializeComponent();
            bgwProgress.DoWork += bgwProgressDoWork;
            bgwProgress.ProgressChanged += bgwProgressReport;
            bgwProgress.RunWorkerCompleted += bgwProgressComplete;
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

        private void searchForAClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientSearch clientSearch = new frmClientSearch();
                clientSearch.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddClient addClient = new frmAddClient();
                addClient.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void updateExistingClientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateClient updateClient = new frmUpdateClient();
                updateClient.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRemoveClient removeClient = new frmRemoveClient();
                removeClient.Show();
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
                frmClientPurchaseMain frp = new frmClientPurchaseMain();
                frp.Show();
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

        private void searchForAClientPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void removeAPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewAllBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBillsMain frb = new frmBillsMain();
                frb.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchForBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBillSearch frb = new frmBillSearch();
                frb.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void frmClientMain_Load(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = Client.GetClients();
                pbProgrss.Maximum = clients.Count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bgwProgressDoWork(object sender, DoWorkEventArgs e)
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

        public void bgwProgressReport(object sender, ProgressChangedEventArgs e)
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

        public void bgwProgressComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                MessageBox.Show("All Clients Loaded", "View All Clients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Client> clients = Client.GetClients();
                BindingSource bs = new BindingSource();
                bs.DataSource = clients;
                dgvDisplay.DataSource = bs;
                dgvDisplay.Columns["ID"].DisplayIndex = 0;
                dgvDisplay.Columns["FirstName"].DisplayIndex = 1;
                dgvDisplay.Columns["LastName"].DisplayIndex = 2;
                dgvDisplay.Columns["IDNum"].DisplayIndex = 3;
                dgvDisplay.Columns["Phone"].DisplayIndex = 4;
                dgvDisplay.Columns["Email"].DisplayIndex = 5;
                dgvDisplay.Columns["Location"].DisplayIndex = 6;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewAllContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmContractsMain frm = new frmContractsMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Double Click
        private void mnsClientMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void viewMonthlyBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion        
    }
}
