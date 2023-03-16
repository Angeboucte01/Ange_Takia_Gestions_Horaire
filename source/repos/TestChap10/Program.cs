using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChap10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Personne p = new Personne();    //Constructeur par défaut
            p.Nom = "Yogwa";
            p.Prenom = "Godlive";


            Etudiant et1 = new Etudiant(); //Constructeur par défaut
            et1.Nom = "Ouadah";
            et1.Prenom = "Zahia";
            et1.Matricule = 1234656;


            Enseignant es1 = new Enseignant();
            es1.Nom = "Bouhlel";
            es1.Prenom = "Mohamed";
            es1.Salaire = 2000;
            */

            Personne p1 = new Personne("Yogwa", "Godlive", 20);
            Personne p2 = new Personne("Yogwa", "Godlive", 20);
            Personne p3 = p1;

            Console.WriteLine(p1.Equals(p2));//false------true
            Console.WriteLine(p2 == p1);//false

            Console.WriteLine(p1.Equals(p3));//true
            Console.WriteLine(p3 == p1);//true

            // p1.Afficher();
            Etudiant et1 = new Etudiant("Ouadah", "Zahia", 21, 1234656);
            // et1.Afficher();
            Enseignant en1 = new Enseignant("Bouhlel", "Mohamed", 40, 2000);
            // en1.Afficher();

            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1);

            //Personne p2 = new Etudiant("Ouadah", "Zahia", 21, 1234656);
            //Console.WriteLine(p2);
            //Personne p3 = new Enseignant("Bouhlel", "Mohamed", 40, 2000);
            //Console.WriteLine(p3);
            /*p1.Afficher();
            Console.WriteLine("***********************************");
            p2.Afficher();
           
            Console.WriteLine("***********************************");
            p3.Afficher();*/
        }
    }
}
