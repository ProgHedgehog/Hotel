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
    public partial class Services : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public List<string> Request_Data = new List<string>();
        CommonFunctions function = new CommonFunctions();
        public Services(string flag)
        {

            InitializeComponent();
            if (flag == "From_Form1")
            {
                BackBtn.Enabled = false;
            }
            else
            {
                if (flag == "From_Rooms")
                {
                    BackBtn.Enabled = true;
                }
            }
            function.ShowDB("AdditionalService", Service_dataGridView);
        }

        private void ServEdit_btn_Click(object sender, EventArgs e)
        {
            
            ChangeService ch = new ChangeService(Request_Data);
            ch.Show();
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void SevAdd_btn_Click(object sender, EventArgs e)
        {
            function.Add_NewINFO_ToDB();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Clients cl = new Clients("From_Rooms",0);
            cl.Show();
        }

        private void Service_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Request_Data.Clear();
            Request_Data.Add(Service_dataGridView.Rows[e.RowIndex].Cells["AdditionalServiceID"].Value.ToString());
            Request_Data.Add(Service_dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString());
            Request_Data.Add(Service_dataGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString());
            Request_Data.Add(Service_dataGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString());
        }

        private void ServDelete_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"DELETE FROM AdditionalService WHERE AdditionalServiceID = '" + Request_Data[0] + "';";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            sql.Close();
            Service_dataGridView.Rows.Remove(Service_dataGridView.CurrentRow);
        }
    }
}
