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
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.btnExportXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
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
            // dataGridClient
            // 
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Location = new System.Drawing.Point(12, 134);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.RowHeadersWidth = 51;
            this.dataGridClient.RowTemplate.Height = 24;
            this.dataGridClient.Size = new System.Drawing.Size(892, 183);
            this.dataGridClient.TabIndex = 2;
            // 
            // btnExportXml
            // 
            this.btnExportXml.Location = new System.Drawing.Point(52, 355);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(75, 23);
            this.btnExportXml.TabIndex = 3;
            this.btnExportXml.Text = "button1";
            this.btnExportXml.UseVisualStyleBackColor = true;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // FormContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.dataGridClient);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormContrat";
            this.Text = "FormContrat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.Button btnExportXml;
    }
}