using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{           // Un livre est un document donc y'a heritage
    internal class Livre : Document
    {
        public string Auteur { get; set; }
        // Creation du constructeur
        public Livre( string type, int nbreDePage, string auteur) : base(type, nbreDePage)
        {
            Auteur = auteur;
        }
        // Redefiniton de la methode ToString

        public override string ToString()
        {
            return base.ToString() + "\n" +
                        $"Auteur :  {Auteur}";
        }


        public override bool Equals(object obj)
        {
           //On test si l'objet est null
           if(obj == null) return false;
           if(obj.GetType() != typeof(Livre)) return false;
           //Convertion du livre en un objet
           
           Livre autre = (Livre)obj;
           return base.Equals(obj) &&
                Auteur == autre.Auteur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
