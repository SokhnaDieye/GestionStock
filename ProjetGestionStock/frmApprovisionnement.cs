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
    public partial class frmApprovisionnement : Form
    {
        public Produit produit;
        StockEntities db = new StockEntities();
        public frmApprovisionnement()
        {
            InitializeComponent();
        }

        private void frmApprovisionnement_Load(object sender, EventArgs e)
        {
            lblProduit.Text = produit.DesignationProduit;
            dgApprovisionnement.DataSource = db.Approvisionnement.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestante > 0).ToList();
            
        }

        private void frmFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetForm()
        {
            txtDatePeremption.Value = DateTime.Now;
            txtQte.Text = string.Empty;
            dgApprovisionnement.DataSource = db.Approvisionnement.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestante > 0).ToList();
            txtQte.Focus();
            /*if (txtQte <)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Approvisionnement a = new Approvisionnement();
            a.QteAppro = int.Parse(txtQte.Text);
            a.DatePeremption = txtDatePeremption.Value;
            a.QteRestante = int.Parse(txtQte.Text);
            a.DateAppro=DateTime.Now;
            a.CodeProduit=produit.CodeProduit;
            db.Approvisionnement.Add(a);
            db.SaveChanges();
            resetForm();
        }

        private void lblProduit_Click(object sender, EventArgs e)
        {

        }

        private void lblProduit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
