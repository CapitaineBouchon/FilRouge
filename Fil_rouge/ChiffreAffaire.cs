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
    public partial class ChiffreAffaire : Form
    {
        InterrogationDAO interrogationDB;
        public ChiffreAffaire()
        {
            InitializeComponent();
            interrogationDB = new InterrogationDAO(ConfigurationManager.AppSettings["connexionString"]);
        }

        

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (listCA.SelectedIndex)
            {
                case 0:
                    listAffiche.Items.Add(interrogationDB.CATotal());
                    break;
                case 1:
                    listAffiche.DataSource = interrogationDB.CA_fournisseur();
                    break;
                case 2:
                    listAffiche.DataSource = interrogationDB.CA_client();
                    break;
                default:
                    break;
            }
        }
    }
}
