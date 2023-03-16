using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensemble2._1
{
    internal class program
    {

        static bool ExisteDansEnsemble(HashSet<int> E, int val)
        {



            return E.Contains(val);
            
        }
        static void AjouterElementEnsemble(HashSet<int> E)
        {
            int val;
            Console.WriteLine("Donner l'element à ajouter");
            val = int.Parse(Console.ReadLine());
            if(ExisteDansEnsemble(E,val) == true)
            {
                Console.WriteLine("La valeur saisie existe déja dans l'ensemble");
            }
            else
            {
                E.Add(val);
                Console.WriteLine("La valeur à été ajout, avec succes");
            }


        }
        static void RetirerElementEnsemble(HashSet<int> E)
        {
            int val;
            Console.WriteLine("Donner l'element à retirer");
            val = int.Parse(Console.ReadLine());
            if (ExisteDansEnsemble(E, val) == true)
            {
                E.Remove(val);
                Console.WriteLine("La valeur saisie à ete retiré dans l'ensemble");
            }
            else
            {
               
                Console.WriteLine("La valeur saisie n'existe pas");
            }


        }

        static void UnionEnsemble(HashSet<int>E1, HashSet<int> E2)
        {
            Console.WriteLine("-------Union-----");
            E1.UnionWith(E2);
            AfficherEnsemble(E1);
        }
        static void IntersectionEnsemble(HashSet<int> E1, HashSet<int> E2)
        {
            Console.WriteLine("-------Intersection-----");
            E1.Intersect(E2);
            AfficherEnsemble(E1);
        }

        static void AfficherEnsemble(HashSet<int> E)
        {
            Console.Write(" { ");
            foreach(var valeur in E)
            {
                Console.Write(" , " +valeur);
            }

            Console.WriteLine(" } ");

        }


        static void Main(string[] args)
        {
            const int N = 12, M = 6; 
            int[] TAB1 = new int[N] { 7, 8, 6, 3, 2, 3, 2, 1, 9, 4, 1, 1 };
            int[] TAB2 = new int[M] { 7, 8, 6, 3, 2, 3 };



            HashSet<int> Ensemble1 = new HashSet<int>(TAB1);
            HashSet<int> Ensemble2 = new HashSet<int>(TAB2);


            // Console.WriteLine("Le nombre d'elements de l'ensemble est : " +Ensemble1.Count);
            AfficherEnsemble(Ensemble1);
           // AjouterElementEnsemble(Ensemble1);
            RetirerElementEnsemble(Ensemble1);
            AfficherEnsemble(Ensemble1);
            UnionEnsemble(Ensemble1, Ensemble2);



        }
    }
}
