using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetGestionStock.model;
using ProjetGestionStock.Utils;

namespace ProjetGestionStock
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }
        StockEntities db=new StockEntities();
        LoadComboBox load=new LoadComboBox();
        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new {x.idUt,x.IdentifiantUt,x.CodeProfil}).ToList();
            cbbProfil.DataSource = load.loadProfi();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember= "Value";
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash=MD5.Create())
            {
                Utilisateur ut =new Utilisateur();
                ut.IdentifiantUt = txtIdentifiant.Text;
                ut.MotDePasse = Crypts.GetMd5Hash(md5Hash, "passer123");
                ut.CodeProfil = cbbProfil.SelectedValue.ToString();
                db.Utilisateur.Add(ut);
                db.SaveChanges();
                resetForm();
            }
        }
        private void resetForm()
        {
            txtIdentifiant.Text = string.Empty;
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new { x.idUt, x.IdentifiantUt, x.CodeProfil }).ToList();
            cbbProfil.DataSource = load.loadProfi();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember = "Value";
            txtIdentifiant.Focus();
        }
    }
}
