using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    /// <summary>
    /// Classe qui declare les attributs de la disponibilité d'un employé
    /// </summary>
    public class Disponibilite
    {
        // Attributs
        private string jour;
        private DateTime heure_debut;
        private DateTime heure_fin;

        // Constructeur
        // Constructeur
        /// <summary>
        /// Initialise une nouvelle instance de la classe Disponibilite avec le jour, l'heure de début et l'heure de fin spécifiés.
        /// </summary>
        /// <param name="j">Le jour de la disponibilité.</param>
        /// <param name="hd">L'heure de début de la disponibilité.</param>
        /// <param name="hf">L'heure de fin de la disponibilité.</param>
        public Disponibilite(string j, DateTime hd, DateTime hf)
        {
            jour = j;
            heure_debut = hd;
            heure_fin = hf;
        }

        /// <summary>
        /// Obtient le jour de la disponibilité.
        /// </summary>
        public string Jour
        {
            get { return jour; }
        }

        /// <summary>
        /// Obtient l'heure de début de la disponibilité.
        /// </summary>
        public DateTime HeureDebut
        {
            get { return heure_debut; }
        }

        /// <summary>
        /// Obtient l'heure de fin de la disponibilité.
        /// </summary>
        public DateTime HeureFin
        {
            get { return heure_fin; }
        }

        // Méthodes
        /// <summary>
        /// Obtient le jour de la disponibilité.
        /// </summary>
        public string GetJour()
        {
            return jour;
        }

        /// <summary>
        /// Obtient l'heure de début de la disponibilité.
        /// </summary>
        public DateTime GetHeureDebut()
        {
            return heure_debut;
        }

        /// <summary>
        /// Obtient l'heure de fin de la disponibilité.
        /// </summary>
        public DateTime GetHeureFin()
        {
            return heure_fin;
        }
    }


}
