using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace Fil_rouge
{
    public partial class Accueil : Form
    {
        
        public Accueil()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Methode d'alerte lors de la fermeture d'une forme
        /// </summary>
        /// <returns>Yes ou No</returns>
        public DialogResult Message()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous quitter le formulaire actif ?\nVous risquez de perdre les données actuellement saisies.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return reponse;
        }
        public Form page;

        public string fenetreEnvoye;

        /// <summary>
        /// Methode permettant l'ouverture d'une nouvelle forme fille dans la forme mère en redimmentionnant la fenetre mere 
        /// </summary>
        /// <param name="maform">type de form fille a créer</param>
        public void ChangeWindow(Form maform)
        {
            //bool fermeture = true;            
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
                //if (f.DialogResult == DialogResult.No)
                //{
                //    fermeture = false;
                //    break;
                //}
            }
            //if (fermeture)
            //{
                maform.FormBorderStyle = FormBorderStyle.None;
                maform.MdiParent = this;
                maform.Show();
                maform.Location = new Point(0, 0);
                this.Width = maform.Width;
                this.Height = maform.Height;
                maform.Dock = DockStyle.Fill;
            //}
            
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult m = MessageBox.Show("Voulez-vous vous deconnecter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (m == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            page = new RechercheClient();
            ChangeWindow(page);
        }

        private void menuNouveauClient_Click(object sender, EventArgs e)
        {
            page = new CreationNouveauClient();
            ChangeWindow(page);
        }

        private void menuRechercheClient_Click(object sender, EventArgs e)
        {
            page = new RechercheClient();
            ChangeWindow(page);
        }

        private void MenuCreerCommande_Click(object sender, EventArgs e)
        {
            page = new NouvelleCommande();
            ChangeWindow(page);
            this.Width = 964;
            this.Height = 405;
        }

        private void MenuRechercheCommande_Click(object sender, EventArgs e)
        {
            page = new RechercheCommande();
            ChangeWindow(page);
        }

        private void MenuCA_Click(object sender, EventArgs e)
        {
            page = new ChiffreAffaire();
            ChangeWindow(page);
        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = new Catalogue();
            ChangeWindow(page);
        }
    }
}
