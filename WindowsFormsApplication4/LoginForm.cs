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
    public partial class LoginForm : Form
    {
        int i = 0;
        int flag = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Administrator" && textBox2.Text == "adminrdedbo123")
            {
                for (i = 0; i <= 100; i++)
                {

                    progressBar1.Value = i;
                    label6.Refresh();

                    label6.Text = "continuing...";

                    System.Threading.Thread.Sleep(20);

                }
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    MessageBox.Show("Login Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show("Redirecting to Administration.....");
                    AdminLandingPage alp = new AdminLandingPage();
                    alp.Show();
                    this.Hide();
                }

                else MessageBox.Show("Error in loading page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("User Id Field Empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.ResetText();
                textBox2.ResetText();
                flag++;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password Field Empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.ResetText();
                textBox2.ResetText();
                flag++;
            }
            else if (textBox1.Text != "KADMAPO" && textBox2.Text != "kedbotpp")
            {
                MessageBox.Show("Invalid User Id Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.ResetText();
                textBox2.ResetText();
                flag++;
            }
            else
            {
                MessageBox.Show("User Id And Password Both Field Are Empty");
                flag++;
            }
            if(flag==3)
            {
                MessageBox.Show("You Have Crossed Your Maximum Login Limit");
                Application.Restart();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
