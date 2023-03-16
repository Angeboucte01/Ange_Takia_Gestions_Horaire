using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre12
{
    internal class Chien : Animal
    {
        public override void ProduireSon()
        {
            Console.WriteLine("C'est un chien");
        }
    }
}
