using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau2D
{
    internal class tableau2d
    {
        static void RemplirTableau(int [,] TAB, int n, int m)
        {
            int i,j;
            Random r = new Random();
            for (j = 0; j < n; j++)
            {
                for(i = 0; i < m; i++)
                {
                    TAB[i,j] = r.Next(10,200);
                }

            }
        }

        static void AfficherTableau(int[,] TAB, int n, int m)
        {
            int i, j;
            for (j = 0; j < n; j++)
            {
                for (i = 0; i< m; i++)
                {
                    Console.Write("|"  +TAB[i,j]);
                }
                Console.WriteLine(" ");

            }

        }

        /// <summary>
        /// Declaration de la methode main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 5, m = 5;
            int[,] TAB = new int[n, m];
            //Methode permetant de remplir le tableau
            RemplirTableau(TAB, n, m);
            //Method permetant d'afficher le tableau
            AfficherTableau(TAB, n, m);
        }

    }
}
