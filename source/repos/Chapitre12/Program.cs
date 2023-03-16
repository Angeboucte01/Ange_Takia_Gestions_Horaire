using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Chat();
            Animal a2 = new Chien();

            ISon s1  = new Etudiant();
            ISon s2 = new Voiture();
            ISon s3 = new Chat();
            ISon s4 = new Chien();


            Voiture v = new Voiture();
            (v as IChap).ProduireSon();

        }
    }
}
