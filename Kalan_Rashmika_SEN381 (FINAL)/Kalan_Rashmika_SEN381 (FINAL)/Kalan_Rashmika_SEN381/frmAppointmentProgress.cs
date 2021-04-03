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
    public partial class frmAppointmentProgress : Form
    {
        public delegate void Delegate(object sender, EventArgs e);

        public frmAppointmentProgress()
        {
            InitializeComponent();
            Delegate bdel = new Delegate(Back);
            btnBack.Click += new EventHandler(bdel);
            Delegate dclick = new Delegate(Appointments);
            trvTechnician.DoubleClick += new EventHandler(dclick);
        }

        private void Back(object sender, EventArgs e)
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

        List<Employee> employees = Employee.GetEmployees();

        private void frmAppointmentProgress_Load(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                trvTechnician.Nodes.Add("Appointments");
                trvTechnician.Nodes[0].Nodes.Add("Technicians");
                trvTechnician.Nodes[0].Nodes.Add("Unassigned Appointments");
                foreach (var item in employees)
                {
                    if (item.Level == 4 || item.Level == 5 || item.Level == 6)
                    {
                        count++;
                        trvTechnician.Nodes[0].Nodes[0].Nodes.Add(string.Concat(item.FirstName + " " + item.LastName));
                    }
                }

                for (int i = 0; i <= count - 1; i++)
                {
                    trvTechnician.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Active");
                    trvTechnician.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Upcoming");
                    trvTechnician.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Completed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string empID = "";

        private void trvTechnician_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = trvTechnician.SelectedNode;               

                foreach (var emp in employees)
                {
                    if (node.Text == string.Concat(emp.FirstName + " " + emp.LastName))
                    {
                        lblEmployee.Text = string.Concat(emp.FirstName + " " + emp.LastName);
                        empID = emp.ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Appointments(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = trvTechnician.SelectedNode;
                List<EmployeeSchedule> comp = new List<EmployeeSchedule>();
                List<EmployeeSchedule> act = new List<EmployeeSchedule>();
                List<EmployeeSchedule> inp = new List<EmployeeSchedule>();


                List<EmployeeSchedule> employeeSchedules = EmployeeSchedule.GetSchedule(int.Parse(empID));

                foreach (var app in employeeSchedules)
                {
                    if (app.Date.Month == DateTime.Now.Month && app.Date.Year == DateTime.Now.Year && app.Date.Day < DateTime.Now.Day)
                    {
                        comp.Add(new EmployeeSchedule(app.BookID, app.ClientName, app.Desc, app.Date, app.Location, app.Priority));

                    }
                }

                foreach (var app in employeeSchedules)
                {
                    if (app.Date.Month == DateTime.Now.Month && app.Date.Year == DateTime.Now.Year && app.Date.Day > DateTime.Now.Day)
                    {
                        inp.Add(new EmployeeSchedule(app.BookID, app.ClientName, app.Desc, app.Date, app.Location, app.Priority));
                    }
                }

                foreach (var app in employeeSchedules)
                {
                    if (app.Date.Month == DateTime.Now.Month && app.Date.Year == DateTime.Now.Year && app.Date.Day == DateTime.Now.Day)
                    {
                        act.Add(new EmployeeSchedule(app.BookID, app.ClientName, app.Desc, app.Date, app.Location, app.Priority));
                    }
                }

                BindingSource bs = new BindingSource();

                if (node.Text == "Active")
                {
                    lblStatus.Text = "Active";
                    if (act.Count==0)
                    {
                        dgvResult.DataSource = null;
                        MessageBox.Show("No Active Appointments For This Technician.", "Active Appointments.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bs.DataSource = act;
                        dgvResult.DataSource = bs;
                    }                 
                }
                if (node.Text == "Completed")
                {
                    lblStatus.Text = "Completed";
                    if (comp.Count==0)
                    {
                        dgvResult.DataSource = null;
                        MessageBox.Show("No Completed Appointments For This Technician.", "Completed Appointments.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bs.DataSource = comp;
                        dgvResult.DataSource = bs;
                    }
                }
                if (node.Text == "Upcoming")
                {
                    lblStatus.Text = "Upcoming";
                    if (inp.Count==0)
                    {
                        dgvResult.DataSource = null;
                        MessageBox.Show("No Upcoming Appointments For This Technician.", "Upcoming Appointments.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bs.DataSource = inp;
                        dgvResult.DataSource = bs;
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

