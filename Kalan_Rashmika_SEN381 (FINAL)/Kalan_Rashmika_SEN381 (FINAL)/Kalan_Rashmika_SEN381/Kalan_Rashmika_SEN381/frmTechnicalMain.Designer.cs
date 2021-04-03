namespace Kalan_Rashmika_SEN381
{
    partial class frmTechnicalMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnicalMain));
            this.mnsTechnical = new System.Windows.Forms.MenuStrip();
            this.searchForAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUpcoming = new System.Windows.Forms.TextBox();
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.pnlComp = new System.Windows.Forms.Panel();
            this.txtComplete = new System.Windows.Forms.TextBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.txtNumberMonth = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.callCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTechnical.SuspendLayout();
            this.gbxView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlComp.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsTechnical
            // 
            this.mnsTechnical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForAnAppointmentToolStripMenuItem,
            this.addNewAppointmentToolStripMenuItem,
            this.updateExistingAppointmentToolStripMenuItem,
            this.deleteAnAppointmentToolStripMenuItem,
            this.viewEmployeeScheduleToolStripMenuItem,
            this.callCentreToolStripMenuItem});
            this.mnsTechnical.Location = new System.Drawing.Point(0, 0);
            this.mnsTechnical.Name = "mnsTechnical";
            this.mnsTechnical.Size = new System.Drawing.Size(864, 24);
            this.mnsTechnical.TabIndex = 0;
            this.mnsTechnical.Text = "menuStrip1";
            // 
            // searchForAnAppointmentToolStripMenuItem
            // 
            this.searchForAnAppointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByIDToolStripMenuItem,
            this.searchByDateToolStripMenuItem,
            this.searchByClientToolStripMenuItem});
            this.searchForAnAppointmentToolStripMenuItem.Name = "searchForAnAppointmentToolStripMenuItem";
            this.searchForAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.searchForAnAppointmentToolStripMenuItem.Text = "Search For An Appointment";
            // 
            // searchByIDToolStripMenuItem
            // 
            this.searchByIDToolStripMenuItem.Name = "searchByIDToolStripMenuItem";
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.searchByIDToolStripMenuItem.Text = "Search By Appointment ID";
            this.searchByIDToolStripMenuItem.Click += new System.EventHandler(this.searchByIDToolStripMenuItem_Click);
            // 
            // searchByDateToolStripMenuItem
            // 
            this.searchByDateToolStripMenuItem.Name = "searchByDateToolStripMenuItem";
            this.searchByDateToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.searchByDateToolStripMenuItem.Text = "Search By Date";
            this.searchByDateToolStripMenuItem.Click += new System.EventHandler(this.searchByDateToolStripMenuItem_Click);
            // 
            // searchByClientToolStripMenuItem
            // 
            this.searchByClientToolStripMenuItem.Name = "searchByClientToolStripMenuItem";
            this.searchByClientToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.searchByClientToolStripMenuItem.Text = "Search By Client ID";
            this.searchByClientToolStripMenuItem.Click += new System.EventHandler(this.searchByClientToolStripMenuItem_Click);
            // 
            // addNewAppointmentToolStripMenuItem
            // 
            this.addNewAppointmentToolStripMenuItem.Name = "addNewAppointmentToolStripMenuItem";
            this.addNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.addNewAppointmentToolStripMenuItem.Text = "Add New Appointment";
            this.addNewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addNewAppointmentToolStripMenuItem_Click);
            // 
            // updateExistingAppointmentToolStripMenuItem
            // 
            this.updateExistingAppointmentToolStripMenuItem.Name = "updateExistingAppointmentToolStripMenuItem";
            this.updateExistingAppointmentToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.updateExistingAppointmentToolStripMenuItem.Text = "Update Existing Appointment";
            this.updateExistingAppointmentToolStripMenuItem.Click += new System.EventHandler(this.updateExistingAppointmentToolStripMenuItem_Click);
            // 
            // deleteAnAppointmentToolStripMenuItem
            // 
            this.deleteAnAppointmentToolStripMenuItem.Name = "deleteAnAppointmentToolStripMenuItem";
            this.deleteAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.deleteAnAppointmentToolStripMenuItem.Text = "Delete An Appointment";
            this.deleteAnAppointmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAnAppointmentToolStripMenuItem_Click);
            // 
            // viewEmployeeScheduleToolStripMenuItem
            // 
            this.viewEmployeeScheduleToolStripMenuItem.Name = "viewEmployeeScheduleToolStripMenuItem";
            this.viewEmployeeScheduleToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.viewEmployeeScheduleToolStripMenuItem.Text = "View Employee Schedule";
            this.viewEmployeeScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeScheduleToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(372, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 67);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.pbProgrss);
            this.gbxView.Controls.Add(this.panel1);
            this.gbxView.Controls.Add(this.pnlComp);
            this.gbxView.Controls.Add(this.pnlMonth);
            this.gbxView.Controls.Add(this.dgvDisplay);
            this.gbxView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.Location = new System.Drawing.Point(12, 42);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(840, 430);
            this.gbxView.TabIndex = 4;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Appointments for the Month";
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(6, 403);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(828, 19);
            this.pbProgrss.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUpcoming);
            this.panel1.Controls.Add(this.lblUpcoming);
            this.panel1.Location = new System.Drawing.Point(614, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 73);
            this.panel1.TabIndex = 3;
            // 
            // txtUpcoming
            // 
            this.txtUpcoming.Location = new System.Drawing.Point(7, 42);
            this.txtUpcoming.Name = "txtUpcoming";
            this.txtUpcoming.Size = new System.Drawing.Size(120, 26);
            this.txtUpcoming.TabIndex = 4;
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.Location = new System.Drawing.Point(3, 11);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(158, 19);
            this.lblUpcoming.TabIndex = 3;
            this.lblUpcoming.Text = "Upcoming Appointments";
            // 
            // pnlComp
            // 
            this.pnlComp.Controls.Add(this.txtComplete);
            this.pnlComp.Controls.Add(this.lblComplete);
            this.pnlComp.Location = new System.Drawing.Point(308, 311);
            this.pnlComp.Name = "pnlComp";
            this.pnlComp.Size = new System.Drawing.Size(226, 73);
            this.pnlComp.TabIndex = 2;
            // 
            // txtComplete
            // 
            this.txtComplete.Location = new System.Drawing.Point(7, 42);
            this.txtComplete.Name = "txtComplete";
            this.txtComplete.Size = new System.Drawing.Size(120, 26);
            this.txtComplete.TabIndex = 4;
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(3, 11);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(163, 19);
            this.lblComplete.TabIndex = 3;
            this.lblComplete.Text = "Completed Appointments";
            // 
            // pnlMonth
            // 
            this.pnlMonth.Controls.Add(this.txtNumberMonth);
            this.pnlMonth.Controls.Add(this.lblNumber);
            this.pnlMonth.Location = new System.Drawing.Point(6, 311);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(220, 73);
            this.pnlMonth.TabIndex = 1;
            // 
            // txtNumberMonth
            // 
            this.txtNumberMonth.Location = new System.Drawing.Point(7, 42);
            this.txtNumberMonth.Name = "txtNumberMonth";
            this.txtNumberMonth.Size = new System.Drawing.Size(120, 26);
            this.txtNumberMonth.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 11);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(199, 19);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Total Appointments This Month";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 25);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(828, 269);
            this.dgvDisplay.TabIndex = 0;
            // 
            // callCentreToolStripMenuItem
            // 
            this.callCentreToolStripMenuItem.Name = "callCentreToolStripMenuItem";
            this.callCentreToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.callCentreToolStripMenuItem.Text = "Call Centre";
            this.callCentreToolStripMenuItem.Click += new System.EventHandler(this.callCentreToolStripMenuItem_Click);
            // 
            // frmTechnicalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 549);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.mnsTechnical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsTechnical;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTechnicalMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechnicalSupportDepartment";
            this.Load += new System.EventHandler(this.frmTechnicalMain_Load);
            this.mnsTechnical.ResumeLayout(false);
            this.mnsTechnical.PerformLayout();
            this.gbxView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlComp.ResumeLayout(false);
            this.pnlComp.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsTechnical;
        private System.Windows.Forms.ToolStripMenuItem searchForAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUpcoming;
        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.Panel pnlComp;
        private System.Windows.Forms.TextBox txtComplete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.TextBox txtNumberMonth;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ToolStripMenuItem searchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeScheduleToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
        private System.Windows.Forms.ToolStripMenuItem callCentreToolStripMenuItem;
    }
}