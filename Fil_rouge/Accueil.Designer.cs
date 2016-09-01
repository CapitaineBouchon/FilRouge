namespace Fil_rouge
{
    partial class Accueil
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
            this.gestionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNouveauClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercheClient = new System.Windows.Forms.ToolStripMenuItem();
            this.gEstionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreerCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRechercheCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCA = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestionClientToolStripMenuItem
            // 
            this.gestionClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNouveauClient,
            this.menuRechercheClient});
            this.gestionClientToolStripMenuItem.Name = "gestionClientToolStripMenuItem";
            this.gestionClientToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.gestionClientToolStripMenuItem.Text = "Gestion Client";
            // 
            // menuNouveauClient
            // 
            this.menuNouveauClient.Name = "menuNouveauClient";
            this.menuNouveauClient.Size = new System.Drawing.Size(200, 22);
            this.menuNouveauClient.Text = "Créer un nouveau client";
            this.menuNouveauClient.Click += new System.EventHandler(this.menuNouveauClient_Click);
            // 
            // menuRechercheClient
            // 
            this.menuRechercheClient.Name = "menuRechercheClient";
            this.menuRechercheClient.Size = new System.Drawing.Size(200, 22);
            this.menuRechercheClient.Text = "Rechercher un Client";
            this.menuRechercheClient.Click += new System.EventHandler(this.menuRechercheClient_Click);
            // 
            // gEstionCommandeToolStripMenuItem
            // 
            this.gEstionCommandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreerCommande,
            this.MenuRechercheCommande});
            this.gEstionCommandeToolStripMenuItem.Name = "gEstionCommandeToolStripMenuItem";
            this.gEstionCommandeToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.gEstionCommandeToolStripMenuItem.Text = "Gestion Commande";
            // 
            // MenuCreerCommande
            // 
            this.MenuCreerCommande.Name = "MenuCreerCommande";
            this.MenuCreerCommande.Size = new System.Drawing.Size(237, 22);
            this.MenuCreerCommande.Text = "Créer une nouvelle commande";
            this.MenuCreerCommande.Click += new System.EventHandler(this.MenuCreerCommande_Click);
            // 
            // MenuRechercheCommande
            // 
            this.MenuRechercheCommande.Name = "MenuRechercheCommande";
            this.MenuRechercheCommande.Size = new System.Drawing.Size(237, 22);
            this.MenuRechercheCommande.Text = "Rechercher une commande";
            this.MenuRechercheCommande.Click += new System.EventHandler(this.MenuRechercheCommande_Click);
            // 
            // MenuCA
            // 
            this.MenuCA.Name = "MenuCA";
            this.MenuCA.Size = new System.Drawing.Size(101, 20);
            this.MenuCA.Text = "Chiffre d\'affaire";
            this.MenuCA.Click += new System.EventHandler(this.MenuCA_Click);
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.catalogueToolStripMenuItem.Text = "Catalogue";
            this.catalogueToolStripMenuItem.Click += new System.EventHandler(this.catalogueToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientToolStripMenuItem,
            this.gEstionCommandeToolStripMenuItem,
            this.MenuCA,
            this.catalogueToolStripMenuItem,
            this.deconnexionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(732, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(732, 480);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem gestionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNouveauClient;
        private System.Windows.Forms.ToolStripMenuItem menuRechercheClient;
        private System.Windows.Forms.ToolStripMenuItem gEstionCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCreerCommande;
        private System.Windows.Forms.ToolStripMenuItem MenuRechercheCommande;
        private System.Windows.Forms.ToolStripMenuItem MenuCA;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}