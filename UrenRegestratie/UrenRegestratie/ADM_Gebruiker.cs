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
    public partial class ADM_Gebruiker : Form
    {
        public ADM_Gebruiker()
        {
            InitializeComponent();
        }

        private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        {
            UrenRegCon fw = new UrenRegCon();

            int degebruiker = Convert.ToInt16(combGebruikers.SelectedValue);


            var engmod = from eng in fw.Engineers
                      where eng.userID == degebruiker
                      select eng;
            Engineer objeng = engmod.Single();

            objeng.actief = false;

            fw.SaveChanges();
        }

        private void Gebruiker_Load(object sender, EventArgs e)
        {
            btnActiveer.Visible = false;

            UrenRegCon EntityModel = new UrenRegCon();

            if(radioBWel.Checked == true)
            {
            var users = (from p in EntityModel.Engineers
                         select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
            combGebruikers.DisplayMember = "gebruikersnaam";
            combGebruikers.ValueMember = "userid";
            combGebruikers.DataSource = users;
            }
            else if(radioBNiet.Checked == true)
            {
                var users = (from p in EntityModel.Engineers
                             where p.actief == true
                         select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
            combGebruikers.DisplayMember = "gebruikersnaam";
            combGebruikers.ValueMember = "userid";
            combGebruikers.DataSource = users;
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet inactive gebruikers wilt zien.");
            }
        }

       

        private void radioBWel_CheckedChanged(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            if (radioBWel.Checked == true)
            {
                var users = (from p in EntityModel.Engineers
                             select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
                combGebruikers.DisplayMember = "gebruikersnaam";
                combGebruikers.ValueMember = "userid";
                combGebruikers.DataSource = users;
            }
            else if (radioBNiet.Checked == true)
            {
                var users = (from p in EntityModel.Engineers
                             where p.actief == true
                             select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
                combGebruikers.DisplayMember = "gebruikersnaam";
                combGebruikers.ValueMember = "userid";
                combGebruikers.DataSource = users;
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet inactive gebruikers wilt zien.");
            }
        }

        private void radioBNiet_CheckedChanged(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            if (radioBWel.Checked == true)
            {
                var users = (from p in EntityModel.Engineers
                             select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
                combGebruikers.DisplayMember = "gebruikersnaam";
                combGebruikers.ValueMember = "userid";
                combGebruikers.DataSource = users;
            }
            else if (radioBNiet.Checked == true)
            {
                var users = (from p in EntityModel.Engineers
                             where p.actief == true
                             select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
                combGebruikers.DisplayMember = "gebruikersnaam";
                combGebruikers.ValueMember = "userid";
                combGebruikers.DataSource = users;
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet inactive gebruikers wilt zien.");
            }
        }

        private void btnActiveer_Click(object sender, EventArgs e)
        {
            UrenRegCon fw = new UrenRegCon();

            int degebruiker = Convert.ToInt16(combGebruikers.SelectedValue);


            var engmod = from eng in fw.Engineers
                         where eng.userID == degebruiker
                         select eng;
            Engineer objeng = engmod.Single();

            objeng.actief = true;

            fw.SaveChanges();
        }

        private void radioBNiet_Click(object sender, EventArgs e)
        {
            btnActiveer.Visible = false;
            btnVerwijderGebruiker.Visible = true;
        }

        private void radioBWel_Click(object sender, EventArgs e)
        {
            btnActiveer.Visible = true;
            btnVerwijderGebruiker.Visible = false;
        }
    }
}
