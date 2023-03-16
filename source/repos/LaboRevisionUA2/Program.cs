using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboRevisionUA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation d'une adresse
            Adresse ad1 = new Adresse(2, "abc", "ottawa", "sa", "on");
            Console.WriteLine(ad1.ToString());

            Adresse ad2 = new Adresse(2, "abc", "ottawa", "sa", "on");
            Console.WriteLine(ad2.ToString());
            Console.WriteLine(ad1.Egalite(ad2));
        }
        
    }
}
