using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.BL_CLASSES;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class CheckPayment : Form
    {
        LogicClass lc = new LogicClass();
        public CheckPayment()
        {
            InitializeComponent();
        }

        private void CheckPayment_Load(object sender, EventArgs e)
        {
           /* DbConnection obj = new DbConnection();
            SqlCommand cmd = new SqlCommand("Select AccountNo from NewAccountEntry", obj.con);

            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            */
            

        }



        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      /*  private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataSet ds = lc.GetPaymentDetails(comboBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }
        */
        private void Find_Click(object sender, EventArgs e)
        {
            DataSet ds = lc.GetPaymentDetails(textBox4.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

 //if (checkBox1.Checked == false)
// if (checkBox2.Checked == false)