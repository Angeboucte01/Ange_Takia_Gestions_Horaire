using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative1_2702318
{
    internal class EvaluationSommative1
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Jeu d'entrainement sur les operateurs d'addition, soustraction et multiplication." +
                "\n Realisé par: Boucte Ange Pascal " +
                "\n Numero d'inscription : 2702318  " +
                "\n**********************************************************************************" +
                "\n**********************************Partie 1****************************************" +
                "\n**********************************************************************************");


            string operateur = userInputOp();
            int question = numQuestion();
        
        }
        /*
         * Arguments            : Valeur minimal  et valeur maximal
         * Type de retour       : Entier
         * Description          : Genere un nombre aleatoire entre min et max
         * 
        */
        static int randomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        
        static void printMsg()
        {
            /*
        * Arguments            : Aucun
        * Type de retour       : Aucun
        * Description          : Affiche les choix d'entree 
        * 
       */
            Console.WriteLine("Tu veux t'entrainer sur quel operation ?");
            Console.WriteLine("Addition : +");
            Console.WriteLine("Soustraction : -");
            Console.WriteLine("Multiplication : *");
            Console.WriteLine("Mixte : M");
            Console.Write("Merci de faire votre choix :");
        }
      
        static string userInputOp()
        /*
    * Arguments            : Aucun
    * Type de retour       : string
    * Description          : Capture l'operateur choisi par l'utilisateur
    * 
   */
        {
            string input = "";
            bool isInputNotCorrect = true;
            int count = 0;
            // Utilisation de la boucle while car 
            while (isInputNotCorrect)
            {
                if (count > 0)
                {
                    Console.WriteLine("\n Une erreur est survenue. Verifier votre choix");
                }
                printMsg();
                input = Console.ReadLine(); //lit le message entre par l'utilisateur
                isInputNotCorrect = input != "+" && input != "-" && input != "*" && input != "M";
                count++;
            }
            return input;
        }
        static int numQuestion()
           /*
            * Arguments            : Aucun 
            * Type de retour       : int
            * Description          : Nombres de questionaires que l'utilisateur veut jouer
           */
        {
            int q = 0;
            int count = 0;
            //Utilisation de 
            while (q <= 0 || q > 10)
            {
                if (count > 0)
                {
                    Console.Write("\n Le nombre de questions est compris entre 0 et 10 \n");
                }
                Console.Write("Donner le nombre de questions d'entrainement : ");
                string msg = Console.ReadLine();
                q = Convert.ToInt32(msg);
                count++;
            }
            return q;
        }

    }

        
}
