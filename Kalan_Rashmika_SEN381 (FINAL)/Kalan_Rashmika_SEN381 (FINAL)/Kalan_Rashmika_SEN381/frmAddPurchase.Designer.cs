namespace Kalan_Rashmika_SEN381
{
    partial class frmAddPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPurchase));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbSystem = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbController = new System.Windows.Forms.CheckBox();
            this.cbActor = new System.Windows.Forms.CheckBox();
            this.cbSensor = new System.Windows.Forms.CheckBox();
            this.nudController = new System.Windows.Forms.NumericUpDown();
            this.nudActor = new System.Windows.Forms.NumericUpDown();
            this.nudSensor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(300, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(169, 31);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "New Purchase";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(408, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(339, 26);
            this.txtID.TabIndex = 23;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(404, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 19);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Client ID Number";
            // 
            // cbSystem
            // 
            this.cbSystem.BackColor = System.Drawing.Color.White;
            this.cbSystem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSystem.FormattingEnabled = true;
            this.cbSystem.Location = new System.Drawing.Point(408, 138);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(339, 27);
            this.cbSystem.TabIndex = 25;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(404, 116);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(104, 19);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "Choose System";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(404, 179);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(130, 19);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Product Description";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(404, 201);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(339, 107);
            this.rtbDesc.TabIndex = 27;
            this.rtbDesc.Text = "";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(400, 465);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(147, 19);
            this.lblCost.TabIndex = 28;
            this.lblCost.Text = "System CostPerMonth";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(434, 487);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(309, 26);
            this.txtCost.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 67);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnAddPurchase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.Location = new System.Drawing.Point(603, 522);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(144, 67);
            this.btnAddPurchase.TabIndex = 30;
            this.btnAddPurchase.Text = "ADD PURCHASE";
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(405, 490);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(19, 19);
            this.lblR.TabIndex = 32;
            this.lblR.Text = "R";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 160);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(361, 258);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 33;
            this.pbxLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbController);
            this.groupBox1.Controls.Add(this.cbActor);
            this.groupBox1.Controls.Add(this.cbSensor);
            this.groupBox1.Controls.Add(this.nudController);
            this.groupBox1.Controls.Add(this.nudActor);
            this.groupBox1.Controls.Add(this.nudSensor);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 137);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ons";
            // 
            // cbController
            // 
            this.cbController.AutoSize = true;
            this.cbController.Location = new System.Drawing.Point(7, 106);
            this.cbController.Name = "cbController";
            this.cbController.Size = new System.Drawing.Size(89, 23);
            this.cbController.TabIndex = 8;
            this.cbController.Text = "Controller";
            this.cbController.UseVisualStyleBackColor = true;
            // 
            // cbActor
            // 
            this.cbActor.AutoSize = true;
            this.cbActor.Location = new System.Drawing.Point(7, 69);
            this.cbActor.Name = "cbActor";
            this.cbActor.Size = new System.Drawing.Size(63, 23);
            this.cbActor.TabIndex = 7;
            this.cbActor.Text = "Actor";
            this.cbActor.UseVisualStyleBackColor = true;
            // 
            // cbSensor
            // 
            this.cbSensor.AutoSize = true;
            this.cbSensor.Location = new System.Drawing.Point(6, 29);
            this.cbSensor.Name = "cbSensor";
            this.cbSensor.Size = new System.Drawing.Size(70, 23);
            this.cbSensor.TabIndex = 6;
            this.cbSensor.Text = "Sensor";
            this.cbSensor.UseVisualStyleBackColor = true;
            // 
            // nudController
            // 
            this.nudController.Location = new System.Drawing.Point(213, 105);
            this.nudController.Name = "nudController";
            this.nudController.Size = new System.Drawing.Size(120, 26);
            this.nudController.TabIndex = 5;
            // 
            // nudActor
            // 
            this.nudActor.Location = new System.Drawing.Point(213, 68);
            this.nudActor.Name = "nudActor";
            this.nudActor.Size = new System.Drawing.Size(120, 26);
            this.nudActor.TabIndex = 4;
            // 
            // nudSensor
            // 
            this.nudSensor.Location = new System.Drawing.Point(213, 26);
            this.nudSensor.Name = "nudSensor";
            this.nudSensor.Size = new System.Drawing.Size(120, 26);
            this.nudSensor.TabIndex = 3;
            // 
            // frmAddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddPurchase);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cbSystem);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPurchase";
            this.Load += new System.EventHandler(this.frmAddPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbSystem;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudController;
        private System.Windows.Forms.NumericUpDown nudActor;
        private System.Windows.Forms.NumericUpDown nudSensor;
        private System.Windows.Forms.CheckBox cbController;
        private System.Windows.Forms.CheckBox cbActor;
        private System.Windows.Forms.CheckBox cbSensor;
    }
}