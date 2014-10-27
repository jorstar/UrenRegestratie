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
    public partial class ADM_NieuweTaken : Form
    {
        public ADM_NieuweTaken()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            UrenRegCon fw = new UrenRegCon();
            taak taa = new taak();

            taa.taakID = 2;                                      //hoe bepaal ik welk nummer nu komt?

            taa.projectID = combProjecten.SelectedValue;

            if (txtTakenNaam.Text != "")
            {
                taa.naam = txtTakenNaam.Text;
            }
            else
            {
                MessageBox.Show("Vul een naam in.");
            }

            if (txtTakenOmschrijving.Text != "")
            {
                taa.omschrijving = txtTakenOmschrijving.Text;
            }
            else
            {
                MessageBox.Show("Vul een omschrijving in.");
            }


            fw.taaks.Add(taa);
            fw.SaveChanges(); 
        }

        private void NieuweTaken_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.Projects
                              select new { projectid = p.ID, projectnaam = p.naam }).ToList();
            combProjecten.DisplayMember = "projectnaam";
            combProjecten.ValueMember = "projectid";
            combProjecten.DataSource = projectens;
        }
    }
}
