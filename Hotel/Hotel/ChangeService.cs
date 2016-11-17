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
    public partial class ChangeService : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public int ID;
        public ChangeService(List<string> RequestedData)
        {
            InitializeComponent();
            ID = Convert.ToInt32(RequestedData[0]);
            Name_tb.Text = RequestedData[1];
            Description_tb.Text = RequestedData[2];
            Price_tb.Text = RequestedData[3];
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            string check_name = "UPDATE AdditionalService SET Name = '" + Convert.ToString(Name_tb.Text) + "', Description = '" + Convert.ToString(Description_tb.Text) + "', Price = " + Convert.ToDouble(Price_tb.Text) + " WHERE AdditionalServiceID LIKE " + ID + "";
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
