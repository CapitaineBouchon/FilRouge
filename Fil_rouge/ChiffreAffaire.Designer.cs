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
            this.btnSearch = new System.Windows.Forms.Button();
            this.listAffiche = new System.Windows.Forms.ListBox();
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(158, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listAffiche
            // 
            this.listAffiche.FormattingEnabled = true;
            this.listAffiche.Location = new System.Drawing.Point(36, 139);
            this.listAffiche.Name = "listAffiche";
            this.listAffiche.Size = new System.Drawing.Size(467, 134);
            this.listAffiche.TabIndex = 4;
            // 
            // ChiffreAffaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 386);
            this.Controls.Add(this.listAffiche);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listCA);
            this.Controls.Add(this.label1);
            this.Name = "ChiffreAffaire";
            this.Text = "ChiffreAffaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listAffiche;
    }
}