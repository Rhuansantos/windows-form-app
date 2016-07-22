using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // using mysql

namespace firstApp
{
    class sqlConnection
    {


        string cn = @"server=127.0.0.1;userid=root;password=root;database=windows-form; port=3306";
        //public void mysqlConnection()
        //{
            


            //using (MySqlConnection con = new MySqlConnection(cn))
            //{
            //    con.Open();

            //    if (con.State == System.Data.ConnectionState.Open)
            //    {
            //        label1.Text = "Database Connect";
            //    }
            //    else
            //    {
            //        label1.Text = "Connection failed";
            //    }
            //}


        //}

    }
}
