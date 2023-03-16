using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Créer ordi1
            Ordinateur ordi1 = new Ordinateur(512,12,15, true,"Portable");
            ordi1.Capacite = -1024;
            //Afficher Ordi1
            ordi1.Afficher();
            //Augmenter ram Ordi1 de 16Go
            ordi1.AugmenterRam(16);
            //Convertir la capacité de l'ordi 1 en To et l'afficher
          
        }
    }
}
