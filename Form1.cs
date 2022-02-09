using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Microsoft.Data.SqlClient;*/
using System.Data.SqlClient;

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
            int maxSizePB = 5;
            textBoxConnectDB.Clear();
            progressBarConnectDB.Maximum = maxSizePB;
            progressBarConnectDB.Value +=  Convert.ToInt32(maxSizePB *0.2);
           
            string connectionString = "Server=127.0.0.1:3306";

            SqlConnection connect = new SqlConnection(connectionString);

            progressBarConnectDB.Value += Convert.ToInt32(maxSizePB * 0.2);
            try
            {
                connect.Open();
                progressBarConnectDB.Value += Convert.ToInt32(maxSizePB * 0.2);
            }
            catch (SqlException ex) { progressBarConnectDB.Value = maxSizePB; MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (connect.State == ConnectionState.Open)
            {
                textBoxConnectDB.Text += "Соединение открыто!\n";
                progressBarConnectDB.Value += Convert.ToInt32(maxSizePB * 0.2);
                connect.Close();
                progressBarConnectDB.Value += Convert.ToInt32(maxSizePB * 0.2);
                textBoxConnectDB.Text += "Соединение закрыто.";
                progressBarConnectDB.Value = 0;
            }
        }

        //Данный обработчик показывает информацию об авторе программы
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\nNayunik\nГод написания:\n2022","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
