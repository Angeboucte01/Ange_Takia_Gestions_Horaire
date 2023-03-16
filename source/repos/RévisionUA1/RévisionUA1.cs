using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RévisionUA1
{
    internal class RévisionUA1
    {
        static void Main(string[] args)
        {
            string s = "Bonjour tout le monde";
            //Remplacer la lettre o par a 
            string s1 = s.Replace('o','a');  
            Console.WriteLine(s1);
            //Remplacer une chaine par une autre
            string s2 = s.Replace("le monde","le cameroun");
            Console.WriteLine(s2);
        }
    }
}
