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
    public partial class frmSearchAppointmentID : Form
    {
        public delegate void Del(object sender, EventArgs e);
        BookedEmployee book = new BookedEmployee();

        public frmSearchAppointmentID()
        {
            InitializeComponent();
            Del ID = new Del(SearchID);
            btnSearch.Click += new EventHandler(ID);
            Del Date = new Del(SearchDate);
            btnSearchDate.Click += new EventHandler(Date);
            Del client = new Del(SearchClient);
            btnClient.Click += new EventHandler(SearchClient);
        }

        public void Display(List<BookedEmployee> bookedEmployees)
        {
            dgvDisp.DataSource = bookedEmployees;
            dgvDisp.Columns["EmpID"].Visible = false;
            dgvDisp.Columns["ClientID"].Visible = false;
            dgvDisp.Columns["BookID"].DisplayIndex = 0;
            dgvDisp.Columns["EmpName"].DisplayIndex = 1;
            dgvDisp.Columns["ClientName"].DisplayIndex = 2;
            dgvDisp.Columns["Desc"].DisplayIndex = 3;
            dgvDisp.Columns["Date"].DisplayIndex = 4;
            dgvDisp.Columns["Priority"].DisplayIndex = 5;
        }

        private void SearchID(object sender, EventArgs e)
        {
            try
            {
                IBook bemp = book;
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No Appointment ID Was Entered.");
                }
                else if (bookedEmployees.Any(book => book.BookID == int.Parse(txtIDNum.Text)))
                {
                    foreach (var item in bookedEmployees)
                    {
                        if (item.BookID == int.Parse(txtIDNum.Text))
                        {
                            this.Size = new Size(920, 369);
                            lblApps.Text = "Showing Appointments for Booking ID: ";
                            lblName.Text = item.BookID.ToString();
                            break;
                        }
                    }
                    List<BookedEmployee> dt = bemp.GetAppID(int.Parse(txtIDNum.Text));
                    Display(dt);
                }
                else
                {
                    throw new Exception("Appointment ID Does Not Exist.");
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
                IBook bemp = book;
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                List<BookedEmployee> bres = new List<BookedEmployee>();
                if (bookedEmployees.Any(book => book.Date.Year== dtpApp.Value.Year && book.Date.Month==dtpApp.Value.Month && book.Date.Day==dtpApp.Value.Day))
                {
                    this.Size = new Size(920, 369);
                    foreach (var item in bookedEmployees)
                    {
                        if (item.Date.Year==dtpApp.Value.Year && item.Date.Month==dtpApp.Value.Month && item.Date.Day==dtpApp.Value.Day)
                        {
                            bres.Add(new BookedEmployee(item.BookID, item.EmpID, item.ClientID, item.Desc, item.Date, item.Priority));
                        }
                    }
                    lblApps.Text = "Showing Appointments For The Date: ";
                    lblName.Text = dtpApp.Value.ToString("yyyy/MM/dd");
                    Display(bres);
                    dgvDisp.Columns["EmpName"].Visible = false;
                    dgvDisp.Columns["ClientName"].Visible=false;
                }
                else
                {
                    throw new Exception("No Appointments Found For This Date");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchClient(object sender, EventArgs e)
        {
            try
            {
                IBook bemp = book;
                List<Client> clients = Client.GetClients();
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                if (string.IsNullOrEmpty(txtClientID.Text))
                {
                    throw new Exception("No Client ID Entered.");
                }

                if (User.ValidID(txtClientID.Text) == true)
                {
                    foreach (var item in clients)
                    {

                        if (item.IDNum == txtClientID.Text)
                        {
                            this.Size = new Size(920, 369);
                            lblApps.Text = "Showing Appointments for Client: ";
                            lblName.Text = string.Concat(item.FirstName + " " + item.LastName);
                            break;
                        }

                    }
                }

                List<BookedEmployee> dt = bemp.GetCApps(txtClientID.Text);
                Display(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSearchAppointmentID_Load(object sender, EventArgs e)
        {
            try
            {
                if (frmTechnicalMain.Display == "ID")
                {
                    gbxSearchID.Visible = true;
                    gbxClient.Visible = false;
                    gbxDate.Visible = false;
                }
                else if (frmTechnicalMain.Display == "Client")
                {
                    gbxClient.Visible = true;
                    gbxDate.Visible = false;
                    gbxSearchID.Visible = false;
                }
                else if (frmTechnicalMain.Display == "Date")
                {
                    dtpApp.MinDate = DateTime.Now;
                    gbxSearchID.Visible = false;
                    gbxClient.Visible = false;
                    gbxDate.Visible = true;
                }
                this.Size = new Size(271, 369);
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
    }
}
