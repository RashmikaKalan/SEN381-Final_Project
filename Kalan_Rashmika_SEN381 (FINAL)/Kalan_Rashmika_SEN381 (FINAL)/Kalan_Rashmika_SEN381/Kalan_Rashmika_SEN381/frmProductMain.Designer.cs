namespace Kalan_Rashmika_SEN381
{
    partial class frmProductMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductMain));
            this.mnsProduct = new System.Windows.Forms.MenuStrip();
            this.searchForProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbcProducts = new System.Windows.Forms.TabControl();
            this.tbPoducts = new System.Windows.Forms.TabPage();
            this.dtpVersion = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblVersionDate = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbAddOns = new System.Windows.Forms.TabPage();
            this.btnNextAdd = new System.Windows.Forms.Button();
            this.btnPrevAdd = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.rtbAddDesc = new System.Windows.Forms.RichTextBox();
            this.lblAddDesc = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddID = new System.Windows.Forms.Label();
            this.pbProgrss = new System.Windows.Forms.ProgressBar();
            this.bgwProgress = new System.ComponentModel.BackgroundWorker();
            this.txtManufacture = new System.Windows.Forms.TextBox();
            this.lblManufacture = new System.Windows.Forms.Label();
            this.txtManA = new System.Windows.Forms.TextBox();
            this.lblManufactureA = new System.Windows.Forms.Label();
            this.mnsProduct.SuspendLayout();
            this.tbcProducts.SuspendLayout();
            this.tbPoducts.SuspendLayout();
            this.tbAddOns.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsProduct
            // 
            this.mnsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForProductToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.updateExistingProductToolStripMenuItem,
            this.removeProductToolStripMenuItem});
            this.mnsProduct.Location = new System.Drawing.Point(0, 0);
            this.mnsProduct.Name = "mnsProduct";
            this.mnsProduct.Size = new System.Drawing.Size(682, 24);
            this.mnsProduct.TabIndex = 0;
            this.mnsProduct.Text = "menuStrip1";
            // 
            // searchForProductToolStripMenuItem
            // 
            this.searchForProductToolStripMenuItem.Name = "searchForProductToolStripMenuItem";
            this.searchForProductToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.searchForProductToolStripMenuItem.Text = "Search ";
            this.searchForProductToolStripMenuItem.Click += new System.EventHandler(this.searchForProductToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // updateExistingProductToolStripMenuItem
            // 
            this.updateExistingProductToolStripMenuItem.Name = "updateExistingProductToolStripMenuItem";
            this.updateExistingProductToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.updateExistingProductToolStripMenuItem.Text = "Update Existing Product";
            this.updateExistingProductToolStripMenuItem.Click += new System.EventHandler(this.updateExistingProductToolStripMenuItem_Click);
            // 
            // removeProductToolStripMenuItem
            // 
            this.removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            this.removeProductToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.removeProductToolStripMenuItem.Text = "Remove Product";
            this.removeProductToolStripMenuItem.Click += new System.EventHandler(this.removeProductToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(271, 436);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 67);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbcProducts
            // 
            this.tbcProducts.Controls.Add(this.tbPoducts);
            this.tbcProducts.Controls.Add(this.tbAddOns);
            this.tbcProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcProducts.Location = new System.Drawing.Point(13, 46);
            this.tbcProducts.Name = "tbcProducts";
            this.tbcProducts.SelectedIndex = 0;
            this.tbcProducts.Size = new System.Drawing.Size(657, 356);
            this.tbcProducts.TabIndex = 10;
            // 
            // tbPoducts
            // 
            this.tbPoducts.Controls.Add(this.txtManufacture);
            this.tbPoducts.Controls.Add(this.lblManufacture);
            this.tbPoducts.Controls.Add(this.dtpVersion);
            this.tbPoducts.Controls.Add(this.btnNext);
            this.tbPoducts.Controls.Add(this.btnPrev);
            this.tbPoducts.Controls.Add(this.lblR);
            this.tbPoducts.Controls.Add(this.lblVersionDate);
            this.tbPoducts.Controls.Add(this.txtVersion);
            this.tbPoducts.Controls.Add(this.lblVersion);
            this.tbPoducts.Controls.Add(this.txtCost);
            this.tbPoducts.Controls.Add(this.lblCost);
            this.tbPoducts.Controls.Add(this.txtID);
            this.tbPoducts.Controls.Add(this.rtbDescription);
            this.tbPoducts.Controls.Add(this.lblDesc);
            this.tbPoducts.Controls.Add(this.txtName);
            this.tbPoducts.Controls.Add(this.lblName);
            this.tbPoducts.Controls.Add(this.lblID);
            this.tbPoducts.Location = new System.Drawing.Point(4, 28);
            this.tbPoducts.Name = "tbPoducts";
            this.tbPoducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbPoducts.Size = new System.Drawing.Size(649, 324);
            this.tbPoducts.TabIndex = 0;
            this.tbPoducts.Text = "View All Products";
            this.tbPoducts.UseVisualStyleBackColor = true;
            // 
            // dtpVersion
            // 
            this.dtpVersion.Location = new System.Drawing.Point(393, 225);
            this.dtpVersion.Name = "dtpVersion";
            this.dtpVersion.Size = new System.Drawing.Size(248, 26);
            this.dtpVersion.TabIndex = 54;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(472, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 33);
            this.btnNext.TabIndex = 53;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(110, 283);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(91, 33);
            this.btnPrev.TabIndex = 52;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(8, 243);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(19, 19);
            this.lblR.TabIndex = 51;
            this.lblR.Text = "R";
            // 
            // lblVersionDate
            // 
            this.lblVersionDate.AutoSize = true;
            this.lblVersionDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionDate.Location = new System.Drawing.Point(389, 199);
            this.lblVersionDate.Name = "lblVersionDate";
            this.lblVersionDate.Size = new System.Drawing.Size(188, 19);
            this.lblVersionDate.TabIndex = 49;
            this.lblVersionDate.Text = "Current Version Release Date";
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(393, 155);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(248, 26);
            this.txtVersion.TabIndex = 48;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(389, 133);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(104, 19);
            this.lblVersion.TabIndex = 47;
            this.lblVersion.Text = "Current Version";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(33, 240);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(227, 26);
            this.txtCost.TabIndex = 46;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(8, 218);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(107, 19);
            this.lblCost.TabIndex = 45;
            this.lblCost.Text = "Cost Per Month";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(281, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(88, 26);
            this.txtID.TabIndex = 44;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 155);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(248, 50);
            this.rtbDescription.TabIndex = 43;
            this.rtbDescription.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(8, 133);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 19);
            this.lblDesc.TabIndex = 42;
            this.lblDesc.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 26);
            this.txtName.TabIndex = 41;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 19);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Product Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(277, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 19);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "Product ID";
            // 
            // tbAddOns
            // 
            this.tbAddOns.Controls.Add(this.txtManA);
            this.tbAddOns.Controls.Add(this.lblManufactureA);
            this.tbAddOns.Controls.Add(this.btnNextAdd);
            this.tbAddOns.Controls.Add(this.btnPrevAdd);
            this.tbAddOns.Controls.Add(this.lblCurrency);
            this.tbAddOns.Controls.Add(this.txtAddCost);
            this.tbAddOns.Controls.Add(this.lblAddCost);
            this.tbAddOns.Controls.Add(this.txtAddID);
            this.tbAddOns.Controls.Add(this.rtbAddDesc);
            this.tbAddOns.Controls.Add(this.lblAddDesc);
            this.tbAddOns.Controls.Add(this.txtAddName);
            this.tbAddOns.Controls.Add(this.lblAddName);
            this.tbAddOns.Controls.Add(this.lblAddID);
            this.tbAddOns.Location = new System.Drawing.Point(4, 28);
            this.tbAddOns.Name = "tbAddOns";
            this.tbAddOns.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddOns.Size = new System.Drawing.Size(649, 324);
            this.tbAddOns.TabIndex = 1;
            this.tbAddOns.Text = "View All Add Ons";
            this.tbAddOns.UseVisualStyleBackColor = true;
            this.tbAddOns.Click += new System.EventHandler(this.tbAddOns_Click);
            // 
            // btnNextAdd
            // 
            this.btnNextAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnNextAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAdd.ForeColor = System.Drawing.Color.White;
            this.btnNextAdd.Location = new System.Drawing.Point(467, 258);
            this.btnNextAdd.Name = "btnNextAdd";
            this.btnNextAdd.Size = new System.Drawing.Size(91, 33);
            this.btnNextAdd.TabIndex = 56;
            this.btnNextAdd.Text = ">>";
            this.btnNextAdd.UseVisualStyleBackColor = false;
            this.btnNextAdd.Click += new System.EventHandler(this.btnNextAdd_Click);
            // 
            // btnPrevAdd
            // 
            this.btnPrevAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))));
            this.btnPrevAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevAdd.ForeColor = System.Drawing.Color.White;
            this.btnPrevAdd.Location = new System.Drawing.Point(105, 258);
            this.btnPrevAdd.Name = "btnPrevAdd";
            this.btnPrevAdd.Size = new System.Drawing.Size(91, 33);
            this.btnPrevAdd.TabIndex = 55;
            this.btnPrevAdd.Text = "<<";
            this.btnPrevAdd.UseVisualStyleBackColor = false;
            this.btnPrevAdd.Click += new System.EventHandler(this.btnPrevAdd_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(376, 89);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(19, 19);
            this.lblCurrency.TabIndex = 54;
            this.lblCurrency.Text = "R";
            // 
            // txtAddCost
            // 
            this.txtAddCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCost.Location = new System.Drawing.Point(401, 86);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(227, 26);
            this.txtAddCost.TabIndex = 53;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCost.Location = new System.Drawing.Point(376, 64);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(107, 19);
            this.lblAddCost.TabIndex = 52;
            this.lblAddCost.Text = "Cost Per Month";
            // 
            // txtAddID
            // 
            this.txtAddID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddID.Location = new System.Drawing.Point(281, 30);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(88, 26);
            this.txtAddID.TabIndex = 50;
            // 
            // rtbAddDesc
            // 
            this.rtbAddDesc.Location = new System.Drawing.Point(10, 143);
            this.rtbAddDesc.Name = "rtbAddDesc";
            this.rtbAddDesc.Size = new System.Drawing.Size(248, 96);
            this.rtbAddDesc.TabIndex = 49;
            this.rtbAddDesc.Text = "";
            // 
            // lblAddDesc
            // 
            this.lblAddDesc.AutoSize = true;
            this.lblAddDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc.Location = new System.Drawing.Point(6, 121);
            this.lblAddDesc.Name = "lblAddDesc";
            this.lblAddDesc.Size = new System.Drawing.Size(78, 19);
            this.lblAddDesc.TabIndex = 48;
            this.lblAddDesc.Text = "Description";
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(10, 86);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(248, 26);
            this.txtAddName.TabIndex = 47;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(6, 64);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(98, 19);
            this.lblAddName.TabIndex = 46;
            this.lblAddName.Text = "Product Name";
            // 
            // lblAddID
            // 
            this.lblAddID.AutoSize = true;
            this.lblAddID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddID.Location = new System.Drawing.Point(277, 8);
            this.lblAddID.Name = "lblAddID";
            this.lblAddID.Size = new System.Drawing.Size(77, 19);
            this.lblAddID.TabIndex = 45;
            this.lblAddID.Text = "Product ID";
            // 
            // pbProgrss
            // 
            this.pbProgrss.Location = new System.Drawing.Point(16, 407);
            this.pbProgrss.Name = "pbProgrss";
            this.pbProgrss.Size = new System.Drawing.Size(649, 19);
            this.pbProgrss.TabIndex = 11;
            // 
            // bgwProgress
            // 
            this.bgwProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProgress_DoWork);
            this.bgwProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwProgress_ProgressChanged);
            this.bgwProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProgress_RunWorkerCompleted);
            // 
            // txtManufacture
            // 
            this.txtManufacture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacture.Location = new System.Drawing.Point(395, 92);
            this.txtManufacture.Name = "txtManufacture";
            this.txtManufacture.Size = new System.Drawing.Size(248, 26);
            this.txtManufacture.TabIndex = 56;
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacture.Location = new System.Drawing.Point(391, 70);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(93, 19);
            this.lblManufacture.TabIndex = 55;
            this.lblManufacture.Text = "Manufacturer:";
            // 
            // txtManA
            // 
            this.txtManA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManA.Location = new System.Drawing.Point(380, 153);
            this.txtManA.Name = "txtManA";
            this.txtManA.Size = new System.Drawing.Size(248, 26);
            this.txtManA.TabIndex = 58;
            // 
            // lblManufactureA
            // 
            this.lblManufactureA.AutoSize = true;
            this.lblManufactureA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureA.Location = new System.Drawing.Point(376, 131);
            this.lblManufactureA.Name = "lblManufactureA";
            this.lblManufactureA.Size = new System.Drawing.Size(93, 19);
            this.lblManufactureA.TabIndex = 57;
            this.lblManufactureA.Text = "Manufacturer:";
            // 
            // frmProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 512);
            this.Controls.Add(this.pbProgrss);
            this.Controls.Add(this.tbcProducts);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.mnsProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsProduct;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagementDepartment";
            this.Load += new System.EventHandler(this.frmProductMain_Load);
            this.mnsProduct.ResumeLayout(false);
            this.mnsProduct.PerformLayout();
            this.tbcProducts.ResumeLayout(false);
            this.tbPoducts.ResumeLayout(false);
            this.tbPoducts.PerformLayout();
            this.tbAddOns.ResumeLayout(false);
            this.tbAddOns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsProduct;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem searchForProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProductToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcProducts;
        private System.Windows.Forms.TabPage tbPoducts;
        private System.Windows.Forms.TabPage tbAddOns;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblVersionDate;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.RichTextBox rtbAddDesc;
        private System.Windows.Forms.Label lblAddDesc;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddID;
        private System.Windows.Forms.Button btnNextAdd;
        private System.Windows.Forms.Button btnPrevAdd;
        private System.Windows.Forms.DateTimePicker dtpVersion;
        private System.Windows.Forms.ProgressBar pbProgrss;
        private System.ComponentModel.BackgroundWorker bgwProgress;
        private System.Windows.Forms.TextBox txtManufacture;
        private System.Windows.Forms.Label lblManufacture;
        private System.Windows.Forms.TextBox txtManA;
        private System.Windows.Forms.Label lblManufactureA;
    }
}