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
    public partial class frmAddAppointment : Form
    {
        public delegate void MyDel(object sender, EventArgs e);
        BookedEmployee bemp = new BookedEmployee();
        Client client = new Client();

        public frmAddAppointment()
        {
            InitializeComponent();
            MyDel add = new MyDel(AddAppointment);
            btnAddApp.Click += new EventHandler(add);
        }

        private void AddAppointment(object sender, EventArgs e)
        {
            try
            {
                BookedEmployee bemp = new BookedEmployee();
                List<Employee> employees = Employee.GetEmployees();
                List<Client> clients = Client.GetClients();
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                BookedEmployee bookedEmployee = new BookedEmployee();
                string employeeName = cbEmployee.GetItemText(cbEmployee.SelectedItem);

                foreach (var item in bookedEmployees)
                {
                    TimeSpan start = item.Date.TimeOfDay;
                    TimeSpan ts = TimeSpan.FromHours(1);
                    TimeSpan end = start.Add(ts);
                    TimeSpan chose = dtpTime.Value.TimeOfDay;
                    if (item.Date.Year==dtpDate.Value.Year && item.Date.Month==dtpDate.Value.Month)
                    {
                        if (chose>start && chose<=end)
                        {
                            throw new Exception("Employee is already booked for that time slot.");
                        }
                    }
                }

                foreach (var item in employees)
                {
                    if (employeeName == string.Concat(item.FirstName + " " + item.LastName))
                    {
                        bookedEmployee.EmpID = int.Parse(item.ID);
                        break;
                    }
                }

                if (rbMaintanance.Checked == true)
                {
                    bookedEmployee.Desc = "Maintanance";
                }
                else if (rbUpgrade.Checked == true)
                {
                    bookedEmployee.Desc = "Upgrade";
                }
                else if (rbOther.Checked == true)
                {
                    bookedEmployee.Desc = "Other";
                }
                else
                {
                    throw new Exception("No Description Was Chosen.");
                }

                bookedEmployee.Priority = cbPriority.GetItemText(cbPriority.SelectedItem);

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    throw new Exception("Please Ensure All Fields Are Filled In.");
                }
                else if (clients.Any(client => client.IDNum == txtID.Text))
                {
                    foreach (var person in clients)
                    {
                        if ((person.IDNum == txtID.Text) && User.ValidID(txtID.Text))
                        {
                            bookedEmployee.ClientID = person.ID;
                            bookedEmployee.Date = dtpDate.Value.Date+dtpTime.Value.TimeOfDay;
                            bemp.InsertApp(bookedEmployee);
                            DialogResult r = MessageBox.Show("Appointment has been added.", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (r == DialogResult.OK)
                            {
                                txtID.Clear();
                                rbMaintanance.Checked = false;
                                rbUpgrade.Checked = false;
                                rbOther.Checked = false;
                                frmTechnicalMain frm = new frmTechnicalMain();
                                frm.Show();
                                this.Hide();
                            }
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Client Does Not Exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.MinDate = DateTime.Now;
                dtpTime.Format = DateTimePickerFormat.Time;
                dtpTime.ShowUpDown = true;
                List<Employee> employees = Employee.GetEmployees();
                foreach (var item in employees)
                {
                    cbEmployee.Items.Add(string.Concat(item.FirstName + " " + item.LastName));
                }

                List<string> prior = bemp.Priorities();
                cbPriority.DataSource = prior;
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


        #region Double Clicks
        private void cbEmployee_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void rbUpgrade_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbMaintanance_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        #endregion
    }
}
