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
using System.Configuration;

namespace Fil_rouge
{
    public partial class RechercheClient : Form
    {        
        string init;
        ClientDAO clientDB;
        /// <summary>
        /// Initialise une nouvelle Form RechercheClient
        /// </summary>
        public RechercheClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initialise une nouvelle From RechercheClient avec un parametre d'appel
        /// </summary>
        /// <param name="recherche">Paramètre de modification du chargement</param>
        public RechercheClient(string recherche) : this()
        {
            init = recherche;
        }
        string requete = "";
        List<Client> affichage = new List<Client>();
        //btnRechercher
        private void button1_Click(object sender, EventArgs e)
        {
            requete = "";
            int countRequete = 0;
            if (txtId.Text.Length == 0 && txtNom.Text.Length ==0 && txtAdresse.Text.Length == 0 && comboType.Text == "Tous")
            {
                
            }
            else
            {
                requete += "AND ";
                if (txtId.Text.Length != 0)
                {
                    requete += "code_client = " + txtId.Text+ " ";
                    countRequete++;
                }

                
                if (txtNom.Text.Length != 0 && countRequete == 0)
                {
                    requete += "nom_client LIKE ('%" + txtNom.Text + "%') ";
                    countRequete++;
                }
                else if (txtNom.Text.Length != 0 && countRequete > 0)
                {
                    requete += "AND nom_client LIKE ('%" + txtNom.Text + "%') ";
                }


                if (txtAdresse.Text.Length != 0 && countRequete == 0)
                {
                    requete += "(adresse_client LIKE ('%" + txtAdresse.Text + "%') OR ville_client LIKE ('%" + txtAdresse.Text + "%'))";
                    countRequete++;
                }
                else if (txtAdresse.Text.Length != 0 && countRequete > 0)
                {
                    requete += "AND (adresse_client LIKE ('%" + txtAdresse.Text + "%') OR ville_client LIKE ('%" + txtAdresse.Text + "%'))";
                }


                if (comboType.Text == "Particulier" && countRequete == 0)
                {
                    requete += "type_client = 0 ";
                }
                else if (comboType.Text == "Professionnel" && countRequete == 0)
                {
                    requete += "type_client = 1 ";
                }
                else if (comboType.Text == "Particulier" && countRequete > 0)
                {
                    requete += "AND type_client = 0 ";
                }
                else if (comboType.Text == "Professionnel" && countRequete > 0)
                {
                    requete += "AND type_client = 1 ";
                }
            }
            
            affichage = clientDB.Search(requete);

            if (affichage.Count == 0)
            {
                MessageBox.Show("Client introuvable.", "Recherche de client", MessageBoxButtons.OK);
            }
            else
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                gridRecherche.AutoGenerateColumns = true;
                gridRecherche.DataSource = affichage;
                gridRecherche.AutoResizeColumns();
                gridRecherche.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                for (int i = 0; i < gridRecherche.ColumnCount; i++)
                {
                    if (i == 0 | i == 1 | i == 3 | i == 5 | i == 6)
                    {
                        gridRecherche.Columns[i].Visible = true;
                    }
                    else
                        gridRecherche.Columns[i].Visible = false;
                }
            }
            Console.WriteLine(requete);
            btnValider.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void RechercheClient_Load(object sender, EventArgs e)
        {
            comboType.SelectedIndex = 0;
            txtId.Select();
            clientDB = new ClientDAO(ConfigurationManager.AppSettings["connexionString"]);
            if (init == "rechercher")
            {
                btnValider.Visible = false;
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            gridRecherche.Columns.Clear();
            CreationNouveauClient maform = new CreationNouveauClient("creer");
            if (maform.ShowDialog() == DialogResult.Yes)
            {                
                button1_Click(btnSearch, EventArgs.Empty);
            }
        }

        private void betReset_Click(object sender, EventArgs e)
        {
            gridRecherche.Columns.Clear();
            txtAdresse.Clear();
            txtNom.Clear();
            txtId.Clear();
            requete = "";
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(gridRecherche.SelectedRows[0].Cells[2].Value))
            {
                CreationNouveauClient mafomr = new CreationNouveauClient("modifierPro", clientDB.findPro(Convert.ToInt32(gridRecherche.SelectedRows[0].Cells[0].Value)));
                if (mafomr.ShowDialog() == DialogResult.OK)
                {
                    btnSearch.PerformClick();
                }
            }
            else
            {
                CreationNouveauClient maform = new CreationNouveauClient("modifierPart", clientDB.findPar(Convert.ToInt32(gridRecherche.SelectedRows[0].Cells[0].Value)));
                if (maform.ShowDialog() == DialogResult.OK)
                {
                    btnSearch.PerformClick();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(gridRecherche.SelectedRows[0].Cells[2].Value))
            {
                CreationNouveauClient mafomr = new CreationNouveauClient("supprimerPro", clientDB.findPro(Convert.ToInt32(gridRecherche.SelectedRows[0].Cells[0].Value)));
                if (mafomr.ShowDialog() == DialogResult.OK)
                {
                    btnSearch.PerformClick();
                }
            }
            else
            {
                CreationNouveauClient maform = new CreationNouveauClient("supprimerPart", clientDB.findPar(Convert.ToInt32(gridRecherche.SelectedRows[0].Cells[0].Value)));
                if (maform.ShowDialog() == DialogResult.OK)
                {
                    btnSearch.PerformClick();
                }
            }
        }

        private void gridRecherche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnValider.Enabled = true;
            Console.WriteLine(gridRecherche.SelectedRows[0].Cells[2].Value);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            CreationNouveauClient maform = new CreationNouveauClient();
        }
    }
}
