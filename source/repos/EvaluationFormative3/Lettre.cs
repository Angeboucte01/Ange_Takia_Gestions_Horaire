using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationFormative3
{
    internal sealed class Lettre : ObjetPostal
    {  
        public bool Format { get; set; } //True A3         False A4
        public Lettre(int poids, string adresse, bool modeExp, bool form) : base(poids, adresse, modeExp)
        {
            Format = form;
        }
        //Redefinition de CalculerPrix

        public override double CalculerPrix()
        {
            double m = 0;
            m = CalculerPrix() + 2.0 * CalculerPrix() * Poids;
            return m;

            if (Format == true)
                return
                     m = 7.0;
            else if (Format == false)
                return
                m = 5.0;
            else if (ModeExpedition == false)
                return m += m;
            else
                return m;
        }

        //Redefinition de Equals

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(Lettre))  return false;
            Lettre other = (Lettre)obj;
            return base.Equals(obj) && Format == other.Format;
        }

        //Redefinition de ToString

        public override string ToString()
        {
            return base.ToString() + "\n"+
                $"Le format est : {Format}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
