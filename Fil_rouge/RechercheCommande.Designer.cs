namespace Fil_rouge
{
    partial class RechercheCommande
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
            this.comboChoix = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BoxClient = new System.Windows.Forms.GroupBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCommande = new System.Windows.Forms.GroupBox();
            this.txtIdCommande = new System.Windows.Forms.TextBox();
            this.radioIdCommande = new System.Windows.Forms.RadioButton();
            this.radioEnCours = new System.Windows.Forms.RadioButton();
            this.radioImpaye = new System.Windows.Forms.RadioButton();
            this.gridAffichage = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();
            this.BoxClient.SuspendLayout();
            this.boxCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher par";
            // 
            // comboChoix
            // 
            this.comboChoix.FormattingEnabled = true;
            this.comboChoix.Items.AddRange(new object[] {
            "Client",
            "Commande"});
            this.comboChoix.Location = new System.Drawing.Point(37, 49);
            this.comboChoix.Name = "comboChoix";
            this.comboChoix.Size = new System.Drawing.Size(128, 21);
            this.comboChoix.TabIndex = 1;
            this.comboChoix.SelectedIndexChanged += new System.EventHandler(this.comboChoix_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // BoxClient
            // 
            this.BoxClient.Controls.Add(this.txtIdClient);
            this.BoxClient.Controls.Add(this.label2);
            this.BoxClient.Location = new System.Drawing.Point(12, 301);
            this.BoxClient.Name = "BoxClient";
            this.BoxClient.Size = new System.Drawing.Size(285, 80);
            this.BoxClient.TabIndex = 3;
            this.BoxClient.TabStop = false;
            this.BoxClient.Visible = false;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(80, 33);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(161, 20);
            this.txtIdClient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identifiant";
            // 
            // boxCommande
            // 
            this.boxCommande.Controls.Add(this.radioImpaye);
            this.boxCommande.Controls.Add(this.radioEnCours);
            this.boxCommande.Controls.Add(this.radioIdCommande);
            this.boxCommande.Controls.Add(this.txtIdCommande);
            this.boxCommande.Location = new System.Drawing.Point(12, 76);
            this.boxCommande.Name = "boxCommande";
            this.boxCommande.Size = new System.Drawing.Size(285, 142);
            this.boxCommande.TabIndex = 4;
            this.boxCommande.TabStop = false;
            this.boxCommande.Visible = false;
            // 
            // txtIdCommande
            // 
            this.txtIdCommande.Enabled = false;
            this.txtIdCommande.Location = new System.Drawing.Point(171, 34);
            this.txtIdCommande.Name = "txtIdCommande";
            this.txtIdCommande.Size = new System.Drawing.Size(100, 20);
            this.txtIdCommande.TabIndex = 1;
            // 
            // radioIdCommande
            // 
            this.radioIdCommande.AutoSize = true;
            this.radioIdCommande.Location = new System.Drawing.Point(6, 34);
            this.radioIdCommande.Name = "radioIdCommande";
            this.radioIdCommande.Size = new System.Drawing.Size(132, 17);
            this.radioIdCommande.TabIndex = 2;
            this.radioIdCommande.TabStop = true;
            this.radioIdCommande.Text = "Numero de commande";
            this.radioIdCommande.UseVisualStyleBackColor = true;
            this.radioIdCommande.CheckedChanged += new System.EventHandler(this.radioIdCommande_CheckedChanged);
            // 
            // radioEnCours
            // 
            this.radioEnCours.AutoSize = true;
            this.radioEnCours.Location = new System.Drawing.Point(6, 63);
            this.radioEnCours.Name = "radioEnCours";
            this.radioEnCours.Size = new System.Drawing.Size(122, 17);
            this.radioEnCours.TabIndex = 2;
            this.radioEnCours.TabStop = true;
            this.radioEnCours.Text = "Commande en cours";
            this.radioEnCours.UseVisualStyleBackColor = true;
            this.radioEnCours.CheckedChanged += new System.EventHandler(this.radioIdCommande_CheckedChanged);
            // 
            // radioImpaye
            // 
            this.radioImpaye.AutoSize = true;
            this.radioImpaye.Location = new System.Drawing.Point(6, 95);
            this.radioImpaye.Name = "radioImpaye";
            this.radioImpaye.Size = new System.Drawing.Size(131, 17);
            this.radioImpaye.TabIndex = 2;
            this.radioImpaye.TabStop = true;
            this.radioImpaye.Text = "Commande non-payée";
            this.radioImpaye.UseVisualStyleBackColor = true;
            this.radioImpaye.CheckedChanged += new System.EventHandler(this.radioIdCommande_CheckedChanged);
            // 
            // gridAffichage
            // 
            this.gridAffichage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAffichage.Location = new System.Drawing.Point(303, 76);
            this.gridAffichage.Name = "gridAffichage";
            this.gridAffichage.Size = new System.Drawing.Size(483, 219);
            this.gridAffichage.TabIndex = 5;
            // 
            // btnDetail
            // 
            this.btnDetail.Enabled = false;
            this.btnDetail.Location = new System.Drawing.Point(222, 272);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Détails";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // RechercheCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 389);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.gridAffichage);
            this.Controls.Add(this.boxCommande);
            this.Controls.Add(this.BoxClient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboChoix);
            this.Controls.Add(this.label1);
            this.Name = "RechercheCommande";
            this.Text = "RechercheCommande";
            this.Load += new System.EventHandler(this.RechercheCommande_Load);
            this.BoxClient.ResumeLayout(false);
            this.BoxClient.PerformLayout();
            this.boxCommande.ResumeLayout(false);
            this.boxCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAffichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboChoix;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox BoxClient;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox boxCommande;
        private System.Windows.Forms.TextBox txtIdCommande;
        private System.Windows.Forms.RadioButton radioIdCommande;
        private System.Windows.Forms.RadioButton radioImpaye;
        private System.Windows.Forms.RadioButton radioEnCours;
        private System.Windows.Forms.DataGridView gridAffichage;
        private System.Windows.Forms.Button btnDetail;
    }
}