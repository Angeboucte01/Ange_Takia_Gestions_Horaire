using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal sealed class Patron : Employe
    {

        public double SalaireMensuel { get; set; }
        public Patron(string nom, string prenom, double salaire) : base(nom, prenom)
        {
            SalaireMensuel = salaire;
        }

        public override double CalculerSalaire()
        {
            return SalaireMensuel;
        }

        public override string ToString()
        {
            return base.ToString() +"\n"+
                $"Salaire : {SalaireMensuel}";
        }


        public override bool Equals(object? obj)
        {   
            if (obj == null) return false;
            if(obj.GetType() != typeof(Patron)) return false;
            Patron objPatron = (Patron)obj;
            return base.Equals(obj)  && SalaireMensuel == objPatron.SalaireMensuel;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

    }
}
