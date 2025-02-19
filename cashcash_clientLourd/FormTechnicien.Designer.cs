namespace cashcash_clientLourd
{
    partial class FormTechnicien
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridTechniciens = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTechniciens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Techniciens";
            // 
            // dataGridTechniciens
            // 
            this.dataGridTechniciens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTechniciens.Location = new System.Drawing.Point(12, 28);
            this.dataGridTechniciens.Name = "dataGridTechniciens";
            this.dataGridTechniciens.RowHeadersWidth = 51;
            this.dataGridTechniciens.RowTemplate.Height = 24;
            this.dataGridTechniciens.Size = new System.Drawing.Size(1092, 150);
            this.dataGridTechniciens.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(975, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "retour à l\'accueil";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormTechnicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridTechniciens);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormTechnicien";
            this.Text = "FormTechnicien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTechniciens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridTechniciens;
        private System.Windows.Forms.Button btnHome;
    }
}