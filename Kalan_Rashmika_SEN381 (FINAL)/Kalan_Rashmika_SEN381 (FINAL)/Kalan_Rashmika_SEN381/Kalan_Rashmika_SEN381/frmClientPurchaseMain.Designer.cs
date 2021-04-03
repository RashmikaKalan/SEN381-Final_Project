namespace Kalan_Rashmika_SEN381
{
    partial class frmClientPurchaseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientPurchaseMain));
            this.mnsPurchasesMain = new System.Windows.Forms.MenuStrip();
            this.searchForPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.mnsPurchasesMain.SuspendLayout();
            this.gbxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPurchasesMain
            // 
            this.mnsPurchasesMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForPurchaseToolStripMenuItem,
            this.addNewPurchaseToolStripMenuItem,
            this.removePurchaseToolStripMenuItem});
            this.mnsPurchasesMain.Location = new System.Drawing.Point(0, 0);
            this.mnsPurchasesMain.Name = "mnsPurchasesMain";
            this.mnsPurchasesMain.Size = new System.Drawing.Size(714, 24);
            this.mnsPurchasesMain.TabIndex = 0;
            this.mnsPurchasesMain.Text = "menuStrip1";
            // 
            // searchForPurchaseToolStripMenuItem
            // 
            this.searchForPurchaseToolStripMenuItem.Name = "searchForPurchaseToolStripMenuItem";
            this.searchForPurchaseToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.searchForPurchaseToolStripMenuItem.Text = "Search For Subscription";
            this.searchForPurchaseToolStripMenuItem.Click += new System.EventHandler(this.searchForPurchaseToolStripMenuItem_Click);
            // 
            // addNewPurchaseToolStripMenuItem
            // 
            this.addNewPurchaseToolStripMenuItem.Name = "addNewPurchaseToolStripMenuItem";
            this.addNewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.addNewPurchaseToolStripMenuItem.Text = "Add New Subscription";
            this.addNewPurchaseToolStripMenuItem.Click += new System.EventHandler(this.addNewPurchaseToolStripMenuItem_Click);
            // 
            // removePurchaseToolStripMenuItem
            // 
            this.removePurchaseToolStripMenuItem.Name = "removePurchaseToolStripMenuItem";
            this.removePurchaseToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.removePurchaseToolStripMenuItem.Text = "Remove Subscription";
            this.removePurchaseToolStripMenuItem.Click += new System.EventHandler(this.removePurchaseToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(395, 372);
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
            this.gbxView.Controls.Add(this.dgvDisplay);
            this.gbxView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.Location = new System.Drawing.Point(12, 27);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(690, 339);
            this.gbxView.TabIndex = 4;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Subscriptions";
            this.gbxView.Enter += new System.EventHandler(this.gbxView_Enter);
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(6, 314);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(678, 19);
            this.pbProgrss.TabIndex = 14;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 25);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(678, 269);
            this.dgvDisplay.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(177, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 67);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmClientPurchaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.mnsPurchasesMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsPurchasesMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientPurchaseMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientSubscriptions";
            this.Load += new System.EventHandler(this.frmClientPurchaseMain_Load);
            this.mnsPurchasesMain.ResumeLayout(false);
            this.mnsPurchasesMain.PerformLayout();
            this.gbxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPurchasesMain;
        private System.Windows.Forms.ToolStripMenuItem searchForPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePurchaseToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
    }
}