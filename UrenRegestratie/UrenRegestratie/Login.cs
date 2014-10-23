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
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region newUSER
            //UrenRegCon fw = new UrenRegCon();
            //Engineer en = new Engineer();
            //en.userID = 2;
            //en.voornaam = "user";
            //en.achternaam = "user";
            //en.gebruikersnaam = "user";
            //en.wachtwoord = CalculateHashedPassword("USER", "user");
            //en.permissie = false;
            //fw.Engineers.Add(en);
            //fw.SaveChanges(); 
            #endregion                        
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
                UrenRegCon EntityModel = new UrenRegCon();
                string user = tbUsername.Text;
                string pass = CalculateHashedPassword(tbPassword.Text, user);
                tbPassword.Text = "";
                tbUsername.Text = "";

                var Gebruiker = (from E in EntityModel.Engineers
                                 where E.gebruikersnaam == user && E.wachtwoord == pass
                                 select E.userID).First();
                //if (Gebruiker != null)
                //{
                int uid = Convert.ToInt16(Gebruiker);

                    Form2 frm = new Form2(uid);
                    frm.Show();
                    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Incorrect username / password");
                //}
                
            }
            catch(EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect username / password");
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

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }

        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }
        }
    }
}
