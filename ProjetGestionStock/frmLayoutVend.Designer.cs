namespace ProjetGestionStock
{
    partial class frmLayoutVend
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.bntHome = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVendeur = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBilan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeconnection = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntHome)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bntHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "PAGES VENDEURS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(828, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 50);
            this.panel2.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(108, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(70, 28);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "label1";
            // 
            // bntHome
            // 
            this.bntHome.Image = global::ProjetGestionStock.Properties.Resources.icons8_menu_30;
            this.bntHome.Location = new System.Drawing.Point(4, 0);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(58, 50);
            this.bntHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bntHome.TabIndex = 3;
            this.bntHome.TabStop = false;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(273, 509);
            this.sidebar.TabIndex = 3;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVendeur);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 58);
            this.panel3.TabIndex = 0;
            // 
            // btnVendeur
            // 
            this.btnVendeur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVendeur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendeur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendeur.Image = global::ProjetGestionStock.Properties.Resources.user2;
            this.btnVendeur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendeur.Location = new System.Drawing.Point(-5, -19);
            this.btnVendeur.Name = "btnVendeur";
            this.btnVendeur.Size = new System.Drawing.Size(322, 102);
            this.btnVendeur.TabIndex = 4;
            this.btnVendeur.Text = "Vente";
            this.btnVendeur.UseVisualStyleBackColor = false;
            this.btnVendeur.Click += new System.EventHandler(this.btnVendeur_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRecherche);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 69);
            this.panel4.TabIndex = 5;
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecherche.FlatAppearance.BorderSize = 0;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecherche.Image = global::ProjetGestionStock.Properties.Resources.icons8_search_30;
            this.btnRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecherche.Location = new System.Drawing.Point(-5, -4);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(335, 83);
            this.btnRecherche.TabIndex = 4;
            this.btnRecherche.Text = "Recherche Produit";
            this.btnRecherche.UseVisualStyleBackColor = false;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBilan);
            this.panel6.Location = new System.Drawing.Point(3, 216);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 75);
            this.panel6.TabIndex = 6;
            // 
            // btnBilan
            // 
            this.btnBilan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBilan.FlatAppearance.BorderSize = 0;
            this.btnBilan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBilan.Image = global::ProjetGestionStock.Properties.Resources.notes2;
            this.btnBilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilan.Location = new System.Drawing.Point(-4, -11);
            this.btnBilan.Name = "btnBilan";
            this.btnBilan.Size = new System.Drawing.Size(286, 100);
            this.btnBilan.TabIndex = 5;
            this.btnBilan.Text = "Bilan";
            this.btnBilan.UseVisualStyleBackColor = false;
            this.btnBilan.Click += new System.EventHandler(this.btnBilan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeconnection);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 334);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 69);
            this.panel5.TabIndex = 7;
            // 
            // btnDeconnection
            // 
            this.btnDeconnection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeconnection.Image = global::ProjetGestionStock.Properties.Resources.logout__2_;
            this.btnDeconnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnection.Location = new System.Drawing.Point(-5, -2);
            this.btnDeconnection.Name = "btnDeconnection";
            this.btnDeconnection.Size = new System.Drawing.Size(293, 93);
            this.btnDeconnection.TabIndex = 6;
            this.btnDeconnection.Text = "Deconnection";
            this.btnDeconnection.UseVisualStyleBackColor = false;
            this.btnDeconnection.Click += new System.EventHandler(this.btnDeconnection_Click_1);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetGestionStock.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(217, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLayoutVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1145, 559);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Name = "frmLayoutVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Load += new System.EventHandler(this.frmLayoutVend_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntHome)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bntHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnVendeur;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeconnection;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBilan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}