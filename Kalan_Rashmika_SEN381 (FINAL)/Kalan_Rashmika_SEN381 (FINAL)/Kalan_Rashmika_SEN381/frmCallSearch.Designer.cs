namespace Kalan_Rashmika_SEN381
{
    partial class frmCallSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallSearch));
            this.tbcSearch = new System.Windows.Forms.TabControl();
            this.tbpID = new System.Windows.Forms.TabPage();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbpDate = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lbSDate = new System.Windows.Forms.Label();
            this.tbpEmployee = new System.Windows.Forms.TabPage();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbcSearch.SuspendLayout();
            this.tbpID.SuspendLayout();
            this.tbpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.tbpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSearch
            // 
            this.tbcSearch.Controls.Add(this.tbpID);
            this.tbcSearch.Controls.Add(this.tbpDate);
            this.tbcSearch.Controls.Add(this.tbpEmployee);
            this.tbcSearch.Location = new System.Drawing.Point(12, 12);
            this.tbcSearch.Name = "tbcSearch";
            this.tbcSearch.SelectedIndex = 0;
            this.tbcSearch.Size = new System.Drawing.Size(567, 333);
            this.tbcSearch.TabIndex = 0;
            // 
            // tbpID
            // 
            this.tbpID.Controls.Add(this.lblMin);
            this.tbpID.Controls.Add(this.txtDuration);
            this.tbpID.Controls.Add(this.txtDate);
            this.tbpID.Controls.Add(this.txtEmployee);
            this.tbpID.Controls.Add(this.txtID);
            this.tbpID.Controls.Add(this.btnSearch);
            this.tbpID.Controls.Add(this.lblDuration);
            this.tbpID.Controls.Add(this.lblDate);
            this.tbpID.Controls.Add(this.lblEmployee);
            this.tbpID.Controls.Add(this.lblID);
            this.tbpID.Location = new System.Drawing.Point(4, 28);
            this.tbpID.Name = "tbpID";
            this.tbpID.Padding = new System.Windows.Forms.Padding(3);
            this.tbpID.Size = new System.Drawing.Size(559, 301);
            this.tbpID.TabIndex = 0;
            this.tbpID.Text = "Search By ID";
            this.tbpID.UseVisualStyleBackColor = true;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(406, 268);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(57, 19);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "Minutes";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(125, 265);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(275, 26);
            this.txtDuration.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 213);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(275, 26);
            this.txtDate.TabIndex = 8;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(125, 157);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(275, 26);
            this.txtEmployee.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 26);
            this.txtID.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(187, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 61);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 272);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 19);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 216);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 160);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(113, 19);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Call ID:";
            // 
            // tbpDate
            // 
            this.tbpDate.Controls.Add(this.dtpDate);
            this.tbpDate.Controls.Add(this.dgvResult);
            this.tbpDate.Controls.Add(this.btnSearchDate);
            this.tbpDate.Controls.Add(this.lbSDate);
            this.tbpDate.Location = new System.Drawing.Point(4, 28);
            this.tbpDate.Name = "tbpDate";
            this.tbpDate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDate.Size = new System.Drawing.Size(559, 301);
            this.tbpDate.TabIndex = 1;
            this.tbpDate.Text = "Search By Date";
            this.tbpDate.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(3, 131);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(550, 164);
            this.dgvResult.TabIndex = 10;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Location = new System.Drawing.Point(212, 52);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(145, 61);
            this.btnSearchDate.TabIndex = 9;
            this.btnSearchDate.Text = "SEARCH";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            // 
            // lbSDate
            // 
            this.lbSDate.AutoSize = true;
            this.lbSDate.Location = new System.Drawing.Point(6, 15);
            this.lbSDate.Name = "lbSDate";
            this.lbSDate.Size = new System.Drawing.Size(41, 19);
            this.lbSDate.TabIndex = 7;
            this.lbSDate.Text = "Date:";
            // 
            // tbpEmployee
            // 
            this.tbpEmployee.Controls.Add(this.dgvDisp);
            this.tbpEmployee.Controls.Add(this.lblName);
            this.tbpEmployee.Controls.Add(this.lblShow);
            this.tbpEmployee.Controls.Add(this.btnSearchEmp);
            this.tbpEmployee.Controls.Add(this.txtEmpID);
            this.tbpEmployee.Controls.Add(this.lblEmpID);
            this.tbpEmployee.Location = new System.Drawing.Point(4, 28);
            this.tbpEmployee.Name = "tbpEmployee";
            this.tbpEmployee.Size = new System.Drawing.Size(559, 301);
            this.tbpEmployee.TabIndex = 2;
            this.tbpEmployee.Text = "Search By Employee";
            this.tbpEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(3, 134);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.Size = new System.Drawing.Size(550, 164);
            this.dgvDisp.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblName.Location = new System.Drawing.Point(149, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 19);
            this.lblName.TabIndex = 13;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(3, 100);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(121, 19);
            this.lblShow.TabIndex = 12;
            this.lblShow.Text = "Showing Calls For";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearchEmp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmp.Location = new System.Drawing.Point(395, 41);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(145, 46);
            this.btnSearchEmp.TabIndex = 11;
            this.btnSearchEmp.Text = "SEARCH";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(122, 12);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(154, 26);
            this.txtEmpID.TabIndex = 10;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(3, 12);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(92, 19);
            this.lblEmpID.TabIndex = 9;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(228, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 80);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(88, 9);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(244, 26);
            this.dtpDate.TabIndex = 11;
            // 
            // frmCallSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbcSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCallSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForCalls";
            this.Load += new System.EventHandler(this.frmCallSearch_Load);
            this.tbcSearch.ResumeLayout(false);
            this.tbpID.ResumeLayout(false);
            this.tbpID.PerformLayout();
            this.tbpDate.ResumeLayout(false);
            this.tbpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.tbpEmployee.ResumeLayout(false);
            this.tbpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSearch;
        private System.Windows.Forms.TabPage tbpID;
        private System.Windows.Forms.TabPage tbpDate;
        private System.Windows.Forms.TabPage tbpEmployee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lbSDate;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}