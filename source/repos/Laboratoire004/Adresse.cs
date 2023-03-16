using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire004
{
    internal class Adresse
    {
        //numero de la rue nomRue ville, province, codePostal

       public int NumeroRue { get; set; }
        public string NomRue { get; set; }

        public string Ville { get; set; }   
        public string  Province { get; set; }   
        public string CodePostal { get; set; }   

        public Adresse(int numeroRue, string nomRue, string ville, string province, string codePostal)
        {
            NumeroRue = numeroRue;
            NomRue = nomRue;
            Ville = ville;
            Province = province;
            CodePostal = codePostal;
        }

        /*
         * Arguments        : auncun
         * Type de retour   : Non
         * Role             :Afficher l'adresse 
         */
        public void Afficher()
        {
            Console.WriteLine($"{NumeroRue} {NomRue}, {Ville}, {Province},{CodePostal}");
        }
    }
}
