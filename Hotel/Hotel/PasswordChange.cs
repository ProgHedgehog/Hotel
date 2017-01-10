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

    public partial class PasswordChange : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void Changepassbut_Click(object sender, EventArgs e)
        {
            var stop_array = new[] { ".", ",", ";", ":", "?", "!", "<", ">", "-", "=" };
            if (PasswordTb.Text == "")
            {
                MessageBox.Show("Поле не было заполнено!");
            }
            else
            {
                var flag = true;
                if (PasswordTb.Text != "")
                {
                    foreach (string t in stop_array)
                    {
                        if (PasswordTb.Text.Contains(t))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Введены недопустимые символы");
                    }
                    if (flag == true)
                    {
                        sql.Open();
                        string check_name = @"UPDATE Registration SET Password = '" + Convert.ToString(PasswordTb.Text) + "' WHERE Login = '" + UserRigts._login + "'";
                        SQLiteCommand check = new SQLiteCommand(check_name, sql);
                        check.ExecuteNonQuery();
                        sql.Close();
                        if (MessageBox.Show("Новый пароль сохранён") == DialogResult.OK)
                        {
                            this.Close();
                        }
                        sql.Close();
                    }
                }
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            if ((PasswordTb.Text.ToCharArray().Count() > 4)&&(PasswordTb.Text.ToCharArray().Count()<15))
            {
                Changepassbut.Enabled = true;
            }
        }
    }
}