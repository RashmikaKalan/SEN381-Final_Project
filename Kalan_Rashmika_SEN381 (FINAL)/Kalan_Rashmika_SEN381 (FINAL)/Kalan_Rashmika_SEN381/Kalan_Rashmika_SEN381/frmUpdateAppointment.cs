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
                BookedEmployee bemp = new BookedEmployee();
                txtIDNum.Enabled = false;
                List<string> name = new List<string>();
                foreach (var item in employees)
                {
                    name.Add(string.Concat(item.FirstName + " " + item.LastName));
                }
                cbEmployee.DataSource = name;

                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                if (bookedEmployees.Any(book => book.BookID == int.Parse(txtIDNum.Text)))
                {
                    int empID = 0;
                    string desc = "";
                    string priority = "";

                    foreach (var item in bookedEmployees)
                    {
                        if (item.BookID == int.Parse(txtIDNum.Text))
                        {
                            clientID = item.ClientID;
                            empID = item.EmpID;
                            desc = item.Desc;
                            priority = item.Priority;
                            dtpDate.Value = item.Date.Date;
                            dtpTime.Value = item.Date;
                            break;
                        }
                    }

                    foreach (var item in employees)
                    {
                        if (empID == int.Parse(item.ID))
                        {
                            cbEmployee.SelectedIndex = employees.IndexOf(item);
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
                        if (item == priority)
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
                BookedEmployee bemp = new BookedEmployee();
                BookedEmployee UpdateApp = new BookedEmployee();
                UpdateApp.BookID = int.Parse(txtIDNum.Text);
                UpdateApp.ClientID = clientID;
                UpdateApp.Date = dtpDate.Value.Date+dtpTime.Value.TimeOfDay;
                UpdateApp.Desc = cbDesc.GetItemText(cbDesc.SelectedItem);
                UpdateApp.Priority = cbPriority.GetItemText(cbPriority.SelectedItem);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.MinDate = DateTime.Now;
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
