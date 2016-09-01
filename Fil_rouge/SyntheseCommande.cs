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
    public partial class SyntheseCommande : Form
    {
        public SyntheseCommande()
        {
            InitializeComponent();
        }

        private void SyntheseCommande_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Commande enregistrée", "Commande", MessageBoxButtons.OK);
            this.MdiParent.Width = 748;
            this.MdiParent.Height = 519;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                f.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MdiParent.Width = 964;
            this.MdiParent.Height = 405;
            this.Close();
        }
    }
}
