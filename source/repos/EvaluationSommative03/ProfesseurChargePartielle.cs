using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative03
{
    internal sealed class ProfesseurChargePartielle : Professeur
    {
        //- Définir les attributs 
        public int NbreHeureSem { get; set; }
        private double prixHeure;

        //et les propriétés
        public  double PrixHeure { get { return prixHeure; }
            set 
            {   if(value == 3 || value == 6)
                prixHeure = value;
            } 
        }


        //- Définir un constructeur initialisant tous les attributs
        public ProfesseurChargePartielle(string nom, string prenom, string telephone, int nbreHeureSem, double prixHeure) : base(nom, prenom, telephone)
        {

            NbreHeureSem = nbreHeureSem;
            PrixHeure = prixHeure;
        }
        //Redéfinir la méthode CalculerSalaire
        public override double CalculerSalaire()
        {
            return (NbreHeureSem*4) * PrixHeure;
        }
        //Redéfinir la méthode Equals.

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(ProfesseurChargePartielle)) return false;
            ProfesseurChargePartielle professeurChargePartielle = (ProfesseurChargePartielle)obj;
            return base.Equals(obj) 
                 && NbreHeureSem== professeurChargePartielle.NbreHeureSem
                 && PrixHeure == professeurChargePartielle.PrixHeure;
        }
        //Redéfinir la méthode Tostring
        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Nombre heure par semaine :{NbreHeureSem}" + "\n" +
                $"Prix Heure : {PrixHeure}";
        }

        //Redéfinir la méthode GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
