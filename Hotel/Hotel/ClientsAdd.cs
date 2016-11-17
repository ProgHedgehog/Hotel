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
    public partial class ClientsAdd : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        int ID;
        public ClientsAdd(List<string> Requested_Data)
        {
            InitializeComponent();
            ID = Convert.ToInt32(Requested_Data[0]);
            FIO_tb.Text = Requested_Data[1];
            Passport_tb.Text = Requested_Data[2];
            Number_tb.Text = Requested_Data[3];
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            string check_name = "UPDATE Client SET FIO = '" + Convert.ToString(FIO_tb.Text) + "', Passport = '" + Convert.ToString(Passport_tb.Text) + "', Number = " + Convert.ToDouble(Number_tb.Text) + " WHERE ClientID LIKE '" + ID + "'";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            sql.Close();
            if (MessageBox.Show("Изменения были успешно сохранены!") == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}