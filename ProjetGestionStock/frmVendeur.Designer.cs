namespace ProjetGestionStock
{
    partial class frmVendeur
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
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPUnitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLibelleProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumTelephone = new System.Windows.Forms.TextBox();
            this.txtAdresseEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgVente = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVente)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Produit";
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimer.Location = new System.Drawing.Point(1076, 607);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(226, 35);
            this.btnImprimer.TabIndex = 34;
            this.btnImprimer.Text = "&Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(341, 607);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(226, 35);
            this.btnValider.TabIndex = 33;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-265, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Categorie";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(13, 412);
            this.txtQte.Margin = new System.Windows.Forms.Padding(4);
            this.txtQte.Multiline = true;
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(675, 40);
            this.txtQte.TabIndex = 24;
            this.txtQte.TextChanged += new System.EventHandler(this.GenererPrix_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-265, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantite critique";
            // 
            // txtPrenom
            // 
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrenom.Location = new System.Drawing.Point(880, 422);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(664, 40);
            this.txtPrenom.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-265, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantite Minimal";
            // 
            // txtPUnitaire
            // 
            this.txtPUnitaire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPUnitaire.Location = new System.Drawing.Point(13, 297);
            this.txtPUnitaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtPUnitaire.Multiline = true;
            this.txtPUnitaire.Name = "txtPUnitaire";
            this.txtPUnitaire.Size = new System.Drawing.Size(675, 40);
            this.txtPUnitaire.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-265, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prix Unitaire";
            // 
            // txtLibelleProduit
            // 
            this.txtLibelleProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLibelleProduit.Location = new System.Drawing.Point(13, 182);
            this.txtLibelleProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibelleProduit.Multiline = true;
            this.txtLibelleProduit.Name = "txtLibelleProduit";
            this.txtLibelleProduit.Size = new System.Drawing.Size(675, 40);
            this.txtLibelleProduit.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-265, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Designation";
            // 
            // txtCodeProd
            // 
            this.txtCodeProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodeProd.Location = new System.Drawing.Point(13, 67);
            this.txtCodeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeProd.Multiline = true;
            this.txtCodeProd.Name = "txtCodeProd";
            this.txtCodeProd.Size = new System.Drawing.Size(675, 40);
            this.txtCodeProd.TabIndex = 18;
            this.txtCodeProd.TextChanged += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-265, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNumTelephone);
            this.panel1.Controls.Add(this.txtAdresseEmail);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.txtPUnitaire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodeProd);
            this.panel1.Controls.Add(this.txtLibelleProduit);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.txtQte);
            this.panel1.Controls.Add(this.btnImprimer);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 661);
            this.panel1.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(12, 496);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 25);
            this.label15.TabIndex = 43;
            this.label15.Text = "Prix";
            // 
            // txtPrix
            // 
            this.txtPrix.Enabled = false;
            this.txtPrix.Location = new System.Drawing.Point(17, 538);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(675, 40);
            this.txtPrix.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(875, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = "Telephone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(875, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Adresse Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(8, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "Quantite";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(12, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "PU ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Libelle Produit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(881, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(884, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nom";
            // 
            // txtNumTelephone
            // 
            this.txtNumTelephone.Location = new System.Drawing.Point(880, 87);
            this.txtNumTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTelephone.Multiline = true;
            this.txtNumTelephone.Name = "txtNumTelephone";
            this.txtNumTelephone.Size = new System.Drawing.Size(664, 40);
            this.txtNumTelephone.TabIndex = 27;
            this.txtNumTelephone.TextChanged += new System.EventHandler(this.btnRechecheNum_Click);
            // 
            // txtAdresseEmail
            // 
            this.txtAdresseEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdresseEmail.Location = new System.Drawing.Point(880, 306);
            this.txtAdresseEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresseEmail.Multiline = true;
            this.txtAdresseEmail.Name = "txtAdresseEmail";
            this.txtAdresseEmail.Size = new System.Drawing.Size(664, 40);
            this.txtAdresseEmail.TabIndex = 26;
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNom.Location = new System.Drawing.Point(880, 191);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(664, 40);
            this.txtNom.TabIndex = 25;
            // 
            // dgVente
            // 
            this.dgVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgVente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVente.Location = new System.Drawing.Point(0, 1);
            this.dgVente.Name = "dgVente";
            this.dgVente.RowHeadersWidth = 51;
            this.dgVente.RowTemplate.Height = 24;
            this.dgVente.Size = new System.Drawing.Size(1701, 317);
            this.dgVente.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgVente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1701, 318);
            this.panel2.TabIndex = 43;
            // 
            // frmVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 984);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmVendeur";
            this.Text = "frmVendeur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPUnitaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLibelleProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumTelephone;
        private System.Windows.Forms.TextBox txtAdresseEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgVente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrix;
    }
}