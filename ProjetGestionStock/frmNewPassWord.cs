using ProjetGestionStock.model;
using ProjetGestionStock.Utils;
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

namespace ProjetGestionStock
{
    public partial class frmNewPassWord : Form
    {
        StockEntities db = new StockEntities();
        string identity = frmForgetPassword.identifiant;
        public frmNewPassWord()
        {
            InitializeComponent();
        }

        private void btnRenitialisation_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {   
                var user = db.Utilisateur.Where(a => a.IdentifiantUt == identity).FirstOrDefault();
                    if (user != null)
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            user.MotDePasse = Crypts.GetMd5Hash(md5Hash, txtNewPassword.Text);
                            db.SaveChanges();
                            
                            lblForgetPassword f = new lblForgetPassword();
                            this.Hide();
                            f.Show();
                        }
                    }else
                    {
                        MessageBox.Show("Erreur de Renitialisation");
                    }
                
            }else
            {
                MessageBox.Show("Les deux mot de passe doit etre identique");
            }
        }
    }
}

