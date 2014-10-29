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
    public partial class ADMTaken : Form
    {
        public ADMTaken()
        {
            InitializeComponent();
        }
        //model
        UrenRegCon ef = new UrenRegCon();

        private void ADMTaken_Load(object sender, EventArgs e)
        {
            vulcmb();
            selectionchanged();
        }
        private void vulcmb()
        {
            try
            {
                var projects = (from p in ef.Projects
                                where p.afgesloten == false
                                select new { id = p.ID, naam = p.naam }).ToList();
                cmbProjecten.DisplayMember = "naam";
                cmbProjecten.ValueMember = "id";
                cmbProjecten.DataSource = projects;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void selectionchanged()
        {
            var taken = (from t in ef.taaks
                         where t.projectID == (int)cmbProjecten.SelectedValue
                         select new { ID = t.taakID, Naam = t.naam, Omschrijving = t.omschrijving }).ToList();
            dgvTaken.DataSource = taken;
        }

        private void cmbProjecten_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionchanged();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ADM_NieuweTaken newFrm = new ADM_NieuweTaken();
            newFrm.MdiParent = Form2.ActiveForm;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }
    }
}
