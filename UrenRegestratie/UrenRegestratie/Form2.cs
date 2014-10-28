using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegestratie
{
    public partial class Form2 : Form
    {
        public int uid;
        public Form2(int userid)
        {
            InitializeComponent();
            uid = userid;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            var Adofnor = (from p in EntityModel.Engineers
                         where p.userID == uid
                           select p).First();

            Engineer eng = (Engineer)Adofnor;
            if(!eng.permissie)
            {
                projectenToolStripMenuItem.Visible = false;
                takenToolStripMenuItem.Visible = false;
                gebruikersToolStripMenuItem.Visible = false;
            }

            DisposeAllChilds();
            home newFrm = new home(uid);
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }


        private void urenregistratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            UrenRegestratieForm newFrm = new UrenRegestratieForm(uid);
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void deProjectenToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DisposeAllChilds();
                ADM_projectenForm newFrm = new ADM_projectenForm();
                newFrm.MdiParent = this;
                newFrm.WindowState = FormWindowState.Maximized;
                newFrm.Show();
        }

        private void nieuwProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            ADM_NieuwProject newFrm = new ADM_NieuwProject();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void deGebruikersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            ADM_Gebruiker newFrm = new ADM_Gebruiker(uid);
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void nieuweGebruikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            ADM_NieuweGebruiker newFrm = new ADM_NieuweGebruiker();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            home newFrm = new home(uid);
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;            
            newFrm.Show();
        }
        private void deTakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            ADM_NieuweTaken newFrm = new ADM_NieuweTaken();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }
        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void DisposeAllChilds()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        
    }
}
