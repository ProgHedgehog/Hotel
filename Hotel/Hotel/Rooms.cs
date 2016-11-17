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
using System.IO;

namespace Hotel
{
    public partial class Rooms : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public List<string> Request_Data = new List<string>();
        public Rooms()
        {
            InitializeComponent();
            ShowDB("Room");
        }

        private void ShowDB(string TableName)
        {
            sql.Open();
            try
            {
                SQLiteCommand sqlcon = new SQLiteCommand(sql);
                sqlcon.CommandText = @"SELECT * FROM "+TableName+";";
                SQLiteDataReader srd = sqlcon.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(srd);
                RoomsdataGridView.DataSource = dt;
                srd.Close();
            }
            catch
            {
                MessageBox.Show("Вывод базы данных невозможен");
            }

            sql.Close();
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //Hide();
            this.Close();
            Clients cl = new Clients("From_Rooms");
            cl.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string line;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader file = new StreamReader(openFileDialog1.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                sql.Open();
                                SQLiteCommand command_insert = new SQLiteCommand(line, sql);
                                command_insert.ExecuteNonQuery();
                                sql.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            //RoomsChange rc = new RoomsChange(ID);
            //rc.Show();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            RoomsChange rc = new RoomsChange(Request_Data);
            rc.Show();
            this.Close();
        }

        private void RoomsdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Request_Data.Clear();
            Editbtn.Enabled = true;
            Deletebtn.Enabled = true;
            Request_Data.Add(RoomsdataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString());
            Request_Data.Add(RoomsdataGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString());
            Request_Data.Add(RoomsdataGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString());
            Request_Data.Add(RoomsdataGridView.Rows[e.RowIndex].Cells["TypeName"].Value.ToString());
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string current_name = RoomsdataGridView[1, RoomsdataGridView.CurrentRow.Index].Value.ToString();
            sql.Open();
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"DELETE FROM Room WHERE Name = '" + current_name + "';";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            sql.Close();
            RoomsdataGridView.Rows.Remove(RoomsdataGridView.CurrentRow);
        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {

            if (Filtercmbb.Text != "все")
            {
                sql.Open();
                try
                {
                    SQLiteCommand sqlcon = new SQLiteCommand(sql);
                    sqlcon.CommandText = @"SELECT * FROM Room WHERE Status = '" + Filtercmbb.Text + "';";
                    SQLiteDataReader srd = sqlcon.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(srd);
                    RoomsdataGridView.DataSource = dt;
                    srd.Close();
                }
                catch
                {
                    MessageBox.Show("Вывод базы данных невозможен");
                }
                sql.Close();
            }
            else
            {
                ShowDB("Room");
            }

        }

        private void Filtercmbb_SelectedValueChanged(object sender, EventArgs e)
        {
            Filterbtn.Enabled = true;
        }
        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}