namespace DAMP_Forms.Controls
{
    partial class cntrlFreightNote
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
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dtpCurDate = new System.Windows.Forms.DateTimePicker();
            this.lblFreight_Date = new System.Windows.Forms.Label();
            this.lblCurDate = new System.Windows.Forms.Label();
            this.lblFreightDesc = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblTruckNo = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.txtFreightDesc = new System.Windows.Forms.TextBox();
            this.dtpFreightdate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cntrlButtonBar1 = new DAMP_Forms.Controls.cntrlButtonBar();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.lblErrMsg = new DAMP_Forms.Controls.cntrlErrMessage();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.50424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.49576F));
            this.tableLayoutPanel1.Controls.Add(this.txtBillNo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountNo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTruckNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFreight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpCurDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFreight_Date, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCurDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFreightDesc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFreight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTruckNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAccountNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBillNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFreightDesc, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpFreightdate, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 386);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBillNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillNo.Location = new System.Drawing.Point(223, 17);
            this.txtBillNo.MaxLength = 15;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(138, 20);
            this.txtBillNo.TabIndex = 11;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNo.Location = new System.Drawing.Point(223, 72);
            this.txtAccountNo.MaxLength = 10;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(138, 20);
            this.txtAccountNo.TabIndex = 12;
            this.txtAccountNo.UseSystemPasswordChar = true;
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTruckNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTruckNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTruckNo.Location = new System.Drawing.Point(223, 127);
            this.txtTruckNo.MaxLength = 10;
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(138, 20);
            this.txtTruckNo.TabIndex = 13;
            this.txtTruckNo.UseSystemPasswordChar = true;
            // 
            // txtFreight
            // 
            this.txtFreight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFreight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreight.Location = new System.Drawing.Point(223, 182);
            this.txtFreight.MaxLength = 11;
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(138, 20);
            this.txtFreight.TabIndex = 14;
            // 
            // dtpCurDate
            // 
            this.dtpCurDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpCurDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCurDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCurDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCurDate.Location = new System.Drawing.Point(223, 290);
            this.dtpCurDate.Name = "dtpCurDate";
            this.dtpCurDate.Size = new System.Drawing.Size(121, 25);
            this.dtpCurDate.TabIndex = 19;
            this.dtpCurDate.Value = new System.DateTime(2013, 6, 8, 0, 0, 0, 0);
            // 
            // lblFreight_Date
            // 
            this.lblFreight_Date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFreight_Date.AutoSize = true;
            this.lblFreight_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreight_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFreight_Date.Location = new System.Drawing.Point(70, 349);
            this.lblFreight_Date.Name = "lblFreight_Date";
            this.lblFreight_Date.Size = new System.Drawing.Size(80, 17);
            this.lblFreight_Date.TabIndex = 10;
            this.lblFreight_Date.Text = "Freight_Date";
            // 
            // lblCurDate
            // 
            this.lblCurDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurDate.AutoSize = true;
            this.lblCurDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurDate.Location = new System.Drawing.Point(70, 294);
            this.lblCurDate.Name = "lblCurDate";
            this.lblCurDate.Size = new System.Drawing.Size(83, 17);
            this.lblCurDate.TabIndex = 3;
            this.lblCurDate.Text = "Current_Date";
            // 
            // lblFreightDesc
            // 
            this.lblFreightDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFreightDesc.AutoSize = true;
            this.lblFreightDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreightDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFreightDesc.Location = new System.Drawing.Point(70, 239);
            this.lblFreightDesc.Name = "lblFreightDesc";
            this.lblFreightDesc.Size = new System.Drawing.Size(118, 17);
            this.lblFreightDesc.TabIndex = 7;
            this.lblFreightDesc.Text = "Freight Description";
            // 
            // lblFreight
            // 
            this.lblFreight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFreight.AutoSize = true;
            this.lblFreight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFreight.Location = new System.Drawing.Point(70, 184);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(48, 17);
            this.lblFreight.TabIndex = 5;
            this.lblFreight.Text = "Freight";
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTruckNo.AutoSize = true;
            this.lblTruckNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTruckNo.Location = new System.Drawing.Point(70, 129);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(64, 17);
            this.lblTruckNo.TabIndex = 6;
            this.lblTruckNo.Text = "Truck No.";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountNo.Location = new System.Drawing.Point(70, 74);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(79, 17);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "Account No.";
            // 
            // lblBillNo
            // 
            this.lblBillNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBillNo.Location = new System.Drawing.Point(70, 19);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(49, 17);
            this.lblBillNo.TabIndex = 2;
            this.lblBillNo.Text = "Bill No.";
            // 
            // txtFreightDesc
            // 
            this.txtFreightDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFreightDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreightDesc.Location = new System.Drawing.Point(223, 223);
            this.txtFreightDesc.MaxLength = 200;
            this.txtFreightDesc.Multiline = true;
            this.txtFreightDesc.Name = "txtFreightDesc";
            this.txtFreightDesc.Size = new System.Drawing.Size(237, 49);
            this.txtFreightDesc.TabIndex = 20;
            // 
            // dtpFreightdate
            // 
            this.dtpFreightdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFreightdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFreightdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFreightdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFreightdate.Location = new System.Drawing.Point(223, 345);
            this.dtpFreightdate.Name = "dtpFreightdate";
            this.dtpFreightdate.Size = new System.Drawing.Size(121, 25);
            this.dtpFreightdate.TabIndex = 21;
            this.dtpFreightdate.Value = new System.DateTime(2013, 6, 8, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cntrlButtonBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 35);
            this.panel2.TabIndex = 8;
            // 
            // cntrlButtonBar1
            // 
            this.cntrlButtonBar1.BackColor = System.Drawing.Color.White;
            this.cntrlButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlButtonBar1.Location = new System.Drawing.Point(0, 0);
            this.cntrlButtonBar1.Margin = new System.Windows.Forms.Padding(0);
            this.cntrlButtonBar1.Name = "cntrlButtonBar1";
            this.cntrlButtonBar1.PageName = "PageName";
            this.cntrlButtonBar1.Size = new System.Drawing.Size(1256, 35);
            this.cntrlButtonBar1.TabIndex = 0;
            this.cntrlButtonBar1.VisibleCloseBtn = true;
            this.cntrlButtonBar1.VisibleDeleteBtn = true;
            this.cntrlButtonBar1.VisibleEditBtn = true;
            this.cntrlButtonBar1.VisibleListBtn = true;
            this.cntrlButtonBar1.VisibleNewBtn = true;
            this.cntrlButtonBar1.VisibleSaveBtn = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.lblErrMsg);
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMsg.Location = new System.Drawing.Point(0, 35);
            this.pnlMsg.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(1256, 34);
            this.pnlMsg.TabIndex = 9;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Location = new System.Drawing.Point(41, 6);
            this.lblErrMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(1169, 22);
            this.lblErrMsg.TabIndex = 0;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            this.tableLayoutPanel3.Controls.Add(this.txtRefNo, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblRefNo, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(626, 51);
            this.tableLayoutPanel3.TabIndex = 10;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRefNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Location = new System.Drawing.Point(223, 15);
            this.txtRefNo.MaxLength = 10;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(121, 20);
            this.txtRefNo.TabIndex = 1;
            // 
            // lblRefNo
            // 
            this.lblRefNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefNo.Location = new System.Drawing.Point(70, 17);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(52, 17);
            this.lblRefNo.TabIndex = 0;
            this.lblRefNo.Text = "Ref No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.name,
            this.gender});
            this.dataGridView1.Location = new System.Drawing.Point(111, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(408, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(626, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 471);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblUserDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 471);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserDetails.Location = new System.Drawing.Point(276, 10);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(78, 17);
            this.lblUserDetails.TabIndex = 1;
            this.lblUserDetails.Text = "User Details";
            // 
            // cntrlFreightNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Name = "cntrlFreightNote";
            this.Size = new System.Drawing.Size(1256, 628);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMsg.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.DateTimePicker dtpCurDate;
        private System.Windows.Forms.Label lblFreight_Date;
        private System.Windows.Forms.Label lblCurDate;
        private System.Windows.Forms.Label lblFreightDesc;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Panel panel2;
        private cntrlButtonBar cntrlButtonBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel pnlMsg;
        private cntrlErrMessage lblErrMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label lblRefNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.TextBox txtFreightDesc;
        private System.Windows.Forms.DateTimePicker dtpFreightdate;


    }
}
