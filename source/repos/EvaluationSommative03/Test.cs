using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative03
{
    internal class Test
    {
        static void Main(string[] args)
        {
            //Définir deux ProfesseurChargePartielle et deux ProfesseurPermanent.
            ProfesseurChargePartielle pc1 = new ProfesseurChargePartielle("Boucte", "Ange", "66666665666", 20, 15.60);
            ProfesseurChargePartielle pc2 = new ProfesseurChargePartielle("Wami", "Tchouambia", "6666656666", 5, 50.5);
            //deux ProfesseurPermanent.
            ProfesseurPermanent pp1 = new ProfesseurPermanent("Cristiano", "Ronaldo", "6766666666", "Brevet", 13, 12589.02);
            ProfesseurPermanent pp2 = new ProfesseurPermanent("Messi", "Lionel", "6666966666", "Cep", 14, 12588.02);

            //Créer un tableau de professeur et ajouter les quatre objets précédents dans le tableau

            Professeur [] prof = new Professeur [] { pc1, pc2, pp1, pp2 };


            //Afficher les professeurs qui ont une assurance.
            foreach (Professeur p in prof)
                if(p.GetType()==typeof(ProfesseurPermanent))
                    
                { 
                    Console.WriteLine(p.ToString());
                }

              
           // Console.WriteLine(pp1.ToString());
        }


    }
}
