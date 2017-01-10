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
    
    public partial class AdminPanel : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public AdminPanel()
        {
            InitializeComponent();
            AddtoCMbb();
        }
        public void AddtoCMbb()
        {
            sql.Open();
            string book_id = "";
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"SELECT login from Registration";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            while (srd.Read())
            {
                book_id = srd[0] + "";
                if (book_id != "admin")
                {
                    OnDeletecmb.Items.Add(book_id);
                }
            }
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string role="";
            if (OnAddcmb.Text == "Менеджер")
            {
                role = "manager";
            }
            else
            {
                if (OnAddcmb.Text == "Бухгалтер")
                {
                    role = "Bookkeeper";
                }
            }
            
            string login = OnAddtb.Text;
            sql.Open();
            string check_name = "insert into Registration(ID, Login, Password, Role) Values(null,'"+login+"','','"+role+"')";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Пользователь успешно добавлен");
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            string check_name = "Delete from registration where login ='"+OnDeletecmb.Text+"'";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            sql.Close();
            OnDeletecmb.Items.Remove(OnDeletecmb.SelectedItem);
            OnDeletecmb.Text = "";
            MessageBox.Show("Пользователь успешно удалён");
        }
    }
}
