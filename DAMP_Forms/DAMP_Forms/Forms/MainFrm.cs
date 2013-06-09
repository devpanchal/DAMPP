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

                cntrlAccountMaster objAccountMaster = new cntrlAccountMaster();
                pnlDetails.Controls.Clear();
                pnlDetails.Controls.Add(objAccountMaster);
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
                cntrlItemMaster objItemMaster = new cntrlItemMaster();
                pnlDetails.Controls.Clear();
                pnlDetails.Controls.Add(objItemMaster);
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
                cntrlFreightNote objFreightNote = new cntrlFreightNote();
                pnlDetails.Controls.Clear();
                pnlDetails.Controls.Add(objFreightNote);
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
                cntrlRegistration objRegistration = new cntrlRegistration();
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
