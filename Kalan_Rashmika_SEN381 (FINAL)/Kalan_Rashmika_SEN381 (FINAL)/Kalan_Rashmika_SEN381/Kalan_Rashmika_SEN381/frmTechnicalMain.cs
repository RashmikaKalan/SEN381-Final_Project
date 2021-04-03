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
    public partial class frmTechnicalMain : Form
    {
        public frmTechnicalMain()
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
                frmLogin frl = new frmLogin();
                frl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTechnicalMain_Load(object sender, EventArgs e)
        {
            try
            {
                BookedEmployee bemp = new BookedEmployee();
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                pbProgrss.Maximum = bookedEmployees.Count;
                bgwProgress.WorkerReportsProgress = true;
                bgwProgress.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddAppointment fra = new frmAddAppointment();
                fra.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateExistingAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateAppointment fru = new frmUpdateAppointment();
                fru.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAnAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRemoveAppointment frr = new frmRemoveAppointment();
                frr.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Display;

        private void searchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Display = "ID";
                frmSearchAppointmentID frs = new frmSearchAppointmentID();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void searchByEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Display = "Employee";
                frmSearchAppointmentID frs = new frmSearchAppointmentID();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Display = "Date";
                frmSearchAppointmentID frs = new frmSearchAppointmentID();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchByClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Display = "Client";
                frmSearchAppointmentID frs = new frmSearchAppointmentID();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void viewEmployeeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeeSchedule fre = new frmEmployeeSchedule();
                fre.Show();
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
                BookedEmployee bemp = new BookedEmployee();
                MessageBox.Show("All Appointments For This Month Found.", "View Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                List<BookedEmployee> result = new List<BookedEmployee>();
                foreach (var item in bookedEmployees)
                {
                    if (item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year)
                    {
                        result.Add(new BookedEmployee(item.BookID, item.EmpID, item.ClientID, item.Desc, item.Date, item.Priority));
                    }
                }
                dgvDisplay.DataSource = result;
                txtNumberMonth.Text = result.Count().ToString();

                int comp = 0;
                foreach (var app in bookedEmployees)
                {
                    if (app.Date.Month == DateTime.Now.Month && app.Date.Year == DateTime.Now.Year && app.Date.Day < DateTime.Now.Day)
                    {
                        comp++;
                    }
                }
                txtComplete.Text = comp.ToString();

                int upcoming = 0;
                foreach (var app in bookedEmployees)
                {
                    if (app.Date.Month == DateTime.Now.Month && app.Date.Year == DateTime.Now.Year && app.Date.Day > DateTime.Now.Day)
                    {
                        upcoming++;
                    }
                }
                txtUpcoming.Text = upcoming.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void callCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCallCentre frc = new frmCallCentre();
                frc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
