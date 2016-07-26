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
    public partial class Form2 : Form
    {


        string cn = @"server=127.0.0.1;userid=root;password=root;database=windows-form; port=3306";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the '_windows_formDataSet.users' table. You can move, or remove it, as needed.
          //this.usersTableAdapter.Fill(this._windows_formDataSet.users);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {




        }
    }
}
