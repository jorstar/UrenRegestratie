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

        }

        private void Gebruiker_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            var users = (from p in EntityModel.Engineers
                         select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
            combGebruikers.DisplayMember = "userid";
            combGebruikers.ValueMember = "gebruikersnaam";
            combGebruikers.DataSource = users;
        }
    }
}
