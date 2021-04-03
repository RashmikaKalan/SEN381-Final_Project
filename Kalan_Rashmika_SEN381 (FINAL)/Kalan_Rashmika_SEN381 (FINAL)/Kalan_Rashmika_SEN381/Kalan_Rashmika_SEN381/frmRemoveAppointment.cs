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
    public partial class frmRemoveAppointment : Form
    {
        public delegate void Del(object sender, EventArgs e);

        public frmRemoveAppointment()
        {
            InitializeComponent();
            Del remove = new Del(RemoveClick);
            btnDelete.Click += new EventHandler(remove);
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            try
            {
                BookedEmployee bemp = new BookedEmployee();
                List<BookedEmployee> bookedEmployees = bemp.GetBookedEmployees();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No Appointment ID Entered.");
                }
                else if (bookedEmployees.Any(book => book.BookID == int.Parse(txtIDNum.Text)))
                {
                    bemp.RemoveApp(int.Parse(txtIDNum.Text));
                    DialogResult r = MessageBox.Show("Appointment Removed", "Remove Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        txtIDNum.Clear();
                        frmTechnicalMain frm = new frmTechnicalMain();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    throw new Exception("Appointment ID does not exist.");
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
                frmTechnicalMain frm = new frmTechnicalMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void frmRemoveAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
