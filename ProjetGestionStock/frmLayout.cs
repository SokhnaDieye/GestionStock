using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionStock
{
    public partial class frmLayout : Form
    {
        public string profil;
        public frmLayout()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }
        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent = this;
            f.Show();
           f.WindowState = FormWindowState.Maximized;
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie f=new frmCategorie();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForgetPassword f=new lblForgetPassword();
            f.Show();
            this.Close();
        }

        private void rechercheProdutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmRechercheProduit f = new frmRechercheProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void approvissionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            fermer();
            frmApprovisionnement f = new frmApprovisionnement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            /* Computer myComputer = new Computer();
             this.Width = myComputer.Screen.Boounds();
             this.Height = myComputer.Screen.Boounds();
             this.Location = new Point(0, 0);*/

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Width = screenWidth;
            this.Height = screenHeight;
            this.Location = new Point(0, 0);

            /*if (profil=="VEND")
            {
                formulaireToolStripMenuItem.Visible = false;
                securiteToolStripMenuItem.Visible = false;
               // actionToolStripMenuItem.Visible = false;
            }else if (profil=="GEST")
            {
                formulaireToolStripMenuItem.Visible = true;
                securiteToolStripMenuItem.Visible = true;
                //actionToolStripMenuItem.Visible=true;
            }*/
        }
    }
}
