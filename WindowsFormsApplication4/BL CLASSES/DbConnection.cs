using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using WindowsFormsApplication4.BL_CLASSES;

namespace WindowsFormsApplication4.BL_CLASSES
{
    class DbConnection
    {

        public SqlConnection con = new SqlConnection("Data Source=USER-PC;Initial Catalog=KADMAEDBO;Integrated Security=True;Pooling=False");

        //Method to Open Connection
        public void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (InvalidOperationException)
            {
                con.Close();
                con.Open();
            }
        }

        //Method to Close Connection
        public void CloseConnection()
        {
            con.Close();
        }

    }
}
