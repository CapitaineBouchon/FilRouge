namespace Fil_rouge
{
    partial class ChiffreAffaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listCA = new System.Windows.Forms.ListBox();
            this.gridCA = new System.Windows.Forms.DataGridView();
            this.groupTemps = new System.Windows.Forms.GroupBox();
            this.radioMois = new System.Windows.Forms.RadioButton();
            this.radioAnnee = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAnnee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMois = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCA)).BeginInit();
            this.groupTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiffre d\'affaire";
            // 
            // listCA
            // 
            this.listCA.FormattingEnabled = true;
            this.listCA.Items.AddRange(new object[] {
            "Tous",
            "Par Fournisseur",
            "Par Type de Client"});
            this.listCA.Location = new System.Drawing.Point(32, 59);
            this.listCA.Name = "listCA";
            this.listCA.Size = new System.Drawing.Size(100, 43);
            this.listCA.TabIndex = 1;
            // 
            // gridCA
            // 
            this.gridCA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCA.Location = new System.Drawing.Point(32, 138);
            this.gridCA.Name = "gridCA";
            this.gridCA.Size = new System.Drawing.Size(490, 166);
            this.gridCA.TabIndex = 2;
            // 
            // groupTemps
            // 
            this.groupTemps.Controls.Add(this.radioAnnee);
            this.groupTemps.Controls.Add(this.radioMois);
            this.groupTemps.Location = new System.Drawing.Point(138, 33);
            this.groupTemps.Name = "groupTemps";
            this.groupTemps.Size = new System.Drawing.Size(97, 69);
            this.groupTemps.TabIndex = 3;
            this.groupTemps.TabStop = false;
            this.groupTemps.Text = "Trier par";
            // 
            // radioMois
            // 
            this.radioMois.AutoSize = true;
            this.radioMois.Location = new System.Drawing.Point(6, 19);
            this.radioMois.Name = "radioMois";
            this.radioMois.Size = new System.Drawing.Size(47, 17);
            this.radioMois.TabIndex = 0;
            this.radioMois.TabStop = true;
            this.radioMois.Text = "Mois";
            this.radioMois.UseVisualStyleBackColor = true;
            this.radioMois.CheckedChanged += new System.EventHandler(this.radioMois_CheckedChanged);
            // 
            // radioAnnee
            // 
            this.radioAnnee.AutoSize = true;
            this.radioAnnee.Location = new System.Drawing.Point(6, 42);
            this.radioAnnee.Name = "radioAnnee";
            this.radioAnnee.Size = new System.Drawing.Size(56, 17);
            this.radioAnnee.TabIndex = 0;
            this.radioAnnee.TabStop = true;
            this.radioAnnee.Text = "Année";
            this.radioAnnee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Année";
            // 
            // comboAnnee
            // 
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.Location = new System.Drawing.Point(257, 51);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(121, 21);
            this.comboAnnee.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mois";
            // 
            // comboMois
            // 
            this.comboMois.FormattingEnabled = true;
            this.comboMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.comboMois.Location = new System.Drawing.Point(257, 97);
            this.comboMois.Name = "comboMois";
            this.comboMois.Size = new System.Drawing.Size(121, 21);
            this.comboMois.TabIndex = 5;
            // 
            // ChiffreAffaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 386);
            this.Controls.Add(this.comboMois);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupTemps);
            this.Controls.Add(this.gridCA);
            this.Controls.Add(this.listCA);
            this.Controls.Add(this.label1);
            this.Name = "ChiffreAffaire";
            this.Text = "ChiffreAffaire";
            this.Load += new System.EventHandler(this.ChiffreAffaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCA)).EndInit();
            this.groupTemps.ResumeLayout(false);
            this.groupTemps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCA;
        private System.Windows.Forms.DataGridView gridCA;
        private System.Windows.Forms.GroupBox groupTemps;
        private System.Windows.Forms.RadioButton radioAnnee;
        private System.Windows.Forms.RadioButton radioMois;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAnnee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMois;
    }
}