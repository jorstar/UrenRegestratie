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
    public partial class ADM_NieuwProject : Form
    {
        public ADM_NieuwProject()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();
            Project proj = new Project();

            int ready = 0;

            if (txtProjectnaam.Text != "")
            {
                proj.naam = txtProjectnaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een naam in.");
                ready = 1;
            }

            if (txtProjectomschrijving.Text != "")
            {
                proj.omschrijving = txtProjectomschrijving.Text;
            }
            else
            {
                proj.omschrijving = "";
            }

            if (dateTimeBegin.Text != "")
            {
                proj.beginDatum = dateTimeBegin.Value;
            }
            else
            {
                MessageBox.Show("Vul een begindatum in.");
                ready = 1;
            }
            proj.afgesloten = false;


            if (ready == 0)
            {
                fw.Projects.Add(proj);
                fw.SaveChanges();
                MessageBox.Show("Project is aangemaakt.");
            }
                else
            {
                ready = 0;
                MessageBox.Show("Uw project is niet aangemaakt.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
