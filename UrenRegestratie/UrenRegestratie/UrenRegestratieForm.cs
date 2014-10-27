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
    public partial class UrenRegestratieForm : Form
    {
        public int uid;
        public UrenRegestratieForm(int userid)
        {
            InitializeComponent();
            uid = userid;
        }

        private void UrenRegestratieForm_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            var projectens = (from ut in EntityModel.user_taak
                              where ut.Engineer.userID == uid
                              group ut by new {ut.projectID, ut.Project.naam}  into p
                              select new { projectid = p.Key.projectID, projectnaam = p.Key.naam }).ToList();
            
            combProject.DisplayMember = "projectnaam";
            combProject.ValueMember = "projectid";
            combProject.DataSource = projectens;

            int projecid = Convert.ToInt16(combProject.SelectedValue);

            var taak = (from ut in EntityModel.user_taak
                        where ut.Engineer.userID == uid && ut.Project.ID == projecid
                        select new { taakid = ut.taak.taakID, taaknaam = ut.taak.naam }).ToList();
            combTaak.DisplayMember = "taaknaam";
            combTaak.ValueMember = "taakid";
            combTaak.DataSource = taak;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            UrenRegCon fw = new UrenRegCon();
            Regestratie reg = new Regestratie();

            
            reg.userID = uid;
            

            if (combProject.SelectedValue != "")
            {
                reg.projectID = Convert.ToInt16(combProject.SelectedValue);
            }
            else
            {
                MessageBox.Show("Selecteer een project.");
            }

            if (combTaak.SelectedValue != "")
            {
                reg.taakID = Convert.ToInt16(combTaak.SelectedValue);
            }
            else
            {
                MessageBox.Show("Selecteer een taak.");
            }

            if (dateTimePicker1.Text != "")
            {
                reg.datum = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Vul een datum in.");
            }

            if (txtVerantwoording.Text != "")
            {
                reg.verantwoording = txtVerantwoording.Text;
            }
            else
            {
                MessageBox.Show("Vul je verantwoording in.");
            }

            if (txtAantalUren.Text != "")
            {
                reg.uren = Convert.ToInt16(txtAantalUren.Text);
            }
            else
            {
                MessageBox.Show("Vul uw aantal uren in.");
            }




            fw.Regestraties.Add(reg);
            fw.SaveChanges(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
