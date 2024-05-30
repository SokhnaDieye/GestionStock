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
    public partial class frmForgetPassword : Form
    {
        StockEntities db = new StockEntities();
        
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        public static string identifiant;
        string code =  DateTime.Now.Millisecond.ToString();
        //DateTime.Now.ToString() + DateTime.Now.Minute.ToString() +

        private void btnEnvoiEmail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            var user = db.Utilisateur.Where(a => a.IdentifiantUt == txtIdentifiant.Text).FirstOrDefault();
            if (user != null)
            {
                identifiant = (txtIdentifiant.Text).ToString();
                GMailer.sendMail(email, "Reinitialisation votre mot de passe", string.Format("Votre code est {0}",code));
                MessageBox.Show("Veuillez verifier votre email pour recuperer le Code");
                txtEmail.Enabled=false;
                txtIdentifiant.Enabled=false;
            }
            else
            {
                MessageBox.Show("Identifiant Incorrect");
            }
                
        }
        private void btnverifierCode_Click(object sender, EventArgs e)
        {
            if (code == txtCode.Text)
            {
                frmNewPassWord f = new frmNewPassWord();
                this.Hide();
                f.Show();

            }
            else
            {
                MessageBox.Show("Code Incorrect");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lblForgetPassword f = new lblForgetPassword();
            this.Hide();
            f.Show();
        }
    }
}
