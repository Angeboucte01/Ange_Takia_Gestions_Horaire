using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleFonctio
{
    internal class ExempleFonction
    {
        //Definition de fonctions


        //Definition de la methode 
        static void Main(string[] args)
        {
            //On veut calculer la moyenne d'un etudiant 
            // noteUA1*0.3 + noteUA2*0.35 + noteUA3*0.35

            //Declaration des variable
            double NoteUA1, NoteUA2, NoteUA3, moyenne;

            //lecture des note
            Console.WriteLine("Entrer la note de UA1");
            NoteUA1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer la note de UA2");
            NoteUA2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer la note de UA3");
            NoteUA3 = int.Parse(Console.ReadLine());

            //Calcul de la moyennne
            moyenne = (NoteUA1 * 0.3) + (NoteUA2 * 0.35) + (NoteUA3 * 0.35);
            //Affichage de la moyenne
            Console.WriteLine("La moyenne de l'etudiant est: " + moyenne);

        }

    }
}
