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
        public string current_login;
        public string currnet_role;
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public Authorization()
        {
            InitializeComponent();
            if (UserRigts._login != "")
            {
                EnterBtn.Text = "Выход";
            }
        }
        public bool success;
        public string c = "";
        private void Registration_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            SQLiteCommand check_if_registered = new SQLiteCommand("Select Login from Registration where Login ='"+Logintb.Text+"'", sql);
            check_if_registered.ExecuteNonQuery();
            SQLiteDataReader reader = check_if_registered.ExecuteReader();

            while (reader.Read())
            {
                c = reader[0] + "";
            }
            if (c != "")
            {
                string register = "update Registration set password='"+Passwordtb.Text+"' where login='"+Logintb.Text+"'";
                SQLiteCommand registeration_comand = new SQLiteCommand(register, sql);
                registeration_comand.ExecuteNonQuery();
                sql.Close();
                if (MessageBox.Show("Вы зарегистрированы") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пользователь с этим логином не зарегистрирован в системе. Обратитесь к администратору");
            }
            sql.Close();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (EnterBtn.Text == "Вход")
            {
                string login = "";
                sql.Open();
                SQLiteCommand check_if_registered = new SQLiteCommand("SELECT Login FROM Registration WHERE Password = '" + Passwordtb.Text + "' AND Login = '" + Logintb.Text + "'", sql);
                check_if_registered.ExecuteNonQuery();
                SQLiteDataReader reader = check_if_registered.ExecuteReader();
                while (reader.Read())
                {
                    login = reader[0] + "";
                }
                string role = "";
                check_if_registered = new SQLiteCommand("SELECT role FROM Registration WHERE Password = '" + Passwordtb.Text + "' AND Login = '" + Logintb.Text + "'", sql);
                check_if_registered.ExecuteNonQuery();
                reader = check_if_registered.ExecuteReader();
                while (reader.Read())
                {
                    role = reader[0] + "";
                }
                if (login == "")
                {
                    MessageBox.Show("Логин или пароль указан не верно");
                }
                else
                {
                    if (MessageBox.Show("Здравствуйте " + login + " ") == DialogResult.OK)
                    {
                        UserRigts.Get_Rights(role, login);
                        Logintb.Clear();
                        Passwordtb.Clear();
                    }
                }
                currnet_role = role;
                sql.Close();
                Form1 f1 = this.Owner as Form1;
                if (role == "superuser")
                {
                    f1.roomsWorkToolStripMenuItem.Enabled = true;
                    f1.adminToolStripMenuItem.Enabled = true;
                    f1.clientsWorkToolStripMenuItem.Enabled = true;
                    f1.clientsToolStripMenuItem.Enabled = true;
                    f1.populatesClientsToolStripMenuItem.Enabled = true;
                    f1.roomsToolStripMenuItem.Enabled = true;
                    f1.documentationToolStripMenuItem.Enabled = true;
                    f1.ChangePassToolStripMenuItem.Enabled = true;
                }
                else
                {
                    if (role == "manager")
                    {
                        f1.clientsWorkToolStripMenuItem.Enabled = true;
                        f1.roomsWorkToolStripMenuItem.Enabled = true;
                        f1.ChangePassToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        if (role == "Bookkeeper")
                        {
                            f1.documentationToolStripMenuItem.Enabled = true;
                            f1.ChangePassToolStripMenuItem.Enabled = true;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                if(EnterBtn.Text == "Выход")
                {
                    UserRigts._role = "";
                    UserRigts._login = "";
                    EnterBtn.Text = "Вход";
                    Form1 f1 = this.Owner as Form1;
                    f1.roomsWorkToolStripMenuItem.Enabled = false;
                    f1.adminToolStripMenuItem.Enabled = false;
                    f1.clientsWorkToolStripMenuItem.Enabled = false;
                    f1.clientsToolStripMenuItem.Enabled = false;
                    f1.populatesClientsToolStripMenuItem.Enabled = false;
                    f1.roomsToolStripMenuItem.Enabled = false;
                    f1.documentationToolStripMenuItem.Enabled = false;
                    f1.ChangePassToolStripMenuItem.Enabled = false;
                    Logintb.Clear();
                    Passwordtb.Clear();
                    Close();

                    List<Form> forms = f1.MdiChildren.ToList();
                    foreach(Form f in forms)
                    {
                        f.Close();
                    }
                }
            }
        }

        private void Authorization_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }

    static public class UserRigts
    {
        public static string _role;
        public static string _login;
        static public void Get_Rights(string role, string login)
        { 
            _role = role;
            _login = login;
        }
    }
}
