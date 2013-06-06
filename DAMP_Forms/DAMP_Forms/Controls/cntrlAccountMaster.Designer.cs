namespace DAMP_Forms.Controls
{
    partial class cntrlAccountMaster
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cntrlButtonBar1 = new DAMP_Forms.Controls.cntrlButtonBar();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.lblErrMsg = new DAMP_Forms.Controls.cntrlErrMessage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.lblErrMsg);
            this.pnlMsg.Location = new System.Drawing.Point(0, 78);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 471);
            this.panel1.TabIndex = 10;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1256, 471);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserDetails.Location = new System.Drawing.Point(589, 10);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(78, 17);
            this.lblUserDetails.TabIndex = 1;
            this.lblUserDetails.Text = "User Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.name,
            this.gender});
            this.dataGridView1.Location = new System.Drawing.Point(132, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(991, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // cntrlAccountMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMsg);
            this.Name = "cntrlAccountMaster";
            this.Size = new System.Drawing.Size(1256, 628);
            this.panel2.ResumeLayout(false);
            this.pnlMsg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private cntrlButtonBar cntrlButtonBar1;
        private System.Windows.Forms.Panel pnlMsg;
        private cntrlErrMessage lblErrMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    }
}
