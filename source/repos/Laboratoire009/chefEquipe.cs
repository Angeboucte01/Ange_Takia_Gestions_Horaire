using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal  sealed class ChefEquipe : Employe
    {   
        public double SalaireHebdo { get; set; }
        public ChefEquipe(string nom, string prenom, double salHed) : base(nom, prenom)
        {
                SalaireHebdo = salHed;
        }

        public override double CalculerSalaire()
        {
            return  2*SalaireHebdo;
        }

        public override bool Equals(object? obj)
        { 
            if (obj == null) return false;
            if(obj.GetType() != typeof(ChefEquipe)) return false;
            ChefEquipe chefEquipe = (ChefEquipe)obj;
            return base.Equals(obj) && chefEquipe.SalaireHebdo == SalaireHebdo;
        }

        public override string ToString()
        {
            return base.ToString() +"\n"+ 
                $"Salaire Hebdomadaire : {SalaireHebdo}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
