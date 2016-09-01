using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_rouge
{
    public partial class CreationNouveauClient : Form
    {
        public CreationNouveauClient()
        {
            InitializeComponent();
        }

        private void btnParticulier_CheckedChanged(object sender, EventArgs e)
        {
            if (btnParticulier.Checked)
            {
                panelParticulier.Visible = true;
                panelPro.Visible = false;
            }
            else if (btnPro.Checked)
            {
                panelParticulier.Visible = false;
                panelPro.Visible = true;
            }
        }

        private void btnPro_CheckedChanged(object sender, EventArgs e)
        {
            if (btnParticulier.Checked)
            {
                panelParticulier.Visible = true;
                panelPro.Visible = false;
                panelParticulier.Location = panelPro.Location;
            }
            else if (btnPro.Checked)
            {
                panelParticulier.Visible = false;
                panelPro.Visible = true;
                panelPro.Location = panelParticulier.Location;
            }
        }

        private void CreationNouveauClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fiche Client créée", "Fiche client", MessageBoxButtons.OK);
            this.MdiParent.Width = 748;
            this.MdiParent.Height = 519;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                f.Close();
            }
        }

        private void CreationNouveauClient_Load(object sender, EventArgs e)
        {
            txtnom_Par.Select();
        }
    }
}
