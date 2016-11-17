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
    public partial class Form1 : Form
    {
        string authorisation_status = "";
        Authorization au;
        public Form1()
        {
            InitializeComponent();
            DateBase db = new DateBase();
            db.AddDatabase();

            au = new Authorization();
            au.MdiParent = this;
            au.Dock = DockStyle.Fill;
            au.Show();
        }

        
        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (au == null)
            {
                au = new Authorization();
                au.MdiParent = this;
                au.Dock = DockStyle.Fill;
                au.Show();
            }
            else
            {
                au.Show();
                au.Activate();
            }
        }

        Clients cl;
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new Clients("From_Form1");
                cl.MdiParent = this;
                cl.Dock = DockStyle.Fill;
                cl.Show();
            }
            else
            {
                cl.Show();
                cl.Activate();
            }
        }

        Rooms rm;
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rm == null)
            {
                rm = new Rooms();
                rm.MdiParent = this;
                rm.Dock = DockStyle.Fill;
                rm.Show();
            }
            else
            {
                rm.Show();
                rm.Activate();
            }
        }

        Documents dc;
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dc == null)
            {
                dc = new Documents();
                dc.MdiParent = this;
                dc.Dock = DockStyle.Fill;
                dc.Show();
            }
            else
            {
                dc.Show();
                dc.Activate();
            }
        }

        PopulatedClients pc;
        private void populatesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pc == null)
            {
                pc = new PopulatedClients();
                pc.MdiParent = this;
                pc.Dock = DockStyle.Fill;
                pc.Show();
            }
            else
            {
                pc.Show();
                pc.Activate();
            }
        }

        Services sr;
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sr == null)
            {
                sr = new Services("From_Form1");
                sr.MdiParent = this;
                sr.Dock = DockStyle.Fill;
                sr.Show();
            }
            else
            {
                sr.Show();
                sr.Activate();
            }
        }

        private void roomsWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
