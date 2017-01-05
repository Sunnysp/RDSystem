using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Dispose();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEntry ne = new NewEntry();
            
            ne.Show();
            ne.MdiParent = this;
        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAccount ua = new UpdateAccount();
            ua.Show();
            ua.MdiParent = this;
            
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAccount ra = new RemoveAccount();
            ra.Show();
            ra.MdiParent = this;
        }

        private void entryExistingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEntry ne = new NewEntry();
            ne.MdiParent = this;
            ne.Show();
        }

        private void checkPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckPayment cp = new CheckPayment();
            cp.MdiParent = this;
            cp.Show();
        }

        private void entryNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPaymentEntry npe = new NewPaymentEntry();
            npe.MdiParent = this;
            npe.Show();
        }

        private void duePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuePayment dp = new DuePayment();
            dp.MdiParent = this;
            dp.Show();
        }

        private void clearDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDue cd = new ClearDue();
            cd.MdiParent = this;
            cd.Show();
        }

        private void searchAccountByPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchingAccount sa = new SearchingAccount();
            sa.MdiParent = this;
            sa.Show();
        }
    }
}
