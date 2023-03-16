using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre010
{
    internal class Enseignant : Personne
    {
        //un enseignant est caractérisé par son nom, prenom et salaire
        public double Salaire { get; set; }

        public Enseignant(string nom, string prenom, double salaire) : base(nom, prenom)
        {
            Salaire = salaire;
        }


        //// Définir un construicteur qui initialise tout les attributs

        public Enseignant(string nom, string prenom, double salaire, int age) : base(nom, prenom,  salaire)
        {
            Age = age;
        }

    }

}
