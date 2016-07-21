using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquettageFilRouge
{
    public partial class Chiffre_affaire : Form
    {
        public Chiffre_affaire()
        {
            InitializeComponent();
        }

        private void Chiffre_affaire_Load(object sender, EventArgs e)
        {
            this.Width = 400;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void commandesEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

        }

        private void commandesParClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Top = 50;
        }
    }
}
