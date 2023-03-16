using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre11
{
    internal class Forme2D
    {
        //Defintition des proprietes

        public int Cgx { get; set; }
        public int Cgy { get; set; }

        //Definition du constructeur
        public Forme2D(int x, int y) { Cgx = x; Cgy = y; }
    }

}
