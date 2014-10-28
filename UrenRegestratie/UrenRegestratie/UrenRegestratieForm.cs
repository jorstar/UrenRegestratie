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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon EntityModel = new UrenRegCon();

            int projecid = Convert.ToInt16(combProject.SelectedValue);

            var taak = (from ut in EntityModel.user_taak
                        where ut.Engineer.userID == uid && ut.Project.ID == projecid
                        select new { taakid = ut.taak.taakID, taaknaam = ut.taak.naam }).ToList();
            combTaak.DisplayMember = "taaknaam";
            combTaak.ValueMember = "taakid";
            combTaak.DataSource = taak;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();
            Regestratie reg = new Regestratie();

            int ready = 0;

            reg.userID = uid;
            

            if (combProject.SelectedValue != "")
            {
                reg.projectID = Convert.ToInt16(combProject.SelectedValue);
            }
            else
            {
                MessageBox.Show("Selecteer een project.");
                ready = 1;
            }

            if (combTaak.SelectedValue != "")
            {
                reg.taakID = Convert.ToInt16(combTaak.SelectedValue);
            }
            else
            {
                MessageBox.Show("Selecteer een taak.");
                ready = 1;
            }

            if (dateTimePicker1.Text != "")
            {
                reg.datum = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Vul een datum in.");
                ready = 1;
            }

            if (txtVerantwoording.Text != "")
            {
                reg.verantwoording = txtVerantwoording.Text;
            }
            else
            {
                MessageBox.Show("Vul je verantwoording in.");
                ready = 1;
            }

            if (txtAantalUren.Text != "")
            {
                reg.uren = Convert.ToInt16(txtAantalUren.Text);
            }
            else
            {
                MessageBox.Show("Vul uw aantal uren in.");
                ready = 1;
            }



                if(ready == 0)
                {
            fw.Regestraties.Add(reg);
            fw.SaveChanges();
            MessageBox.Show("Uren zijn geregistreert.");
                }
                else
                {
                    ready = 0;
                    MessageBox.Show("registratie niet opgeslagen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        

        
    }
}
