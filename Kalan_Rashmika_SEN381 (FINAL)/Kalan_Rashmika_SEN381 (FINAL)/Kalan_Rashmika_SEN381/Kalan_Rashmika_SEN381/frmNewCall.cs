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
    public partial class frmNewCall : Form
    {
        public frmNewCall()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmCallCentre frm = new frmCallCentre();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void frmNewCall_Load(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employee = Employee.GetEmployees();
                foreach (var item in employee)
                {
                    if (item.ID == frmLogin.EmployeeID)
                    {
                        txtEmpName.Text = string.Concat(item.FirstName + " " + item.LastName);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DateTime startcall;

        private void pbAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                startcall = DateTime.Now;
                MessageBox.Show("Call Duration Started.", "Call Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbHangup_Click(object sender, EventArgs e)
        {
            try
            {
                CallCentre call = new CallCentre();
                DateTime endcall = DateTime.Now;
                TimeSpan span = endcall.Subtract(startcall);
                double min = Math.Round((span.TotalMinutes), 2);
                CallCentre ncall = new CallCentre(0,int.Parse(frmLogin.EmployeeID), min, startcall);
                call.AddCall(ncall);
                DialogResult r = MessageBox.Show("Call Details Recorded.\nCall Duration: " + min+" min", "Call Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r==DialogResult.OK)
                {
                    txtEmpName.Clear();
                    frmCallCentre frm = new frmCallCentre();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
