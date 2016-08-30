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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RechercheClient newclient = new RechercheClient();
            
            newclient.Show();
        }
    }
}
