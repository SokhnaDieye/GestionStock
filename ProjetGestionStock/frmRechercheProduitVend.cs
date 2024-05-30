using ProjetGestionStock.model;
using ProjetGestionStock.Utils;
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
    public partial class frmRechercheProduitVend : Form
    {
        StockEntities db = new StockEntities();
        LoadComboBox load = new LoadComboBox();
        public frmRechercheProduitVend()
        {
            InitializeComponent();
        }

   

        private void btnRecherch_Click_1(object sender, EventArgs e)
        {
            var liste = db.Ventes.ToList();

            if (!string.IsNullOrEmpty(txtProduit.Text))
            {
                liste = liste.Where(
                    a => a.DesignationProduitV.ToLower().Contains(txtProduit.Text.ToLower())
                  ).ToList();
                
            }
            if (!string.IsNullOrEmpty(txtPU.Text))
            {
                double p = double.Parse(txtPU.Text);
                liste = liste.Where(
                    a => a.PuProduitV <= p
                  ).ToList();
            }
            dgRecherche.DataSource = liste;
        }
    }
}
