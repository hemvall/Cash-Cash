namespace cashcash_clientLourd
{
    partial class FormContrat
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
            this.dataGridContrat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(386, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Contrat";
            // 
            // dataGridContrat
            // 
            this.dataGridContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContrat.Location = new System.Drawing.Point(12, 134);
            this.dataGridContrat.Name = "dataGridContrat";
            this.dataGridContrat.RowHeadersWidth = 51;
            this.dataGridContrat.RowTemplate.Height = 24;
            this.dataGridContrat.Size = new System.Drawing.Size(776, 183);
            this.dataGridContrat.TabIndex = 2;
            // 
            // FormContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridContrat);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormContrat";
            this.Text = "FormContrat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridContrat;
    }
}