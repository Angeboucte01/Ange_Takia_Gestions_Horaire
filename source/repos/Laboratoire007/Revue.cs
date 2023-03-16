using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Revue : Document
    {
        public double PrixAbonnement { get; set; }
        public int Mois { get; set; }
        public int AnneePublication { get; set; }


        public Revue( string type, int nbreDePage, string auteur,double pricAbonnement, int mois, int anneePublication) : base ( type, nbreDePage)
        {
            PrixAbonnement = pricAbonnement;
            Mois = mois;
            AnneePublication = anneePublication;
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + 
                $"Prix abonnement : {PrixAbonnement}" + "\n" + 
                $"Mois : {Mois}" + "\n" + 
                $"Annee de publication : {AnneePublication}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(obj.GetType() != typeof(Revue)) return false;
            Revue other = (Revue)obj;
            if(PrixAbonnement != other.PrixAbonnement) return false;
            return base.Equals(obj) && 
            PrixAbonnement == other.PrixAbonnement;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
