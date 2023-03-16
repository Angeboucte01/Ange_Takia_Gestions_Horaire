using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Manuel : Livre
    {
        public int NiveauScolaire;
        public Manuel(string type, int nbreDePage, string auteur, int niveauScolaire) : base(type, nbreDePage, auteur)
        {
            NiveauScolaire = niveauScolaire;
        }



        public override string ToString()
        {
            return base.ToString() + "\n"+ 
                $"Niveau scolaire : {NiveauScolaire}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(obj.GetType() != typeof(Manuel)) return false;
            Manuel manuel = (Manuel)obj;
            return base.Equals(obj) && 
            NiveauScolaire == manuel.NiveauScolaire;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
