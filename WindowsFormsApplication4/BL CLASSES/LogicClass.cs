using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Collections;
using System.Data.SqlClient;

using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using WindowsFormsApplication4.BL_CLASSES;

namespace WindowsFormsApplication4.BL_CLASSES
{
    class LogicClass
    {
        //Creating an object of the DbConnection Class.
        DbConnection obj = new DbConnection();

        //Entry New Account.
        public string NewAccountEntry(string accountno, string name, string contactno, string address, string doo, string doc, string amount, string sign, string pthrgh, string pmsign, string password, string gender)
        {

            SqlCommand cmd = new SqlCommand("Insert into NewAccountEntry Values (@AccountNo,@Name,@ContactNo,@Address,@Openingdate,@Closingdate,@Amount,@Signature,@Paidthrough,@PMSign,@Password,@Gender)", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@ContactNo", contactno);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Openingdate", doo);
            cmd.Parameters.AddWithValue("@Closingdate", doc);
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@Signature", sign);
            cmd.Parameters.AddWithValue("@Paidthrough", pthrgh);
            cmd.Parameters.AddWithValue("@PMSign", pmsign);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Gender", gender);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Value Added Successfully";
        }


        //Update New Account.
        public string UpdateAccountEntry(string accountno, string name, string contactno, string address, string doo, string doc, string amount, string sign, string pthrgh, string pmsign, string password, string gender)
        {

            SqlCommand cmd = new SqlCommand("update NewAccountEntry set AccountNo=@AccountNo,Name=@Name,ContactNo=@ContactNo,Address=@Address,Openingdate=@Openingdate,Closingdate=@Closingdate,Amount=@Amount,Signature=@Signature,Paidthrough=@Paidthrough,PMSign=@PMSign,Password=@Password,Gender=@Gender where AccountNo=@AccountNo", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@ContactNo", contactno);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Openingdate", doo);
            cmd.Parameters.AddWithValue("@Closingdate", doc);
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@Signature", sign);
            cmd.Parameters.AddWithValue("@Paidthrough", pthrgh);
            cmd.Parameters.AddWithValue("@PMSign", pmsign);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Gender", gender);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Value Updated Successfully";
        }



        //Get All Account Details
        public DataSet GetAccountDetails()
        {
            SqlCommand cmd = new SqlCommand("Select *  from NewAccountEntry", obj.con);
            obj.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //Get AccountDetails.
        public ArrayList GetAccountDetails(string accountno)
        {
            ArrayList arr = new ArrayList();
            SqlCommand cmd = new SqlCommand("Select * from NewAccountEntry where AccountNo= @AccountNo", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                arr.Add(dr[0].ToString());
                arr.Add(dr[1].ToString());
                arr.Add(dr[2].ToString());
                arr.Add(dr[3].ToString());
                arr.Add(dr[4].ToString());
                arr.Add(dr[5].ToString());
                arr.Add(dr[6].ToString());
                arr.Add(dr[7].ToString());
                arr.Add(dr[8].ToString());
                arr.Add(dr[9].ToString());
                arr.Add(dr[10].ToString());
                arr.Add(dr[11].ToString());
            }
            return arr;
        }

        //Remove Existing Account
        public string RemoveExistingAccount(string accountno)
        {
            SqlCommand cmd = new SqlCommand("Delete NewAccountEntry where AccountNo=@v1", obj.con);
            cmd.Parameters.AddWithValue("@v1", accountno);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Account Removed Successfully";
        }


        //get account no
        public ArrayList GetAccountNo()
        {
            ArrayList arr = new ArrayList();
            SqlCommand cmd = new SqlCommand("Select AccountNo from NewAccountEntry", obj.con);

            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                arr.Add(dr[0].ToString());

            }
            return arr;
        }

        public int CheckAccountNo(string accountno)
        {
            string str;
            int chk;
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from NewAccountEntry where AccountNo= @AccountNo", obj.con);
                cmd.Parameters.AddWithValue("@AccountNo", accountno);
                obj.OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    str = dr[0].ToString();
                    if (str == accountno)
                        chk = 0;
                    else
                        chk = 1;
                }
                else
                    chk = 1;
                return chk;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }

