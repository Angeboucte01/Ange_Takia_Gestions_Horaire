using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo123548
{
    internal abstract class Matiere
    {
        private int coefficient;

        public int nbr = 0;
        public static int Code { get; private  set; }
        public  string Nom { get; private set; }

        public int NbreHeures { get;  set; }
         public int Coefficient
         {
            get => coefficient; 
            set
            {
                 this.coefficient = value;
                /*if (value <= 1 && value >= 3)
                    coefficient = value;
                else
                    coefficient = 1;
                */    //Console.WriteLine("Une mauvaise valeur a été saisi");
            }
         }

        public Matiere(string nom, int nbrH, int coef)
        {
            Nom = nom;
            NbreHeures = nbrH;
            Coefficient = coef;
            Code = ++nbr;
        }
        //Mehode CalculerMoyenne
        public abstract double CalculerMoyenne();

        public override string ToString()
        {
            return
                  $"Nom:{Nom}" + "\n" +
                  $"Nombres heures : {NbreHeures}" + "\n" +
                  $"Codes: {nbr}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(Matiere)) return false;
            Matiere other = (Matiere)obj;
            return  Nom== other.Nom && NbreHeures == other.NbreHeures && Code == other.nbr;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
