using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetGestionStock.model;
using ProjetGestionStock.Utils;

namespace ProjetGestionStock
{
    public partial class lblForgetPassword : Form
    {
        public lblForgetPassword()
        {
            InitializeComponent();
        }
        StockEntities db=new StockEntities();

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string userConnecter;
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            var leUser= db.Utilisateur.Where(a => a.IdentifiantUt == textIdentifiant.Text).FirstOrDefault();
            if (leUser !=null)
            {
                userConnecter = (textIdentifiant.Text).ToString();
                string hash = leUser.MotDePasse;
                using (MD5 md5Hash = MD5.Create())
                {
                    if(Crypts.VerifyMd5Hash(md5Hash, txtMotDePasse.Text, hash))
                    {
                        if (leUser.CodeProfil == "VEND")
                        {
                            // Afficher le formulaire pour le profil "vend"
                            frmLayoutVend fr = new frmLayoutVend();
                            this.Hide();
                            fr.Show();
                        }
                        else if (leUser.CodeProfil == "GEST")
                        {
                            // Afficher le formulaire par défaut
                            frmLayout f = new frmLayout();
                            this.Hide();
                            f.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrecte");
                    }
                }
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrecte");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword f = new frmForgetPassword();
            this.Hide();
            f.Show(); 
        }

        private void lblForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
