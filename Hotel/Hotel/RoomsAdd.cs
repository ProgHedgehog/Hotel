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
    public partial class RoomsAdd : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public RoomsAdd()
        {
            InitializeComponent();
            AddToCombobox("TypeName", "Room", Typecmbb);
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
            sql.Open();
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"insert into room(roomID, Name, Description, Status, Price, TypeName) values(null, '" + Convert.ToString(Nametb.Text) + "', '" + Convert.ToString(Descriptiontb.Text) + "', 'свободен'," + Convert.ToDouble(Pricetb.Text) + ", '" + Convert.ToString(Typecmbb.Text) + "');";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            MessageBox.Show("Номер добавлен");
            sql.Close();
            Close();
        }
    }
}
