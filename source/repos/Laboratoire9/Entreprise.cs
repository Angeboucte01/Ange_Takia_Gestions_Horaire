using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire9
{
    internal class Entreprise
    {
        List<Employe> employes { get; set; } = new List<Employe>();

        public void AjouterEmploye(Employe e) { employes.Add(e); }

        public double MontantPrime()
        {
            double m = 0;
            foreach (Employe employe in employes)
            {
                if (employe is IPrime)
                    m += (employe as IPrime).CalculerPrime();
            }
            return m;
        }
    }
}
