namespace Kalan_Rashmika_SEN381
{
    partial class frmSearchAppointmentID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchAppointmentID));
            this.gbxSearchID = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxDate = new System.Windows.Forms.GroupBox();
            this.dtpApp = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbxClient = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApps = new System.Windows.Forms.Label();
            this.gbxSearchID.SuspendLayout();
            this.gbxDate.SuspendLayout();
            this.gbxClient.SuspendLayout();
            this.gbxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearchID
            // 
            this.gbxSearchID.Controls.Add(this.btnSearch);
            this.gbxSearchID.Controls.Add(this.txtIDNum);
            this.gbxSearchID.Controls.Add(this.lblID);
            this.gbxSearchID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearchID.Location = new System.Drawing.Point(6, 12);
            this.gbxSearchID.Name = "gbxSearchID";
            this.gbxSearchID.Size = new System.Drawing.Size(233, 174);
            this.gbxSearchID.TabIndex = 1;
            this.gbxSearchID.TabStop = false;
            this.gbxSearchID.Text = "Search By ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(49, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 61);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(7, 57);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(220, 25);
            this.txtIDNum.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Appointment ID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(55, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 59);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxDate
            // 
            this.gbxDate.Controls.Add(this.dtpApp);
            this.gbxDate.Controls.Add(this.btnSearchDate);
            this.gbxDate.Controls.Add(this.lblDate);
            this.gbxDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDate.Location = new System.Drawing.Point(12, 12);
            this.gbxDate.Name = "gbxDate";
            this.gbxDate.Size = new System.Drawing.Size(233, 187);
            this.gbxDate.TabIndex = 2;
            this.gbxDate.TabStop = false;
            this.gbxDate.Text = "Search By Date";
            // 
            // dtpApp
            // 
            this.dtpApp.Location = new System.Drawing.Point(6, 56);
            this.dtpApp.Name = "dtpApp";
            this.dtpApp.Size = new System.Drawing.Size(215, 25);
            this.dtpApp.TabIndex = 5;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Location = new System.Drawing.Point(49, 101);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(122, 61);
            this.btnSearchDate.TabIndex = 4;
            this.btnSearchDate.Text = "SEARCH";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Choose a Date";
            // 
            // gbxClient
            // 
            this.gbxClient.Controls.Add(this.btnClient);
            this.gbxClient.Controls.Add(this.txtClientID);
            this.gbxClient.Controls.Add(this.lblClient);
            this.gbxClient.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClient.Location = new System.Drawing.Point(18, 12);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(233, 187);
            this.gbxClient.TabIndex = 7;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "Search By Client";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(49, 101);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(122, 61);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "SEARCH";
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(7, 57);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(220, 25);
            this.txtClientID.TabIndex = 3;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(6, 36);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(114, 17);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client ID Number";
            // 
            // gbxResult
            // 
            this.gbxResult.Controls.Add(this.lblName);
            this.gbxResult.Controls.Add(this.lblApps);
            this.gbxResult.Controls.Add(this.dgvDisp);
            this.gbxResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxResult.Location = new System.Drawing.Point(268, 12);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(624, 306);
            this.gbxResult.TabIndex = 8;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Search Results";
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(6, 77);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.Size = new System.Drawing.Size(612, 223);
            this.dgvDisp.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblName.Location = new System.Drawing.Point(268, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(176, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Change at runtime";
            // 
            // lblApps
            // 
            this.lblApps.AutoSize = true;
            this.lblApps.Location = new System.Drawing.Point(6, 36);
            this.lblApps.Name = "lblApps";
            this.lblApps.Size = new System.Drawing.Size(256, 19);
            this.lblApps.TabIndex = 6;
            this.lblApps.Text = "Showing Appointments For Booking ID: ";
            // 
            // frmSearchAppointmentID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 471);
            this.Controls.Add(this.gbxResult);
            this.Controls.Add(this.gbxClient);
            this.Controls.Add(this.gbxSearchID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchAppointmentID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForAppointment";
            this.Load += new System.EventHandler(this.frmSearchAppointmentID_Load);
            this.gbxSearchID.ResumeLayout(false);
            this.gbxSearchID.PerformLayout();
            this.gbxDate.ResumeLayout(false);
            this.gbxDate.PerformLayout();
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.gbxResult.ResumeLayout(false);
            this.gbxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.DateTimePicker dtpApp;
        private System.Windows.Forms.GroupBox gbxResult;
        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApps;
    }
}