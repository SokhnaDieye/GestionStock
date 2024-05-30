using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionStock.model
{
    public class RapportListeVente
    {

        public string CodeProduitV { get; set; }
        public string DesignationProduitV { get; set; }
        public double PuProduitV { get; set; }
        public int Quantite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string AdresseEmail { get; set; }
        public double Prix { get; set; }
    }
}
