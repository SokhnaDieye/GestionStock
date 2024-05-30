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

namespace ProjetGestionStock
{
    public partial class frmCategorie : Form
    {
        StockEntities db=new StockEntities();
        public frmCategorie()
        {
            InitializeComponent();
        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.Categorie.ToList();
        }
        private void resetForm()
        {
            txtLibelle.Text=string.Empty;
            txtCode.Text=string.Empty;
            dgCategorie.DataSource=db.Categorie.ToList();
            txtCode.Focus();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie c=new Categorie();
            c.CodeCategorie=txtCode.Text;
            c.LibelleCode=txtLibelle.Text;
            db.Categorie.Add(c);
            db.SaveChanges();
            resetForm();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie c = db.Categorie.Find(id);
            c.CodeCategorie = txtCode.Text;
            c.LibelleCode = txtLibelle.Text;
            db.SaveChanges();
            resetForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            txtLibelle.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie c = db.Categorie.Find(id);
            db.Categorie.Remove(c);
            db.SaveChanges();
            resetForm();
        }
    }
}
