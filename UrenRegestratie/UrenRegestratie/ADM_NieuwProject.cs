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
            UrenRegCon fw = new UrenRegCon();
            Project proj = new Project();


            if (txtProjectnaam.Text != "")
            {
                proj.naam = txtProjectnaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een naam in.");
            }

            if (txtProjectomschrijving.Text != "")
            {
                proj.omschrijving = txtProjectomschrijving.Text;
            }
            else
            {
                MessageBox.Show("Vul een omschrijving in in.");
            }

            if (dateTimeBegin.Text != "")
            {
                proj.beginDatum = dateTimeBegin.Value;
            }
            else
            {
                MessageBox.Show("Vul een begindatum in.");
            }
            proj.afgesloten = false;
            


            fw.Projects.Add(proj);
            fw.SaveChanges(); 
        }
    }
}
