using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Data.SqlClient;
using System.Configuration;
using Classes;

namespace Fil_rouge
{
    public partial class CreationNouveauClient : Form
    {
        //Variables de stockages des données entrantes
        string variation;
        Professionnel proEnvoie = new Professionnel();
        Particulier partEnvoie = new Particulier();
        ClientDAO clientDB;
        CommercialDAO commercialDB;

        /// <summary>
        /// Initialise une nouvelle Form CreationNouveauClient
        /// </summary>
        public CreationNouveauClient()
        {
            InitializeComponent();
            clientDB = new ClientDAO(ConfigurationManager.AppSettings["connexionString"]);
            commercialDB = new CommercialDAO(ConfigurationManager.AppSettings["connexionString"]);
        }
        /// <summary>
        /// Initialise une nouvelle From CreationNouveauClient en fonction des actions de 'envoie'
        /// </summary>
        /// <param name="envoie">Parametre de création de la nouvelle Form</param>
        public CreationNouveauClient(string envoie) : this()
        {            
            variation = envoie;
        }
        /// <summary>
        /// Initialise une nouvelle From CreationNouveauClient avec une variable de type Professionnel
        /// </summary>
        /// <param name="envoie">Parametre de création de la nouvelle Form</param>
        /// <param name="proCast">Reception d'un Client de type Professionnel</param>
        public CreationNouveauClient(string envoie, Professionnel proCast) : this(envoie)
        {
            proEnvoie = proCast;            
        }
        /// <summary>
        /// Initialise une nouvelle From CreationNouveauClient avec une variable de type Particulier
        /// </summary>
        /// <param name="envoie">Parametre de création de la nouvelle Form</param>
        /// <param name="partCast">Reception d'un Client de type Particulier</param>
        public CreationNouveauClient(string envoie, Particulier partCast) : this(envoie)
        {
            partEnvoie = partCast;
        }        
        private void btnParticulier_CheckedChanged(object sender, EventArgs e)
        {
            if (btnParticulier.Checked)
            {
                panelParticulier.Visible = true;
                panelParticulier.Enabled = true;
                panelPro.Visible = false;
                panelPro.Enabled = false;
            }
            else if (btnPro.Checked)
            {
                panelParticulier.Visible = false;
                panelParticulier.Enabled = false;
                panelPro.Visible = true;
                panelPro.Enabled = true;
            }

            foreach (Control x in this.Controls)
            {
                //Si le Control est un panel
                if (x is Panel)
                {
                    //Boucle qui scan chaque Control du Panel
                    foreach (Control y in x.Controls)
                    {
                        //Si le Control est une TextBox
                        if (y is TextBox)
                        {
                            ((TextBox)y).BackColor = Color.White;
                            ((TextBox)y).Clear();
                        }
                    }

                }
                //Si le Control est un TabControl
                if (x is TabControl)
                {
                    //Pour chaque TabControlPanel
                    foreach (Control z in x.Controls)
                    {
                        //Boucle qui scan chaque Control du TabControlPanel
                        foreach (Control y in z.Controls)
                        {
                            //Si le Control est une TextBox
                            if (y is TextBox)
                            {
                                //Si le fond de la TextBox est rouge
                                ((TextBox)y).BackColor = Color.White;
                                ((TextBox)y).Clear();
                            }
                        }
                    }
                }
                //Si le Control est une TextBox
                if (x is TextBox)
                {
                    ((TextBox)x).BackColor = Color.White;
                    ((TextBox)x).Clear();
                }
            }
        }
        private void btnPro_CheckedChanged(object sender, EventArgs e)
        {
            if (btnParticulier.Checked)
            {
                panelParticulier.Visible = true;
                panelParticulier.Enabled = true;
                panelPro.Visible = false;
                panelPro.Enabled = false;
                panelParticulier.Location = panelPro.Location;
            }
            else if (btnPro.Checked)
            {
                panelParticulier.Visible = false;
                panelParticulier.Enabled = false;
                panelPro.Visible = true;
                panelPro.Enabled = true;
                panelPro.Location = panelParticulier.Location;
            }

            foreach (Control x in this.Controls)
            {
                //Si le Control est un panel
                if (x is Panel)
                {
                    //Boucle qui scan chaque Control du Panel
                    foreach (Control y in x.Controls)
                    {
                        //Si le Control est une TextBox
                        if (y is TextBox)
                        {
                            ((TextBox)y).BackColor = Color.White;
                            ((TextBox)y).Clear();
                        }
                    }

                }
                //Si le Control est un TabControl
                if (x is TabControl)
                {
                    //Pour chaque TabControlPanel
                    foreach (Control z in x.Controls)
                    {
                        //Boucle qui scan chaque Control du TabControlPanel
                        foreach (Control y in z.Controls)
                        {
                            //Si le Control est une TextBox
                            if (y is TextBox)
                            {
                                //Si le fond de la TextBox est rouge
                                ((TextBox)y).BackColor = Color.White;
                                ((TextBox)y).Clear();
                            }
                        }
                    }
                }
                //Si le Control est une TextBox
                if (x is TextBox)
                {
                    ((TextBox)x).BackColor = Color.White;
                    ((TextBox)x).Clear();
                }
            }
        }
        private void CreationNouveauClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (fenetre)
            //{
            //    DialogResult reponse = MessageBox.Show("Voulez-vous quitter le formulaire actif ?\nVous risquez de perdre les données actuellement saisies.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //    if (reponse == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }

