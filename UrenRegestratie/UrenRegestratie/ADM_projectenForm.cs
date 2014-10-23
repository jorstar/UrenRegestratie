﻿using System;
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

        private void combProjecten_Enter(object sender, EventArgs e)
        {
            
        }

        private void projecten_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
        }

        private void combProjecten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridviewProjecten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProjAfsl_Click(object sender, EventArgs e)
        {
            
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
    }
}
