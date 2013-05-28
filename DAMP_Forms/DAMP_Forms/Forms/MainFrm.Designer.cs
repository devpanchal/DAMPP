namespace DAMP_Forms.Forms
{
    partial class MainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freightNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogoMain = new System.Windows.Forms.Panel();
            this.pnlLogoSettings = new System.Windows.Forms.Panel();
            this.pnlLogoName = new System.Windows.Forms.Panel();
            this.lblDAMPName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlLogoMain.SuspendLayout();
            this.pnlLogoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.utilityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMasterToolStripMenuItem,
            this.transportMasterToolStripMenuItem,
            this.itemMasterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 25);
            this.toolStripMenuItem1.Text = "Master";
            // 
            // accountMasterToolStripMenuItem
            // 
            this.accountMasterToolStripMenuItem.Image = global::DAMP_Forms.Properties.Resources.Account_Icon;
            this.accountMasterToolStripMenuItem.Name = "accountMasterToolStripMenuItem";
            this.accountMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.accountMasterToolStripMenuItem.Text = "Account Master";
            this.accountMasterToolStripMenuItem.Click += new System.EventHandler(this.accountMasterToolStripMenuItem_Click);
            // 
            // transportMasterToolStripMenuItem
            // 
            this.transportMasterToolStripMenuItem.Image = global::DAMP_Forms.Properties.Resources.Transport_Icon1;
            this.transportMasterToolStripMenuItem.Name = "transportMasterToolStripMenuItem";
            this.transportMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.transportMasterToolStripMenuItem.Text = "Transport Master";
            this.transportMasterToolStripMenuItem.Click += new System.EventHandler(this.transportMasterToolStripMenuItem_Click);
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Image = global::DAMP_Forms.Properties.Resources.Item_Icon;
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.challanToolStripMenuItem,
            this.freightNoteToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // challanToolStripMenuItem
            // 
            this.challanToolStripMenuItem.Name = "challanToolStripMenuItem";
            this.challanToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.challanToolStripMenuItem.Text = "Challan";
            this.challanToolStripMenuItem.Click += new System.EventHandler(this.challanToolStripMenuItem_Click);
            // 
            // freightNoteToolStripMenuItem
            // 
            this.freightNoteToolStripMenuItem.Name = "freightNoteToolStripMenuItem";
            this.freightNoteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.freightNoteToolStripMenuItem.Text = "Freight Note";
            this.freightNoteToolStripMenuItem.Click += new System.EventHandler(this.freightNoteToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem,
            this.backUpToolStripMenuItem1});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.userRegistrationToolStripMenuItem.Text = "User Registration";
            this.userRegistrationToolStripMenuItem.Click += new System.EventHandler(this.userRegistrationToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem1
            // 
            this.backUpToolStripMenuItem1.Name = "backUpToolStripMenuItem1";
            this.backUpToolStripMenuItem1.Size = new System.Drawing.Size(200, 26);
            this.backUpToolStripMenuItem1.Text = "Back Up";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlLogoMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnlDetails, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 678);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlLogoMain
            // 
            this.pnlLogoMain.Controls.Add(this.pnlLogoSettings);
            this.pnlLogoMain.Controls.Add(this.pnlLogoName);
            this.pnlLogoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogoMain.Location = new System.Drawing.Point(3, 3);
            this.pnlLogoMain.Name = "pnlLogoMain";
            this.pnlLogoMain.Size = new System.Drawing.Size(1256, 61);
            this.pnlLogoMain.TabIndex = 1;
            // 
            // pnlLogoSettings
            // 
            this.pnlLogoSettings.BackColor = System.Drawing.Color.White;
            this.pnlLogoSettings.Location = new System.Drawing.Point(950, 2);
            this.pnlLogoSettings.Name = "pnlLogoSettings";
            this.pnlLogoSettings.Size = new System.Drawing.Size(304, 59);
            this.pnlLogoSettings.TabIndex = 1;
            // 
            // pnlLogoName
            // 
            this.pnlLogoName.BackColor = System.Drawing.Color.White;
            this.pnlLogoName.Controls.Add(this.lblDAMPName);
            this.pnlLogoName.Controls.Add(this.picLogo);
            this.pnlLogoName.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoName.Name = "pnlLogoName";
            this.pnlLogoName.Size = new System.Drawing.Size(950, 61);
            this.pnlLogoName.TabIndex = 0;
            // 
            // lblDAMPName
            // 
            this.lblDAMPName.AutoSize = true;
            this.lblDAMPName.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAMPName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDAMPName.Location = new System.Drawing.Point(67, 2);
            this.lblDAMPName.Name = "lblDAMPName";
            this.lblDAMPName.Size = new System.Drawing.Size(394, 55);
            this.lblDAMPName.TabIndex = 1;
            this.lblDAMPName.Text = "DAMP Softwares Ltd";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::DAMP_Forms.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(61, 61);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 638);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1256, 37);
            this.pnlBottom.TabIndex = 4;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(3, 110);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1256, 522);
            this.pnlDetails.TabIndex = 5;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlLogoMain.ResumeLayout(false);
            this.pnlLogoName.ResumeLayout(false);
            this.pnlLogoName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freightNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlLogoMain;
        private System.Windows.Forms.Panel pnlLogoName;
        private System.Windows.Forms.Panel pnlLogoSettings;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDAMPName;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem1;


    }
}