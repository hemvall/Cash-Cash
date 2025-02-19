namespace cashcash_clientLourd
{
    partial class FormIntervention
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
            this.dataGridViewInterventions = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(366, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interventions";
            // 
            // dataGridViewInterventions
            // 
            this.dataGridViewInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInterventions.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewInterventions.Name = "dataGridViewInterventions";
            this.dataGridViewInterventions.RowHeadersWidth = 51;
            this.dataGridViewInterventions.RowTemplate.Height = 24;
            this.dataGridViewInterventions.Size = new System.Drawing.Size(1183, 183);
            this.dataGridViewInterventions.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1066, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "retour à l\'accueil";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(403, 308);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(75, 23);
            this.btnXML.TabIndex = 3;
            this.btnXML.Text = "button1";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXml_click);
            // 
            // FormIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridViewInterventions);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormIntervention";
            this.Text = "FormIntervention";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewInterventions;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXML;
    }
}