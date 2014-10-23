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
            //en koppel de classes met de comboboxen van urenregistratieform
            //
            int user = uid;
            DisposeAllChilds();
            home newFrm = new home(uid);
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }


        private void urenregistratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            UrenRegestratieForm newFrm = new UrenRegestratieForm();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void deProjectenToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DisposeAllChilds();
                projectenForm newFrm = new projectenForm();
                newFrm.MdiParent = this;
                newFrm.WindowState = FormWindowState.Maximized;
                newFrm.Show();
        }

        private void nieuwProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            NieuwProject newFrm = new NieuwProject();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void deGebruikersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            Gebruiker newFrm = new Gebruiker();
            newFrm.MdiParent = this;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void nieuweGebruikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllChilds();
            NieuweGebruiker newFrm = new NieuweGebruiker();
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
