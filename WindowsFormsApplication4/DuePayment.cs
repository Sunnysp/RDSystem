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
    public partial class DuePayment : Form
    {

        LogicClass lc = new LogicClass();
        public DuePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cleardue = "";
            cleardue = lc.GetDueStatus(textBox1.Text);
            if(cleardue=="No")
            {
                DataSet ds = lc.GetDuePaymentDetails(textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {

                MessageBox.Show("No Records Found Against Account No " + textBox1.Text);
            }
        }
    }
}
