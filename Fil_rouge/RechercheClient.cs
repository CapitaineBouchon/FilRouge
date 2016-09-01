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
    public partial class RechercheClient : Form
    {
        public string resultat;
        public RechercheClient()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        //dataGridView1.AutoGenerateColumns = true;
        //    dataGridView1.Columns[2].Visible = false;
        //    dataGridView1.Columns[2].HeaderText = "Nom";

        private void button1_Click(object sender, EventArgs e)
        {
            //resultat = "ok";
            //this.DialogResult = DialogResult.OK;
            //Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void RechercheClient_Load(object sender, EventArgs e)
        {
            comboType.SelectedIndex = 0;
            txtId.Select();
        }
    }
}
