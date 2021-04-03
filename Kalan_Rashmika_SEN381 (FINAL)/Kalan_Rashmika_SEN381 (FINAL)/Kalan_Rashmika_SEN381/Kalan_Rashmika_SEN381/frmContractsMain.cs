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
    public partial class frmContractsMain : Form
    {

        public frmContractsMain()
        {
            InitializeComponent();
            bgwWork.DoWork += bgwWorkDoWork;
            bgwWork.ProgressChanged += bgwWorkProgress;
            bgwWork.RunWorkerCompleted += bgwWorkComplete;
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

        private void bgwWorkDoWork(object sender,DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i <= pbProgrss.Maximum; i++)
                {
                    bgwWork.ReportProgress(i);
                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmContractsMain_Load(object sender, EventArgs e)
        {
            try
            {
                Contracts con = new Contracts();
                List<Contracts> contracts = con.GetContracts();
                pbProgrss.Maximum = contracts.Count;
                bgwWork.WorkerReportsProgress = true;
                bgwWork.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwWorkProgress(object sender, ProgressChangedEventArgs e)
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

        private void bgwWorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                Contracts con = new Contracts();
                List<Contracts> contracts = con.GetContracts();
                MessageBox.Show("All Contracts Loaded.", "View All Contracts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDisplay.DataSource = contracts;
                dgvDisplay.Columns["ID"].DisplayIndex = 0;
                dgvDisplay.Columns["ClientID"].DisplayIndex = 1;
                dgvDisplay.Columns["subID"].DisplayIndex = 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
