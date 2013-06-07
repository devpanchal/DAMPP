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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }


        private void accountMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = accountMasterToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }


        private void transportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = transportMasterToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = itemMasterToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = salesToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void challanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = challanToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void freightNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = freightNoteToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPageName.Text = userRegistrationToolStripMenuItem.Text;
                cntrlRegistration objRegistration = new cntrlRegistration();
                objRegistration.regPageName = userRegistrationToolStripMenuItem.Text;
                pnlDetails.Controls.Clear();
                pnlDetails.Controls.Add(objRegistration);
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

    }
}
