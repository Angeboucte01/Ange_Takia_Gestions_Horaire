using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Roman : Livre
    {
     public string PrixUnitaire { get; set; }
        public Roman(string type, int nbreDePage, string auteur, string prixUnitaire) : base(type, nbreDePage, auteur)
        {
            PrixUnitaire = prixUnitaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Prix unitaire :{PrixUnitaire}";
        }

        public override bool Equals(object obj)
        {
             if (obj == null) return false;
             if(obj.GetType() != GetType()) return false;
             if (!(obj is Roman)) return false;
             Roman roman = (Roman)obj;
             return base.Equals(obj) && 
             PrixUnitaire == roman.PrixUnitaire; ;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
