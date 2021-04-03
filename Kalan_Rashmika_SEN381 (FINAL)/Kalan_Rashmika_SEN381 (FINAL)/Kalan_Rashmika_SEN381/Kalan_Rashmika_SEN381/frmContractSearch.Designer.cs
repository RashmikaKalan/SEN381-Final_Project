namespace Kalan_Rashmika_SEN381
{
    partial class frmContractSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractSearch));
            this.tbcSearch = new System.Windows.Forms.TabControl();
            this.tbpContractID = new System.Windows.Forms.TabPage();
            this.gbxSearchR = new System.Windows.Forms.GroupBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.rtbContract = new System.Windows.Forms.RichTextBox();
            this.btnBackC = new System.Windows.Forms.Button();
            this.btnSearchCon = new System.Windows.Forms.Button();
            this.txtConID = new System.Windows.Forms.TextBox();
            this.lblConID = new System.Windows.Forms.Label();
            this.tbpClient = new System.Windows.Forms.TabPage();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContracts = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.gbxClientContract = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblConIDC = new System.Windows.Forms.Label();
            this.lblConIDClient = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbcSearch.SuspendLayout();
            this.tbpContractID.SuspendLayout();
            this.gbxSearchR.SuspendLayout();
            this.tbpClient.SuspendLayout();
            this.gbxClientContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSearch
            // 
            this.tbcSearch.Controls.Add(this.tbpContractID);
            this.tbcSearch.Controls.Add(this.tbpClient);
            this.tbcSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSearch.Location = new System.Drawing.Point(13, 13);
            this.tbcSearch.Name = "tbcSearch";
            this.tbcSearch.SelectedIndex = 0;
            this.tbcSearch.Size = new System.Drawing.Size(710, 439);
            this.tbcSearch.TabIndex = 0;
            // 
            // tbpContractID
            // 
            this.tbpContractID.Controls.Add(this.gbxSearchR);
            this.tbpContractID.Controls.Add(this.btnBackC);
            this.tbpContractID.Controls.Add(this.btnSearchCon);
            this.tbpContractID.Controls.Add(this.txtConID);
            this.tbpContractID.Controls.Add(this.lblConID);
            this.tbpContractID.Location = new System.Drawing.Point(4, 28);
            this.tbpContractID.Name = "tbpContractID";
            this.tbpContractID.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContractID.Size = new System.Drawing.Size(702, 407);
            this.tbpContractID.TabIndex = 0;
            this.tbpContractID.Text = "Search By Contract ID";
            this.tbpContractID.UseVisualStyleBackColor = true;
            // 
            // gbxSearchR
            // 
            this.gbxSearchR.Controls.Add(this.lblContract);
            this.gbxSearchR.Controls.Add(this.lblEmployeeName);
            this.gbxSearchR.Controls.Add(this.rtbContract);
            this.gbxSearchR.Location = new System.Drawing.Point(247, 10);
            this.gbxSearchR.Name = "gbxSearchR";
            this.gbxSearchR.Size = new System.Drawing.Size(449, 391);
            this.gbxSearchR.TabIndex = 14;
            this.gbxSearchR.TabStop = false;
            this.gbxSearchR.Text = "Search Result";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblContract.Location = new System.Drawing.Point(212, 34);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(0, 24);
            this.lblContract.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(53, 38);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(145, 19);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "Showing Contract ID: ";
            // 
            // rtbContract
            // 
            this.rtbContract.Location = new System.Drawing.Point(7, 80);
            this.rtbContract.Name = "rtbContract";
            this.rtbContract.Size = new System.Drawing.Size(442, 305);
            this.rtbContract.TabIndex = 0;
            this.rtbContract.Text = "";
            // 
            // btnBackC
            // 
            this.btnBackC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBackC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackC.ForeColor = System.Drawing.Color.White;
            this.btnBackC.Location = new System.Drawing.Point(48, 167);
            this.btnBackC.Name = "btnBackC";
            this.btnBackC.Size = new System.Drawing.Size(122, 59);
            this.btnBackC.TabIndex = 13;
            this.btnBackC.Text = "BACK";
            this.btnBackC.UseVisualStyleBackColor = false;
            // 
            // btnSearchCon
            // 
            this.btnSearchCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearchCon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCon.ForeColor = System.Drawing.Color.White;
            this.btnSearchCon.Location = new System.Drawing.Point(48, 75);
            this.btnSearchCon.Name = "btnSearchCon";
            this.btnSearchCon.Size = new System.Drawing.Size(122, 61);
            this.btnSearchCon.TabIndex = 12;
            this.btnSearchCon.Text = "SEARCH";
            this.btnSearchCon.UseVisualStyleBackColor = false;
            // 
            // txtConID
            // 
            this.txtConID.Location = new System.Drawing.Point(6, 31);
            this.txtConID.Name = "txtConID";
            this.txtConID.Size = new System.Drawing.Size(220, 26);
            this.txtConID.TabIndex = 11;
            // 
            // lblConID
            // 
            this.lblConID.AutoSize = true;
            this.lblConID.Location = new System.Drawing.Point(5, 10);
            this.lblConID.Name = "lblConID";
            this.lblConID.Size = new System.Drawing.Size(82, 19);
            this.lblConID.TabIndex = 10;
            this.lblConID.Text = "Contract ID";
            // 
            // tbpClient
            // 
            this.tbpClient.Controls.Add(this.lblClient);
            this.tbpClient.Controls.Add(this.lblClientName);
            this.tbpClient.Controls.Add(this.label1);
            this.tbpClient.Controls.Add(this.cbContracts);
            this.tbpClient.Controls.Add(this.lblChoose);
            this.tbpClient.Controls.Add(this.gbxClientContract);
            this.tbpClient.Controls.Add(this.btnBack);
            this.tbpClient.Controls.Add(this.btnSearch);
            this.tbpClient.Controls.Add(this.txtIDNum);
            this.tbpClient.Controls.Add(this.lblID);
            this.tbpClient.Location = new System.Drawing.Point(4, 28);
            this.tbpClient.Name = "tbpClient";
            this.tbpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClient.Size = new System.Drawing.Size(702, 407);
            this.tbpClient.TabIndex = 1;
            this.tbpClient.Text = "Search By Client ID Number";
            this.tbpClient.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblClient.Location = new System.Drawing.Point(114, 265);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 24);
            this.lblClient.TabIndex = 21;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(11, 269);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(97, 19);
            this.lblClientName.TabIndex = 20;
            this.lblClientName.Text = "Contracts For:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(431, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 19;
            // 
            // cbContracts
            // 
            this.cbContracts.FormattingEnabled = true;
            this.cbContracts.Location = new System.Drawing.Point(15, 344);
            this.cbContracts.Name = "cbContracts";
            this.cbContracts.Size = new System.Drawing.Size(260, 27);
            this.cbContracts.TabIndex = 17;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(11, 322);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(168, 19);
            this.lblChoose.TabIndex = 16;
            this.lblChoose.Text = "Choose Contract To View";
            // 
            // gbxClientContract
            // 
            this.gbxClientContract.Controls.Add(this.richTextBox1);
            this.gbxClientContract.Controls.Add(this.lblConIDC);
            this.gbxClientContract.Controls.Add(this.lblConIDClient);
            this.gbxClientContract.Location = new System.Drawing.Point(298, 10);
            this.gbxClientContract.Name = "gbxClientContract";
            this.gbxClientContract.Size = new System.Drawing.Size(398, 391);
            this.gbxClientContract.TabIndex = 15;
            this.gbxClientContract.TabStop = false;
            this.gbxClientContract.Text = "Search Result";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(386, 320);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // lblConIDC
            // 
            this.lblConIDC.AutoSize = true;
            this.lblConIDC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConIDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.lblConIDC.Location = new System.Drawing.Point(235, 26);
            this.lblConIDC.Name = "lblConIDC";
            this.lblConIDC.Size = new System.Drawing.Size(0, 24);
            this.lblConIDC.TabIndex = 9;
            // 
            // lblConIDClient
            // 
            this.lblConIDClient.AutoSize = true;
            this.lblConIDClient.Location = new System.Drawing.Point(76, 30);
            this.lblConIDClient.Name = "lblConIDClient";
            this.lblConIDClient.Size = new System.Drawing.Size(145, 19);
            this.lblConIDClient.TabIndex = 8;
            this.lblConIDClient.Text = "Showing Contract ID: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(78, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 59);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(78, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 61);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(15, 33);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(260, 26);
            this.txtIDNum.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 19);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Client ID Number";
            // 
            // frmContractSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 464);
            this.Controls.Add(this.tbcSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContractSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractSearch";
            this.Load += new System.EventHandler(this.frmContractSearch_Load);
            this.tbcSearch.ResumeLayout(false);
            this.tbpContractID.ResumeLayout(false);
            this.tbpContractID.PerformLayout();
            this.gbxSearchR.ResumeLayout(false);
            this.gbxSearchR.PerformLayout();
            this.tbpClient.ResumeLayout(false);
            this.tbpClient.PerformLayout();
            this.gbxClientContract.ResumeLayout(false);
            this.gbxClientContract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSearch;
        private System.Windows.Forms.TabPage tbpContractID;
        private System.Windows.Forms.TabPage tbpClient;
        private System.Windows.Forms.Button btnBackC;
        private System.Windows.Forms.Button btnSearchCon;
        private System.Windows.Forms.TextBox txtConID;
        private System.Windows.Forms.Label lblConID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxSearchR;
        private System.Windows.Forms.RichTextBox rtbContract;
        private System.Windows.Forms.ComboBox cbContracts;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.GroupBox gbxClientContract;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConIDC;
        private System.Windows.Forms.Label lblConIDClient;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}