using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal abstract class Employe
    {
        //Definition des attributs et proprietés

        public int nbre = 0;
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public static int Code { get;  set; }    


        public Employe(string nom, string prenom) 
        { 
            Nom = nom;
            Prenom = prenom;
            Code = ++ nbre;
        }

        //La methode Calculer salaire est abstraire car on a ps une implementation 

        public abstract double CalculerSalaire();



        public override string ToString()
        {
            return $"Nom : {Nom}" + "\n" +
                   $"Prenom : {Prenom}" + "\n" +
                   $"Code : {nbre}"; 
        }


        public override bool Equals(object? obj)
        {

            if (obj == null) return false;
            if(obj.GetType() != GetType()) return false;
            Employe other = obj as Employe;
            return Nom == other.Nom && Prenom == other.Prenom;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
