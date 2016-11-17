using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class PopulatedClients : Form
    {
        public PopulatedClients()
        {
            InitializeComponent();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ClientsInformation ci = new ClientsInformation();
            ci.Show();
        }
    }
}
