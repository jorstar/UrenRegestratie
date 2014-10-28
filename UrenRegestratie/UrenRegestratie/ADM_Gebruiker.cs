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

        //private void btnVerwijderGebruiker_Click(object sender, EventArgs e)
        //{
        //    UrenRegCon fw = new UrenRegCon();

        //    int degebruiker = Convert.ToInt16(combGebruikers.SelectedValue);


        //    var engmod = from eng in fw.Engineers
        //              where eng.userID == degebruiker
        //              select eng;
        //    Engineer objeng = engmod.Single();

        //    objeng.actief = false;

        //    fw.SaveChanges();
        //}

        private void Gebruiker_Load(object sender, EventArgs e)
        {           
            //entity model
            UrenRegCon ef = new UrenRegCon();
            
            //kijk welke radiobutton actief is
            if (rdbActief.Checked)
            {
                btnActieveer.Enabled = false;
                var users = (from p in ef.Engineers
                             where p.actief == true && p.userID != uid
                             select new { id = p.userID, voornaam = p.voornaam, achternaam = p.achternaam }).ToList();

                
                lbGebruikers.DataSource = users;
                lbGebruikers.ValueMember = "id";
                lbGebruikers.DisplayMember = "voornaam" + " " + "achternaam";
                
                
              
            }
            else if (rdbDeactief.Checked)
            {
                btnDeactiveer.Enabled = false;
                var users = from p in ef.Engineers
                             where p.actief == false
                             select p;

                Engineer eng = (Engineer)users;
                lbGebruikers.DisplayMember = eng.voornaam + eng.achternaam;
                lbGebruikers.ValueMember = eng.userID.ToString();
                lbGebruikers.DataSource = users.ToList();
            }
        }

       


        private void checkChanged(object sender, EventArgs e)
        {
            //entity model
            UrenRegCon ef = new UrenRegCon();

            //kijk welke radiobutton geselecteerd is
            if (rdbActief.Checked)
            {
                btnActieveer.Enabled = false;
                var users = from p in ef.Engineers
                            where p.actief == true
                            select p;
                Engineer eng = (Engineer)users;
                lbGebruikers.DisplayMember = eng.voornaam + eng.achternaam;
                lbGebruikers.DataSource = users.ToList();
            }
            else if (rdbDeactief.Checked)
            {
                btnDeactiveer.Enabled = false;
                var users = from p in ef.Engineers
                            where p.actief == false
                            select p;

                Engineer eng = (Engineer)users;
                lbGebruikers.DisplayMember = eng.voornaam + eng.achternaam;
                lbGebruikers.DataSource = users.ToList();
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet inactive gebruikers wilt zien.");
            }
        }
        

        //private void btnActiveer_Click(object sender, EventArgs e)
        //{
        //    UrenRegCon fw = new UrenRegCon();

        //    int degebruiker = Convert.ToInt16(combGebruikers.SelectedValue);


        //    var engmod = from eng in fw.Engineers
        //                 where eng.userID == degebruiker
        //                 select eng;
        //    Engineer objeng = engmod.Single();

        //    objeng.actief = true;

        //    fw.SaveChanges();
        //}
    }
}
