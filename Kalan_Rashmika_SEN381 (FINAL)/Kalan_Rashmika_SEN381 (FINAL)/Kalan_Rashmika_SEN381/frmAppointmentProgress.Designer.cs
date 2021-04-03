namespace Kalan_Rashmika_SEN381
{
    partial class frmAppointmentProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentProgress));
            this.trvTechnician = new System.Windows.Forms.TreeView();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxBack = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAppStatus = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.gbxBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // trvTechnician
            // 
            this.trvTechnician.Location = new System.Drawing.Point(13, 13);
            this.trvTechnician.Margin = new System.Windows.Forms.Padding(4);
            this.trvTechnician.Name = "trvTechnician";
            this.trvTechnician.Size = new System.Drawing.Size(223, 345);
            this.trvTechnician.TabIndex = 0;
            this.trvTechnician.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTechnician_AfterSelect);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(188, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 80);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // gbxBack
            // 
            this.gbxBack.Controls.Add(this.dgvResult);
            this.gbxBack.Controls.Add(this.lblStatus);
            this.gbxBack.Controls.Add(this.lblAppStatus);
            this.gbxBack.Controls.Add(this.lblEmployee);
            this.gbxBack.Controls.Add(this.btnBack);
            this.gbxBack.Controls.Add(this.lblEmployeeName);
            this.gbxBack.Location = new System.Drawing.Point(243, 13);
            this.gbxBack.Name = "gbxBack";
            this.gbxBack.Size = new System.Drawing.Size(503, 345);
            this.gbxBack.TabIndex = 38;
            this.gbxBack.TabStop = false;
            this.gbxBack.Text = "Appointments";
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(7, 103);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(490, 150);
            this.dgvResult.TabIndex = 43;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblStatus.Location = new System.Drawing.Point(231, 63);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 42;
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.AutoSize = true;
            this.lblAppStatus.Location = new System.Drawing.Point(90, 63);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(135, 19);
            this.lblAppStatus.TabIndex = 41;
            this.lblAppStatus.Text = "Appointment Status: ";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblEmployee.Location = new System.Drawing.Point(231, 26);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 24);
            this.lblEmployee.TabIndex = 40;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(149, 30);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(76, 19);
            this.lblEmployeeName.TabIndex = 39;
            this.lblEmployeeName.Text = "Employee: ";
            // 
            // frmAppointmentProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 370);
            this.Controls.Add(this.gbxBack);
            this.Controls.Add(this.trvTechnician);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointmentProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsProgress";
            this.Load += new System.EventHandler(this.frmAppointmentProgress_Load);
            this.gbxBack.ResumeLayout(false);
            this.gbxBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTechnician;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxBack;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAppStatus;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}