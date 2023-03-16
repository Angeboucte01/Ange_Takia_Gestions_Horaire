using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationFormative3
{
    //Declaration  des attributs et propriètés
    internal abstract class ObjetPostal
    {
        public static int nbreAdr = 0;
        public int Code { get; private set; }
        public int Poids { get; set; }
        public string AdresseDest { get; set; }
        public bool ModeExpedition { get; set; } //True :Normal            False : EXpress


      // Definiton d'un constructeur initialisant tout les attribut
        public ObjetPostal(int poids, string adresse, bool modeExp)
        {
            Poids = poids;
            AdresseDest = adresse;
            ModeExpedition = modeExp;
            Code = ++nbreAdr;
        }


        public abstract double CalculerPrix();

        /*
         La methode calculerPrix est bstraite car il n'existe pas une implementation pour calculer 
         le prix d'un objet postale c'est a dire qu'on a 
         pas une formule pour le faire et le calcul de celui ci varie en fonctions des situations
         */

        //Redefinition de Equals
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(ObjetPostal)) return false;
            ObjetPostal objetPostal = (ObjetPostal)obj;
            return  Code == objetPostal.Code 
                         && 
                   Poids == objetPostal.Poids
                         && 
             AdresseDest == objetPostal.AdresseDest 
                         &&
          ModeExpedition == objetPostal.ModeExpedition;
        }

        public override string ToString()
        {
            return  $"Le poids de l'objet est : {Poids}" + "\n" +
                    $"L'adresse de destination de l'objet est : {AdresseDest}" + "\n" +
                    $"Le mode d'expedition de l'objet est : {ModeExpedition}" + "\n" +
                    $"Le code de l'objet est : {Code}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
