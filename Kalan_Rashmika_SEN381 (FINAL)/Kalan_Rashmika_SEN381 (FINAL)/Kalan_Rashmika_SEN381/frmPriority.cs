using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmPriority : Form
    {
        public delegate void MyDel(object sender, EventArgs e);

        public frmPriority()
        {
            InitializeComponent();
            MyDel del = new MyDel(Back);
            btnBack.Click += new EventHandler(del);
        }

        private void frmTester_Load(object sender, EventArgs e)
        {
            try
            {                
                BookedEmployee booked = new BookedEmployee();
                IBook bemp = booked;
                List<BookedEmployee> appointments = bemp.GetBookedEmployees();
                PriorityQueue<BookedEmployee> pq = new PriorityQueue<BookedEmployee>();
                foreach (var item in appointments)
                {
                    pq.Enqueue(item);
                }
                rtbDisplay.Text = pq.ToString();
                MessageBox.Show("Appointments are shown starting with highest priority.", "View By Priority", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Double Clicks
        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
