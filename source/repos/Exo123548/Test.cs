using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo123548
{
    internal class Test
    {
        static void Main(string[] args)
        {
            MatierePersonne mt1 = new MatierePersonne("Maths", 20, 3, "Cité", 99, 54);

            MatierePersonne mt2 = new MatierePersonne("Physique", 20, 2, "Cité", 99, 45);

            MatiereLigne ml1 = new MatiereLigne("Chimie", 51, 6, 18, 15);

            MatiereLigne ml2 = new MatiereLigne("EPS", 12, 1, 14, 13);


            List<Matiere> matieres = new List<Matiere>();
            matieres.Add(mt1);
            matieres.Add(ml1);
              matieres.Add(ml2);
            matieres.Add(mt2);

           /* mt1.CalculerMoyenne().ToString();
            mt2.CalculerMoyenne().ToString();
            ml1.CalculerMoyenne().ToString();
            ml2.CalculerMoyenne ().ToString();*/


            matieres.ToString();
        }
    }
}
