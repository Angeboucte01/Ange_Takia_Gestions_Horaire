using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationFormative3
{
    internal class Test
    {
        static void Main(string[] args)
        {
            //Définir deux colis et deux lettres
            Colis c1 = new Colis(150, "Ottawa", true, 520);
            Colis c2 = new Colis(150, "Gatineau", false, 120);


            Lettre l1 = new Lettre(87, "Yaoundé", true, true);
            Lettre l2 = new Lettre(97, "Douala", false, false);


            //Créer un tableau d’objets postaux et ajouter les quatre objets précédents dans le tableau.
            List<ObjetPostal> tableauObjet = new List<ObjetPostal>();
            tableauObjet.Add(c1);
            tableauObjet.Add(c2);
            tableauObjet.Add(l1);
            tableauObjet.Add(l2);


            //Afficher le montant total de l’assurance

            //J'ai pas pu


            //Afficher les objets postaux qui ont une assurance
            foreach (ObjetPostal obj in tableauObjet)
                if (obj.GetType() == typeof(Colis))
                {
                    Console.WriteLine(obj.ToString());
                }



        }



    }
}
