using System;

namespace StructureDeDonneesAppliquees
{
    internal class program
    {
        static void Remplir_Tableau(int n, int[] TAB)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" Donner la valeur " + i);
                TAB[i] = int.Parse(Console.ReadLine());
            }
        }







        static int Somme_Tableau(int n, int[] TAB)
        {
            int i, somme = 0;
            for (i = 0; i < n; i++)
            {
                somme += TAB[i]; //somme=somme+TAB[i];
            }



            return somme;
        }



        static int Maximum_Tableau(int n, int[] TAB)
        {
            int i, max = TAB[0];



            for (i = 1; i < n; i++)
            {
                if (TAB[i] > max)
                {
                    max = TAB[i];
                }
            }
            return max;
        }



        static int Minimum_Tableau(int n, int[] TAB)
        {
            int i, min = TAB[0];



            for (i = 1; i < n; i++)
            {
                if (TAB[i] < min)
                {
                    min = TAB[i];
                }
            }
            return min;
        }



        //static int Minimum_Tableau(int n, int[] TAB)


        static void position_valeur(int n, int[] TAB)
        {
            int i, val;

            for(i = 0; i < n; i++)
            {
                if(TAB[i] < val)    
                //val = TAB[i];
            }



        }
  



        static void Afficher_Tableau(int n, int[] TAB)
        {
            //int i;
            for (int i = 0; i < n; i++)
            {
                Console.Write(" | " + TAB[i]);
            }
            Console.WriteLine(" | ");
        }




        static void afficherTableau(int[] tableau)
        {
            foreach (var valeur in tableau)
            {
                Console.Write(valeur + " | ");
            }
        }




        static void Main(string[] args)
        {
            int N = 5;
            int[] T1 = new int[N];
            int[] T2 = new int[5] { 12, 6, 4, 8, 9 };



            /*Remplir_Tableau(N, T1);
             Console.WriteLine(" Tableau 1 ");
             Afficher_Tableau(N, T1);*/



            Console.WriteLine("  ");
            Console.WriteLine(" Tableau 2 ");
            //Afficher_Tableau(N, T2);
            afficherTableau(T2);



            Console.WriteLine("Somme du tableau " + Somme_Tableau(N, T2));
            Console.WriteLine("Le maximum du tableau " + Maximum_Tableau(N, T2));
            Console.WriteLine("Le minimum du tableau " + Minimum_Tableau(N, T2));



        }
    }
}
   
