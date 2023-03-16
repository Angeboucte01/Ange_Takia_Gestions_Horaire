using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative03
{
    internal sealed class ProfesseurPermanent : Professeur, IAssurance
    {
        //Defintion des attributs et proprietes

        public double Salaire { get; set; }
        public string Diplome { get; set; }
        public int AnneeExperience { get; set; }
        // Définir un constructeur initialisant tous les attributs
        public ProfesseurPermanent(string nom, string prenom, string telephone, string diplome, int anneExperience, double sal) : base(nom, prenom, telephone)
        {
            AnneeExperience = anneExperience;
            Diplome = diplome;
            Salaire = sal;

        }
        //Redéfinir la méthode CalculerSalaire.

        public override double CalculerSalaire()
        {


            if (AnneeExperience <= 2 && AnneeExperience !< 0)
                return Salaire = 40000;
            else if (
                
                AnneeExperience < 6)
                return Salaire = 50000;
            else if (AnneeExperience < 11)
                return Salaire = 60000;
            else
                return Salaire = 70000;
        }

        // Redéfinir la méthode Equals.
        public override bool Equals(object? obj)
        {  
            if (obj == null) return false;
            if(obj.GetType() != typeof(ProfesseurPermanent)) return false;
            ProfesseurPermanent other = (ProfesseurPermanent)obj;
            return base.Equals(obj) 
                && Salaire == other.Salaire
                && AnneeExperience == other.AnneeExperience
                && Diplome == other.Diplome;
        }

        //Redéfinir la méthode ToString.
        public override string ToString()
        {
            return base.ToString() +"\n"+
                $"Annee exprience : {AnneeExperience}" + "\n" +
                $"Diplome : {Diplome}" + "\n" +
                $"Salaire : {CalculerSalaire()}" + "\n" +
                $"******************************************************"
                ;

            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double AssuranceMaladie()
        {
            return Salaire * 0.25;
        }
    }
}
