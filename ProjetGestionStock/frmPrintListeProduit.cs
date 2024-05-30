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
    public partial class frmPrintListeProduit : Form
    {
        StockEntities db=new StockEntities();
        public frmPrintListeProduit()
        {
            InitializeComponent();
        }

        private void frmPrintListeProduit_Load(object sender, EventArgs e)
        {
            rptListeProduit objRpt=new rptListeProduit();
            objRpt.SetDataSource(GetTableProduit());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
        public DataTable GetTableProduit()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeProduit", typeof(string));
            table.Columns.Add("DesignationProduit", typeof(string));
            table.Columns.Add("PU", typeof(double));
            table.Columns.Add("QteMin", typeof(int));
            table.Columns.Add("QteCri", typeof(int));
            table.Columns.Add("Categorie", typeof(string));
            var liste = db.Produit.ToList();
            foreach (var item in liste)
            {
                string cat = db.Categorie.Where(a=>a.CodeCategorie==item.CodeCategorie).FirstOrDefault().LibelleCode;
                table.Rows.Add(item.CodeProduit,item.DesignationProduit,item.PU,item.QteMin,
                    item.QteCri,cat);   
            }
            return table;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Enabled = true;
            this.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
