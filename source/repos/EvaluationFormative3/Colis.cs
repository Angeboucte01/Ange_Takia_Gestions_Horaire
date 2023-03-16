using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationFormative3
{
    internal class Colis : ObjetPostal , IAssurance
    {  // Declaration des attributs et proprietes
        public double Volume { get; set; }
        public Colis(int poids, string adresse, bool modeExp, double volume) : base(poids, adresse, modeExp)
        {
            Volume = volume;
        }

        //Redefinisiion de la methode CalculerPrix
        public override double CalculerPrix()
        {
            double p = 0;
            p = 0.25 * Volume + Poids *1.0;
            return p;
        }

        //Redefinisiion de la methode Equals
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(Colis)) return false;
            Colis colis = (Colis)obj;
            return base.Equals(obj) && Volume == colis.Volume;
        }

        //Redefinisiion de la methode ToString

        public override string ToString()
        {
            return base.ToString() + "\n"+
                $"Le volume de l'objet est : {Volume}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double MontantAssurance()
        {
            double z = 0;
            z = Poids * 1.5;
            return z;
        }


       
    }
}
