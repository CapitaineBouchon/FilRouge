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
        
        //Variable permettant de savoir quelle type de fenetre a été ouverte : 
        //True = Ecriture, modification Supression
        //False = lecture seule
        bool fenetre;

        /// <summary>
        /// Methode permettant l'ouverture d'une nouvelle forme fille dans la forme mère en redimmentionnant la fenetre mere 
        /// </summary>
        /// <param name="maform">type de form fille a créer</param>
        public void ChangeWindow (Form maform)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            maform.FormBorderStyle = FormBorderStyle.None;
            maform.MdiParent = this;
            maform.Show();
            maform.Location = new Point(0, 0);
            this.Width = maform.Width;
            this.Height = maform.Height;
            maform.Dock = DockStyle.Fill;
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult m = MessageBox.Show("Voulez-vous vous deconnecter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (m == DialogResult.Yes)
            //{

            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void menuNouveauClient_Click(object sender, EventArgs e)
        {
            if (fenetre)
            {
                if (Message() == DialogResult.Yes)
                {
                    CreationNouveauClient cli = new CreationNouveauClient();
                    ChangeWindow(cli);
                    fenetre = true;
                }
            }
            else
            {
                CreationNouveauClient cli = new CreationNouveauClient();
                ChangeWindow(cli);
                fenetre = true;
            }

        }

        private void menuRechercheClient_Click(object sender, EventArgs e)
        {
            if (fenetre)
            {
                if (Message() == DialogResult.Yes)
                {
                    
                    RechercheClient maform = new RechercheClient();                    
                    ChangeWindow(maform);
                    fenetre = false;
                }
            }
            else
            {
                RechercheClient maform = new RechercheClient();
                ChangeWindow(maform);
                fenetre = false;
            }
            
        }

        private void MenuCreerCommande_Click(object sender, EventArgs e)
        {
            
            if (fenetre)
            {
                if (Message() == DialogResult.Yes)
                {

                    NouvelleCommande maform = new NouvelleCommande();
                    ChangeWindow(maform);
                    this.Width = 964;
                    this.Height = 405;
                    fenetre = true;
                }
            }
            else
            {
                NouvelleCommande maform = new NouvelleCommande();
                ChangeWindow(maform);
                this.Width = 964;
                this.Height = 405;
                fenetre = true;
            }
        }

        private void MenuRechercheCommande_Click(object sender, EventArgs e)
        {

        }
    }
}
