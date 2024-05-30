namespace ProjetGestionStock
{
    partial class frmListeVente
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
            this.crystalReportViewerVente = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerVente
            // 
            this.crystalReportViewerVente.ActiveViewIndex = -1;
            this.crystalReportViewerVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVente.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVente.Location = new System.Drawing.Point(12, 97);
            this.crystalReportViewerVente.Name = "crystalReportViewerVente";
            this.crystalReportViewerVente.Size = new System.Drawing.Size(1216, 483);
            this.crystalReportViewerVente.TabIndex = 2;
            // 
            // btnQuiter
            // 
            this.btnQuiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiter.Location = new System.Drawing.Point(12, 12);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(122, 52);
            this.btnQuiter.TabIndex = 3;
            this.btnQuiter.Text = "Quitter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // frmListeVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 629);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.crystalReportViewerVente);
            this.Name = "frmListeVente";
            this.Text = "frmListeVente";
            this.Load += new System.EventHandler(this.frmListeVente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVente;
        private System.Windows.Forms.Button btnQuiter;
    }
}