        //Generate payment Id
        public int GeneratePaymentId()
        {
            int countId = 0;
            SqlCommand cmd = new SqlCommand("Select * from Payment", obj.con);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                countId++;
            }
            countId++;
            return countId;
        }

        //Entry New Payment Details.
        public string NewPaymentEntry(string paymentid, string accountno, string name, string amount, string paymentdate, string fineamount, string paidby)
        {

            SqlCommand cmd = new SqlCommand("Insert into Payment Values (@paymentid, @accountno, @name, @amount, @paymentdate, @fineamount, @PaidBy)", obj.con);
            cmd.Parameters.AddWithValue("@PaymentId", paymentid);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            cmd.Parameters.AddWithValue("@Name", name);

            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@PaymentDate", paymentdate);
            cmd.Parameters.AddWithValue("@FineAmount", fineamount);
            cmd.Parameters.AddWithValue("@PaidBy", paidby);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Value Added Successfully";
        }

        //Get Payment Details.
        public DataSet GetPaymentDetails(string accountno)
        {
            SqlCommand cmd = new SqlCommand("Select * from Payment where AccountNo= @AccountNo", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            obj.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        //Get Payment Date From Payment Table
        public string fetchpaymentdate(string accountno)
        {
            string date = "";
            SqlCommand cmd = new SqlCommand("select top 1 PaymentDate from Payment where AccountNo = @v1 order by PaymentId desc", obj.con);
            cmd.Parameters.AddWithValue("@v1", accountno);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                date = dr[0].ToString();
            }
            return date;
        }



        //Fine Calculation
       public int calFine(int m)
        {
            int res = 0;
            if (m < 30)
            {
                return 0;
            }
            else {
                res = m + calFine(m - 1);

            }

            return res;
        }

        //Due Payment Entry

        public string duepaymetentry(string paymentid,string accountno,string name,string dueamount,string payingdate,string paidby,string cleardue)
        {
            string clearamount = "";
            string cleardate = "";

            SqlCommand cmd = new SqlCommand("Insert into DuePayment Values (@PaymentId, @AccountNo, @Name, @DueAmount, @paymentdate,@ClearDue,@ClearAmount,@ClearDate,@PaidBy)", obj.con);
            cmd.Parameters.AddWithValue("@PaymentId", paymentid);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            cmd.Parameters.AddWithValue("@Name", name);

            cmd.Parameters.AddWithValue("@DueAmount", dueamount);
            cmd.Parameters.AddWithValue("@PaymentDate", payingdate);
            cmd.Parameters.AddWithValue("@ClearDue", cleardue);
            cmd.Parameters.AddWithValue("@ClearAmount", clearamount);
            cmd.Parameters.AddWithValue("@ClearDate", cleardate);
            cmd.Parameters.AddWithValue("@PaidBy", paidby);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Value Added Successfully";

        }


        //Get Payment Id From Payment Table
        public string fetchpaymentid(string accountno)
        {
            string pid = "";
            SqlCommand cmd = new SqlCommand("select PaymentId from Payment where AccountNo = @v1", obj.con);
            cmd.Parameters.AddWithValue("@v1", accountno);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pid = dr[0].ToString();
            }
            return pid;
        }

        //Get Due Payment Details.
        public DataSet GetDuePaymentDetails(string accountno)
        {
            SqlCommand cmd = new SqlCommand("Select * from DuePayment where AccountNo= @AccountNo", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            obj.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        //Fetch Due Status.
        public string GetDueStatus(string accountno)
        {
            string dstatus = "";
            SqlCommand cmd = new SqlCommand("Select * from DuePayment where AccountNo= @AccountNo", obj.con);
            cmd.Parameters.AddWithValue("@AccountNo", accountno);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dstatus = dr[5].ToString();
            }

            return dstatus;
        }

        //Fetch Due Amount.
        public string GetDueAmount(string paymentid)
        {
            string damount = "";
            SqlCommand cmd = new SqlCommand("Select * from DuePayment where PaymentId= @PaymentId", obj.con);
            cmd.Parameters.AddWithValue("@PaymentId", paymentid);
            obj.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                damount = dr[3].ToString();
            }

            return damount;
        }


        //Update Due Payment Table
        public string UpdateDuePaymentTable(string paymentid,string cleardue,string clearamount,string cleardate)
        {
            
            SqlCommand cmd = new SqlCommand("update DuePayment set Cleardue=@ClearDue,ClearAmount=@ClearAmount,ClearDate=@ClearDate where PaymentId=@PaymentId", obj.con);
            cmd.Parameters.AddWithValue("@PaymentId", paymentid);
            cmd.Parameters.AddWithValue("@ClearDue", cleardue);
            cmd.Parameters.AddWithValue("@ClearAmount", clearamount);
            cmd.Parameters.AddWithValue("@ClearDate", cleardate);
            obj.OpenConnection();
            cmd.ExecuteNonQuery();
            return "Value Updated Successfully";
        }


        //Search Account By Post MAster Name
        //Get Due Payment Details.
        public DataSet SearchAccountDetails(string pmsign,string pmpasswd)
        {
            SqlCommand cmd = new SqlCommand("Select * from NewAccountEntry where PMSign= @PMSign and Password= @Password", obj.con);
            cmd.Parameters.AddWithValue("@PMSign", pmsign);
            cmd.Parameters.AddWithValue("@Password", pmpasswd);
            obj.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
