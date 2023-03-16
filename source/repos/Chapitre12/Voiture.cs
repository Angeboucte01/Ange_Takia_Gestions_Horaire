using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre12
{
    internal class Voiture : ISon, IChap
    {
        void ISon.ProduireSon()
        {
            Console.WriteLine("Son du moteur");
        }

        void IChap.ProduireSon()
        {
            Console.WriteLine("Son du chappement");
        }
    }
}
