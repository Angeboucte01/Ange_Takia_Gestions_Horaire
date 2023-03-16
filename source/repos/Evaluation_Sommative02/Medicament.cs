using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Sommative02
{
    internal class Medicament
    {
        //son nom (chaine)
        private string nom;
        //son prix (double)
        private double prix;
        //son principe actif (chaine)
        private string principeActif;
        //et une liste de ses effets indésirables(List<string>)
        private List<string> effectIndesirable = new List<string>();
        public string Nom
        {
            get { return this.nom; }
            set {
                if (value.ToUpper() != null)
                    nom = value.ToUpper();
                else nom = "MEDICAMENT";

            }
        }
         public double Prix
         {
            get { return this.prix; }
            set
            {
                if (value < 0) 
                {
                    this.prix = 10.99;
                }
                    
                else 
                    this.prix = value;

            }

         }

        public string PrincipeActif
        {
            get { return this.principeActif; }
            set 
            {
                if (value.ToLower() != null)
                    this.principeActif = value.ToLower();
                else this.principeActif = "principe actif";
            }
        }
        public List<string> EffectIndesirable
        {
            get { return this.effectIndesirable; }
            set
            {
                this.effectIndesirable = value;
                
            }
        }
        //Définir un constructeur ne prenant aucun argument.

        public Medicament()
        {

        }


        // Définir un constructeur initialisant le nom et le principe actif
        public Medicament(string nom, string principeActif)
        {
            this.Nom = nom;
            this.PrincipeActif=principeActif;
        }

        //Définir un constructeur initialisant le nom, le principe actif et le prix
        public Medicament(string nom, string principeActif, double prix) : this(nom,principeActif)
        {
            this.Prix = prix;
        }

        //Définir une méthode nommée AjouterEffet permettant d’ajouter un effet indésirable au 
        //médicament courant.Vous ne devez pas ajouter le même effet indésirable deux fois
        /*
        * Arguments        : string
        * Type de retour   : aucun
        * Role             :Ajouter un effet indesirable le salaire annuel 
       */
       
         public void  AjouterEffet(string effetindesirable)
         {
            string eff;
            bool trouver = false;

            foreach (string effet in this.effectIndesirable)
            {
                eff = effet; 
                if(eff== effetindesirable)
                {
                    trouver = true;
                }
            }
            if (!trouver)
            {
                this.effectIndesirable.Add(effetindesirable);
            }

         }
        /*
        * Arguments        : string
        * Type de retour   : bool
        * Role             :supprimer un effet indesirable 
       */
        //Définir une méthode nommée SupprimerEffet permettant de supprimer un effet indésirable au 
        //médicament courant.La méthode retourne true si la suppression est faite et false sinon

        public  bool SupprimerEffet(string effetindesirable)
        {
            string eff;
            bool trouver = false;

            foreach (string effet in this.effectIndesirable)
            {
                eff = effet;
                if (eff == effetindesirable)
                {
                    trouver = true;
                }
            }
            if (trouver)
            {
                this.effectIndesirable.Remove(effetindesirable);
                return true;
            }
            else return false;
        }
        /*
        * Arguments        : Aucun
        * Type de retour   : Aucun
        * Role             :Afficher les effet indesirable 
       */
        //Définir une méthode nommée AfficherEffets permettant d’afficher les effets indésirables du 
        // médicament courant.L’affichage est comme suit 

        public void AfficherEffets()
        {
            string affichage = "Liste des effets indesirables : [ ";
            foreach (string effet in this.effectIndesirable)
            {
                if (effet != null)
                {
                    affichage = affichage + effet + ", " ;
                } 
            }
            affichage = affichage.Substring(0, affichage.Length - 2);
            affichage += " ";
            affichage = affichage + "]";
            Console.WriteLine(affichage);
        }

        //Définir une méthode nommée Egalite permettant de tester l’égalité du médicament courant 
        // avec le médicament passé comme paramètre.Deux médicaments sont égaux s’ils ont le même
        //principe actif

        /*
        * Arguments        : medicaments
        * Type de retour   : bool
        * Role             :comparer lesmedicaments 
       */

        public bool Egalite(Medicament medicament)
        {
         if (this.principeActif == medicament.PrincipeActif)
         {
                return true;
         }
         else 
                return false;
        }

        //Surcharger l’opérateur ==.



        //Définir une méthode nommée Afficher permettant d’afficher le médicament courant. 
        //L’affichage du médicament est comme suit

        /*
       * Arguments        : medicaments
       * Type de retour   : Aucun
       * Role             :Afficher les effets indesirables 
      */
        public void Afficher()
        {
            string affichage = "Liste des effets indesirables : [ ";
            foreach (string effet in this.effectIndesirable)
            {
                if (effet != null)
                {

                    affichage = affichage + effet + ", ";
                }
            }
            affichage = affichage.Substring(0, affichage.Length - 2);
            affichage += " ";

            affichage = affichage + "]";

            Console.WriteLine($"Nom             :  {this.Nom}");
            Console.WriteLine($"Principe Actif  :  {this.PrincipeActif}");
            Console.WriteLine(affichage);
            Console.WriteLine($"prix            :  {this.Prix}$  ");
        }
    }
}
