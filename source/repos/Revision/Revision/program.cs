using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{ // Exercice1 ENUMERATION
    internal class program
    {//Type utiliateur

         public  enum Ensemble {}

        static void Ajouter(HashSet<Ensemble> Nbre)
        {
            /* int valeur=0;
            do
            { 
                Console.WriteLine("Donner le nombre à ajouter dans l'ensemble");
                valeur = int.Parse(Console.ReadLine());
                
                
            }
            while(Nbre.Count <= 5 && valeur <= 20 && valeur <= 60);

            Nbre.Add((Ensemble)valeur);
            Console.WriteLine("L'article a ete ajouter avec succes");*/


            int val;int ind;

            do
            {
                Console.WriteLine("Donner la valeur a ajouter");
                val = int.Parse(Console.ReadLine());

            }
            while (val <= 20 && val <= 60 && Nbre.Count >=5);
            Nbre.Add((Ensemble)val);
        }
        

        static void Afficher(HashSet<Ensemble> Nbre)
        {

            Console.WriteLine("{   ");
            foreach (var valeur in Nbre)
            {
                Console.WriteLine("   "+ valeur);
            }
            Console.WriteLine("   }");

        }


        static void Main(string[] args)
        {
            HashSet<Ensemble> paire = new HashSet<Ensemble>();
            HashSet<Ensemble> impaire = new HashSet<Ensemble>();

            Ajouter(paire);
            Afficher(paire);

        }





    }
}
