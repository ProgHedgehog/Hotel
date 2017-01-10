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
    public partial class RoomsChange : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");

        public string Current_Name;

        public RoomsChange(List<string> Data_For_Request)
        {
            InitializeComponent();
            if (Data_For_Request != null)
            {
                AddToCombobox("Name", "Type", Typecmbb);
                Nametb.Text = Data_For_Request[1];
                Current_Name = Data_For_Request[1];
                if (Descriptioncmb.Items.Contains(Data_For_Request[2]))
                {
                    Descriptioncmb.Text = Data_For_Request[2];
                }
                PricemaskedTextBox.Text = Data_For_Request[3];
                if (Typecmbb.Items.Contains(Data_For_Request[4]))
                {
                    Typecmbb.Text = Data_For_Request[4];
                }
            }
            else
            {
                MessageBox.Show("Редактирование не возможно");
            }
        }

        private void AddToCombobox(string ItemName, string TableName, ComboBox ComboboxName)
        {
            string c = " ";
            sql.Open();
            string sql_request = "SELECT " + ItemName + " FROM " + TableName + " ";
            SQLiteCommand add = new SQLiteCommand(sql_request, sql);
            add.ExecuteNonQuery();
            SQLiteDataReader reader = add.ExecuteReader();
            while (reader.Read())
            {
                c = reader[0] + "";
                ComboboxName.Items.Add(c);
            }
            sql.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string c = " ";
            sql.Open();
            string sql_request = "SELECT Name FROM Room WHERE Name ='" + Nametb.Text + "' ";
            SQLiteCommand add = new SQLiteCommand(sql_request, sql);
            add.ExecuteNonQuery();
            SQLiteDataReader reader = add.ExecuteReader();
            while (reader.Read())
            {
                c = reader[0] + "";
            }
            sql.Close();

            if (Nametb.Text.Trim() == c)
            {
                MessageBox.Show("Номер с таким именем уже существует!");
            }
            else
            {
                var stop_array = new[] { ".", ",", ";", ":", "?", "!", "<", ">", "-", "=" };
                if ((Nametb.Text.Equals("")) || (Descriptioncmb.Text.Equals("")) || (PricemaskedTextBox.Text.Equals("")) || (Typecmbb.Text.Equals("")))
                {
                    MessageBox.Show("Одно или несколько полей не заполнены");
                }
                else
                {
                    var flag = true;
                    if (Nametb.Text != "")
                    {
                        foreach (string t in stop_array)
                        {
                            if (Nametb.Text.Contains(t))
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag == false)
                        {
                            MessageBox.Show("Название номера введено не верно!");
                        }
                        if (flag == true)
                        {
                            sql.Open();
                            string check_name = @"UPDATE Room SET Name = '" + Convert.ToString(Nametb.Text) + "', Description = '" + Convert.ToString(Descriptioncmb.Text) + "', Price = '" + Convert.ToDouble(PricemaskedTextBox.Text) + "', TypeName = '" + Convert.ToString(Typecmbb.Text) + "' WHERE Name LIKE '" + Current_Name + "'";
                            SQLiteCommand check = new SQLiteCommand(check_name, sql);
                            check.ExecuteNonQuery();
                            sql.Close();
                            if (MessageBox.Show("Изменения были успешно сохранены!") == DialogResult.OK)
                            {
                                this.Close();
                                Rooms room = new Rooms();
                                room.Show();
                            }
                            sql.Close();
                        }
                    }
                }
            }
        }
    }
}
