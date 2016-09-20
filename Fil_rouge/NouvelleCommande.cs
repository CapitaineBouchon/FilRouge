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
    public partial class NouvelleCommande : Form
    {
        public NouvelleCommande()
        {
            InitializeComponent();
        }

        private void NouvelleCommande_Load(object sender, EventArgs e)
        {
            txtSearchBox.Select();
        }

        //Variable pour le bouton suivant et précédant
        int bouton = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //RechercheClient newclient = new RechercheClient();
            //if (newclient.ShowDialog() == DialogResult.OK)
            //{
            //    boxClient.Enabled = true;
            //    Console.WriteLine(newclient.resultat);
            //}

            //txtNomPar.Text = newclient.resultat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (bouton)
            {
                case 0:
                    boxProduit.Visible = true;
                    boxClient.Visible = false;
                    boxProduit.Location = boxClient.Location;
                    bouton++;
                    btnPrecedant.Enabled = true;
                    break;

                case 1:
                    boxProduit.Visible = false;
                    boxRemarque.Visible = true;
                    boxRemarque.Location = boxProduit.Location;
                    bouton++;
                    btnSynthese.Enabled = true;
                    btnSuivant.Enabled = false;
                    break;
                default:
                    break;
            }
            
        }

        private void btnPrecedant_Click(object sender, EventArgs e)
        {
            switch (bouton)
            {
                case 1:
                    boxProduit.Visible = false;
                    boxClient.Visible = true;
                    boxProduit.Location = boxClient.Location;
                    bouton--;
                    btnPrecedant.Enabled = false;
                    break;

                case 2:
                    boxProduit.Visible = true;
                    boxRemarque.Visible = false;
                    boxRemarque.Location = boxProduit.Location;
                    bouton--;
                    btnSynthese.Enabled = false;
                    btnSuivant.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnSynthese_Click(object sender, EventArgs e)
        {
            SyntheseCommande maform = new SyntheseCommande();
            maform.MdiParent = this.MdiParent;
            maform.Location = new Point(0, 0);
            
            this.MdiParent.Height = maform.Height;
            maform.Dock = DockStyle.Fill;
            maform.FormBorderStyle = FormBorderStyle.None;
            maform.Show();

        }

        private void boxParticulier_Enter(object sender, EventArgs e)
        {

        }
    }
    }

