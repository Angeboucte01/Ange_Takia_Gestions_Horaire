using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre010
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
        public void AfficherPersonne()
        {
            Console.WriteLine($"{Nom} {Prenom}, {Age}");

        }

    }
}
