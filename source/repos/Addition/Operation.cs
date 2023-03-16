using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Operation
    {
        public static void Main(string[] args)
        {
            Matrice A = new Matrice(2, 6);
            Console.WriteLine(A.getNombreLigne());
            Console.WriteLine(A.getNombreColonne());
            A.RemplirMatrice();
            A.AfficherMatrice();
        }
    }
}
