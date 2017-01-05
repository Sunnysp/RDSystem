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
    public partial class NewEntry : Form
    {
        LogicClass lc = new LogicClass();
        public NewEntry()
        {
            InitializeComponent();
        }
       


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox9.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doo = "", doc = "", sign = "", pthrgh = "", gender = "";
            int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0;
            int i;
            string dt = System.DateTime.Today.ToString();
            doo = dateTimePicker1.Text;
            doc = dateTimePicker2.Text;

            pthrgh = comboBox1.Text;
            sign = comboBox2.Text;

            if (radioButton4.Checked == true)
                gender = radioButton4.Text;
            if (radioButton5.Checked == true)
                gender = radioButton5.Text;

            if (textBox8.Text == "Alaka Sinhababu")
            {
                if (textBox7.Text == "alakasb1234567#")
                {
                    flag7 = 0;
                }
            }
            else if (textBox8.Text == "Tarapada Panda")
            {
                if (textBox7.Text == "tarapadap1234567#")
                {
                    flag8 = 0;
                }
            }
            else
            {
                //MessageBox.Show("The Post Master's Sign or Password Does Not Match");

            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Empty Field");
                flag1 = 1;
            }
            else if (radioButton4.Text == "" || radioButton5.Text == "")
            {
                MessageBox.Show("Empty Field");
                flag2 = 1;
               
            }
            else if (textBox1.Text.Length != 10 || textBox1.Text=="0000000000")
            {
                MessageBox.Show("Enter VAlid Account Number");
                MessageBox.Show("It must be 10 digit...");
                flag3 = 1;
              
            }
            else if (textBox5.Text.Length != 10)
            {
                MessageBox.Show("Enter VAlid Contact Number");
                MessageBox.Show("It must be 10 digit...");
                flag4 = 1;
            
            }
            else if (doo.CompareTo(dt) == dt.CompareTo(doo))
            {
                MessageBox.Show("Enter valid Opening date");
                flag5 = 1;
               
            }
         
          

            if (flag1 == 0 && flag2 == 0 && flag3 == 0 && flag4 == 0 && flag5 == 0 && flag6 == 0 && flag7 == 0 && flag8 == 0)
            {
                int chk = lc.CheckAccountNo(textBox1.Text);
                
                if(chk==1)
                {
                    for (i = 0; i <= 100; i++)
                    {


                        progressBar1.Value = i;

                        System.Threading.Thread.Sleep(100);

                    }

                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        label10.Text = "Success : " + lc.NewAccountEntry(textBox1.Text, textBox2.Text, textBox5.Text, textBox4.Text, doo, doc, textBox9.Text, sign, pthrgh, textBox8.Text, textBox7.Text, gender);
                        MessageBox.Show("The Account Number " + textBox1.Text + " Of " + textBox2.Text + " Is Stored Successfully.");

                        progressBar1.Value = 0;
                    }
                    else
                        MessageBox.Show("Error in loading page");
                }
                else
                {
                    MessageBox.Show("Entered Account is already Stored in your System....");
                    MessageBox.Show("please enter another Account Number");
        
                }
                //label10.Text = pthrgh;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("MIS Interest");
            comboBox2.Items.Add("English");
            comboBox2.Items.Add("Bengali");
            comboBox2.Items.Add("LTI");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddYears(5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.ResetText();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                
                textBox5.ResetText();
            }
        }
    }
}
