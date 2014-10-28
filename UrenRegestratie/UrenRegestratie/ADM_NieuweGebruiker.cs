using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegestratie
{
    public partial class ADM_NieuweGebruiker : Form
    {
        public ADM_NieuweGebruiker()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();
            Engineer en = new Engineer();

            int ready = 0;

            if(txtVoornaam.Text != "")
            {
                en.voornaam = txtVoornaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een voornaam in.");
                ready = 1;
            }
            
            if(txtAchternaam.Text != "")
            {
                en.achternaam = txtAchternaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een achternaam in.");
                ready = 1;
            }
            
            if(txtGebruikersnaam.Text != "")
            {
                en.gebruikersnaam = txtGebruikersnaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een gebruikersnaam in.");
                ready = 1;
            }

            if (txtWachtwoord.Text != "")
            {
                en.wachtwoord = CalculateHashedPassword(txtWachtwoord.Text, txtGebruikersnaam.Text);
            }
            else
            {
                MessageBox.Show("Vul een wachtwoord in.");
                ready = 1;
            }
            
            if(radioBNormaleGebruiker.Checked == true)
            {
                en.permissie = false;
            }
            else if(radioBAdministrator.Checked == true)
            {
                en.permissie = true;
            }
            else
            {
                MessageBox.Show("Check aan of de gebruiker een normale gebruiker is of een administrator.");
                ready = 1;
            }


                if(ready == 0)
                {
            fw.Engineers.Add(en);
            fw.SaveChanges();
            MessageBox.Show("Gebruiker is aangemaakt.");
                }
                else
                {
                    ready = 0;
                    MessageBox.Show("Gebruiker niet aangemaakt.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string CalculateHashedPassword(string clearpwd, string loginnaam)
        {

            using (var sha = SHA256.Create())
            {

                var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

                return Convert.ToBase64String(computedHash);

            }

        }

        
    }
}
