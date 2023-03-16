using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChap10
{
    internal class Etudiant : Personne
    {
        //un étudiant est caractérisé par son nom, prenom et sa matricule

        public int Matricule { get; set; }

        //Créer un constructeur dans la classe Etudiant
        public Etudiant(string nom, string prenom, int matricule) : base(nom, prenom)
        {
            this.Matricule = matricule;
        }

        public Etudiant(string nom, string prenom) : this(nom, prenom, 0)
        { }
        /*
         * 
        public Etudiant(string nom, string prenom) : base(nom, prenom)
        {
            this.Matricule = 123456;
        }
         * 
         */


        // Définir un constructeur qui initialise tout les attributs
        public Etudiant(string nom, string prenom, int age, int matricule) :
            base(nom, prenom, age)
        {
            this.Matricule = matricule;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Matricule : {Matricule}");
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Matricule : {Matricule}";
        }
    }
}
