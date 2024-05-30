using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetGestionStock.model;

namespace ProjetGestionStock.Utils
{
    internal class LoadComboBox
    {
        StockEntities db = new StockEntities();

        public List<ListSelectedViewModel> loadCategorie()
        {
            List<ListSelectedViewModel> laListe = new List<ListSelectedViewModel>();
            laListe.Add(new ListSelectedViewModel { 
                Value=null,
                Text="Selectionner........"
            });
            var liste=db.Categorie.ToList();
            foreach (var c in liste)
            {
                laListe.Add(new ListSelectedViewModel
                {
                    Value = c.CodeCategorie,
                    Text = c.LibelleCode,
                });

            }
            return laListe;
        }
        public List<ListSelectedViewModel> loadProfi()
        {
            List<ListSelectedViewModel> laListe = new List<ListSelectedViewModel>();
            laListe.Add(new ListSelectedViewModel
            {
                Value = null,
                Text = "Selectionner........"
            });
            var liste = db.Profil.ToList();
            foreach (var c in liste)
            {
                laListe.Add(new ListSelectedViewModel
                {
                    Value = c.CodeProfil,
                    Text = c.LibelleProfil,
                });

            }
            return laListe;
        }


    }
}
