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
    public partial class ADM_projectenForm : Form
    {

        public ADM_projectenForm()
        {
            InitializeComponent();
        }

        

        private void projecten_Load(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              where p.afgesloten == false
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnProjAfsl_Click(object sender, EventArgs e)
        {
            try
            { 
            UrenRegCon fw = new UrenRegCon();

            int projid = Convert.ToInt16(combProjecten.SelectedValue);


            var projafsl = from proj in fw.Projects
                         where proj.ID == projid
                         select proj;
            Project objafsl = projafsl.Single();

            objafsl.afgesloten = true;
            objafsl.eindDatum = DateTime.Today;

            fw.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ADM_NieuwProject newFrm = new ADM_NieuwProject();
            newFrm.MdiParent = Form2.ActiveForm;
            newFrm.WindowState = FormWindowState.Maximized;
            newFrm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            { 
            if(radioBNiet.Checked == true)
            {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              where p.afgesloten == false
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            else if(radioBWel.Checked == true)
            {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet afgesloten projecten wilt zien.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            { 
            if(radioBNiet.Checked == true)
            {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              where p.afgesloten == false
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            else if (radioBWel.Checked == true)
            {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
            }
            else
            {
                MessageBox.Show("selecteer of u wel of niet afgesloten proecten wilt zien.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void combProjecten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int hetproject = (int)combProjecten.SelectedValue;

                UrenRegCon EntityModel = new UrenRegCon();
                var projectens = (from p in EntityModel.Projects
                                  where p.ID == hetproject
                                  select new { projectid = p.ID, projectnaam = p.naam, begindatum = p.beginDatum, taken = p.taaks }).ToList();

                GridviewProjecten.DataSource = projectens;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
