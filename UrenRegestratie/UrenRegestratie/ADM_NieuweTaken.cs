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
    public partial class ADM_NieuweTaken : Form
    {
        public ADM_NieuweTaken()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            { 

            UrenRegCon fw = new UrenRegCon();
            taak taa = new taak();

            int ready = 0;


            taa.projectID = Convert.ToInt16(combProjecten.SelectedValue);

            if (txtTakenNaam.Text != "")
            {
                taa.naam = txtTakenNaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een naam in.");
                ready = 1;
            }

            if (txtTakenOmschrijving.Text != "")
            {
                taa.omschrijving = txtTakenOmschrijving.Text;
            }
            else
            {
                taa.omschrijving = "";
            }

            if (ready == 0)
            {
                fw.taaks.Add(taa);
                fw.SaveChanges();
            }
                else
            {
                ready = 0;
                MessageBox.Show("Uw taak is niet aangemaakt.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NieuweTaken_Load(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
