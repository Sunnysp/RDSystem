namespace WindowsFormsApplication4
{
    partial class AdminLandingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryExistingAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAccountByPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "KADMA E.D.B.O";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.paymentEntryToolStripMenuItem,
            this.duePaymentToolStripMenuItem,
            this.clearDueToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(913, 34);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem,
            this.entryExistingAccountToolStripMenuItem,
            this.searchAccountByPMToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 28);
            this.toolStripMenuItem1.Text = "Account Entry";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.newAccountToolStripMenuItem.Text = "New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
            // 
            // entryExistingAccountToolStripMenuItem
            // 
            this.entryExistingAccountToolStripMenuItem.Name = "entryExistingAccountToolStripMenuItem";
            this.entryExistingAccountToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.entryExistingAccountToolStripMenuItem.Text = "Entry Existing Account";
            this.entryExistingAccountToolStripMenuItem.Click += new System.EventHandler(this.entryExistingAccountToolStripMenuItem_Click);
            // 
            // paymentEntryToolStripMenuItem
            // 
            this.paymentEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkPaymentToolStripMenuItem,
            this.entryNewToolStripMenuItem,
            this.fineToolStripMenuItem,
            this.dueToolStripMenuItem});
            this.paymentEntryToolStripMenuItem.Name = "paymentEntryToolStripMenuItem";
            this.paymentEntryToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.paymentEntryToolStripMenuItem.Text = "Payment Entry";
            // 
            // checkPaymentToolStripMenuItem
            // 
            this.checkPaymentToolStripMenuItem.Name = "checkPaymentToolStripMenuItem";
            this.checkPaymentToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.checkPaymentToolStripMenuItem.Text = "Check Payment";
            this.checkPaymentToolStripMenuItem.Click += new System.EventHandler(this.checkPaymentToolStripMenuItem_Click);
            // 
            // entryNewToolStripMenuItem
            // 
            this.entryNewToolStripMenuItem.Name = "entryNewToolStripMenuItem";
            this.entryNewToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.entryNewToolStripMenuItem.Text = "Entry New";
            this.entryNewToolStripMenuItem.Click += new System.EventHandler(this.entryNewToolStripMenuItem_Click);
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.fineToolStripMenuItem.Text = "Fine";
            // 
            // dueToolStripMenuItem
            // 
            this.dueToolStripMenuItem.Name = "dueToolStripMenuItem";
            this.dueToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.dueToolStripMenuItem.Text = "Due Payment";
            // 
            // duePaymentToolStripMenuItem
            // 
            this.duePaymentToolStripMenuItem.Name = "duePaymentToolStripMenuItem";
            this.duePaymentToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.duePaymentToolStripMenuItem.Text = "Due Payment";
            this.duePaymentToolStripMenuItem.Click += new System.EventHandler(this.duePaymentToolStripMenuItem_Click);
            // 
            // clearDueToolStripMenuItem
            // 
            this.clearDueToolStripMenuItem.Name = "clearDueToolStripMenuItem";
            this.clearDueToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.clearDueToolStripMenuItem.Text = "Clear Due";
            this.clearDueToolStripMenuItem.Click += new System.EventHandler(this.clearDueToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // searchAccountByPMToolStripMenuItem
            // 
            this.searchAccountByPMToolStripMenuItem.Name = "searchAccountByPMToolStripMenuItem";
            this.searchAccountByPMToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.searchAccountByPMToolStripMenuItem.Text = "Search Account By PM";
            this.searchAccountByPMToolStripMenuItem.Click += new System.EventHandler(this.searchAccountByPMToolStripMenuItem_Click);
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 509);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminLandingPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryExistingAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAccountByPMToolStripMenuItem;
    }
}