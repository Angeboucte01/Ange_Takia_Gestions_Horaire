using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo123548
{
    internal class MatiereLigne : Matiere

    {
        private double note1;
        private double note2;
        public double Note1 {
            get { return this.note1; }
            set
            { 
                this.note1 = value;
              /*  if (value <= 0 && value >= 100)
                    note1 = value;
                else
                    note1 = 10;
                   */// Console.WriteLine("Vous avez entré une mauvaise note");
            }
        }  
        public double Note2 {
            get => this.note2;

            set { 
                this.note2 = value;
                 /*if (value <= 0 && value >= 100)
                note2 = value;

           else
                    note2 = 10;
                *///Console.WriteLine("Vous avez entré une mauvaise note");
            }
        }

        public MatiereLigne(string nom, int nbrH, int coef, int note1, int note2) : base(nom, nbrH, coef)
        {
            this.Note1 = note1;
            this.Note2 = note2;
        }

        public override bool Equals(object? obj)

        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(MatierePersonne)) return false;
            MatiereLigne other = (MatiereLigne)obj;
            return base.Equals(obj) && Note1 == other.Note1
                                    && Note2 == other.Note2;
        }

        public override string ToString()
        {
            return  base.ToString()  +
                $"Note1 : {Note1}" +
                $"Note2 : {Note2}";
               
        }

        public override double CalculerMoyenne()
        {
            return Note1 * 0.4 + Note2 * 0.6;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
