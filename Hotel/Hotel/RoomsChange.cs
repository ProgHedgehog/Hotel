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
                AddToCombobox("TypeName", "Room", Typecmbb);
                Nametb.Text = Data_For_Request[0];
                Current_Name = Data_For_Request[0];
                Descriptiontb.Text = Data_For_Request[1];
                Pricetb.Text = Data_For_Request[2];
                if (Typecmbb.Items.Contains(Data_For_Request[3]))
                {
                    Typecmbb.Text = Data_For_Request[3];
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
            string sql_request = "SELECT "+ItemName+" FROM "+TableName+" ";
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
            sql.Open();
            string check_name = "UPDATE Room SET Name = '" + Convert.ToString(Nametb.Text) + "', Description = '" + Convert.ToString(Descriptiontb.Text) + "', Price = " + Convert.ToDouble(Pricetb.Text) + ", TypeName = '" + Convert.ToString(Typecmbb.Text) + "' WHERE Name LIKE '" + Current_Name + "'";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            sql.Close();
            if (MessageBox.Show("Изменения были успешно сохранены!") == DialogResult.OK)
            {
                this.Close();
                Rooms room = new Rooms();
                room.Show();
            }
        }
    }
}