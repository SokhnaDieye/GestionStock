namespace ProjetGestionStock
{
    partial class frmApprovisionnement
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.txtDatePeremption = new System.Windows.Forms.DateTimePicker();
            this.dgApprovisionnement = new System.Windows.Forms.DataGridView();
            this.lblProduit = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.frmFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de peremption";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(42, 59);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(208, 28);
            this.txtQte.TabIndex = 2;
            // 
            // txtDatePeremption
            // 
            this.txtDatePeremption.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePeremption.Location = new System.Drawing.Point(356, 59);
            this.txtDatePeremption.Name = "txtDatePeremption";
            this.txtDatePeremption.Size = new System.Drawing.Size(208, 28);
            this.txtDatePeremption.TabIndex = 3;
            // 
            // dgApprovisionnement
            // 
            this.dgApprovisionnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApprovisionnement.Location = new System.Drawing.Point(34, 159);
            this.dgApprovisionnement.Name = "dgApprovisionnement";
            this.dgApprovisionnement.RowHeadersWidth = 51;
            this.dgApprovisionnement.RowTemplate.Height = 24;
            this.dgApprovisionnement.Size = new System.Drawing.Size(927, 439);
            this.dgApprovisionnement.TabIndex = 4;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProduit.Location = new System.Drawing.Point(895, 59);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(66, 24);
            this.lblProduit.TabIndex = 5;
            this.lblProduit.Text = "label3";
            this.lblProduit.Click += new System.EventHandler(this.lblProduit_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(42, 114);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(188, 39);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(404, 114);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(188, 39);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // frmFermer
            // 
            this.frmFermer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frmFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmFermer.Location = new System.Drawing.Point(773, 114);
            this.frmFermer.Name = "frmFermer";
            this.frmFermer.Size = new System.Drawing.Size(188, 39);
            this.frmFermer.TabIndex = 8;
            this.frmFermer.Text = "&Fermer";
            this.frmFermer.UseVisualStyleBackColor = false;
            this.frmFermer.Click += new System.EventHandler(this.frmFermer_Click);
            // 
            // frmApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 627);
            this.ControlBox = false;
            this.Controls.Add(this.frmFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.dgApprovisionnement);
            this.Controls.Add(this.txtDatePeremption);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApprovisionnement";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.frmApprovisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.DateTimePicker txtDatePeremption;
        private System.Windows.Forms.DataGridView dgApprovisionnement;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button frmFermer;
    }
}