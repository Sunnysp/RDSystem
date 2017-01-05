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
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    
    public partial class NewPaymentEntry : Form
    {
        LogicClass lc = new LogicClass();
        public NewPaymentEntry()
        {
            InitializeComponent();
        }

        private void NewPaymentEntry_Load(object sender, EventArgs e)
        {
          /*  DbConnection obj = new DbConnection();
            SqlCommand cmd = new SqlCommand("Select AccountNo from NewAccountEntry", obj.con);

            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }*/

            comboBox2.Items.Add("Account Holder");
            comboBox2.Items.Add("Post Master");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int paymentid = lc.GeneratePaymentId();
            string message = lc.NewPaymentEntry(paymentid.ToString(), textBox4.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text,comboBox2.Text);
            label8.Text = message;
            MessageBox.Show("The Payment Id of " + textBox4.Text + " of " + textBox1.Text + " is " + paymentid);
            //string paymentid = lc.fetchpaymentid(textBox4.Text);
            if (comboBox2.SelectedItem == "Post Master")
            {
                string cleardue = "No";
                string msg = lc.duepaymetentry(paymentid.ToString(), textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text,cleardue);
                MessageBox.Show(msg);
                MessageBox.Show(textBox1.Text + "Has a due amount " + textBox2.Text + "to Mr. Tarapada Panda");
            }




            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            
            dateTimePicker1.ResetText();
        }

       /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList arr = lc.GetAccountDetails(comboBox1.Text);
            textBox1.Text = arr[1].ToString();
            textBox2.Text = arr[6].ToString();
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList arr = lc.GetAccountDetails(textBox4.Text);
            textBox1.Text = arr[1].ToString();
            textBox2.Text = arr[6].ToString();
            double amount = Convert.ToDouble(textBox2.Text);
            string strdate = lc.fetchpaymentdate(textBox4.Text);
            int MyFirstDate = Convert.ToDateTime(strdate).Day;
            int MyEndDate = DateTime.Now.Day;
            int diff = MyEndDate - MyFirstDate;
            Console.WriteLine(diff);
            double fine = 0.04 * amount * lc.calFine(diff);
            textBox3.Text = fine.ToString();
            textBox2.Text = (amount + fine).ToString();




            /* //strdate=date.ToString();
             // double pdate = Convert.ToDouble(date);
             //int m = Convert.ToInt64(date);
             //double pdate = Convert.ToDouble(strdate);
             double MyEndDate = DateTime.Now.ToOADate();
             double diff = MyEndDate - 
             Console.WriteLine(MyEndDate);
             int m = (int)MyEndDate;
             Console.WriteLine(m);
             //double fine = 0.04 * amount * lc.calFine(m);
            // textBox3.Text = fine.ToString();
 */


            //for due payment

            


        }
    }
}
