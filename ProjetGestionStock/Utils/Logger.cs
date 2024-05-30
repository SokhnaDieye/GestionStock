using ProjetGestionStock.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetGestionStock.model;
namespace ProjetGestionStock.Utils
{
    public class Logger
    {
        StockEntities db =new StockEntities();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TitreErreur"></param>
        /// <param name="erreur"></param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DtaErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 1000 ? erreur.Substring(0, 1000) : erreur;
                log.TitreErreur = TitreErreur;
                db.Td_Erreur.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="erreur"></param>
        /// <param name="libelle"></param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "App Gestion Stock";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }

}
