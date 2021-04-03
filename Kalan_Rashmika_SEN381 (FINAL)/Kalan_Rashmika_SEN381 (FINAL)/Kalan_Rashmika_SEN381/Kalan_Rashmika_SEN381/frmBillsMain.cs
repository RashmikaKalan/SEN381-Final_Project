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
    public partial class frmBillsMain : Form
    {
        MonthlyBilling bill = new MonthlyBilling();

        public frmBillsMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientMain frc = new frmClientMain();
                frc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBillsMain_Load(object sender, EventArgs e)
        {
            try
            {
                MonthlyBilling bill = new MonthlyBilling();
                List<MonthlyBilling> billings = bill.GetMonthlyBillings();
                int count = billings.Count;
                pbProgrss.Maximum = count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
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

        #region Double Clicks
        private void mnsBill_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

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

        private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                MonthlyBilling bills = new MonthlyBilling();
                MessageBox.Show("All Bills For The Month Found.", "Monthly Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<MonthlyBilling> billings = bills.GetMonthlyBillings();
                List<Client> clients = Client.GetClients();
                List<MonthlyBilling> result = new List<MonthlyBilling>();
                foreach (var bill in billings)
                {
                    if (bill.Date.Year == DateTime.Now.Year && bill.Date.Month == DateTime.Now.Month)
                    {
                        foreach (var client in clients)
                        {
                            if (bill.ClientID == client.ID)
                            {
                                result.Add(new MonthlyBilling(bill.InvID, client.ID, client.FirstName, client.LastName, bill.Month, bill.Amount, bill.Date, bill.SubID));
                            }
                        }
                    }
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = result;
                dgvDisplay.DataSource = bs;
                dgvDisplay.Columns["Amount"].DefaultCellStyle.Format = "c";
                dgvDisplay.Columns[1].HeaderText = "ClientID";
                dgvDisplay.Columns[2].HeaderText = "ClientFirstName";
                dgvDisplay.Columns[3].HeaderText = "ClientLastName";

                DialogResult newbills = MessageBox.Show("Issue Any New Bills For The Month?", "Monthly Billing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (newbills == DialogResult.Yes)
                {
                    foreach (var item in billings)
                    {
                        if (DateTime.Now == item.Date.AddDays(28))
                        {
                            MonthlyBilling billing = new MonthlyBilling(item.InvID, item.ClientID, DateTime.Now.ToString("MMMM"), item.Amount, DateTime.Now, item.SubID);
                            bill.NewBill(billing);
                        }
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
