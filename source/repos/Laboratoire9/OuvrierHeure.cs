using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire9
{
    internal  class OuvrierHeure : Ouvrier
    {

        // definition des  attributs et proprietés
        public int NbreHeure { get; set; }
        public double PrixHeure { get; set; }
        public OuvrierHeure(string nom, string prenom, bool plageHoraire, int nbreheure, double prixHeure) : base(nom, prenom, plageHoraire)
        {
            PrixHeure = prixHeure;
            NbreHeure = nbreheure;
        }
        //Equals

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(OuvrierHeure)) return false;
            OuvrierHeure other = (OuvrierHeure)obj;
            return base.Equals(obj) &&
            PrixHeure == other.PrixHeure
                      &&
            NbreHeure == other.NbreHeure;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override double CalculerSalaire()
        {
            double result = 0;
            if (PrixHeure != 0)
                result = PrixHeure * NbreHeure;
            return result;
        }
    }
}
