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
    public partial class Form1 : Form
    {
        ConnexionDAO connexionDB;
        CommercialDAO commercialDB;

        public Form1()
        {
            InitializeComponent();
            connexionDB = new ConnexionDAO(ConfigurationManager.AppSettings["connexionString"]);
            commercialDB = new CommercialDAO(ConfigurationManager.AppSettings["connexionString"]);
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connexion logs = new Connexion();
            logs.Login = txtId.Text;
            logs.MdP = txtPwd.Text;
            if (connexionDB.TestConnexion(logs))
            {
                
                txtId.Clear();
                txtPwd.Clear();
                logs = connexionDB.Find(logs);
                Global.idCommercial = logs.IdCommercial;
                Accueil a = new Accueil();
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Identifiant / Mot de Passe Incorrect", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtId.Select();
            }

        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPwd.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Select();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mess = MessageBox.Show("Voulez-vous quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mess == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
