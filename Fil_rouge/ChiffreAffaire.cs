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
    public partial class ChiffreAffaire : Form
    {
        public ChiffreAffaire()
        {
            InitializeComponent();
        }

        private void ChiffreAffaire_Load(object sender, EventArgs e)
        {
            radioAnnee.Checked = true;
            comboMois.Enabled = false;
            listCA.SelectedIndex = 0;
            //Chargement des années via une requete
        }

        private void radioMois_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnnee.Checked)
            {
                comboMois.Enabled = false;
            }
            else
            {
                comboMois.Enabled = true;
            }
        }
    }
}
