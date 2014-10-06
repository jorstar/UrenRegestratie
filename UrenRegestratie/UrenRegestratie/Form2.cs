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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //en koppel de classes met de comboboxen van urenregistratieform
            //
        }


        private void urenregistratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrenRegestratieForm newFrm = new UrenRegestratieForm();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void deProjectenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projecten newFrm = new projecten();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void nieuwProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwProject newFrm = new NieuwProject();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void deGebruikersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gebruiker newFrm = new Gebruiker();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void nieuweGebruikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuweGebruiker newFrm = new NieuweGebruiker();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home newFrm = new home();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
    }
}
