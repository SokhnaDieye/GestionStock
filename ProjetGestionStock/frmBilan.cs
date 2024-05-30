using ProjetGestionStock.model;
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
    public partial class frmBilan : Form
    {
        StockEntities db = new StockEntities();
        public frmBilan()
        {
            InitializeComponent();
            dgBilan.DataSource = db.Ventes.ToList();
            this.Load += FrmBilan_Load;
        }

        private void frmBilan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void FrmBilan_Load(object sender, EventArgs e)
        {
            GeneratePieChart();
        }
        /// <summary>
        /// Gerere le diagramme circulaire pour voir le produit qui a le plus de vente
        /// </summary>
        private void GeneratePieChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Ventes");
            var ventes = db.Ventes.ToList();
            var ventesParProduit = ventes.GroupBy(v => v.DesignationProduitV)
                                         .ToDictionary(g => g.Key, g => g.Sum(v => v.Prix));
            foreach (var vente in ventesParProduit)
            {
                chart1.Series["Ventes"].Points.AddXY(vente.Key, vente.Value);
            }
            chart1.Series["Ventes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Size = new Size(800, 800);
        }
    }
}

