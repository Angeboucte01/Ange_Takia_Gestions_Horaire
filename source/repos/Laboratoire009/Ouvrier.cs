using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal abstract class Ouvrier : Employe ,IPrimeRisque
    {    public bool PlageHoraire { get; set; }
        public Ouvrier(string nom, string prenom, bool pH) : base(nom, prenom)
        {
            PlageHoraire = pH;
        }

        //Elle est abstraite 

        public override bool Equals(object? obj)
        {   
            if (obj == null) return false;
            if(obj.GetType() != typeof(Ouvrier)) return false;
            Ouvrier other = (Ouvrier)obj;
            return base.Equals(obj) && PlageHoraire == other.PlageHoraire;
        }

        public override string ToString()
        {
            return base.ToString() +"\n" + 
                $"Plage horaire : {PlageHoraire}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

        public double Risque()
        {
            return CalculerSalaire() * 0.3;
        }
    }
}
