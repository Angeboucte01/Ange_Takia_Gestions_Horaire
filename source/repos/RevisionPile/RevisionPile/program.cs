using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPile
{
    internal class program
    {

        //static void Inserer(Stack<string> Resultat, string[] Marque)
        //{
        //    foreach (var item in Marque)
        //    {
        //        Resultat.Push(item);
        //    }
        //}

        //static void pileTrier(Stack<string> Resultat, SortedSet<string> strings)
        //{

        //    strings.UnionWith(Resultat);

        //    foreach (string item in Resultat)
        //    {
        //        Console.WriteLine(" " + item);
        //    }

        //}

        static void Afficher(Stack<string> Resultat)
        {
            foreach (string item in Resultat)
            {
                Console.WriteLine(" " + item.);
            }
           
        }
        static void Main(string[] args)
        {
            string[] Marque = new string[] { "Ford", "GMC", "Honda", "BMW", "Mercedes", "Audi", "Chevrolet", "Jeep" };
            Stack<string> Resultat = new Stack<string>(Marque);
            SortedSet<string> strings = new SortedSet<string>();


            //Inserer(Resultat, Marque);
            Afficher(Resultat);
            
            //pileTrier(Resultat,strings);

        }
    }
}
