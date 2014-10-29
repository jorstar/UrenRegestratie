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

        UrenRegCon EntityModel = new UrenRegCon();

        private void projecten_Load(object sender, EventArgs e)
        {
            checkchanged();
            vulcmb();
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
            checkchanged();
            vulcmb();
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
            checkchanged();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkchanged();
        }

        private void checkchanged()
        {
            try
            {
                if (radioBNiet.Checked == true)
                {                   
                    var projectens = (from p in EntityModel.Projects
                                      where p.afgesloten == false
                                      select new { ID = p.ID, Naam = p.naam, Omschrijving = p.omschrijving, Afgesloten = p.afgesloten }).ToList();
                    GridviewProjecten.DataSource = projectens;
                }
                else if (radioBWel.Checked == true)
                {                    
                    var projectens = (from p in EntityModel.Projects
                                      select new { ID = p.ID, Naam = p.naam, Omschrijving = p.omschrijving, Afgesloten = p.afgesloten }).ToList();
                    GridviewProjecten.DataSource = projectens;
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
        private void vulcmb()
        {
            try
            {
                var projects = (from p in EntityModel.Projects
                                where p.afgesloten == false
                                select new { ID = p.ID, Naam = p.naam }).ToList();
                combProjecten.DisplayMember = "Naam";
                combProjecten.ValueMember = "ID";
                combProjecten.DataSource = projects;
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
       
    }
}
