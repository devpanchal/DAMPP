using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAMP_Forms.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        
        private void accountMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = accountMasterToolStripMenuItem.Text;
        }

        private void transportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = transportMasterToolStripMenuItem.Text;
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = itemMasterToolStripMenuItem.Text;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = salesToolStripMenuItem.Text;
        }

        private void challanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = challanToolStripMenuItem.Text;
        }

        private void freightNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = freightNoteToolStripMenuItem.Text;
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPageName.Text = backUpToolStripMenuItem.Text;
        }
    }
}
