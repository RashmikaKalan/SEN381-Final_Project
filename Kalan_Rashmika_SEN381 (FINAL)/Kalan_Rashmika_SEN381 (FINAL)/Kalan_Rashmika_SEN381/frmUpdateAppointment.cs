using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmUpdateAppointment : Form
    {
        public delegate void Del(object sender, EventArgs e);
        BookedEmployee book = new BookedEmployee();

        public frmUpdateAppointment()
        {
            InitializeComponent();
            Del search = new Del(SearchClick);
            btnSearch.Click += new EventHandler(search);
            Del update = new Del(UpdateClick);
            btnUpdate.Click += new EventHandler(update);
        }

        List<Employee> employees = Employee.GetEmployees();
        List<Client> clients = Client.GetClients();
        public static string clientID;

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                IBook bemp = book;
                txtIDNum.Enabled = false;
                List<Employee> name = new List<Employee>();
                List<String> empfull = new List<string>();
                foreach (var item in employees)
                {
                    if (item.Level == 4 || item.Level == 5 || item.Level == 6)
                    {
                        name.Add(new Employee(item.ID, item.FirstName, item.LastName, item.Phone, item.Email, item.Level));
                        empfull.Add(string.Concat(item.FirstName + " " + item.LastName));
                    }
                }
                cbEmployee.DataSource = empfull;

                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                if (bookedEmployees.Any(book => book.BookID == int.Parse(txtIDNum.Text)))
                {
                    int empID = 0;
                    string desc = "";
                    int priority = 0;

                    foreach (var item in bookedEmployees)
                    {
                        if (item.BookID == int.Parse(txtIDNum.Text))
                        {
                            clientID = item.ClientID;
                            empID = item.EmpID;
                            desc = item.Desc;
                            priority = item.Priority;
                            dtpDate.Value = item.Date;
                            dtpTime.Value = item.Date;
                            break;
                        }
                    }

                    foreach (var item in name)
                    {
                        if (empID == int.Parse(item.ID))
                        {
                            cbEmployee.SelectedIndex = name.IndexOf(item);
                            break;
                        }
                    }

                    foreach (var item in clients)
                    {
                        if (clientID == item.ID)
                        {
                            txtName.Text = string.Concat(item.FirstName + " " + item.LastName);
                            txtName.Enabled = false;
                            break;
                        }
                    }

                    List<string> type = bemp.Type();
                    cbDesc.DataSource = type;
                    foreach (var item in type)
                    {
                        if (item == desc)
                        {
                            cbDesc.SelectedIndex = type.IndexOf(item);
                            break;
                        }
                    }

                    List<string> prior = bemp.Priorities();
                    cbPriority.DataSource = prior;

                    foreach (var item in prior)
                    {
                        if (prior.IndexOf(item)+1 == priority)
                        {
                            cbPriority.SelectedIndex = prior.IndexOf(item);
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("No Appointment Found With That ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            try
            {
                IBook bemp = book;
                BookedEmployee UpdateApp = new BookedEmployee();
                UpdateApp.BookID = int.Parse(txtIDNum.Text);
                UpdateApp.ClientID = clientID;
               
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                foreach (var item in bookedEmployees)
                {
                    DateTime current = item.Date;
                    DateTime shour = item.Date.AddHours(1);
                    DateTime start = shour.AddMinutes(30);
                    DateTime chosen = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
                    CustomAppointmentException.CheckTime(current, start, chosen);
                }
                UpdateApp.Date = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;

                UpdateApp.Desc = cbDesc.GetItemText(cbDesc.SelectedItem);
                string pri = cbPriority.GetItemText(cbPriority.SelectedItem);
                switch (pri)
                {
                    case "High":
                        UpdateApp.Priority = 1;
                        break;
                    case "Medium":
                        UpdateApp.Priority = 2;
                        break;
                    case "Low":
                        UpdateApp.Priority = 3;
                        break;
                }

                string[] empFull = (cbEmployee.GetItemText(cbEmployee.SelectedItem)).Split(' ');
                string first = empFull[0].Trim();
                string last = empFull[1].Trim();
                foreach (var item in employees)
                {
                    if (item.FirstName == first && item.LastName == last)
                    {
                        UpdateApp.EmpID = int.Parse(item.ID);
                        break;
                    }
                }

                bemp.UpdateExistingApp(UpdateApp);
                DialogResult r = MessageBox.Show("Appointment Updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    txtIDNum.Clear();
                    txtName.Clear();
                    frmTechnicalMain frm = new frmTechnicalMain();
                    frm.Show();
                    this.Hide();
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

        private void frmUpdateAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                dtpTime.Format = DateTimePickerFormat.Time;
                dtpTime.ShowUpDown = true;
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

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
        #endregion
    }
}