            //}  
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            bool reussi = true;
            //Boucle qui scan chaque Control de la form
            #region
            if (variation != "supprimerPart" || variation != "supprimerPro")
            {
                foreach (Control x in this.Controls)
                {
                    //Si le Control est un panel
                    if (x is Panel)
                    {
                        //Boucle qui scan chaque Control du Panel
                        foreach (Control y in x.Controls)
                        {
                            //Si le Control est une TextBox
                            if (y is TextBox)
                            {
                                //Si le fond de la TextBox est rouge
                                if (((TextBox)y).BackColor == Color.Red)
                                {
                                    reussi = false;
                                    y.Select();
                                }
                            }
                        }                       
                    }
                    //Si le Control est un TabControl
                    if (x is TabControl)
                    {
                        //Pour chaque TabControlPanel
                        foreach (Control z in x.Controls)
                        {
                            //Boucle qui scan chaque Control du TabControlPanel
                            foreach (Control y in z.Controls)
                            {
                                //Si le Control est une TextBox
                                if (y is TextBox)
                                {
                                    //Si le fond de la TextBox est rouge
                                    if (((TextBox)y).BackColor == Color.Red)
                                    {
                                        reussi = false;
                                        y.Select();
                                    }
                                }
                            }
                        }
                    }
                    //Si le Control est une TextBox
                    if (x is TextBox)
                    {
                        //Si le fond de la TextBox est rouge
                        if (((TextBox)x).BackColor == Color.Red)
                        {
                            reussi = false;
                            x.Select();
                        }
                    }
                }
            }
            
