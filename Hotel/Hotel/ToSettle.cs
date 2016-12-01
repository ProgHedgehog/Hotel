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
    public partial class ToSettle : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        int _RoomID;
        int _ClientID;
        public ToSettle(int room_id, int client_id)
        {
            InitializeComponent();
            _RoomID = room_id;
            _ClientID = client_id;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Clients cl = new Clients("From_Rooms", 0);
            cl.Show();
        }

        private void ContentsReportbtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            string start_date = "";
            string finish_date = "";
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"SELECT ArrivalDate FROM Contract WHERE RoomID=" + _RoomID + " ";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            while (srd.Read())
            {
                start_date = srd[0] + "";
            }

            SQLiteCommand sqlcon3 = new SQLiteCommand(sql);
            sqlcon3.CommandText = @"SELECT ArrivalDate FROM Contract WHERE RoomID=" + _RoomID + " ";
            SQLiteDataReader srd3 = sqlcon3.ExecuteReader();
            while (srd.Read())
            {
                finish_date = srd3[0] + "";
            }
            sql.Close();
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата заезда не может быть больше даты выезда");
            }
            if ((start_date != "") && (finish_date != ""))
            {
                if ((dateTimePicker1.Value > Convert.ToDateTime(start_date)) && (dateTimePicker1.Value < Convert.ToDateTime(finish_date)))
                {
                    if ((dateTimePicker2.Value > Convert.ToDateTime(start_date)) && (dateTimePicker2.Value < Convert.ToDateTime(finish_date)))
                    {
                        MessageBox.Show("Выберите другую дату заезда");
                    }
                    else
                    {
                        sql.Open();
                        sqlcon = new SQLiteCommand(sql);
                        sqlcon.CommandText = @"INSERT INTO Contract(ContractID, Data, ArrivalDate, DepartureDate, RoomID, ClientID, BookID) VALUES(null,'" + dateTimePicker3.Value.Date.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "', '" + dateTimePicker2.Value.Date.ToString() + "'," + _RoomID + "," + _ClientID + ", 0)";
                        srd = sqlcon.ExecuteReader();
                        SQLiteCommand sqlcon2 = new SQLiteCommand(sql);
                        sqlcon2.CommandText = @"UPDATE Room SET Status = 'занят' WHERE RoomID = " + _RoomID + " ";
                        SQLiteDataReader srd2 = sqlcon2.ExecuteReader();
                        sql.Close();
                        MessageBox.Show("Клиент был заселён в номер");
                        Close();
                    }
                }
            }
            else
            {
                sql.Open();
                sqlcon = new SQLiteCommand(sql);
                sqlcon.CommandText = @"INSERT INTO Contract(ContractID, Data, ArrivalDate, DepartureDate, RoomID, ClientID, BookID) VALUES(null,'" + dateTimePicker3.Value.Date.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "', '" + dateTimePicker2.Value.Date.ToString() + "'," + _RoomID + "," + _ClientID + ", 0)";
                srd = sqlcon.ExecuteReader();
                SQLiteCommand sqlcon2 = new SQLiteCommand(sql);
                sqlcon2.CommandText = @"UPDATE Room SET Status = 'занят' WHERE RoomID = " + _RoomID + " ";
                SQLiteDataReader srd2 = sqlcon2.ExecuteReader();
                sql.Close();
                MessageBox.Show("Клиент был заселён в номер");
                Close();
            }
        }
    }
}
