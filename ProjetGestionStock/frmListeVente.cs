using ProjetGestionStock.report;
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
using ProjetGestionStock.report;

namespace ProjetGestionStock
{
    public partial class frmListeVente : Form
    {
        StockEntities db = new StockEntities();
        public frmListeVente()
        {
            InitializeComponent();
        }

        private void frmListeVente_Load(object sender, EventArgs e)
        {
            rptListeVente objRpt = new rptListeVente();
            objRpt.SetDataSource(GetTableVente());
            crystalReportViewerVente.ReportSource = objRpt;
            crystalReportViewerVente.Refresh();
        }
        public DataTable GetTableVente()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeProduitV", typeof(string));
            table.Columns.Add("DesignationProduitV", typeof(string));
            table.Columns.Add("PuProduitV", typeof(double));
            table.Columns.Add("Quantite", typeof(int));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prenom", typeof(string));
            table.Columns.Add("Tel", typeof(string));
            table.Columns.Add("AdresseEmail", typeof(string));
            table.Columns.Add("Prix", typeof(double));
            return table;
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
