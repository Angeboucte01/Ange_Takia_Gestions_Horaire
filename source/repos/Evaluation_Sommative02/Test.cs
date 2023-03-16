using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Sommative02
{
    internal class Test
    {
        static void Main(string[] args)
        {
            //Créer un médicament m1 avec le premier constructeur de la classe Médicament
            Medicament m1 = new Medicament();
            Medicament m2 = new Medicament("TYLENOL", "acétaminophène", 16.99);
            // Créer un médicament m3 avec le troisième constructeur de la classe Médicament0
            Medicament m3 = new Medicament("LANZOPRAL", "lanzoprasole",10.99);
            Console.WriteLine(m3.Egalite(m2));
            m2.AjouterEffet("Palpitation");
            m2.AjouterEffet("nausees");
            m2.AjouterEffet("vomissement");

            m3.AjouterEffet("Palpitation");
            m3.AjouterEffet("Lesion au foie");
            m3.AjouterEffet("vomissements");


            m2.Afficher();
            m3.Afficher();


            List<Medicament> listemedicaments = new List<Medicament>();  
           

            Ordonance ord = new Ordonance("Ange Pascal", listemedicaments );

            ord.AjouterMédicament(m2);
            ord.AjouterMédicament(m3);

            ord.EffetsIndésirables();


        }
    }
}
