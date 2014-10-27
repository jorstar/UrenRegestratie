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

            var projectens = (from p in EntityModel.Projects
                              join ut in EntityModel.user_taak
                              on p.ID equals ut.projectID
                              join en in EntityModel.Engineers
                              on ut.userID equals en.userID
                              where en.userID == uid
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProject.DisplayMember = "projectnaam";
            combProject.ValueMember = "projectid";
            combProject.DataSource = projectens;

            var taak = (from p in EntityModel.taaks
                        join ut in EntityModel.user_taak
                        on p.taakID equals ut.taakID
                        join en in EntityModel.Engineers
                        on ut.userID equals en.userID
                        where en.userID == uid
                        select new { taakid = p.taakID, taaknaam = p.naam }).ToList();
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
    }
}
