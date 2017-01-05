using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.BL_CLASSES;
using System.Collections;

namespace WindowsFormsApplication4
{
    public partial class RemoveAccount : Form
    {
        LogicClass lc = new LogicClass();
        public RemoveAccount()
        {
            InitializeComponent();
            DataSet ds = lc.GetAccountDetails();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList arr = lc.GetAccountDetails(textBox1.Text);
            //textBox1.Text = arr[0].ToString();
            textBox2.Text = arr[1].ToString();
            textBox5.Text = arr[2].ToString();
            textBox4.Text = arr[3].ToString();
            textBox7.Text = arr[10].ToString();
            textBox8.Text = arr[9].ToString();
            textBox9.Text = arr[6].ToString();

            dateTimePicker1.Text = arr[4].ToString();
            dateTimePicker2.Text = arr[5].ToString();
            comboBox1.Text = arr[8].ToString();
            if (arr[10].ToString() == "Male")
                radioButton1.Checked = true;
            if (arr[11].ToString() == "Female")
                radioButton2.Checked = true;
            comboBox2.Text = arr[7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = lc.RemoveExistingAccount(textBox1.Text);
            MessageBox.Show(message);
            MessageBox.Show("The Account Number "+textBox1.Text+" Of "+textBox2.Text+"Is Removed Successfully");
        }
    }
}
