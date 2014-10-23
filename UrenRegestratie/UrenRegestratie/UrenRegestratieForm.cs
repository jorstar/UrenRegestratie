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
        public UrenRegestratieForm()
        {
            InitializeComponent();
        }

        private void UrenRegestratieForm_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();

            var users = (from p in EntityModel.Engineers
                              select new { projectid = p.userID, projectnaam = p.gebruikersnaam }).ToList();
            combUser.DisplayMember = "userid";
            combUser.ValueMember = "gebruikersnaam";
            combUser.DataSource = users;

            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProject.DisplayMember = "projectnaam";
            combProject.ValueMember = "projectid";
            combProject.DataSource = projectens;

            var taak = (from p in EntityModel.taaks
                              select new { taakid = p.taakID, taaknaam = p.naam }).ToList();
            combTaak.DisplayMember = "taaknaam";
            combTaak.ValueMember = "taakid";
            combTaak.DataSource = taak;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {

        }
    }
}
