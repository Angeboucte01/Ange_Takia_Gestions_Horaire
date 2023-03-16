using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative03
{
    internal abstract class Professeur
    {
        //Définition les attributs et les propriétés. (Attention aux contraintes)

        //un code quis’incrémente d’une façon automatique à chaque création
        public  int Code { get; private set; }
        public static int nbre = 0;
        //un nom(string),
        public string Nom { get; set; }
        //un prénom(string) 
        public string Prenom { get; set; }
        //numéro de téléphone composé de 10 chiffres
        private string telephone;

        public string Telephone
        {
            get { return telephone ; }
            set
            {
                if(value.Length.Equals(10))
                    telephone = value;
                else
                    Console.WriteLine("Mauvaise valueur du numero saisi saisie");
                
            }
        }

        //Définir un constructeur initialisant tous les attributs
        public Professeur(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Code = ++nbre;
        }

        //Pourquoi la méthode CalculerSalaire est abstraite ?
        /*La methode CalculerSalaire est abstraite car on ne calacul  pas le salaire des professeurs de la meme facon */

        public abstract double CalculerSalaire();


        //- Redéfinir la méthode Equals.

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Professeur)) return false;
            Professeur professeur = (Professeur)obj;
            return
                Nom == professeur.Nom
                    &&
                    Prenom == professeur.Prenom
                    && Telephone == professeur.Telephone
                    && Code == professeur.Code;
        }
        //Redéfinir la méthode ToString
        public override string ToString()
        {
            return
                $"Nom :{Nom}" + "\n" +
                $"Prenom :{Prenom}" + "\n" +
                $"Telephone : {Telephone}" + "\n" +
                $"Code :{Code}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
