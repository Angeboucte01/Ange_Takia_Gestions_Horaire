using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre12
{
    internal class Chat : Animal
    {
        public override void ProduireSon()
        {
            Console.WriteLine("Le chat miaule");
        }
    }
}
