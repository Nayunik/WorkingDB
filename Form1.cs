using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WorkingDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonConnectionToDB_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

            SqlConnection connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

            if (connect.State == ConnectionState.Open)
            {
                MessageBox.Show("соединение открыто");
            }
        }
    }
}
