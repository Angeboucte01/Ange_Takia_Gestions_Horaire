using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok
{
    internal class Class1
    {
        public static int getSurface(int b, int h)
        {   // Écrivez votre code ici

            //Declaration et initialisation de la variable de retour surface
            int surface = (b * h) / 2;

            //retour de la methode getSurface
            return surface;
        }

        // Testez le code
        public static void Main()
        {
            Console.WriteLine(getSurface(8, 2));
            Console.WriteLine(getSurface(7, 3));
        }
    }
}
