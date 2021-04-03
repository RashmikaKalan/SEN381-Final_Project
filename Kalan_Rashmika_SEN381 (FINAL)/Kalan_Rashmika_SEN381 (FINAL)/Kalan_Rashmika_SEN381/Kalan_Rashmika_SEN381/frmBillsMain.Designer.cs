namespace Kalan_Rashmika_SEN381
{
    partial class frmBillsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillsMain));
            this.mnsBill = new System.Windows.Forms.MenuStrip();
            this.searchForBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.mnsBill.SuspendLayout();
            this.gbxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsBill
            // 
            this.mnsBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForBillToolStripMenuItem});
            this.mnsBill.Location = new System.Drawing.Point(0, 0);
            this.mnsBill.Name = "mnsBill";
            this.mnsBill.Size = new System.Drawing.Size(714, 24);
            this.mnsBill.TabIndex = 0;
            this.mnsBill.Text = "menuStrip1";
            this.mnsBill.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsBill_ItemClicked);
            // 
            // searchForBillToolStripMenuItem
            // 
            this.searchForBillToolStripMenuItem.Name = "searchForBillToolStripMenuItem";
            this.searchForBillToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.searchForBillToolStripMenuItem.Text = "Search for Bill";
            this.searchForBillToolStripMenuItem.Click += new System.EventHandler(this.searchForBillToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(165, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 67);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(407, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 67);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.pbProgrss);
            this.gbxView.Controls.Add(this.dgvDisplay);
            this.gbxView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.Location = new System.Drawing.Point(12, 27);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(690, 340);
            this.gbxView.TabIndex = 8;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Bills For This Month";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 25);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(678, 269);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(0, 315);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(684, 19);
            this.pbProgrss.TabIndex = 12;
            // 
            // bgwProgress
            // 
            this.bgwProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProgress_DoWork);
            this.bgwProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwProgress_ProgressChanged);
            this.bgwProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProgress_RunWorkerCompleted);
            // 
            // frmBillsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.mnsBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsBill;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBillsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyBilling";
            this.Load += new System.EventHandler(this.frmBillsMain_Load);
            this.mnsBill.ResumeLayout(false);
            this.mnsBill.PerformLayout();
            this.gbxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsBill;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ToolStripMenuItem searchForBillToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
    }
}