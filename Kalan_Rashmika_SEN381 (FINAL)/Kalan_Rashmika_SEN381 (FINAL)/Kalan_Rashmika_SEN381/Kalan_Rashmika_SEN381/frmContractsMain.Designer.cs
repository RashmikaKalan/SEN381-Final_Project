namespace Kalan_Rashmika_SEN381
{
    partial class frmContractsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractsMain));
            this.mnsContract = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxContract = new System.Windows.Forms.GroupBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.bgwWork = new System.ComponentModel.BackgroundWorker();
            this.mnsContract.SuspendLayout();
            this.gbxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsContract
            // 
            this.mnsContract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.mnsContract.Location = new System.Drawing.Point(0, 0);
            this.mnsContract.Name = "mnsContract";
            this.mnsContract.Size = new System.Drawing.Size(800, 24);
            this.mnsContract.TabIndex = 0;
            this.mnsContract.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.searchToolStripMenuItem.Text = "Search ";
            // 
            // gbxContract
            // 
            this.gbxContract.Controls.Add(this.dgvDisplay);
            this.gbxContract.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContract.Location = new System.Drawing.Point(12, 37);
            this.gbxContract.Name = "gbxContract";
            this.gbxContract.Size = new System.Drawing.Size(776, 294);
            this.gbxContract.TabIndex = 1;
            this.gbxContract.TabStop = false;
            this.gbxContract.Text = "View All Contracts";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(7, 26);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(763, 262);
            this.dgvDisplay.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(340, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 59);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(12, 337);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(776, 19);
            this.pbProgrss.TabIndex = 12;
            // 
            // frmContractsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.pbProgrss);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxContract);
            this.Controls.Add(this.mnsContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsContract;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContractsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractsMain";
            this.Load += new System.EventHandler(this.frmContractsMain_Load);
            this.mnsContract.ResumeLayout(false);
            this.mnsContract.PerformLayout();
            this.gbxContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsContract;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxContract;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.ComponentModel.BackgroundWorker bgwWork;
    }
}