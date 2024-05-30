namespace ProjetGestionStock
{
    partial class frmProduit
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
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQteMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQteCritique = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAppro = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.logerreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(528, 51);
            this.dgProduit.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.RowHeadersWidth = 51;
            this.dgProduit.RowTemplate.Height = 24;
            this.dgProduit.Size = new System.Drawing.Size(1100, 696);
            this.dgProduit.TabIndex = 0;
            this.dgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduit_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(32, 54);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(465, 40);
            this.txtCode.TabIndex = 1;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(32, 131);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(465, 40);
            this.txtDesignation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(32, 216);
            this.txtPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtPU.Multiline = true;
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(465, 40);
            this.txtPU.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix Unitaire";
            // 
            // txtQteMin
            // 
            this.txtQteMin.Location = new System.Drawing.Point(32, 291);
            this.txtQteMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtQteMin.Multiline = true;
            this.txtQteMin.Name = "txtQteMin";
            this.txtQteMin.Size = new System.Drawing.Size(465, 40);
            this.txtQteMin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantite Minimal";
            // 
            // txtQteCritique
            // 
            this.txtQteCritique.Location = new System.Drawing.Point(32, 371);
            this.txtQteCritique.Margin = new System.Windows.Forms.Padding(4);
            this.txtQteCritique.Multiline = true;
            this.txtQteCritique.Name = "txtQteCritique";
            this.txtQteCritique.Size = new System.Drawing.Size(465, 40);
            this.txtQteCritique.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantite critique";
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(32, 447);
            this.cbbCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(465, 28);
            this.cbbCategorie.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 424);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categorie";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(234, 552);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(263, 53);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.Location = new System.Drawing.Point(234, 677);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(263, 53);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifier.Location = new System.Drawing.Point(234, 617);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(263, 55);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Location = new System.Drawing.Point(225, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(263, 35);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "S&elect";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAppro
            // 
            this.btnAppro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAppro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAppro.Location = new System.Drawing.Point(539, 7);
            this.btnAppro.Name = "btnAppro";
            this.btnAppro.Size = new System.Drawing.Size(243, 35);
            this.btnAppro.TabIndex = 15;
            this.btnAppro.Text = "&Approvisionner";
            this.btnAppro.UseVisualStyleBackColor = false;
            this.btnAppro.Click += new System.EventHandler(this.btnAppro_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimer.Location = new System.Drawing.Point(845, 7);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(263, 35);
            this.btnImprimer.TabIndex = 16;
            this.btnImprimer.Text = "&Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // logerreur
            // 
            this.logerreur.AutoSize = true;
            this.logerreur.ForeColor = System.Drawing.Color.Red;
            this.logerreur.Location = new System.Drawing.Point(39, 513);
            this.logerreur.Name = "logerreur";
            this.logerreur.Size = new System.Drawing.Size(0, 20);
            this.logerreur.TabIndex = 17;
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 749);
            this.ControlBox = false;
            this.Controls.Add(this.logerreur);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnAppro);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.txtQteCritique);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQteMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQteMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQteCritique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAppro;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Label logerreur;
    }
}