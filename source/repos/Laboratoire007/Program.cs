using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document d1 = new Document("Livre", 150);
            d1.ToString();
            Console.WriteLine(d1);

            Document d2 = new Document("Anglais", 250);
            d2.ToString();
            Console.WriteLine(d2);

            Document d3 = new Livre("Musique", 254, "Ange");
            d3.ToString();
            Console.WriteLine(d3);

        }
    }
}
