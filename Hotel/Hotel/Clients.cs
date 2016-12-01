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
    public partial class Clients : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        CommonFunctions function = new CommonFunctions();
        public List<string> Request_Data = new List<string>();
        public string Current_Flag;
        public int Selected_Room_ID;
        public Clients(string flag, int room_id)
        {

            Current_Flag = flag;
            Selected_Room_ID = room_id;
            if (flag == "From_Form1")
            {
                InitializeComponent();
                function.ShowDB("Client", ClientsdataGridView);
                ChooseBtn.Enabled = false;
                BackBtn.Enabled = false;
                SettleBtn.Enabled = false;
                BookBtn.Enabled = false;
            }
            else
            {
                if (flag == "From_Rooms")
                {
                    InitializeComponent();
                    function.ShowDB("Client", ClientsdataGridView);
                    ChooseBtn.Enabled = true;
                    BackBtn.Enabled = true;
                }
            }
            
        }
        Rooms rm = new Rooms();
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            //Rooms rm = new Rooms();
            rm.Show();
        }

        private void SettleBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ToSettle ts = new ToSettle(Selected_Room_ID, Convert.ToInt32(ID_tb.Text));
            ts.Show();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Booking bk = new Booking(Selected_Room_ID,Convert.ToInt32(ID_tb.Text));
            bk.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            function.Add_NewINFO_ToDB();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            ClientsAdd cla = new ClientsAdd(Request_Data);
            cla.Show();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Services sr = new Services("From_Rooms");
            sr.Show();
        }

        private void ClientsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Request_Data.Clear();
            Request_Data.Add(ClientsdataGridView.Rows[e.RowIndex].Cells["ClientID"].Value.ToString());
            Request_Data.Add(ClientsdataGridView.Rows[e.RowIndex].Cells["FIO"].Value.ToString());
            Request_Data.Add(ClientsdataGridView.Rows[e.RowIndex].Cells["Passport"].Value.ToString());
            Request_Data.Add(ClientsdataGridView.Rows[e.RowIndex].Cells["Number"].Value.ToString());
            ID_tb.Text = Request_Data[0];
            Selected_tb.Text = Request_Data[1];
            BookBtn.Enabled = true;
            SettleBtn.Enabled = true;
        }

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            sql.Open();
            SQLiteCommand sqlcon = new SQLiteCommand(sql);
            sqlcon.CommandText = @"DELETE FROM Client WHERE FIO = '" + Selected_tb.Text + "';";
            SQLiteDataReader srd = sqlcon.ExecuteReader();
            sql.Close();
            ClientsdataGridView.Rows.Remove(ClientsdataGridView.CurrentRow);
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}