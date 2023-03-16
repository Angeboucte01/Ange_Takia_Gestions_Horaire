using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo123548
{
    internal class MatierePersonne : Matiere, IReprise
    {
        
        public string Local { get; set; }
        public double SommeNotes { get; set; }
        public double NbresNotes { get; set; }
        public MatierePersonne(string nom, int nbrH, int coef, string local, double sn, double nn) : base(nom, nbrH, coef)
        {
            Local = nom;
            SommeNotes = sn;
            NbresNotes = nn;
        }

        /*
         List<double> Notes { get; set; }*/

        public override double CalculerMoyenne()
        {
            return SommeNotes / NbresNotes;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(MatierePersonne)) return false;
            MatierePersonne matierePersonne = (MatierePersonne)obj;
            return base.Equals(obj) && Local == matierePersonne.Local ;
        }

        public override string ToString()
        {
            return base.ToString() +"\n" +
                $"Local : {Local}";
        }

        public bool Reprise()
        {
            if( CalculerMoyenne() <= 55 && CalculerMoyenne() <60)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
