using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hotel
{
    public partial class Authorization : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public Authorization()
        {
            InitializeComponent();
        }
        public string c = "";
        private void Registration_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            SQLiteCommand check_if_registered = new SQLiteCommand("Drop table Registration", sql);
            check_if_registered.ExecuteNonQuery();
            //SQLiteDataReader reader = check_if_registered.ExecuteReader();

            //while (reader.Read())
            //{
            //    c = reader[0] + "";
            //}
            //if (c == "")
            //{
            //    string register = "INSERT INTO Registration (ID, Login, Password) Values(null, '" + Logintb.Text + "', '" + Passwordtb.Text + "')";
            //    SQLiteCommand registeration_comand = new SQLiteCommand(register, sql);
            //    registeration_comand.ExecuteNonQuery();
            //    sql.Close();
            //    if (MessageBox.Show("Вы зарегистрированы") == DialogResult.OK)
            //    {
            //        this.Close();
            //    }
            //}
        
            //else
            //{
            //    MessageBox.Show("Пользователь с логином '" + c + "' уже зарегистрирован в системе");
            //}
            sql.Close();
        } 

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string login = "";
            sql.Open();
            SQLiteCommand check_if_registered = new SQLiteCommand("SELECT Login FROM Users WHERE Password = '" + Passwordtb.Text + "' AND Login = '" + Logintb.Text + "'", sql);
            check_if_registered.ExecuteNonQuery();
            SQLiteDataReader reader = check_if_registered.ExecuteReader();

            while (reader.Read())
            {
                login = reader[0] + "";
            }
            if (login == "")
            {
                MessageBox.Show("Логин или пароль указан не верно");
            }
            else
            {
                if (MessageBox.Show("Здравствуйте " + login + " ") == DialogResult.OK)
                {
                    Close();
                }
            }
            sql.Close();
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
