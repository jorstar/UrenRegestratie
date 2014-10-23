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
            UrenRegCon fw = new UrenRegCon();
            Engineer en = new Engineer();

            en.userID = 2;                    //hoe bepaal ik welk nummer nu komt?

            if(txtVoornaam.Text != "")
            {
                en.voornaam = txtVoornaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een voornaam in.");
            }
            
            if(txtAchternaam.Text != "")
            {
                en.achternaam = txtAchternaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een achternaam in.");
            }
            
            if(txtGebruikersnaam.Text != "")
            {
                en.gebruikersnaam = txtGebruikersnaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een gebruikersnaam in.");
            }

            if (txtWachtwoord.Text != "")
            {
                en.wachtwoord = CalculateHashedPassword(txtWachtwoord.Text, txtGebruikersnaam.Text);
            }
            else
            {
                MessageBox.Show("Vul een wachtwoord in.");
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
            }
            fw.Engineers.Add(en);
            fw.SaveChanges(); 
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
