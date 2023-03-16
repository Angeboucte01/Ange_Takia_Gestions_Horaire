using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Dictionnaire : Document
    {
        //Declaration et initialisation des attibuts

        public string Langue { get; set; }

        //Constructeur initilisant tout ls attributs
        public Dictionnaire(string type, int nbreDePage,string langue) : base(type, nbreDePage)
        {
            Langue = langue;
        }
        //Redefinition de la methode ToString

        public override string ToString()
        {
            return base.ToString() +"\n" +
            $"La Langue du dictionnaire est :{Langue}";
        }

        //Redefinition de la methode equals
        public override bool Equals(object obj)
        {
            // On teste si l'objet est null
            if (obj == null) return false;
            if(obj.GetType() != typeof(Dictionnaire)) return false; 
            Dictionnaire dictionnaire = (Dictionnaire)obj;
             return base.Equals(obj) && Langue == dictionnaire.Langue;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
