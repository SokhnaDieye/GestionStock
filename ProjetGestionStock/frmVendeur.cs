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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProjetGestionStock
{
    public partial class frmVendeur : Form
    {
        public frmVendeur()
        {
            InitializeComponent();
        }
        StockEntities db = new StockEntities();

        private void resetForm()
        { 
            txtCodeProd.Text = string.Empty;
            txtLibelleProduit.Text= string.Empty;
            txtPUnitaire.Text = string.Empty;
            txtQte.Text = string.Empty;
            txtNumTelephone.Text= string.Empty;
            txtNom.Text= string.Empty;
            txtPrenom.Text = string.Empty;
            txtAdresseEmail.Text= string.Empty;
            txtPrix.Text = string.Empty;
            dgVente.DataSource = db.Ventes.ToList();
            txtCodeProd.Focus();

        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            Ventes v = new Ventes();
            v.CodeProduitV = txtCodeProd.Text;
            v.DesignationProduitV=txtLibelleProduit.Text;
            v.PuProduitV = CheckEnter.checkIsFloat(txtPUnitaire.Text) ? float.Parse(txtPUnitaire.Text) : 0;
            v.Quantite = int.Parse(txtQte.Text);
            v.Tel = txtNumTelephone.Text;
            v.Nom = txtNom.Text;
            v.Prenom = txtPrenom.Text;
            v.AdresseEmail = txtAdresseEmail.Text;
            v.Prix =float.Parse(txtPUnitaire.Text);
            db.Ventes.Add(v);
            db.SaveChanges();
            resetForm();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string productCode = txtCodeProd.Text;
            var product = db.Produit.FirstOrDefault(p => p.CodeProduit.ToLower() == productCode.ToLower());
            Produit prod = product;

            if (prod != null)
            {
                txtLibelleProduit.Text = prod.DesignationProduit;
                txtPUnitaire.Text = prod.PU.ToString();
                txtLibelleProduit.Enabled = false;
                txtPUnitaire.Enabled = false;
            }
            else
            {
                txtLibelleProduit.Text = "";
                txtPUnitaire.Text = "";
                txtLibelleProduit.Enabled = true;
                txtPUnitaire.Enabled = true;
            }
        }

        private void btnRechecheNum_Click(object sender, EventArgs e)
        {
            string telVente = txtNumTelephone.Text;
            var ventes = db.Ventes.FirstOrDefault(v => v.Tel == telVente);
            Ventes vs = ventes;

            if (vs != null)
            {
                txtPrenom.Text = vs.Prenom;
                txtNom.Text = vs.Nom;
                txtAdresseEmail.Text = vs.AdresseEmail;
                txtAdresseEmail.Enabled = false;
                txtPrenom.Enabled = false;
                txtNom.Enabled = false;
            }
            else
            {
                txtAdresseEmail.Text = "";
                txtPrenom.Text = "";
                txtNom.Text = "";
                txtAdresseEmail.Enabled = true;
                txtPrenom.Enabled = true;
                txtNom.Enabled = true;
            }
        }

        private void GenererPrix_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtPUnitaire.Text, out float pU) && int.TryParse(txtQte.Text, out int qte) )
            {
                if (qte<=0)
                {
                    MessageBox.Show("gooo");
                }
                else
                {
                     float prix= qte * pU;
                    txtPrix.Text = prix.ToString();
                }
                
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmListeVente f = new frmListeVente();
            f.Show();
            //this.Enabled = false;
        }
    }
}
