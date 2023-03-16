using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleGrpe10
{
    internal class Exemple2
    {
        static void Main(string[] args)
        {
            /* double moyenne = 100;

             if ( moyenne >= 0 && moyenne < 55)
                 Console.WriteLine(" Vous avez echoué");
             else if ( moyenne >= 55 && moyenne < 60) 
                Console.WriteLine(" Vous avez droit a une reprise");
             else if ( moyenne >= 60 && moyenne <= 100)
                 Console.WriteLine(" Vous avez reussi");
             else
                 Console.WriteLine(" Vous avez entré un nombre erroné");*/

            int somme = 0;
            int X;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("X:");
                X = int.Parse(Console.ReadLine());
                somme+=X;
            }
            Console.WriteLine($"Somme= {somme}");
        }
    }
}
