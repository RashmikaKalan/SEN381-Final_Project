namespace Kalan_Rashmika_SEN381
{
    partial class frmCallCentre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallCentre));
            this.mnsCall = new System.Windows.Forms.MenuStrip();
            this.viewAllCallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForCallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.mnsCall.SuspendLayout();
            this.gbxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsCall
            // 
            this.mnsCall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllCallsToolStripMenuItem,
            this.searchForCallsToolStripMenuItem});
            this.mnsCall.Location = new System.Drawing.Point(0, 0);
            this.mnsCall.Name = "mnsCall";
            this.mnsCall.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnsCall.Size = new System.Drawing.Size(714, 25);
            this.mnsCall.TabIndex = 0;
            this.mnsCall.Text = "menuStrip1";
            this.mnsCall.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsCall_ItemClicked);
            // 
            // viewAllCallsToolStripMenuItem
            // 
            this.viewAllCallsToolStripMenuItem.Name = "viewAllCallsToolStripMenuItem";
            this.viewAllCallsToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.viewAllCallsToolStripMenuItem.Text = "New Call";
            this.viewAllCallsToolStripMenuItem.Click += new System.EventHandler(this.viewAllCallsToolStripMenuItem_Click);
            // 
            // searchForCallsToolStripMenuItem
            // 
            this.searchForCallsToolStripMenuItem.Name = "searchForCallsToolStripMenuItem";
            this.searchForCallsToolStripMenuItem.Size = new System.Drawing.Size(102, 19);
            this.searchForCallsToolStripMenuItem.Text = "Search For Calls";
            this.searchForCallsToolStripMenuItem.Click += new System.EventHandler(this.searchForCallsToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(274, 377);
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
            this.gbxView.Location = new System.Drawing.Point(6, 38);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(690, 333);
            this.gbxView.TabIndex = 4;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View All Calls";
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(0, 309);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(684, 19);
            this.pbProgrss.TabIndex = 13;
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
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 456);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.mnsCall);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsCall;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCallCentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallCentre";
            this.Load += new System.EventHandler(this.frmCallCentre_Load);
            this.mnsCall.ResumeLayout(false);
            this.mnsCall.PerformLayout();
            this.gbxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsCall;
        private System.Windows.Forms.ToolStripMenuItem viewAllCallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForCallsToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.ComponentModel.BackgroundWorker bgwProgress;
    }
}