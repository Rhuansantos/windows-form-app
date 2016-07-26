using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // using mysql

namespace firstApp
{
    public partial class Form1 : Form
    {

        //string cn = @"server=127.0.0.1;userid=root;password=root;database=windows-form; port=3306";


        // global variaables
        private string conn;
        private MySqlConnection connect;

        // init the form
        public Form1()
        {
            InitializeComponent();
        }


        // function for the database connect
        private void db_connection()
        {
            try
            {
                conn = "server=127.0.0.1;userid=root;password=root;database=windows-form; port=3306;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }



        // function to valitade the login
        private bool validate_login(string user, string pass)
        {

            // connection with the database
            db_connection();
            MySqlCommand cmd = new MySqlCommand();

            // select the user where user is igual current user
            cmd.CommandText = "Select * from users where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                //connect.Close();


                // Hide the current windows and open the next one
                this.Hide();
                var windows2 = new Form2();
                windows2.Show();

                // return true if the login is ok
                return true;

   

            }
            else
            {
                // close the connection and  return false with a erro message
                connect.Close();
                return false;
            }
        }



        // button for login
        private void button1_Click(object sender, EventArgs e)
        {


            // grabing the values from the textbox username and password
            string user = textBox1.Text;
            string pass = textBox2.Text;

            // if the fiels are empty doe that
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }

             // return message for erros
            bool r = validate_login(user, pass);
            if (r)
                MessageBox.Show("Correct Login Credentials");
            else
                MessageBox.Show("Incorrect Login Credentials");

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
