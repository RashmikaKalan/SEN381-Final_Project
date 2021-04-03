namespace Kalan_Rashmika_SEN381
{
    partial class frmNewCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCall));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.pbAnswer = new System.Windows.Forms.PictureBox();
            this.pbHangup = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(94, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 31);
            this.lblHeader.TabIndex = 35;
            this.lblHeader.Text = "New Call Details";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(34, 74);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(113, 19);
            this.lblEmpName.TabIndex = 36;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(153, 71);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(202, 26);
            this.txtEmpName.TabIndex = 38;
            // 
            // pbAnswer
            // 
            this.pbAnswer.Image = ((System.Drawing.Image)(resources.GetObject("pbAnswer.Image")));
            this.pbAnswer.Location = new System.Drawing.Point(42, 125);
            this.pbAnswer.Name = "pbAnswer";
            this.pbAnswer.Size = new System.Drawing.Size(120, 113);
            this.pbAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnswer.TabIndex = 39;
            this.pbAnswer.TabStop = false;
            this.pbAnswer.Click += new System.EventHandler(this.pbAnswer_Click);
            // 
            // pbHangup
            // 
            this.pbHangup.Image = ((System.Drawing.Image)(resources.GetObject("pbHangup.Image")));
            this.pbHangup.Location = new System.Drawing.Point(235, 125);
            this.pbHangup.Name = "pbHangup";
            this.pbHangup.Size = new System.Drawing.Size(120, 113);
            this.pbHangup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHangup.TabIndex = 40;
            this.pbHangup.TabStop = false;
            this.pbHangup.Click += new System.EventHandler(this.pbHangup_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(120, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 80);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmNewCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 359);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbHangup);
            this.Controls.Add(this.pbAnswer);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCall";
            this.Load += new System.EventHandler(this.frmNewCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.PictureBox pbAnswer;
        private System.Windows.Forms.PictureBox pbHangup;
        private System.Windows.Forms.Button btnBack;
    }
}