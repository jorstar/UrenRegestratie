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
    public partial class Login : Form
    {
        UrenRegCon EntityModel = new UrenRegCon();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //programma sluiten
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = tbUsername.Text;
                string pass = CalculateHashedPassword(tbPassword.Text, user);
                tbPassword.Text = "";
                tbUsername.Text = "";

                var Gebruiker = from E in EntityModel.Engineers
                               where E.gebruikersnaam == user || E.wachtwoord == pass
                               select new { E.voornaam, E.achternaam, E.permissie, E.foto };

                
            }
            catch(Exception ex)
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