            #endregion
            //Test des erreurs
            if (reussi)
            {
                //Instructions en cas de réussite aux tests: Création de la variable Client, remplissage et envoie
                Particulier clientPart = new Particulier();
                Professionnel client = new Professionnel(); 
                    
                           
                //Si le client est un particulier ou professionnel, remplissage de la variable correspondante
                #region
                if (btnParticulier.Checked)
                {
                    clientPart.Id = partEnvoie.Id;
                    clientPart.Nom = txtnom_Par.Text;
                    clientPart.Prenom = txtPrenom_Par.Text;
                    clientPart.Type = false;
                    clientPart.Adresse = txtAdresse_Par.Text;
                    clientPart.Complement = txtComplement_Par.Text;
                    clientPart.CodePostal = txtCp_Par.Text;
                    clientPart.Ville = txtVille_Par.Text;
                    clientPart.Telephone = txtTelFix_Par.Text;
                    clientPart.Portable = txtTelPort_Par.Text;
                    clientPart.Mail = txtMail_par.Text;
                    clientPart.Coefficient = Convert.ToDecimal(txtCoeff.Text);
                    clientPart.AdresseFacturation = txtAdresse_Fact.Text;
                    clientPart.ComplementFacturation = txtComp_Fact.Text;
                    clientPart.CodePostalFacturation = txtCP_Fact.Text;
                    clientPart.VilleFacturation = txtVille_Fact.Text;
                    clientPart.AdresseLivraison = txtAdresse_Liv.Text;
                    clientPart.ComplementLivraison = txtComp_Liv.Text;
                    clientPart.CodePostalLivraison = txtCP_Liv.Text;
                    clientPart.VilleLivraison = txtVille_Liv.Text;
                    clientPart.idCommercial = (int)comboCommercial.SelectedValue;
                }
                else if (btnPro.Checked)
                {
                    client.Id = proEnvoie.Id;
                    client.Nom = txtNom_Pro.Text;
                    client.Siret = txtSiret_Pro.Text;
                    client.Domaine = txtDomaine_Pro.Text;
                    client.Type = true;
                    client.Adresse = txtAdresse_Pro.Text;
                    client.Complement = txtComp_Pro.Text;
                    client.CodePostal = txtCP_Pro.Text;
                    client.Ville = txtVille_Pro.Text;
                    client.Telephone = txtTelFix_Pro.Text;
                    client.Portable = txtPort_Pro.Text;
                    client.Mail = txtMail_Pro.Text;
                    client.Coefficient = Convert.ToDecimal(txtCoeff.Text);
                    client.AdresseFacturation = txtAdresse_Fact.Text;
                    client.ComplementFacturation = txtComp_Fact.Text;
                    client.CodePostalFacturation = txtCP_Fact.Text;
                    client.VilleLivraison = txtVille_Fact.Text;
                    client.AdresseLivraison = txtAdresse_Liv.Text;
                    client.ComplementLivraison = txtComp_Liv.Text;
                    client.CodePostalLivraison = txtCP_Liv.Text;
                    client.VilleLivraison = txtVille_Liv.Text;
                    client.idCommercial = (int)comboCommercial.SelectedValue;
                }
                #endregion

                //Opération à effectuer en fonction de la variable 'variation', envoyée par le précédant formulaire
                switch (variation)
                {
                    case "creer":
                        if (btnPro.Checked)
                        {
                            clientDB.InsertPro(client);
                        }
                        else
                        {
                            clientDB.InsertParticulier(clientPart);
                        }
                        this.DialogResult = MessageBox.Show("Fiche client créé", "Information", MessageBoxButtons.OK);
                        break;
                    case "modifierPro":

                        clientDB.UpdatePro(client);
                        this.DialogResult = MessageBox.Show("Fiche client modifiée", "Information", MessageBoxButtons.OK);
                        break;
                    case "modifierPart":
                        clientDB.UpdateParticulier(clientPart);
                        this.DialogResult = MessageBox.Show("Fiche client modifiée", "Information", MessageBoxButtons.OK);
                        break;
                    case "supprimerPro":
                        clientDB.Delete(client.Id);
                        this.DialogResult = MessageBox.Show("Fiche client archivée", "Information", MessageBoxButtons.OK);
                        break;
                    case "supprimerPart":
                        clientDB.Delete(clientPart.Id);
                        this.DialogResult = MessageBox.Show("Fiche client archivée", "Information", MessageBoxButtons.OK);
                        break;
                    default:
                        if (btnPro.Checked)
                        {
                            clientDB.InsertPro(client);
                        }
                        else
                        {
                            clientDB.InsertParticulier(clientPart);
                        }
                        this.DialogResult = MessageBox.Show("Fiche client créé", "Information", MessageBoxButtons.OK);
                        break;
                }
                
                Close();
            }
            else
            {
                //Instruction en cas d'échec aux tests: retour à la saisie du formulaire
                MessageBox.Show("Veuillez compléter ou corriger les champs érronnés", "Erreur de saisie", MessageBoxButtons.OK);
            }

        }
        private void CreationNouveauClient_Load(object sender, EventArgs e)
        {
            comboCommercial.DisplayMember = "Affichage";
            comboCommercial.ValueMember = "Id";
            comboCommercial.DataSource = commercialDB.List();
            comboCommercial.SelectedValue = Global.idCommercial;
            switch (variation)
            {
                case "creer":
                    btnValider.Text = "Créer";
                    btnAnnuler.Visible = true;
                    btnAnnuler.Location = btnValider.Location;
                    btnValider.Location = new Point(855, 402);
                    break;
                case "modifierPro":
                    labelTitre.Text = "Modification de la fiche client";
                    btnValider.Text = "Valider";
                    remplissagePro(proEnvoie);
                    break;
                case "modifierPart":
                    labelTitre.Text = "Modification de la fiche client";
                    btnValider.Text = "Valider";
                    remplissagePar(partEnvoie);
                    break;
                case "supprimerPro":
                    labelTitre.Text = "Suppression de la fiche client";
                    btnValider.Text = "Supprimmer";
                    remplissagePro(proEnvoie);
                    panelPro.Enabled = false;
                    txtAdresse_Liv.Enabled = false;
                    txtComp_Liv.Enabled = false;
                    txtCP_Liv.Enabled = false;
                    txtVille_Liv.Enabled = false;
                    txtAdresse_Fact.Enabled = false;
                    txtComp_Fact.Enabled = false;
                    txtCP_Fact.Enabled = false;
                    txtVille_Fact.Enabled = false;
                    txtCoeff.Enabled = false;
                    break;
                case "supprimerPart":
                    labelTitre.Text = "Suppression de la fiche client";
                    btnValider.Text = "Supprimmer";
                    remplissagePar(partEnvoie);
                    panelParticulier.Enabled = false;
                    txtAdresse_Liv.Enabled = false;
                    txtComp_Liv.Enabled = false;
                    txtCP_Liv.Enabled = false;
                    txtVille_Liv.Enabled = false;
                    txtAdresse_Fact.Enabled = false;
                    txtComp_Fact.Enabled = false;
                    txtCP_Fact.Enabled = false;
                    txtVille_Fact.Enabled = false;
                    txtCoeff.Enabled = false;
                    txtCoeff.Enabled = false;
                    break;
                default:
                    btnValider.Text = "Créer";
                    btnAnnuler.Visible = true;
                    btnAnnuler.Location = btnValider.Location;
                    btnValider.Location = new Point(855, 402);
                    break;
            }
        }
        private void txtlettre_controle(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[a-zA-Z][a-zA-Z '-]+$"))
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;
            }
            
        }
        private void txtchiffre_controle(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[0-9]{10}$") || txtbox.Text == "")
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;
            }
        }
        private void txtCP_controle(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[0-9]{5}$"))
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;
            }
        }
        private void txtadresse_controle(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[a-zA-Z0-9]+[ ][a-zA-Z '-]+$"))
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;
            }
        }
        private void txtmail_controle(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (CtrlMail(txtbox.Text).Length == 0)
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show(CtrlMail(txtbox.Text), "Erreur de saisie", MessageBoxButtons.OK);
                txtbox.BackColor = Color.Red;

            }
        }
        /// <summary>
        /// Fonction de vérification de l'adresse mail.
        /// </summary>
        /// <param name="mail">Mail à vérifier</param>
        /// <returns>Retourne l'erreur de l'adresse mail.</returns>
        private string CtrlMail(string mail)
        {
            string erreur = "";
            int posAt = 0, posPoint = 0;
            if (Regex.IsMatch(mail, @"^[a-z0-9][a-z0-9_.-]{1,50}[@][a-z0-9][a-z0-9-]{1,50}[.][a-z]{2,10}$"))
            {
                return erreur;
            }
            else
            {
                for (int i = 0; i < mail.Length; i++)
                {
                    if (mail.Substring(i, 1) == "@")
                    {
                        posAt = i;
                    }
                    if (mail.Substring(i, 1) == "." & i > posAt)
                    {
                        posPoint = i;
                    }
                }
                erreur = "Erreur de saisie dans : ";
                if (!Regex.IsMatch(mail.Substring(0, posAt), @"^[a-z0-9][a-z0-9_.-]{1,50}"))
                {
                    return erreur += mail.Substring(0, posAt);
                }
                else if (!Regex.IsMatch(mail.Substring(posAt, posPoint), @"^[a-z0-9][a-z0-9-]{1,50}$"))
                {
                    return erreur += mail.Substring(posAt + 1, posPoint - posAt);
                }
                else if (!Regex.IsMatch(mail.Substring(posAt, posPoint), @"^[a-z]{2,10}$"))
                {
                    return erreur += mail.Substring(posPoint, mail.Length - posPoint);
                }
                else
                {
                    return "";
                }
            }

        }
        private void txtCoeff_Validating(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[0-9]{1,2}([.][0-9]{2})?$"))
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;

            }
        }
        private void checkLivraison_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLivraison.Checked && btnParticulier.Checked)
            {
                txtAdresse_Liv.Text = txtAdresse_Par.Text;
                txtComp_Liv.Text = txtComplement_Par.Text;
                txtCP_Liv.Text = txtCp_Par.Text;
                txtVille_Liv.Text = txtVille_Par.Text;
            }
            if (checkLivraison.Checked && btnPro.Checked)
            {
                txtAdresse_Liv.Text = txtAdresse_Pro.Text;
                txtComp_Liv.Text = txtComp_Pro.Text;
                txtVille_Liv.Text = txtVille_Pro.Text;

            }


        }
        private void checkFacturation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFacturation.Checked && btnParticulier.Checked)
            {
                txtAdresse_Fact.Text = txtAdresse_Par.Text;
                txtComp_Fact.Text = txtComplement_Par.Text;
                txtCP_Fact.Text = txtCp_Par.Text;
                txtVille_Fact.Text = txtVille_Par.Text;
            }
            if (checkFacturation.Checked && btnPro.Checked)
            {
                txtAdresse_Fact.Text = txtAdresse_Pro.Text;
                txtComp_Fact.Text = txtComp_Pro.Text;
                txtCP_Fact.Text = txtCP_Pro.Text;
                txtVille_Fact.Text = txtVille_Pro.Text;
            }
        }
        private void txtSiret_Pro_Validating(object sender, CancelEventArgs e)
        {
            Control txtbox = new Control();
            txtbox = (Control)sender;
            if (Regex.IsMatch(txtbox.Text, @"^[0-9]{14}$"))
            {
                txtbox.BackColor = Color.White;
            }
            else
            {
                txtbox.BackColor = Color.Red;
            }
        }        
        private void txt_Change(object sender, EventArgs e)
        {
           
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Fonction de remplissage des champs du formulaire
        /// </summary>
        /// <param name="part">Parametre utilisé pour le remplissage de type Particulier</param>
        private void remplissagePar(Particulier part)
        {
            btnAnnuler.Visible = true;
            btnAnnuler.Location = btnValider.Location;
            btnValider.Location = new Point(855, 402);
            boxCheckBtn.Enabled = false;
            checkFacturation.Enabled = false;
            checkLivraison.Enabled = false;
            btnParticulier.Checked = true;
            txtnom_Par.Text = part.Nom;
            txtPrenom_Par.Text = part.Prenom;
            txtAdresse_Par.Text = part.Adresse;
            txtComplement_Par.Text = part.Complement;
            txtCp_Par.Text = part.CodePostal;
            txtVille_Par.Text = part.Ville;
            txtMail_par.Text = part.Mail;
            txtTelFix_Par.Text = part.Telephone;
            txtTelPort_Par.Text = part.Portable;
            txtAdresse_Liv.Text = part.AdresseLivraison;
            txtComp_Liv.Text = part.ComplementLivraison;
            txtCP_Liv.Text = part.CodePostalLivraison;
            txtVille_Liv.Text = part.VilleLivraison;
            txtAdresse_Fact.Text = part.AdresseFacturation;
            txtComp_Fact.Text = part.ComplementFacturation;
            txtCP_Fact.Text = part.CodePostalFacturation;
            txtVille_Fact.Text = part.VilleFacturation;
            txtCoeff.Text = part.Coefficient.ToString();
            comboCommercial.SelectedValue = part.idCommercial;
        }
        /// <summary>
        /// Fonction de remplissage des champs du formulaire
        /// </summary>
        /// <param name="pro">Parametre utilisé pour le remplissage de type Professionnel</param>
        private void remplissagePro(Professionnel pro)
        {

            btnAnnuler.Visible = true;
            btnAnnuler.Location = btnValider.Location;
            btnValider.Location = new Point(855, 402);
            boxCheckBtn.Enabled = false;
            checkFacturation.Enabled = false;
            checkLivraison.Enabled = false;
            btnPro.Checked = true;
            txtNom_Pro.Text = pro.Nom;
            txtSiret_Pro.Text = pro.Siret;
            txtDomaine_Pro.Text = pro.Domaine;
            txtAdresse_Pro.Text = pro.Adresse;
            txtComp_Pro.Text = pro.Complement;
            txtCP_Pro.Text = pro.CodePostal;
            txtVille_Pro.Text = pro.Ville;
            txtMail_Pro.Text = pro.Mail;
            txtTelFix_Pro.Text = pro.Telephone;
            txtPort_Pro.Text = pro.Portable;
            txtAdresse_Liv.Text = pro.AdresseLivraison;
            txtComp_Liv.Text = pro.ComplementLivraison;
            txtCP_Liv.Text = pro.CodePostalLivraison;
            txtVille_Liv.Text = pro.VilleLivraison;
            txtAdresse_Fact.Text = pro.AdresseFacturation;
            txtComp_Fact.Text = pro.ComplementFacturation;
            txtCP_Fact.Text = pro.CodePostalFacturation;
            txtVille_Fact.Text = pro.VilleFacturation;
            txtCoeff.Text = pro.Coefficient.ToString();
            comboCommercial.SelectedValue = pro.idCommercial;
        }
    }
}
