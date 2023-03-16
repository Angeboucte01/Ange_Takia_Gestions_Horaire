using System;
using System.Collections.Generic;



namespace ExerciceDictionnaire2._2
{
    class Program
    {
        public static void EnsembleVersTableau(SortedSet<int> EnsOrd1, int[] TAB, int N)
        {
            int i = N - 1;



            foreach (int valeur in EnsOrd1)
            {
                TAB[i] = valeur;
                i--;
            }



        }



        public static void RemplirDictionnaire(Dictionary<int, string> C, SortedSet<string> EnsOrd2, int[] TAB, int N)
        {
            int i = 0;



            foreach (var valeur in EnsOrd2)
            {
                C.Add(TAB[i], valeur);
                i++;
            }
        }



        public static void RechercherDictionnaire(Dictionary<int, string> C)
        {
            int code;

            Console.WriteLine(" Donnel le code de la matière à afficher");
            code = int.Parse(Console.ReadLine());
            if (C.ContainsKey(code))
            {
                Console.WriteLine(" La matière recherchée est " + C[code]);



            }
            else
            {
                Console.WriteLine(" La matière recherchée n'existe pas");



            }



        }



        public static void Afficher_Dictionnaire(Dictionary<int, string> D)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" |  Code   | Cours  ");
            Console.WriteLine("----------------------------");
            foreach (KeyValuePair<int, string> valeur in D)
            {



                Console.WriteLine(" |   " + valeur.Key + "  |  " + valeur.Value);
            }
        }



        static void Main(string[] args)
        {
            const int n = 6;
            int[] T = new int[n];



            HashSet<int> E1 = new HashSet<int>() { 1005, 2133, 1101, 5302, 8104, 5016 };
            HashSet<string> E2 = new HashSet<string>() { "Structures des données", "Mathématiques", "Programmation Web", "Multimédia et infographie", "Réseaux et télématiques", "Gestion des bases de données " };



            SortedSet<int> EE1 = new SortedSet<int>(E1); // Déclaration de l'ensemble ordonnée EE1 et le remplir à partir de l'ensemble E1 non ordonné
            SortedSet<string> EE2 = new SortedSet<string>(E2); // Déclaration de l'ensemble ordonnée EE2 et le remplir à partir de l'ensemble E2 non ordonné




            Dictionary<int, string> cours = new Dictionary<int, string>();



            EnsembleVersTableau(EE1, T, n);
            RemplirDictionnaire(cours, EE2, T, n);
            Afficher_Dictionnaire(cours);
            RechercherDictionnaire(cours);
        }
    }
}