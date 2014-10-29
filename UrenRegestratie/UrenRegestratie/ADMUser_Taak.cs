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
    public partial class ADMUser_Taak : Form
    {
        public ADMUser_Taak()
        {
            InitializeComponent();
        }
        //entity framework
        UrenRegCon ef = new UrenRegCon();

        private void ADMUser_Taak_Load(object sender, EventArgs e)
        {
            try
            {
                var gebruikers = (from u in ef.Engineers
                                 select new {id = u.userID ,naam = u.voornaam + " " + u.achternaam}).ToList();

                cmbGebruiker.DisplayMember = "naam";
                cmbGebruiker.ValueMember = "id";
                cmbGebruiker.DataSource = gebruikers;

                var projecten = (from p in ef.Projects
                                 select new { projid = p.ID, pnaam = p.naam }).ToList();

                cmbProject.DisplayMember = "pnaam";
                cmbProject.ValueMember = "projid";
                cmbProject.DataSource = projecten;

                var taken = (from t in ef.taaks
                             where t.projectID == (int)cmbProject.SelectedValue
                             select new { tid = t.taakID, tnaam = t.naam }).ToList();

                cmbTaak.DisplayMember = "tnaam";
                cmbTaak.ValueMember = "tid";
                cmbTaak.DataSource = taken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var taken = (from t in ef.taaks
                             where t.projectID == (int)cmbProject.SelectedValue
                             select new { tid = t.taakID, tnaam = t.naam }).ToList();

                cmbTaak.DisplayMember = "tnaam";
                cmbTaak.ValueMember = "tid";
                cmbTaak.DataSource = taken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                user_taak ut = new user_taak();
                ut.userID = (int)cmbGebruiker.SelectedValue;
                ut.projectID = (int)cmbProject.SelectedValue;
                ut.taakID = (int)cmbTaak.SelectedValue;

                ef.user_taak.Add(ut);
                ef.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
