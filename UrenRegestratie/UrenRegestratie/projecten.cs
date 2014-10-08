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
    public partial class projecten : Form
    {

        UrenRegCon EntityModel = new UrenRegCon();

        public projecten()
        {
            InitializeComponent();
        }

        private void combProjecten_Enter(object sender, EventArgs e)
        {
            
        }

        private void projecten_Load(object sender, EventArgs e)
        {
            var projectens = (from p in EntityModel.Projects
                              select new { p.ID, p.naam });
            combProjecten.DisplayMember = "projectnamen";
            combProjecten.DataSource = projectens;
        }

        private void combProjecten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
