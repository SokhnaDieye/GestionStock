using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetGestionStock.model;
using ProjetGestionStock.Utils;

namespace ProjetGestionStock
{
    public partial class frmLayoutVend : Form
    {
        public Utilisateur utilisateur;
        StockEntities db = new StockEntities();
        public frmLayoutVend()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmLayoutVend_Load(object sender, EventArgs e)
        {
            lblNom.Text = lblForgetPassword.userConnecter.ToUpper();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Width = screenWidth;
            this.Height = screenHeight;
            this.Location = new Point(0, 0);



        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width<= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void btnFerme_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeconnection_Click_1(object sender, EventArgs e)
        {
            lblForgetPassword f = new lblForgetPassword();
            f.Show();
            this.Close();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            fermer();
            frmRechercheProduitVend f = new frmRechercheProduitVend();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void btnVendeur_Click(object sender, EventArgs e)
        {
            fermer();
            frmVendeur f = new frmVendeur();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void btnBilan_Click(object sender, EventArgs e)
        {
            fermer();
            frmBilan f = new frmBilan();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
