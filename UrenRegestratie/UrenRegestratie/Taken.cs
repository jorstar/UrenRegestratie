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
    public partial class Taken : Form
    {
        public Taken()
        {
            InitializeComponent();
        }

        private void combProjecten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Taken_Load(object sender, EventArgs e)
        {
            UrenRegCon EntityModel = new UrenRegCon();
            var projectens = (from p in EntityModel.taaks
                              select new { taakid = p.taakID, taaknaam = p.naam }).ToList();
            combProjecten.DisplayMember = "taaknaam";
            combProjecten.ValueMember = "taakid";
            combProjecten.DataSource = projectens;
        }
    }
}
