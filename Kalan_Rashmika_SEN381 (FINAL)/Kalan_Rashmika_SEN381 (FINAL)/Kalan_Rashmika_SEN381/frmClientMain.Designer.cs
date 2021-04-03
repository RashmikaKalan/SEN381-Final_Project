namespace Kalan_Rashmika_SEN381
{
    partial class frmClientMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientMain));
            this.mnsClientMain = new System.Windows.Forms.MenuStrip();
            this.searchForAClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingClientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMonthlyBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForAClientPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.viewAllContractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsClientMain.SuspendLayout();
            this.gbxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsClientMain
            // 
            this.mnsClientMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForAClientToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.updateExistingClientDetailsToolStripMenuItem,
            this.removeClientToolStripMenuItem,
            this.viewMonthlyBillsToolStripMenuItem,
            this.monthlyBillingToolStripMenuItem,
            this.viewAllContractsToolStripMenuItem});
            this.mnsClientMain.Location = new System.Drawing.Point(0, 0);
            this.mnsClientMain.Name = "mnsClientMain";
            this.mnsClientMain.Size = new System.Drawing.Size(859, 24);
            this.mnsClientMain.TabIndex = 0;
            this.mnsClientMain.Text = "menuStrip1";
            this.mnsClientMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsClientMain_ItemClicked);
            // 
            // searchForAClientToolStripMenuItem
            // 
            this.searchForAClientToolStripMenuItem.Name = "searchForAClientToolStripMenuItem";
            this.searchForAClientToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.searchForAClientToolStripMenuItem.Text = "Search For A Client";
            this.searchForAClientToolStripMenuItem.Click += new System.EventHandler(this.searchForAClientToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // updateExistingClientDetailsToolStripMenuItem
            // 
            this.updateExistingClientDetailsToolStripMenuItem.Name = "updateExistingClientDetailsToolStripMenuItem";
            this.updateExistingClientDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.updateExistingClientDetailsToolStripMenuItem.Text = "Update Existing Client Details";
            this.updateExistingClientDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateExistingClientDetailsToolStripMenuItem_Click);
            // 
            // removeClientToolStripMenuItem
            // 
            this.removeClientToolStripMenuItem.Name = "removeClientToolStripMenuItem";
            this.removeClientToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.removeClientToolStripMenuItem.Text = "Remove Client";
            this.removeClientToolStripMenuItem.Click += new System.EventHandler(this.removeClientToolStripMenuItem_Click);
            // 
            // viewMonthlyBillsToolStripMenuItem
            // 
            this.viewMonthlyBillsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForPurchaseToolStripMenuItem,
            this.addNewPurchaseToolStripMenuItem,
            this.searchForAClientPurchaseToolStripMenuItem,
            this.removeAPurchaseToolStripMenuItem});
            this.viewMonthlyBillsToolStripMenuItem.Name = "viewMonthlyBillsToolStripMenuItem";
            this.viewMonthlyBillsToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.viewMonthlyBillsToolStripMenuItem.Text = "Client Subscriptions";
            this.viewMonthlyBillsToolStripMenuItem.Click += new System.EventHandler(this.viewMonthlyBillsToolStripMenuItem_Click);
            // 
            // searchForPurchaseToolStripMenuItem
            // 
            this.searchForPurchaseToolStripMenuItem.Name = "searchForPurchaseToolStripMenuItem";
            this.searchForPurchaseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.searchForPurchaseToolStripMenuItem.Text = "View All Subscriptions";
            this.searchForPurchaseToolStripMenuItem.Click += new System.EventHandler(this.searchForPurchaseToolStripMenuItem_Click);
            // 
            // addNewPurchaseToolStripMenuItem
            // 
            this.addNewPurchaseToolStripMenuItem.Name = "addNewPurchaseToolStripMenuItem";
            this.addNewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.addNewPurchaseToolStripMenuItem.Text = "Add New Subscription";
            this.addNewPurchaseToolStripMenuItem.Click += new System.EventHandler(this.addNewPurchaseToolStripMenuItem_Click);
            // 
            // searchForAClientPurchaseToolStripMenuItem
            // 
            this.searchForAClientPurchaseToolStripMenuItem.Name = "searchForAClientPurchaseToolStripMenuItem";
            this.searchForAClientPurchaseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.searchForAClientPurchaseToolStripMenuItem.Text = "Search For A Client Subscription";
            this.searchForAClientPurchaseToolStripMenuItem.Click += new System.EventHandler(this.searchForAClientPurchaseToolStripMenuItem_Click);
            // 
            // removeAPurchaseToolStripMenuItem
            // 
            this.removeAPurchaseToolStripMenuItem.Name = "removeAPurchaseToolStripMenuItem";
            this.removeAPurchaseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.removeAPurchaseToolStripMenuItem.Text = "Remove a Subscription";
            this.removeAPurchaseToolStripMenuItem.Click += new System.EventHandler(this.removeAPurchaseToolStripMenuItem_Click);
            // 
            // monthlyBillingToolStripMenuItem
            // 
            this.monthlyBillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBillsToolStripMenuItem,
            this.searchForBillToolStripMenuItem});
            this.monthlyBillingToolStripMenuItem.Name = "monthlyBillingToolStripMenuItem";
            this.monthlyBillingToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.monthlyBillingToolStripMenuItem.Text = "Monthly Billing";
            // 
            // viewAllBillsToolStripMenuItem
            // 
            this.viewAllBillsToolStripMenuItem.Name = "viewAllBillsToolStripMenuItem";
            this.viewAllBillsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.viewAllBillsToolStripMenuItem.Text = "View All Bills For This Month";
            this.viewAllBillsToolStripMenuItem.Click += new System.EventHandler(this.viewAllBillsToolStripMenuItem_Click);
            // 
            // searchForBillToolStripMenuItem
            // 
            this.searchForBillToolStripMenuItem.Name = "searchForBillToolStripMenuItem";
            this.searchForBillToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.searchForBillToolStripMenuItem.Text = "Search For Bill";
            this.searchForBillToolStripMenuItem.Click += new System.EventHandler(this.searchForBillToolStripMenuItem_Click);
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.pbProgrss);
            this.gbxView.Controls.Add(this.dgvDisplay);
            this.gbxView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.Location = new System.Drawing.Point(12, 38);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(835, 333);
            this.gbxView.TabIndex = 1;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Clients";
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(0, 309);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(829, 19);
            this.pbProgrss.TabIndex = 13;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 25);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(823, 269);
            this.dgvDisplay.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(372, 377);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 67);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // viewAllContractsToolStripMenuItem
            // 
            this.viewAllContractsToolStripMenuItem.Name = "viewAllContractsToolStripMenuItem";
            this.viewAllContractsToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.viewAllContractsToolStripMenuItem.Text = "Contract Management";
            this.viewAllContractsToolStripMenuItem.Click += new System.EventHandler(this.viewAllContractsToolStripMenuItem_Click);
            // 
            // frmClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 456);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.mnsClientMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsClientMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientManagementDepartment";
            this.Load += new System.EventHandler(this.frmClientMain_Load);
            this.mnsClientMain.ResumeLayout(false);
            this.mnsClientMain.PerformLayout();
            this.gbxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsClientMain;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingClientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMonthlyBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForPurchaseToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ToolStripMenuItem searchForAClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForAClientPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForBillToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
        private System.Windows.Forms.ToolStripMenuItem viewAllContractsToolStripMenuItem;
    }
}