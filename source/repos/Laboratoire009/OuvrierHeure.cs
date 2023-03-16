using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal sealed class OuvrierHeure : Ouvrier
    {   public int NbreHeure { get; set; }
        public double PrixHeure { get; set; }
        public OuvrierHeure(string nom, string prenom, bool pH, int nbrH, double prixH) : base(nom, prenom, pH)
        {
            NbreHeure = nbrH;
            PrixHeure = prixH;
        }

        public override double CalculerSalaire()
        {
            return PrixHeure * NbreHeure; 
        }


        public override bool Equals(object? obj)
        {   
            if (obj == null) return false;
            if(obj.GetType() != typeof(OuvrierHeure)) return false;
            OuvrierHeure other = (OuvrierHeure)obj;

            return base.Equals(obj) && NbreHeure == other.NbreHeure 
                                    && PrixHeure == other.PrixHeure; 
        }

        public override string ToString()
        {
            return base.ToString() +"\n"+
                $"Nombre d'heure : {NbreHeure}" + "\n" +
                $"Prix d'heure : {PrixHeure}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
