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
    public partial class frmEmployeeSchedule : Form
    {
        public delegate void Del(object sender, EventArgs e);

        public frmEmployeeSchedule()
        {
            InitializeComponent();
            Del search = new Del(SearchClick);
            btnSearchEmp.Click += new EventHandler(search);
            bgwProgress.DoWork += bgwProgressWork;
            bgwProgress.ProgressChanged += bgwProgressReport;
            bgwProgress.RunWorkerCompleted += bgwProgressComplete;
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employees = Employee.GetEmployees();
                pbProgrss.Maximum = employees.Count;
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
                frmTechnicalMain frm = new frmTechnicalMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void frmEmployeeSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmpID.Clear();
                txtComplete.Clear();
                txtNumberMonth.Clear();
                txtUpcoming.Clear();
                lblName.Text = "";
                dgvDisplay.DataSource = null;
                pbProgrss.Value = 0;
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

        public void bgwProgressComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                BookedEmployee bemp = new BookedEmployee();
                List<Employee> employees = Employee.GetEmployees();
                int count = 0;
                int complete = 0;
                int upcoming = 0;
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();

                if (string.IsNullOrEmpty(txtEmpID.Text))
                {
                    throw new Exception("No ID Was Entered.");
                }
                else if (employees.Any(employ => employ.ID == txtEmpID.Text))
                {
                    MessageBox.Show("Employee Schedule Found", "Employee Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<EmployeeSchedule> emp = EmployeeSchedule.GetSchedule(int.Parse(txtEmpID.Text));
                    if (bookedEmployees.Any(book => book.EmpID == int.Parse(txtEmpID.Text)))
                    {
                        dgvDisplay.DataSource = emp;
                        foreach (var item in employees)
                        {
                            if (item.ID == txtEmpID.Text)
                            {
                                lblName.Text = string.Concat(item.FirstName + " " + item.LastName);
                                break;
                            }
                        }

                        foreach (var item in bookedEmployees)
                        {
                            if (item.EmpID == int.Parse(txtEmpID.Text))
                            {
                                if (item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year)
                                {
                                    count++;
                                }
                            }
                        }

                        foreach (var item in bookedEmployees)
                        {
                            if (item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year && item.Date.Day < DateTime.Now.Day)
                            {
                                complete++;
                            }
                        }

                        foreach (var item in bookedEmployees)
                        {

                            if (item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year && item.Date.Day > DateTime.Now.Day)
                            {
                                upcoming++;
                            }
                        }
                        txtComplete.Text = complete.ToString();
                        txtNumberMonth.Text = count.ToString();
                        txtUpcoming.Text = upcoming.ToString();
                    }
                }
                else
                {
                    throw new Exception("Employee With That ID Does Not Exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Double Clicks
        private void gbxEmployee_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
