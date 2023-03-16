using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal class TestEntreprise
    {
        static void Main(string[] args)
        {
            Patron p1 = new Patron("Boucte", "Ange", 15000);
            Commercial c1 = new Commercial("Netsle", "Ca", 10000, 500, 50);
            ChefEquipe ce1 = new ChefEquipe("Yaouba", "Ben", 500);
            OuvrierHeure oh1 = new OuvrierHeure("Benzema", "Karim", true, 20, 1520);
            OuvrierPiece op1 = new OuvrierPiece("Ronaldo", "Cristiano", true, 204, 152000);

            Entreprise e1 = new Entreprise();

            e1.Ajouter(p1);
            e1.Ajouter(c1);
            e1.Ajouter(ce1);
            e1.Ajouter(oh1);
            e1.Ajouter(op1);

            e1.ToString();

            e1.NombreOuvrier();
            e1.MontantPrime();
            e1.Chercher("Benzema");
            e1.ToString();



            p1.ToString();









        }
    }
}
