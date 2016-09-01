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
    public partial class RechercheCommande : Form
    {
        public RechercheCommande()
        {
            InitializeComponent();
        }

        private void RechercheCommande_Load(object sender, EventArgs e)
        {
            BoxClient.Location = boxCommande.Location;
            comboChoix.SelectedIndex = 1;
            radioEnCours.Select();
            //Chargement de la requete dans le dataGridView
        }

        private void comboChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChoix.SelectedIndex == 0)
            {
                BoxClient.Visible = true;
                boxCommande.Visible = false;
            }

            if (comboChoix.SelectedIndex == 1)
            {
                BoxClient.Visible = false;
                boxCommande.Visible = true;
            }
            txtIdClient.Clear();
            txtIdCommande.Clear();
        }

        private void radioIdCommande_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdCommande.Checked)
            {
                txtIdCommande.Enabled = true;
            }
            else
            {
                txtIdCommande.Enabled = false;
                txtIdCommande.Clear(); ;
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
