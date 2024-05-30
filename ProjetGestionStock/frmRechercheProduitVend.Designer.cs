namespace ProjetGestionStock
{
    partial class frmRechercheProduitVend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgRecherche = new System.Windows.Forms.DataGridView();
            this.btnRecherch = new System.Windows.Forms.Button();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgRecherche);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 416);
            this.panel1.TabIndex = 13;
            // 
            // dgRecherche
            // 
            this.dgRecherche.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRecherche.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgRecherche.Location = new System.Drawing.Point(0, 0);
            this.dgRecherche.Name = "dgRecherche";
            this.dgRecherche.RowHeadersWidth = 51;
            this.dgRecherche.Size = new System.Drawing.Size(1106, 416);
            this.dgRecherche.TabIndex = 12;
            // 
            // btnRecherch
            // 
            this.btnRecherch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecherch.Location = new System.Drawing.Point(836, 58);
            this.btnRecherch.Name = "btnRecherch";
            this.btnRecherch.Size = new System.Drawing.Size(145, 29);
            this.btnRecherch.TabIndex = 23;
            this.btnRecherch.Text = "Recherche";
            this.btnRecherch.UseVisualStyleBackColor = false;
            this.btnRecherch.Click += new System.EventHandler(this.btnRecherch_Click_1);
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(451, 64);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(185, 22);
            this.txtPU.TabIndex = 21;
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(148, 64);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(185, 22);
            this.txtProduit.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "PU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Produit";
            // 
            // frmRechercheProduitVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 548);
            this.ControlBox = false;
            this.Controls.Add(this.btnRecherch);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRechercheProduitVend";
            this.Text = "Recherche Produit Vendeur";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgRecherche;
        private System.Windows.Forms.Button btnRecherch;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}