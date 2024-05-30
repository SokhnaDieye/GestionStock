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
    public partial class frmProduit : Form
    {
        StockEntities db = new StockEntities();
        LoadComboBox load = new LoadComboBox();
        Logger log=new Logger();
        public frmProduit()
        {
            InitializeComponent();
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = db.Produit.ToList();
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember= "Text";
        }
        private void resetForm()
        {
            txtCode.Text= string.Empty;
            txtDesignation.Text = String.Empty;
            txtPU.Text = String.Empty;
            txtQteCritique.Text = String.Empty;
            txtQteMin.Text = String.Empty;

            dgProduit.DataSource = db.Produit.ToList();
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";
            txtCode.Focus();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Produit P = new Produit();
                P.CodeProduit = txtCode.Text;
                P.DesignationProduit = txtDesignation.Text;
                P.PU = CheckEnter.checkIsFloat(txtPU.Text) ? float.Parse(txtPU.Text) : 0;
                P.QteMin = int.Parse(txtQteMin.Text);
                P.QteCri = int.Parse(txtQteCritique.Text);
                P.CodeCategorie = cbbCategorie.SelectedValue.ToString();
                db.Produit.Add(P);
                db.SaveChanges();
                resetForm();
            }
            catch (Exception ex)
            {
                logerreur.Text = "Veuillez verifier si tout les champs sont bien remplie";
                //log.WriteDataError("frmProduit-btnAjouter_Click", ex.ToString());
                Logger.WriteLogSystem(ex.ToString(), "frmProduit-btnAjouter_Click");
            }
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit P = db.Produit.Find(id);
            P.CodeProduit = txtCode.Text;
            P.DesignationProduit = txtDesignation.Text;
            P.PU = float.Parse(txtPU.Text);
            P.QteMin = int.Parse(txtQteMin.Text);
            P.QteCri = int.Parse(txtQteCritique.Text);
            P.CodeCategorie = cbbCategorie.SelectedValue.ToString();
            db.SaveChanges();
            resetForm();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit P = db.Produit.Find(id);
            db.Produit.Remove(P);
            db.SaveChanges();
            resetForm();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtPU.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQteCritique.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            cbbCategorie.SelectedValue = dgProduit.CurrentRow.Cells[6].Value;
        }

        private void btnAppro_Click(object sender, EventArgs e)
        {
            frmApprovisionnement f = new frmApprovisionnement() ;
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            f.produit=db.Produit.Find(id);
            f.ShowDialog();

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmPrintListeProduit f = new frmPrintListeProduit();
            f.Show();
            this.Enabled = false;

        }

        private void dgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
