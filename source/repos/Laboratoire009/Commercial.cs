using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal sealed class Commercial : Employe , IPrimeRisque

    {
        public double ChiffrAffaire { get; set; }
        public double SalaireFixe { get; set; }

        public double Pourcentage { get; set; }

        public Commercial(string nom, string prenom, double cf, double sf, double pourcen) : base(nom, prenom)
        {
            ChiffrAffaire = cf;
            SalaireFixe = sf;
            Pourcentage = pourcen;
        }

        public override double CalculerSalaire()
        {
            return  ChiffrAffaire*Pourcentage + SalaireFixe;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Commercial)) return false;
            Commercial other = (Commercial)obj;
            return base.Equals(obj)
                && ChiffrAffaire == other.ChiffrAffaire
                && SalaireFixe == other.SalaireFixe
                && Pourcentage == other.Pourcentage;
        }


        public override string ToString()
        {
            return base.ToString() + "\n"+
                $"Chriffre d'affaire : {ChiffrAffaire}" + "\n" +
                $"Salaire fixe : {SalaireFixe} " + "\n" +
                $"Pourcentage : {Pourcentage}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double Risque()
        {
            return CalculerSalaire() * 0.2;
        }
    }
}
