namespace ProjetGestionStock
{
    partial class frmUtilisateur
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
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbProfil = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnChangerStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgUtilisateur.Location = new System.Drawing.Point(399, 0);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.RowHeadersWidth = 51;
            this.dgUtilisateur.RowTemplate.Height = 24;
            this.dgUtilisateur.Size = new System.Drawing.Size(520, 518);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(34, 82);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(314, 28);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profil";
            // 
            // cbbProfil
            // 
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Location = new System.Drawing.Point(34, 195);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.Size = new System.Drawing.Size(314, 30);
            this.cbbProfil.TabIndex = 4;
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreer.Location = new System.Drawing.Point(184, 340);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(164, 46);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "&Creer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnChangerStatus
            // 
            this.btnChangerStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangerStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangerStatus.Location = new System.Drawing.Point(184, 412);
            this.btnChangerStatus.Name = "btnChangerStatus";
            this.btnChangerStatus.Size = new System.Drawing.Size(164, 45);
            this.btnChangerStatus.TabIndex = 6;
            this.btnChangerStatus.Text = "&Changer Status";
            this.btnChangerStatus.UseVisualStyleBackColor = false;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangerStatus);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.cbbProfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUtilisateur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUtilisateur";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbProfil;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnChangerStatus;
    }
}