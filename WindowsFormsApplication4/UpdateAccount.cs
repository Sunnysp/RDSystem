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
    public partial class UpdateAccount : Form
    {
        LogicClass lc = new LogicClass();
        string gender = "";
        
        public UpdateAccount()
        {
            InitializeComponent();
            DataSet ds = lc.GetAccountDetails();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string doo = "", doc = "", sign = "", pthrgh = "",add="";
            int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0;
           
            string dt = System.DateTime.Today.ToString();
            doo = dateTimePicker1.Text;
            doc = dateTimePicker2.Text;
            add = textBox4.Text;
            pthrgh = comboBox1.Text;
            sign = comboBox2.Text;

            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            if (radioButton2.Checked == true)
                gender = radioButton2.Text;
           


            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Empty Field");
                flag1 = 1;
            }
            else if (radioButton1.Text == "" || radioButton2.Text == "" )
            {
                MessageBox.Show("Empty Field");
                flag2 = 1;
            }
            else if (textBox1.Text.Length != 10)
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
            else if (doc.CompareTo(dt) < dt.CompareTo(doc))
            {
                MessageBox.Show("Enter Valid Closing Date..");
                flag6 = 1;
            }
            else if (textBox8.Text != "Tarapada Panda")
            {
                MessageBox.Show("The Post Master's Sign Does Not Match");
                flag7 = 1;
            }
            else if (textBox7.Text != "kedbotpp")
            {
                MessageBox.Show("Password Not Match...");
                flag8 = 1;
            }

            if (flag1 == 0 && flag2 == 0 && flag3 == 0 && flag4 == 0 && flag5 == 0 && flag6 == 0 && flag7 == 0 && flag8 == 0)
            {
               
                    String message= "Success : " + lc.UpdateAccountEntry(textBox1.Text, textBox2.Text, textBox5.Text, add, doo, doc, textBox9.Text, sign, pthrgh, textBox8.Text, textBox7.Text, gender);
                    MessageBox.Show(message);
                    MessageBox.Show("The Account Number " + textBox1.Text + " Of " + textBox2.Text + " Is Stored Successfully.");

                }
                else
                    MessageBox.Show("Error in loading page");
            
            MessageBox.Show(textBox4.Text);
            }

        private void button2_Click_1(object sender, EventArgs e)
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
            if (arr[11].ToString() == "Male")
                radioButton1.Checked = true;
            if (arr[11].ToString() == "Female")
                radioButton2.Checked = true;
            comboBox2.Text = arr[7].ToString();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {

        }


        }
        }
    

