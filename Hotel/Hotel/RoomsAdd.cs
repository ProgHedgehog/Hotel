﻿using System;
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
    public partial class RoomsAdd : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public RoomsAdd()
        {
            InitializeComponent();
            AddToCombobox("Name", "Type", Typecmbb);
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
                if (ComboboxName.Items.Contains(c) == false)
                {
                    ComboboxName.Items.Add(c);
                }
            }
            sql.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string c = " ";
            sql.Open();
            string sql_request = "SELECT Name FROM Room WHERE Name ='" + NametextBox.Text + "' ";
            SQLiteCommand add = new SQLiteCommand(sql_request, sql);
            add.ExecuteNonQuery();
            SQLiteDataReader reader = add.ExecuteReader();
            while (reader.Read())
            {
                c = reader[0] + "";
            }
            sql.Close();

            if (NametextBox.Text.Trim() == c)
            {
                MessageBox.Show("Номер с таким именем уже существует!");
            }
            else
            {
                var stop_array = new[] { ".", ",", ";", ":", "?", "!", "<", ">", "-", "=" };
                if ((NametextBox.Text.Equals("")) || (Descriptioncmb.Text.Equals("")) || (PricemaskedTextBox.Text.Equals("")) || (Typecmbb.Text.Equals("")))
                {
                    MessageBox.Show("Одно или несколько полей не заполнены");
                }
                else
                {
                    var flag = true;
                    if (NametextBox.Text != "")
                    {
                        foreach (string t in stop_array)
                        {
                            if (NametextBox.Text.Contains(t))
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
                            SQLiteCommand sqlcon = new SQLiteCommand(sql);
                            sqlcon.CommandText = @"insert into room(roomID, Name, Description, Status, Price, TypeName) values(null, '" + Convert.ToString(NametextBox.Text) + "', '" + Convert.ToString(Descriptioncmb.Text) + "', 'свободен','" + Convert.ToDouble(PricemaskedTextBox.Text) + "', '" + Convert.ToString(Typecmbb.Text) + "');";
                            SQLiteDataReader srd = sqlcon.ExecuteReader();
                            MessageBox.Show("Номер добавлен");
                            sql.Close();
                            Close();
                            Rooms r = new Rooms();
                            r.Show();
                        }
                    }
                }
            }
        }
    }
}