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
        private int uid;
        public ADM_Gebruiker(int userid)
        {
            InitializeComponent();
            uid = userid;
        }

        private void Gebruiker_Load(object sender, EventArgs e)
        {
            checkChanged();
            cmbperms.Enabled = false;
            cmbperms.Visible = false;
        }

        private void checkChanged()
        {
            //entity model
            UrenRegCon ef = new UrenRegCon();

            try
            {
                //kijk welke radiobutton actief is
                if (rdbActief.Checked)
                {
                    btnActieveer.Enabled = false;
                    var users = (from p in ef.Engineers
                                 where p.actief == true && p.userID != uid
                                 select new { naam = p.voornaam + " " + p.achternaam, id = p.userID }).ToList();

                    cmbGebruikers.DisplayMember = "naam";
                    cmbGebruikers.ValueMember = "id";
                    cmbGebruikers.DataSource = users;
                    btnActieveer.Enabled = false;
                    btnDeactiveer.Enabled = true;

                }
                else if (rdbDeactief.Checked)
                {
                    btnActieveer.Enabled = false;
                    var users = (from p in ef.Engineers
                                 where p.actief == false
                                 select new { naam = p.voornaam + " " + p.achternaam, id = p.userID }).ToList();

                    cmbGebruikers.DisplayMember = "naam";
                    cmbGebruikers.ValueMember = "id";
                    cmbGebruikers.DataSource = users;
                    btnActieveer.Enabled = true;
                    btnDeactiveer.Enabled = false;
                }
                SelectedName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectedName()
        {
            //entity model
            UrenRegCon ef = new UrenRegCon();
            try
            {
                //userid
                int id = (int)cmbGebruikers.SelectedValue;

                var user = from u in ef.Engineers
                           where u.userID == id
                           select u;
                Engineer eng = (Engineer)user.Single();
                tbVoornaam.Text = eng.voornaam;
                tbAchternaam.Text = eng.achternaam;
                tbGebruikersnaam.Text = eng.gebruikersnaam;
                tbWw.Text = "";
                if (eng.actief)
                {
                    lblActief.Text = "Ja";

                }
                else
                {
                    lblActief.Text = "Nee";
                }
                if(eng.permissie)
                {
                    lblPerms.Text = "Administrator";
                    cmbperms.SelectedItem = "Administrator";
                }
                else
                {
                    lblPerms.Text = "Gebruiker";
                    cmbperms.SelectedItem = "Gebruiker";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedName();
        }

        private void rdbDeactief_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void rdbActief_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void btnActieveer_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();

            int degebruiker = (int)cmbGebruikers.SelectedValue;


            var engmod = from eng in fw.Engineers
                         where eng.userID == degebruiker
                         select eng;
            Engineer objeng = engmod.Single();

            objeng.actief = true;

            fw.SaveChanges();
            checkChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeactiveer_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();

            int degebruiker = (int)cmbGebruikers.SelectedValue;


            var engmod = from eng in fw.Engineers
                         where eng.userID == degebruiker
                         select eng;
            Engineer objeng = engmod.Single();

            objeng.actief = false;

            fw.SaveChanges();
            checkChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbAchternaam.ReadOnly = false;
            tbGebruikersnaam.ReadOnly = false;
            tbVoornaam.ReadOnly = false;
            tbWw.ReadOnly = false;
            lblPerms.Visible = false;
            cmbperms.Visible = true;
            cmbperms.Enabled = true;
            btnOpslaan.Enabled = true;
            btnCancel.Enabled = true;

        }

        private static string CalculateHashedPassword(string clearpwd, string loginnaam)
        {

            using (var sha = System.Security.Cryptography.SHA256.Create())
            {

                var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

                return Convert.ToBase64String(computedHash);

            }

        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();

            int degebruiker = (int)cmbGebruikers.SelectedValue;


            var engmod = from eng in fw.Engineers
                         where eng.userID == degebruiker
                         select eng;

            Engineer objeng = engmod.Single();


            if (tbAchternaam.Text != "" && tbGebruikersnaam.Text != "" && tbVoornaam.Text != "")
            {
                objeng.voornaam = tbVoornaam.Text;
                objeng.achternaam = tbAchternaam.Text;
                objeng.gebruikersnaam = tbGebruikersnaam.Text;
                if (cmbperms.SelectedItem.ToString() == "Administrator")
                {
                    objeng.permissie = true;
                }
                else if(cmbperms.SelectedItem.ToString() == "Gebruiker")
                {
                    objeng.permissie = false;
                }
                if (tbWw.Text != "")
                {
                    objeng.wachtwoord = CalculateHashedPassword(tbWw.Text, tbGebruikersnaam.Text);
                }
                fw.SaveChanges();
            }
            else
            {
                MessageBox.Show("voer alle gegevens in");
            }
            tbWw.Text = "";
            tbAchternaam.ReadOnly = true;
            tbGebruikersnaam.ReadOnly = true;
            tbVoornaam.ReadOnly = true;
            tbWw.ReadOnly = true;
            cmbperms.Enabled = false;
            cmbperms.Visible = false;
            lblPerms.Visible = true;
            btnOpslaan.Enabled = false;
            btnCancel.Enabled = false;
            SelectedName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbAchternaam.ReadOnly = true;
            tbGebruikersnaam.ReadOnly = true;
            tbVoornaam.ReadOnly = true;
            tbWw.ReadOnly = true;
            cmbperms.Enabled = false;
            cmbperms.Visible = false;
            lblPerms.Visible = true;
            btnOpslaan.Enabled = false;
            btnCancel.Enabled = false;
            SelectedName();
        }

       
    }
}
