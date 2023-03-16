using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire9
{
    internal abstract class Ouvrier : Employe, IPrime
    {

        //Defintion des attributs et proprietes

        public bool PlageHoraire { get; set; } //True == matinée FALSE== soirée

        public Ouvrier(string nom, string prenom, bool plageHoraire) : base(nom, prenom)
        {
            PlageHoraire = plageHoraire;
        }
       
        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Plage horaire : {PlageHoraire}";
        }

        public override bool Equals(object? obj)
        { 
            if (obj == null) return false;
            if(obj.GetType() != typeof(Ouvrier)) return false;
            Ouvrier other = (Ouvrier)obj;
            return base.Equals(obj) && PlageHoraire == other.PlageHoraire;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double CalculerPrime()
        {
            return CalculerSalaire() * 0.3; 
        }
    }
}
