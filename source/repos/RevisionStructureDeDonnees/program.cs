using System;


namespace RevisionStructureDeDonnees
{
    internal class program
    {
        //Ecrire un algorithme qui lit la dimension N d'un tableau T du type entier
        //Creation de la methode permettant de remplir le tableau
        static void RemplirTableau(int n, int[] TAB)
        {
            int indice;
            for (indice = 0; indice < n; indice++)
            {
                Console.WriteLine("Donner la valeur" + indice);
                TAB[indice] = int.Parse(Console.ReadLine());
            }
        }
        //Affichage du tableau
        static void AfficherTableau(int n, int[] TAB)
        {
            int indice;
            for (indice = 0; indice < n; indice++)
            {
                Console.Write(" | " + TAB[indice]);
            }
            Console.WriteLine(" | ");
        }
        // Calcul de la somme des elements d'un tableau
        static int SommeTableau(int n, int[] TAB)
        {
            int i;
            int somme = 0;

            for (i = 0; i < n; i++)
            {
                somme += TAB[i];
            }
            return somme;
        }

        static int MaximunTableau(int n, int[] TAB)
        {
            int i;
            int maximun = 0;

            for (i = 0; i < n; i++)
            {
                if (TAB[i] > maximun)
                {

                    maximun = TAB[i];
                }
            }
            return maximun;

        }

        static int MinimumTableau(int n, int[] TAB)
        {
            int i = 0;
            int minimum = 0;
            /*for(i = 0; i < n; i++)
            {
                if(TAB[i] < minimum)
                {
                    minimum = TAB[i];
                }
            }*/

           foreach( int j in TAB)
            {
                if (TAB[j] < minimum) 
                { 
                    minimum = TAB[j]; 
                }
            }

            return minimum;
        }



        static void Main(string[] args)
        {
            int N = 5;
            int[] T1 = new int[N];
            int[] T2 = new int[5] { 2, 3, 4, 5, 8 };


            /* RemplirTableau(N, T1);
             Console.WriteLine(" Tableau1 ");
             AfficherTableau(N,T1);*/

            Console.WriteLine("   ");
            Console.WriteLine(" Tableau2 ");
            AfficherTableau(N, T2);
            Console.WriteLine("La somme du tableau est " + SommeTableau(N, T2));
            Console.WriteLine("Le maximum du tableau est " +MaximunTableau(N, T2));
            Console.WriteLine("Le minimun du tableau est " + MinimumTableau(N, T2));

        }

    }
}
