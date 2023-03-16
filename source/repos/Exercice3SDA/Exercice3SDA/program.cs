using System;
using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;


namespace Exercice3SDA
{
    internal class program
    {



        

        

        class Program
        {
            // Cette méthode permet de trier l'ensemble 1 et de l'unir avec L'ensemble 1 trié.

            static void Trier_Ensemble1(HashSet<int> E1, SortedSet<int> E2)
            {
                E2.UnionWith(E1);
            }
            // Cette méthode permet de trier l'ensemble 2 et de l'unir avec L'ensemble 2    trié.

            static void Trier_Ensemble2(HashSet<string> E1, SortedSet<string> E2)
            {
                E2.UnionWith(E1);
            }
            // Cette méthode permet de verser l'ensemble 1 trié dans un tableau T1 (On verse dans un ordre décroissant).

            static void Verser_Ensemble_Tableau1(SortedSet<int> E, int[] T, int n)
            {
                int i = n - 1;
                foreach (int valeur in E)
                {
                    T[i] = valeur;
                    i--;
                }
            }
            // Cette méthode permet de verser l'ensemble 2 trié dans un tableau T2.
            static void Verser_Ensemble_Tableau2(SortedSet<string> E, string[] T)
            {
                int i = 0;
                foreach (string valeur in E)
                {
                    T[i] = valeur;
                    i++;
                }
            }
            // Cette méthode permet de rechercher une marque dans le dictionnaire en utilisant la clé. 

            static void Rechercher_Dictionnaire(Dictionary<int, string> D)
            {
                int code;
                string marq;
                Console.WriteLine(" Donner le code de la marque à rechercher ");
                code = int.Parse(Console.ReadLine());
                if (D.ContainsKey(code))
                {
                    marq = D[code];
                    Console.WriteLine(" La marque recherchée est : " + marq);
                }
                else
                {
                    Console.WriteLine(" Le code " + code + " N'existe pas dans le dictionnaire");
                }
            }
            // Cette méthode permet de remplir le dictionnaire à partir des tableaux T1 et T2 triés.
            static void Remplir_Dictionnaire(Dictionary<int, string> D, HashSet<int>E11, SortedSet<int> E12, HashSet<string> E21, SortedSet<string> E22)
            {
                int i, n = 5;
                int[] T1 = new int[n];
                string[] T2 = new string[n];
                Trier_Ensemble1(E11, E12);
                Verser_Ensemble_Tableau1(E12, T1, n);
                Trier_Ensemble2(E21, E22);
                Verser_Ensemble_Tableau2(E22, T2);
                for (i = 0; i < n; i++)
                {
                    D.Add(T1[i], T2[i]);
                }
            }
            static void Affiche_Dictionnaire(Dictionary<int, string> D)
            {
                Console.WriteLine("--- DICTIONNAIRE ---");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine(" | Code | " + " Marque");
                Console.WriteLine("------------------------------------------------");
                foreach (KeyValuePair<int, string> valeur in D)
                {
                    Console.WriteLine(" | " + valeur.Key + " | " + valeur.Value +
                    " ");
                }
                Console.WriteLine("------------------------------------------------");
            }
            static void Main(string[] args)
            {
                HashSet<int> Ensemble1 = new HashSet<int>() { 300,250,200,150,100};
                HashSet<string> Ensemble2 = new HashSet<string>() { "Ford", "GMC", "BMW", "Audi", "Chevrolet" };


                SortedSet<int> Ens_Ordre1 = new SortedSet<int>();
                SortedSet<string> Ens_Ordre2 = new SortedSet<string>();
                Dictionary<int, string> Dictionnaire = new Dictionary<int, string>();

                Remplir_Dictionnaire(Dictionnaire, Ensemble1, Ens_Ordre1, Ensemble2,Ens_Ordre2);
                Affiche_Dictionnaire(Dictionnaire);
                Rechercher_Dictionnaire(Dictionnaire);
            }
        }




    }

}
