using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDesTableaux
{
    internal class RevisionDesTableaux
    {
        public  static void Main(string[] args)
        {
            int[,] CalculMatrice = new int[3,3];

            int variable;
            variable = int.Parse(Console.ReadLine());
            Console.WriteLine(variable);
            Console.ReadLine();
            MaPremiereFonction();
        }

        static void MaPremiereFonction()
        {
            Console.WriteLine("Hello World!!!!");
        }
    }
}
