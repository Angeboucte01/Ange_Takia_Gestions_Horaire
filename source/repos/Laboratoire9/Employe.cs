using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire9
{
    internal  abstract class Employe
    {
        //Declarations des attributs et proprietés
         public static int nbreEmploye = 0;
         public string Nom { get; set; }
         public string Prenom { get; set; }
         public int Code { get; private set; }

        //Declaration du constructeur
        public Employe( string nom,string prenom)
        {
            Nom = nom; 
            Prenom = prenom;
            Code = ++nbreEmploye; 
        }
        //Redefintion de la methode TOSTRING
        public override string ToString()
        {
            return $"Nom : {Nom}" + "\n" +
                    $"Prenom :{Prenom}" + "\n" +
                    $"Code : {nbreEmploye}"; 
        }

        //Redefintion de la methode EQUALS

        public override bool Equals(object? obj)
        { 
            if (obj == null)  return false;
            if(obj.GetType() != typeof(Employe)) return false;
            Employe other = (Employe)obj;
            return Nom.Equals(other.Nom) && Prenom.Equals(other.Prenom);

        }

        public abstract double CalculerSalaire();
    }
}
