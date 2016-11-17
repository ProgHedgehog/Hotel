using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Hotel
{
    class CommonFunctions
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        //Заменить  в форме "Rooms change" 
        public void InsertIntoCombobx(string ItemName, string TableName, ComboBox ComboboxName)
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

        // заменить в форме "Rooms change"
        public void ShowDB(string TableName, DataGridView DataGridViewName)
        {
            sql.Open();
            try
            {
                SQLiteCommand sqlcon = new SQLiteCommand(sql);
                sqlcon.CommandText = @"SELECT * FROM " + TableName + ";";
                SQLiteDataReader srd = sqlcon.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(srd);
                DataGridViewName.DataSource = dt;
                srd.Close();
            }
            catch
            {
                MessageBox.Show("Вывод базы данных невозможен");
            }

            sql.Close();
        }

        public void Add_NewINFO_ToDB()
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
        }

    }
}
