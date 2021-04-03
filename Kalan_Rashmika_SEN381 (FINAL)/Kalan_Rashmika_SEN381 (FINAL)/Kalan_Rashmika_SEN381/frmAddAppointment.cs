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
        BookedEmployee booked = new BookedEmployee();
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
                IBook bemp = booked;
                List<Employee> employees = Employee.GetEmployees();
                List<Client> clients = Client.GetClients();
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                BookedEmployee bookedEmployee = new BookedEmployee();
                string employeeName = cbEmployee.GetItemText(cbEmployee.SelectedItem);

                foreach (var item in bookedEmployees)
                {
                    DateTime current = item.Date;
                    DateTime shour = item.Date.AddHours(1);
                    DateTime start = shour.AddMinutes(30);
                    DateTime chosen = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
                    CustomAppointmentException.CheckTime(current, start, chosen);
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

                string pri = cbPriority.GetItemText(cbPriority.SelectedItem);
                switch (pri)
                {
                    case "High":
                        bookedEmployee.Priority = 1;
                        break;
                    case "Medium":
                        bookedEmployee.Priority = 2;
                        break;
                    case "Low":
                        bookedEmployee.Priority = 3;
                        break;
                }

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
            catch (CustomAppointmentException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                IBook bemp = booked;
                dtpDate.MinDate = DateTime.Now;
                dtpTime.Format = DateTimePickerFormat.Time;
                dtpTime.ShowUpDown = true;
                List<Employee> employees = Employee.GetEmployees();
                foreach (var item in employees)
                {
                    if (item.Level==4 || item.Level==5 || item.Level==6)
                    {
                        cbEmployee.Items.Add(string.Concat(item.FirstName + " " + item.LastName));
                    }                  
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
