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
    public partial class SearchingAccount : Form
    {
        LogicClass lc = new LogicClass();
        public SearchingAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = lc.SearchAccountDetails(textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
