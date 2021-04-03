namespace Kalan_Rashmika_SEN381
{
    partial class frmEmployeeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeSchedule));
            this.gbxEmployee = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
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
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.gbxEmployee.SuspendLayout();
            this.gbxView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlComp.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEmployee
            // 
            this.gbxEmployee.Controls.Add(this.pbProgrss);
            this.gbxEmployee.Controls.Add(this.btnClear);
            this.gbxEmployee.Controls.Add(this.btnBack);
            this.gbxEmployee.Controls.Add(this.btnSearchEmp);
            this.gbxEmployee.Controls.Add(this.txtEmpID);
            this.gbxEmployee.Controls.Add(this.lblEmployee);
            this.gbxEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployee.Location = new System.Drawing.Point(12, 12);
            this.gbxEmployee.Name = "gbxEmployee";
            this.gbxEmployee.Size = new System.Drawing.Size(772, 130);
            this.gbxEmployee.TabIndex = 7;
            this.gbxEmployee.TabStop = false;
            this.gbxEmployee.Text = "Search For Employee";
            this.gbxEmployee.Enter += new System.EventHandler(this.gbxEmployee_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(449, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 61);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(622, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 61);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearchEmp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmp.Location = new System.Drawing.Point(279, 21);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(122, 61);
            this.btnSearchEmp.TabIndex = 4;
            this.btnSearchEmp.Text = "SEARCH";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(7, 57);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(220, 25);
            this.txtEmpID.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 36);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(86, 17);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Employee ID";
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.lblName);
            this.gbxView.Controls.Add(this.lblEmployeeName);
            this.gbxView.Controls.Add(this.panel1);
            this.gbxView.Controls.Add(this.pnlComp);
            this.gbxView.Controls.Add(this.pnlMonth);
            this.gbxView.Controls.Add(this.dgvDisplay);
            this.gbxView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.Location = new System.Drawing.Point(12, 148);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(772, 425);
            this.gbxView.TabIndex = 8;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Appointments for the Month";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblName.Location = new System.Drawing.Point(170, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 5;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(11, 35);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(153, 19);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Showing Schedule For: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUpcoming);
            this.panel1.Controls.Add(this.lblUpcoming);
            this.panel1.Location = new System.Drawing.Point(552, 344);
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
            this.pnlComp.Location = new System.Drawing.Point(272, 344);
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
            this.pnlMonth.Location = new System.Drawing.Point(6, 344);
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
            this.dgvDisplay.Location = new System.Drawing.Point(9, 73);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(757, 265);
            this.dgvDisplay.TabIndex = 0;
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(7, 98);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(759, 19);
            this.pbProgrss.TabIndex = 15;
            // 
            // frmEmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 579);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.gbxEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSchedule";
            this.Load += new System.EventHandler(this.frmEmployeeSchedule_Load);
            this.gbxEmployee.ResumeLayout(false);
            this.gbxEmployee.PerformLayout();
            this.gbxView.ResumeLayout(false);
            this.gbxView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlComp.ResumeLayout(false);
            this.pnlComp.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmployee;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUpcoming;
        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.Panel pnlComp;
        private System.Windows.Forms.TextBox txtComplete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.TextBox txtNumberMonth;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
    }
}