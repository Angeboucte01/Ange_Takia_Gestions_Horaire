using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1SDA
{
    public class program
    {
        public static int[] TAB = new int[15];
        public static int[] PremiereSeparation = new int[15];
        public static int[] DeuxiemeSeparation = new int[15];
        public static int i;
        public static int j = 0, k = 0;

        /// <summary>
        /// Methode permettant d'ajouter des elements dans notre tableau 
        /// </summary>
        public static void AjouterElementTableau()
        {
            Console.Write("-----------------------------------------\n");

            for (i = 0; i < 15; i++)
            {
                    Console.Write(" Inserer l'element à indice  {0}  dans tableau : ", i);
                TAB[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        /// <summary>
        /// Methode permettant d'afficher les elements
        /// </summary>
        public static void Affichage()
        {
            Console.Write("\nListe des elements du tableau ");
            for (i = 0; i < 15; i++)
            {
                Console.Write("{0}  ", "|" + TAB[i] + "|");
            }
        }
        /// <summary>
        /// Methode permetant de separer les entiers paires et impaires
        /// </summary>
        public static void Separer_Paire(int[] PremiereSeparation)
        {
            Console.WriteLine("Les valeurs paires sont:");
            for (i = 0; i < PremiereSeparation.Length; i++)
            {
                if (TAB[i] % 2 == 0)
                {
                    Console.WriteLine(PremiereSeparation[i] + "|");
                }
            }
        }


        public static void Separer_Impaire(int [] DeuxièmeSeparation)
        {
            Console.WriteLine("Les valeurs impaires sont:");
            for (i = 0; i < PremiereSeparation.Length; i++)
            {
                if (TAB[i] % 2 != 0)
                {
                    Console.WriteLine(DeuxièmeSeparation[i] + "|");
                }
            }
        }
        /// <summary>
        /// Methode permettant de crier les nombres paires et impaires
        /// </summary>
        public static void TrierTableau()
        {   Array.Sort(TAB);
            Array.Sort(PremiereSeparation);
            Array.Sort(DeuxiemeSeparation);
        }

        
        /// <summary>
        /// Methode permettant de savoir si les tableaux sont trier ou pas
        /// </summary>
        /// <param name="TAB"></param>
        /// <returns></returns>
        public static bool IsSorted(int[] TAB)
        {
            for (int i = 1; i < TAB.Length; i++)
            {
                if (TAB[i - 1] > TAB[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            AjouterElementTableau();
            Separer_Paire(PremiereSeparation);
            Separer_Impaire(DeuxiemeSeparation);
            TrierTableau();
            Affichage();

            if (IsSorted(TAB) == true)
            {
                Console.Write("\nLe tableau à ete trier \n");
            }
            else
            {
                Console.Write("\nLe tableau n'a pas ete trier \n");
            }


        }
    }
}
