namespace cashcash_clientLourd
{
    partial class Accueil
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
            this.btnPageTechniciens = new System.Windows.Forms.Button();
            this.btnPageContrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPageTechniciens
            // 
            this.btnPageTechniciens.Location = new System.Drawing.Point(118, 76);
            this.btnPageTechniciens.Name = "btnPageTechniciens";
            this.btnPageTechniciens.Size = new System.Drawing.Size(232, 23);
            this.btnPageTechniciens.TabIndex = 0;
            this.btnPageTechniciens.Text = "page Intervention";
            this.btnPageTechniciens.UseVisualStyleBackColor = true;
            this.btnPageTechniciens.Click += new System.EventHandler(this.btnPageTechniciens_Click);
            // 
            // btnPageContrat
            // 
            this.btnPageContrat.Location = new System.Drawing.Point(118, 105);
            this.btnPageContrat.Name = "btnPageContrat";
            this.btnPageContrat.Size = new System.Drawing.Size(232, 23);
            this.btnPageContrat.TabIndex = 1;
            this.btnPageContrat.Text = "page Contrat";
            this.btnPageContrat.UseVisualStyleBackColor = true;
            this.btnPageContrat.UseWaitCursor = true;
            this.btnPageContrat.Click += new System.EventHandler(this.BtnPageContrat_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPageContrat);
            this.Controls.Add(this.btnPageTechniciens);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPageTechniciens;
        private System.Windows.Forms.Button btnPageContrat;
    }
}

