using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChap10
{
    internal class Personne
    {
        //Une personne est caractérisée par son nom, son prenom et son age
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        //public Personne() { }
        //Un constructeur qui initialise le nom et le prenom
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        // Définir un construicteur qui initialise tout les attributs
        public Personne(string nom, string prenom, int age) : this(nom, prenom)
        {
            Age = age;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"{Nom} {Prenom}, {Age}");
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom}, {Age}";

        }

        public override bool Equals(object obj)     //this avec obj
        {
            //1. comparer obj avec null
            if (obj == null) return false;
            //2. tester si obj est une Personne 
            if (obj.GetType() != typeof(Personne)) return false; //obj is not Personne
            //3. conversion de obj vers une personne
            Personne personne = (Personne)obj;      //CAST (as)
            //4. Implementer le critere de comparaison
            return this.Nom == personne.Nom && this.Prenom == personne.Prenom && this.Age == personne.Age;
        }
    }
}
