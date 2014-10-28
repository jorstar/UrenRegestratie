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
    public partial class home : Form
    {
        private int uid;
        public home(int userid)
        {
            InitializeComponent();
            uid = userid;
        }

        private void home_Load(object sender, EventArgs e)
        {
            UrenRegCon ent = new UrenRegCon();
            lblVoornaam.Text = (from u in ent.Engineers
                                where u.userID == uid
                                select u.voornaam).First();

            lblAchternaam.Text = (from u in ent.Engineers
                                  where u.userID == uid
                                  select u.achternaam).First();


            var home = (from ut in ent.user_taak
                       where ut.userID == uid
                       select new { project = ut.Project.naam, taak = ut.taak.naam }).ToList();
            dgvprotaak.DataSource = home;


        }
    }
}
