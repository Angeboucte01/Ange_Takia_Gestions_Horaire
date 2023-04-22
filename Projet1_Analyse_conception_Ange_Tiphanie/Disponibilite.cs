using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    public class Disponibilite
    {
        public string Debut { get; set; }
        public string Fin { get; set; }



        public override string ToString()
        {
            return $"{Debut} - {Fin}";
        }
    }
}
