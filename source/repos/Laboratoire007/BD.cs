using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class BD : Livre
    {
        //Definition des proprietes et initialisation
        public bool Couleur { get; set; }

        public BD(string type, int nbreDePage, string auteur, bool couleur) : base(type, nbreDePage, auteur)
        {
            Couleur = couleur;
        }

        //Redefintition de la methode ToString 

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Couleur : {Couleur}";
        }

        //Redefiniton de la methode equals

        public override bool Equals(object obj)
        {
            //On teste si l'objet est null
            if(obj == null) return false;
            if(obj.GetType() != typeof(BD)) return false;
            BD other = (BD)obj;
            if(Couleur != other.Couleur) return false;
             return base.Equals(obj) && 
            Couleur == other.Couleur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
