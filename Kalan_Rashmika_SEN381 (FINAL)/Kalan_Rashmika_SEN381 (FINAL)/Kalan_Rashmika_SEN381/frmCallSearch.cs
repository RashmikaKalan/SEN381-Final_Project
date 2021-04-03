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
    public partial class frmCallSearch : Form
    {
        public delegate void Del(object sender, EventArgs e);
        CallCentre caller = new CallCentre();

        public frmCallSearch()
        {
            InitializeComponent();
            Del searchID = new Del(SearchID);
            btnSearch.Click += new EventHandler(searchID);
            Del searchDate = new Del(SearchDate);
            btnSearchDate.Click += new EventHandler(searchDate);
            Del searchEmp = new Del(SearchEmployee);
            btnSearchEmp.Click += new EventHandler(searchEmp);
        }

        private void frmCallSearch_Load(object sender, EventArgs e)
        {

        }

        private void SearchID(object sender, EventArgs e)
        {
            try
            {
                ICall calli = caller;
                List<CallCentre> calls = calli.GetCalls();
                List<Employee> employees = Employee.GetEmployees();

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    throw new Exception("No ID Entered.");
                }
                else if (calls.Any(call => call.CallID == int.Parse(txtID.Text)))
                {
                    CallCentre ncall = calls.Find(call => call.CallID == int.Parse(txtID.Text));
                    foreach (var emp in employees)
                    {
                        if (ncall.EmpID == int.Parse(emp.ID))
                        {
                            txtEmployee.Text = string.Concat(emp.FirstName + " " + emp.LastName);
                            break;
                        }
                    }
                    txtDate.Text = ncall.Date.ToString();
                    txtDuration.Text = ncall.Duration.ToString();
                }
                else
                {
                    throw new Exception("No Call With That ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchDate(object sender, EventArgs e)
        {
            try
            {
                ICall call = caller;
                List<CallCentre> calls = call.GetCalls();
                List<CallCentre> result = new List<CallCentre>();
                foreach (var item in calls)
                {
                    if (item.Date.Year==dtpDate.Value.Year && item.Date.Month==dtpDate.Value.Month && item.Date.Day==dtpDate.Value.Day)
                    {
                        result.Add(item);
                    }
                }
                dgvResult.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEmployee(object sender, EventArgs e)
        {
            try
            {
                ICall calli = caller;
                List<CallCentre> calls = calli.GetCalls();
                List<CallCentre> result = new List<CallCentre>();
                List<Employee> employees = Employee.GetEmployees();
                if (calls.Any(call=>call.EmpID==int.Parse(txtEmpID.Text)))
                {
                    foreach (var item in calls)
                    {
                        if (item.EmpID==int.Parse(txtEmpID.Text))
                        {
                            result.Add(item);
                        }
                    }

                    foreach (var emp in employees)
                    {
                        if (emp.ID==txtEmpID.Text)
                        {
                            lblName.Text = string.Concat(emp.FirstName + " " + emp.LastName);
                            break;
                        }
                    }

                    dgvDisp.DataSource = result;
                }
                else
                {
                    throw new Exception("No Calls For That Employee");
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
