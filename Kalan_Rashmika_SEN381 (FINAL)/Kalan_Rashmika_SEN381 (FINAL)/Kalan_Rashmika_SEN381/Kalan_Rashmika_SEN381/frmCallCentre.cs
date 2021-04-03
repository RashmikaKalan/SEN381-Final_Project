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
    public partial class frmCallCentre : Form
    {
   

        public frmCallCentre()
        {
            InitializeComponent();
            bgwProgress.DoWork += bgwProgressWork;
            bgwProgress.ProgressChanged += bgwProgressReport;
            bgwProgress.RunWorkerCompleted += bgwProgressComplete;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewAllCallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewCall frn = new frmNewCall();
                frn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void frmCallCentre_Load(object sender, EventArgs e)
        {
            try
            {
                CallCentre call = new CallCentre();
                List<CallCentre> dt = call.GetAllCalls();
                pbProgrss.Maximum = dt.Count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
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
                CallCentre call = new CallCentre();
                MessageBox.Show("All Calls Loaded.", "Call Centre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<CallCentre> dt = call.GetAllCalls();
                dgvDisplay.DataSource = dt;
                dgvDisplay.Columns["EmpID"].Visible = false;
                dgvDisplay.Columns["CallID"].DisplayIndex = 0;
                dgvDisplay.Columns["EmpName"].DisplayIndex = 1;
                dgvDisplay.Columns["EmpName"].HeaderText="Employee Name";
                dgvDisplay.Columns["Date"].DisplayIndex = 2;
                dgvDisplay.Columns["Duration"].DisplayIndex = 3;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void searchForCallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCallSearch frc = new frmCallSearch();
                frc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnsCall_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
