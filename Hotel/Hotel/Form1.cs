using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Clients cl;
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new Clients("From_Form1", 0);
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

        Authorization au;
        private void AuthorisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (au == null)
            {
                au = new Authorization();
                au.Owner = this;
                au.Dock = DockStyle.Fill;
                if (UserRigts._login == null)
                {
                    au.EnterBtn.Text = "Вход";
                }
                else
                {
                    au.EnterBtn.Text = "Выход";
                }
                au.Location =new Point(this.Top+10,this.Left+56);
                au.Width = this.Width - 20;
                au.Height = this.Height - 65;
                au.ShowDialog();
            }
            else
            {
                if (UserRigts._login != "")
                {
                    au.EnterBtn.Text = "Выход";
                }
                else
                {
                    au.EnterBtn.Text = "Вход";
                }
                au.ShowDialog();
                au.Activate();
            }
        }

        AdminPanel adm;
        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (adm == null)
            {
                adm = new AdminPanel();
                adm.MdiParent = this;
                adm.Dock = DockStyle.Fill;
                adm.Show();
            }
            else
            {
                adm.Show();
                adm.Activate();
            }
        }

        public void Get_role(string role)
        {
            if (role == "superuser")
            {
                roomsWorkToolStripMenuItem.Visible = true;
                adminToolStripMenuItem.Visible = true;
                clientsToolStripMenuItem.Visible = true;
                populatesClientsToolStripMenuItem.Visible = true;
                roomsToolStripMenuItem.Visible = true;
                documentationToolStripMenuItem.Visible = true;
            }
            else
            {
                if (role == "Менеджер")
                {
                    adminToolStripMenuItem.Visible = true;
                    clientsToolStripMenuItem.Visible = true;
                    populatesClientsToolStripMenuItem.Visible = true;
                    roomsToolStripMenuItem.Visible = true;
                }
                else
                {
                    if (role == "Бухгалтер")
                    {
                        documentationToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        documentationToolStripMenuItem.Visible = false;
                    }
                }
            }
            this.Close();
        }

        PasswordChange pch;
        private void ChangePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pch == null)
            {   
                pch = new PasswordChange();
                pch.MdiParent = this;
                pch.Dock = DockStyle.Fill;
                pch.Show();
            }   
            else
            {   
                pch.Show();
                pch.Activate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();
        }
    }
}
