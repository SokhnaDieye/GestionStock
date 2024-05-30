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
    public partial class frmRechercheProduit : Form
    {
        StockEntities db=new StockEntities();
        LoadComboBox load=new LoadComboBox();
        public frmRechercheProduit()
        {
            InitializeComponent();
        }

        private void frmRechercheProduit_Load(object sender, EventArgs e)
        {
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember= "Text";
        }

        private void btnRecherch_Click(object sender, EventArgs e)
        {
            var liste = db.VListeProduitCategorie.ToList();

            if (!string.IsNullOrEmpty(txtProduit.Text))
            {
                liste = liste.Where( 
                    a => a.DesignationProduit.ToLower().Contains(txtProduit.Text.ToLower())
                  ).ToList();
            }
            if (!string.IsNullOrEmpty(cbbCategorie.Text))
            {
                liste = liste.Where(
                    a => a.CodeCategorie.ToLower()==cbbCategorie.SelectedValue.ToString().ToLower()
                  ).ToList();
            }
            if (!string.IsNullOrEmpty(txtPU.Text))
            {
                double p = double.Parse(txtPU.Text);
                liste = liste.Where(
                    a => a.PU <= p 
                  ).ToList();
            }

            dgRecherche.DataSource = liste;
        }
    }
}
