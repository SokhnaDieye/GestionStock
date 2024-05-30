namespace ProjetGestionStock
{
    partial class frmRechercheProduit
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
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.btnRecherch = new System.Windows.Forms.Button();
            this.dgRecherche = new System.Windows.Forms.DataGridView();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit";
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(16, 52);
            this.txtProduit.Multiline = true;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(179, 28);
            this.txtProduit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PU";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(526, 55);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(179, 27);
            this.txtPU.TabIndex = 1;
            // 
            // btnRecherch
            // 
            this.btnRecherch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecherch.Location = new System.Drawing.Point(781, 52);
            this.btnRecherch.Name = "btnRecherch";
            this.btnRecherch.Size = new System.Drawing.Size(179, 28);
            this.btnRecherch.TabIndex = 2;
            this.btnRecherch.Text = "Recherche";
            this.btnRecherch.UseVisualStyleBackColor = false;
            this.btnRecherch.Click += new System.EventHandler(this.btnRecherch_Click);
            // 
            // dgRecherche
            // 
            this.dgRecherche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRecherche.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecherche.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRecherche.Location = new System.Drawing.Point(0, 173);
            this.dgRecherche.Name = "dgRecherche";
            this.dgRecherche.RowHeadersWidth = 51;
            this.dgRecherche.Size = new System.Drawing.Size(1339, 380);
            this.dgRecherche.TabIndex = 3;
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(271, 52);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(179, 28);
            this.cbbCategorie.TabIndex = 4;
            // 
            // frmRechercheProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1339, 553);
            this.ControlBox = false;
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.dgRecherche);
            this.Controls.Add(this.btnRecherch);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmRechercheProduit";
            this.Text = "frmRechercheProduit";
            this.Load += new System.EventHandler(this.frmRechercheProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Button btnRecherch;
        private System.Windows.Forms.DataGridView dgRecherche;
        private System.Windows.Forms.ComboBox cbbCategorie;
    }
}