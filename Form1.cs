using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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
            this.ActiveControl = panelMain;
        }

        private void buttonConnectionToDB_Click(object sender, EventArgs e)
        {
            panelCheck.BackColor = Color.DarkGray;
            textBoxConnectDB.Clear();

            string connectionString = "server=" + textBoxServerName.Text + ";database=" + textBoxDataBase.Text + ";username=" + textBoxUsername.Text + ";password=" + textBoxPassword.Text;

            MySqlConnection connect = getMySqlConnection(connectionString);

            if (connect.State == ConnectionState.Open)
            {
                textBoxConnectDB.Text += "Соединение открыто!\r\n";
                connect.Close();
                textBoxConnectDB.Text += "Соединение закрыто.";
                panelCheck.BackColor = Color.Green;
            }
            else { panelCheck.BackColor = Color.Red; }
        }

        /// <summary>
        /// Данная функция выполняет присоединение к базе данных
        /// </summary>
        /// <param name="connectionString">строка для соединения с БД</param>
        /// <returns>Возвращается connector к БД с набором его свойств и методов</returns>
        private MySqlConnection getMySqlConnection(string connectionString)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);

            try
            {
                connect.Open();
            }
            catch (Exception ex) {MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return connect;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\nNayunik\nГод написания:\n2022","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxServerName_Enter(object sender, EventArgs e)
        {
            if (textBoxServerName.Text == "Server")
            { textBoxServerName.Clear(); }
        }

        private void textBoxServerName_Leave(object sender, EventArgs e)
        {
            if (textBoxServerName.Text.Length==0)
            {
                textBoxServerName.Text ="Server";
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            { textBoxUsername.Clear(); }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void textBoxDataBase_Enter(object sender, EventArgs e)
        {
            if (textBoxDataBase.Text == "Name DB")
            { textBoxDataBase.Clear(); }
        }

        private void textBoxDataBase_Leave(object sender, EventArgs e)
        {
            if (textBoxDataBase.Text.Length == 0)
            {
                textBoxDataBase.Text = "Name DB";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            { textBoxPassword.Clear(); }
        }

        private void buttonExecuteRequest_Click(object sender, EventArgs e)
        {
            string connectionString = "server=" + textBoxServerName.Text + ";database=" + textBoxDataBase.Text + ";username=" + textBoxUsername.Text + ";password=" + textBoxPassword.Text;
            string stringRequest = textBoxRequest.Text;
            MySqlConnection connect;
            MySqlCommand commandMySql = new MySqlCommand();

            connect = getMySqlConnection(connectionString);

            if (connect.State == ConnectionState.Open)
            {
                if (stringRequest.ToLower().Contains("select "))
                {
                    commandMySql.Connection = connect;
                    commandMySql.CommandText = stringRequest;
                    try
                    {
                        MySqlDataReader reader = commandMySql.ExecuteReader();
                        if (reader.HasRows)
                        {
                            int numberColumn = reader.FieldCount;
                            for (int i = 0; i < numberColumn; i++)
                            {
                                dataGridView1.Columns.Add("", reader.GetName(i));
                            }
                            int ind = 0;
                            while (reader.Read())//прочитал строку
                            {
                                dataGridView1.Rows.Add();
                                for (int indexColumn = 0; indexColumn < numberColumn; indexColumn++)//цикл по столбцам
                                {
                                    string nameOfColumn = reader.GetName(indexColumn);
                                    dataGridView1.Rows[ind].Cells[indexColumn].Value = reader.GetString(nameOfColumn);
                                }
                                ind++;
                                textBoxRequest.Text += "\r\n";
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    
                }
                else 
                {
                    commandMySql.Connection = connect;
                    commandMySql.CommandText = stringRequest;
                    try
                    {
                        commandMySql.ExecuteNonQuery();
                        textBoxRequest.Text = "Запрос успешно выполнен!";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                
                connect.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=" + textBoxServerName.Text + ";database=" + textBoxDataBase.Text + ";username=" + textBoxUsername + ";password=" + textBoxPassword.Text;
            MySqlConnection connector = getMySqlConnection(connectionString);
            MessageBox.Show("Состояние подключения: "+connector.State+"\r\n"+"База данных: "+connector.Database+"\r\n"+ "Сервер:" + textBoxServerName.Text);
        }

        private void checkConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCheck.BackColor = Color.DarkGray;
            textBoxConnectDB.Clear();

            string connectionString = "server=" + textBoxServerName.Text + ";database=" + textBoxDataBase.Text + ";username=" + textBoxUsername.Text + ";password=" + textBoxPassword.Text;

            MySqlConnection connect = getMySqlConnection(connectionString);

            if (connect.State == ConnectionState.Open)
            {
                textBoxConnectDB.Text += "Соединение открыто!\r\n";
                connect.Close();
                textBoxConnectDB.Text += "Соединение закрыто.";
                panelCheck.BackColor = Color.Green;
            }
            else { panelCheck.BackColor = Color.Red; }
        }

        private void executeRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=" + textBoxServerName.Text + ";database=" + textBoxDataBase.Text + ";username=" + textBoxUsername.Text + ";password=" + textBoxPassword.Text;
            string stringRequest = textBoxRequest.Text;
            MySqlConnection connect;
            MySqlCommand commandMySql = new MySqlCommand();

            connect = getMySqlConnection(connectionString);

            if (connect.State == ConnectionState.Open)
            {
                if (stringRequest.ToLower().Contains("select "))
                {
                    commandMySql.Connection = connect;
                    commandMySql.CommandText = stringRequest;
                    try
                    {
                        MySqlDataReader reader = commandMySql.ExecuteReader();
                        if (reader.HasRows)
                        {
                            int numberColumn = reader.FieldCount;
                            for (int i = 0; i < numberColumn; i++)
                            {
                                dataGridView1.Columns.Add("", reader.GetName(i));
                            }
                            int ind = 0;
                            while (reader.Read())//прочитал строку
                            {
                                dataGridView1.Rows.Add();
                                for (int indexColumn = 0; indexColumn < numberColumn; indexColumn++)//цикл по столбцам
                                {
                                    string nameOfColumn = reader.GetName(indexColumn);
                                    dataGridView1.Rows[ind].Cells[indexColumn].Value = reader.GetString(nameOfColumn);
                                }
                                ind++;
                                textBoxRequest.Text += "\r\n";
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    commandMySql.Connection = connect;
                    commandMySql.CommandText = stringRequest;
                    try
                    {
                        commandMySql.ExecuteNonQuery();
                        textBoxRequest.Text = "Запрос успешно выполнен!";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }

                connect.Close();
            }
        }

    }
}
