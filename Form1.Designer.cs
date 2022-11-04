namespace TestHeritage
{
    partial class frmDiffusion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbFilm = new System.Windows.Forms.RadioButton();
            this.rbSerie = new System.Windows.Forms.RadioButton();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbNbEpisode = new System.Windows.Forms.TextBox();
            this.tbRecette = new System.Windows.Forms.TextBox();
            this.tbAnnee = new System.Windows.Forms.TextBox();
            this.lTitre = new System.Windows.Forms.Label();
            this.lAnnee = new System.Windows.Forms.Label();
            this.lRecette = new System.Windows.Forms.Label();
            this.lNbEpisode = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstDiffusion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rbFilm
            // 
            this.rbFilm.AutoSize = true;
            this.rbFilm.Location = new System.Drawing.Point(30, 27);
            this.rbFilm.Name = "rbFilm";
            this.rbFilm.Size = new System.Drawing.Size(58, 24);
            this.rbFilm.TabIndex = 0;
            this.rbFilm.TabStop = true;
            this.rbFilm.Text = "film";
            this.rbFilm.UseVisualStyleBackColor = true;
            this.rbFilm.CheckedChanged += new System.EventHandler(this.rbFilm_CheckedChanged);
            // 
            // rbSerie
            // 
            this.rbSerie.AutoSize = true;
            this.rbSerie.Location = new System.Drawing.Point(94, 27);
            this.rbSerie.Name = "rbSerie";
            this.rbSerie.Size = new System.Drawing.Size(68, 24);
            this.rbSerie.TabIndex = 1;
            this.rbSerie.TabStop = true;
            this.rbSerie.Text = "série";
            this.rbSerie.UseVisualStyleBackColor = true;
            this.rbSerie.CheckedChanged += new System.EventHandler(this.rbSerie_CheckedChanged);
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(136, 57);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(202, 26);
            this.tbTitre.TabIndex = 2;
            // 
            // tbNbEpisode
            // 
            this.tbNbEpisode.Location = new System.Drawing.Point(136, 153);
            this.tbNbEpisode.Name = "tbNbEpisode";
            this.tbNbEpisode.Size = new System.Drawing.Size(202, 26);
            this.tbNbEpisode.TabIndex = 3;
            // 
            // tbRecette
            // 
            this.tbRecette.Location = new System.Drawing.Point(136, 121);
            this.tbRecette.Name = "tbRecette";
            this.tbRecette.Size = new System.Drawing.Size(202, 26);
            this.tbRecette.TabIndex = 4;
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(136, 89);
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Size = new System.Drawing.Size(202, 26);
            this.tbAnnee.TabIndex = 5;
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Location = new System.Drawing.Point(8, 57);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(36, 20);
            this.lTitre.TabIndex = 6;
            this.lTitre.Text = "titre";
            // 
            // lAnnee
            // 
            this.lAnnee.AutoSize = true;
            this.lAnnee.Location = new System.Drawing.Point(8, 89);
            this.lAnnee.Name = "lAnnee";
            this.lAnnee.Size = new System.Drawing.Size(54, 20);
            this.lAnnee.TabIndex = 7;
            this.lAnnee.Text = "année";
            // 
            // lRecette
            // 
            this.lRecette.AutoSize = true;
            this.lRecette.Location = new System.Drawing.Point(8, 121);
            this.lRecette.Name = "lRecette";
            this.lRecette.Size = new System.Drawing.Size(59, 20);
            this.lRecette.TabIndex = 8;
            this.lRecette.Text = "recette";
            // 
            // lNbEpisode
            // 
            this.lNbEpisode.AutoSize = true;
            this.lNbEpisode.Location = new System.Drawing.Point(8, 153);
            this.lNbEpisode.Name = "lNbEpisode";
            this.lNbEpisode.Size = new System.Drawing.Size(87, 20);
            this.lNbEpisode.TabIndex = 9;
            this.lNbEpisode.Text = "nb épisode";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 185);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(326, 30);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lstDiffusion
            // 
            this.lstDiffusion.FormattingEnabled = true;
            this.lstDiffusion.ItemHeight = 20;
            this.lstDiffusion.Location = new System.Drawing.Point(12, 221);
            this.lstDiffusion.Name = "lstDiffusion";
            this.lstDiffusion.Size = new System.Drawing.Size(326, 204);
            this.lstDiffusion.TabIndex = 13;
            // 
            // frmDiffusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 446);
            this.Controls.Add(this.lstDiffusion);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lNbEpisode);
            this.Controls.Add(this.lRecette);
            this.Controls.Add(this.lAnnee);
            this.Controls.Add(this.lTitre);
            this.Controls.Add(this.tbAnnee);
            this.Controls.Add(this.tbRecette);
            this.Controls.Add(this.tbNbEpisode);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.rbSerie);
            this.Controls.Add(this.rbFilm);
            this.Name = "frmDiffusion";
            this.Text = "Diffusion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFilm;
        private System.Windows.Forms.RadioButton rbSerie;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbNbEpisode;
        private System.Windows.Forms.TextBox tbRecette;
        private System.Windows.Forms.TextBox tbAnnee;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Label lAnnee;
        private System.Windows.Forms.Label lRecette;
        private System.Windows.Forms.Label lNbEpisode;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstDiffusion;
    }
}

