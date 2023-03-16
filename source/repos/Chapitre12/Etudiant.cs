using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre12
{
    internal class Etudiant : ISon
    {
        //
        public void ProduireSon()
        {
            Console.WriteLine("L'etudiant possède une voix");
        }
    }
}
