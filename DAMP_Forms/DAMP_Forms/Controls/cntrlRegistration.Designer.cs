﻿namespace DAMP_Forms
{
    partial class cntrlRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblBirhtday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.cntrlButtonBar1 = new DAMP_Forms.Controls.cntrlButtonBar();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.50424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.49576F));
            this.tableLayoutPanel1.Controls.Add(this.txtUserID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRePassword, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailID, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboGender, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpBirthday, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtContactNo, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblContactNo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBirhtday, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblGender, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRePassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Location = new System.Drawing.Point(223, 17);
            this.txtUserID.MaxLength = 10;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(223, 72);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(266, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(223, 127);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassword.Location = new System.Drawing.Point(223, 182);
            this.txtRePassword.MaxLength = 10;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(121, 20);
            this.txtRePassword.TabIndex = 13;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailID.Location = new System.Drawing.Point(223, 237);
            this.txtEmailID.MaxLength = 10;
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(266, 20);
            this.txtEmailID.TabIndex = 14;
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(223, 292);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 21);
            this.cboGender.TabIndex = 18;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpBirthday.CustomFormat = "dd-MMM-yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(223, 345);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(121, 25);
            this.dtpBirthday.TabIndex = 19;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Location = new System.Drawing.Point(223, 403);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(121, 20);
            this.txtContactNo.TabIndex = 17;
            // 
            // lblContactNo
            // 
            this.lblContactNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContactNo.Location = new System.Drawing.Point(70, 404);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(74, 17);
            this.lblContactNo.TabIndex = 10;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblBirhtday
            // 
            this.lblBirhtday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBirhtday.AutoSize = true;
            this.lblBirhtday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirhtday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBirhtday.Location = new System.Drawing.Point(70, 349);
            this.lblBirhtday.Name = "lblBirhtday";
            this.lblBirhtday.Size = new System.Drawing.Size(55, 17);
            this.lblBirhtday.TabIndex = 3;
            this.lblBirhtday.Text = "Birthday";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.Location = new System.Drawing.Point(70, 294);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 17);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(70, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email ID";
            // 
            // lblRePassword
            // 
            this.lblRePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRePassword.Location = new System.Drawing.Point(70, 184);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(84, 17);
            this.lblRePassword.TabIndex = 6;
            this.lblRePassword.Text = "Re-Password";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(70, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(70, 74);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserID.Location = new System.Drawing.Point(70, 19);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 17);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(626, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 441);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUserDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.623931F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.37607F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(627, 440);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserDetails.Location = new System.Drawing.Point(274, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(78, 17);
            this.lblUserDetails.TabIndex = 1;
            this.lblUserDetails.Text = "User Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPageName);
            this.panel2.Controls.Add(this.cntrlButtonBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 34);
            this.panel2.TabIndex = 2;
            // 
            // lblPageName
            // 
            this.lblPageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageName.AutoSize = true;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.Location = new System.Drawing.Point(628, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPageName.Size = new System.Drawing.Size(0, 21);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cntrlButtonBar1
            // 
            this.cntrlButtonBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cntrlButtonBar1.Location = new System.Drawing.Point(869, 0);
            this.cntrlButtonBar1.Name = "cntrlButtonBar1";
            this.cntrlButtonBar1.Size = new System.Drawing.Size(387, 34);
            this.cntrlButtonBar1.TabIndex = 1;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMsg.Location = new System.Drawing.Point(0, 34);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(1256, 34);
            this.pnlMsg.TabIndex = 4;
            // 
            // cntrlRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cntrlRegistration";
            this.Size = new System.Drawing.Size(1256, 522);
            this.Load += new System.EventHandler(this.cntrlRegistration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBirhtday;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPageName;
        private Controls.cntrlButtonBar cntrlButtonBar1;
        private System.Windows.Forms.Panel pnlMsg;
    }
}
