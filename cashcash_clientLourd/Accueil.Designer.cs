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
            this.btnPageInterventions = new System.Windows.Forms.Button();
            this.btnPageContrat = new System.Windows.Forms.Button();
            this.btnPageTechniciens = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPageInterventions
            // 
            this.btnPageInterventions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageInterventions.AutoSize = true;
            this.btnPageInterventions.Location = new System.Drawing.Point(241, 3);
            this.btnPageInterventions.Name = "btnPageInterventions";
            this.btnPageInterventions.Size = new System.Drawing.Size(232, 26);
            this.btnPageInterventions.TabIndex = 0;
            this.btnPageInterventions.Text = "page Intervention";
            this.btnPageInterventions.UseVisualStyleBackColor = true;
            this.btnPageInterventions.Click += new System.EventHandler(this.btnPageTechniciens_Click);
            // 
            // btnPageContrat
            // 
            this.btnPageContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageContrat.AutoSize = true;
            this.btnPageContrat.Location = new System.Drawing.Point(3, 3);
            this.btnPageContrat.Name = "btnPageContrat";
            this.btnPageContrat.Size = new System.Drawing.Size(232, 26);
            this.btnPageContrat.TabIndex = 1;
            this.btnPageContrat.Text = "page Contrat";
            this.btnPageContrat.UseVisualStyleBackColor = true;
            this.btnPageContrat.UseWaitCursor = true;
            this.btnPageContrat.Click += new System.EventHandler(this.BtnPageContrat_Click);
            // 
            // btnPageTechniciens
            // 
            this.btnPageTechniciens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageTechniciens.AutoSize = true;
            this.btnPageTechniciens.Location = new System.Drawing.Point(479, 3);
            this.btnPageTechniciens.Name = "btnPageTechniciens";
            this.btnPageTechniciens.Size = new System.Drawing.Size(232, 26);
            this.btnPageTechniciens.TabIndex = 2;
            this.btnPageTechniciens.Text = "page Techniciens";
            this.btnPageTechniciens.UseVisualStyleBackColor = true;
            this.btnPageTechniciens.Click += new System.EventHandler(this.btnPageTechniciens_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnPageContrat);
            this.flowLayoutPanel1.Controls.Add(this.btnPageInterventions);
            this.flowLayoutPanel1.Controls.Add(this.btnPageTechniciens);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 40);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 429);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPageInterventions;
        private System.Windows.Forms.Button btnPageContrat;
        private System.Windows.Forms.Button btnPageTechniciens;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

