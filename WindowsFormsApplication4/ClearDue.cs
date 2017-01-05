using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.BL_CLASSES;

namespace WindowsFormsApplication4
{
    public partial class ClearDue : Form
    {
        LogicClass lc = new LogicClass();
        public ClearDue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cleardue = "";
            cleardue = lc.GetDueStatus(textBox1.Text);
            if (cleardue == "No")
            {
                DataSet ds = lc.GetDuePaymentDetails(textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0];
                textBox2.Enabled = true;
                button2.Enabled = true;
            }
            else
            {

                MessageBox.Show("No Records Found Against Account No " + textBox1.Text);
                textBox1.ResetText();
                textBox2.ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clearamount = lc.GetDueAmount(textBox2.Text);
            string cleardate = DateTime.Now.ToString();
            string cleardue = "Yes";
            string msg = lc.UpdateDuePaymentTable(textBox2.Text, cleardue, clearamount, cleardate);
            MessageBox.Show(msg);
            DataSet ds = lc.GetDuePaymentDetails(textBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textBox2.Enabled = false;
            button2.Enabled = false;
        }
    }
}
