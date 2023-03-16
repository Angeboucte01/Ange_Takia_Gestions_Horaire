using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire006
{
    internal class Employe
    {
        // son code,
        private int code;
        // son nom (chaîne),
        private string nom;
        // son prénom (chaîne),
        private string prenom;
        // son salaire (réel),
        private double salaire;
        // son année d’embauche(entier)
        private int anneeEmbauche;
        //son adresse courriel(chaîne),
        private string courriel;
        //son login(chaine) et
        private string login;
        //son mot de passe(chaîne). 
        private string motDePasse;



        public int Code
        {
            get  ; private set ;
        }

        public string Courriel
        {
            get; private set ;
        }
        public string Nom
        {
            get { return nom; } set { nom = value.ToUpper(); }
        }

        public string Prenom
        {
            get { return prenom; } set { prenom = value.ToLower(); }
        }
        public double Salaire
        {
            get { return salaire; } set { salaire = value > 1000 ? value : 1000; }
        }

        public int AnneeEmbauche
        {
            get { return anneeEmbauche; } set { anneeEmbauche = value > 1970 ? value : 1970; }
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set { this.motDePasse = (value.Length > 6) ? value : "ABC963ABC"; }
        }

        //Creation des constructeurs
        //Définir un constructeur initialisant le nom et le prénom.
        public Employe(string nom, string prenom)
        {
            this.Code = code++;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        //Définir un constructeur initialisant le nom, le prénom, le salaire et l’année d’embauche
        public Employe(string nom, string prenom, double salaire, int anneeEmbauche) :
            this(nom, prenom)
        {
             this.Salaire = salaire;
             this.AnneeEmbauche=anneeEmbauche;
        }

        public Employe(string nom, string prenom, double salaire, int anneeEmbauche,string motDePasse) :
           this(nom, prenom,salaire,anneeEmbauche)
        { 
            this.MotDePasse=motDePasse;
        }
















        //Definition des methodes

        /*
        * Arguments        : auncun
        * Type de retour   : Non
        * Role             :Creer l'email 
        */

        //Définir une méthode nommée CreerEmail qui permet d’affecter une valeur à l’attribut
        //représentant l’adresse courriel.Cette valeur est générée par la concaténation du prénom avec
        //le premier caractère du nom séparer par un point. Toutes les adresses courriels se terminent
        //par « @proIT.ca ».

        public void CreerEmail()
        {
            Console.WriteLine($"Adresse courriel: { this.Prenom + this.Nom.Substring(0) + "." + "@proIT.ca"}");
        }
        /*
        * Arguments        : auncun
        * Type de retour   : Non
        * Role             :Afficher l'employé 
        */

        //- Définir une méthode nommée CreerLogin qui permet d’affecter une valeur à l’attribut login.
        // Cette valeur est générée par la concaténation des deux premiers caractères du nom avec les 4
        //premiers caractères du prénom séparer par un point.
        public void CreerLogin()
        {
            Console.WriteLine($"Login : {this.Nom.Substring(0,1)}."+"{this.Prenom.Substring(0,3)}");
        }

        //Définir une méthode nommée SalaireAnn permettant de calculer le salaire annuel de
        //l’employer courant.Le salaire annuel est calculé par la multiplication du salaire par 12.

        public double SalaireAnn()
        {
            return this.Salaire * 12;
        }
        //Définir une méthode nommée Anciennete permettant de calculer le nombre d’année
        //d’ancienneté de l’employé courant.Pour simplifier, calculer l’ancienneté par rapport à 2021
         
        public int Anciennete()
        {
            return 2021 - this.AnneeEmbauche;
        }

        //- Définir une méthode nommée AugmentationSalaire qui permet d’augmenter le salaire de
        // l’employé selon son ancienneté en appliquant la formule suivante : 
        // Si l’ancienneté est inférieure à 3 ans alors on augmente de 5%.
        // Si l’ancienneté est supérieure ou égale à 3 ans et inférieure à 7 ans alors on augmente de 10%.
        // Si l’ancienneté est supérieure ou égale à 7 ans et inférieure à 15 ans alors on augmente de 15%.
        // Si l’ancienneté est supérieure ou égale à 15 ans alors on augmente de 20%


        /*
         * Arguments        : auncun
         * Type de retour   : double
         * Role             :Calculer le salaire augmenté 
         */

        public double AugmenterSalaire()
        {
            double salaireAugmente;
            int anciennete = this.Anciennete();
            if (anciennete < 3) salaireAugmente = this.Anciennete() * 0.05;
            else if (anciennete < 7) salaireAugmente = this.Anciennete() * 0.1;
            else if (anciennete < 15) salaireAugmente = this.Anciennete() * 0.15;
            else salaireAugmente = this.Anciennete() * 0.2;

            return salaireAugmente;
        }
        //Surcharger la méthode AugmentationSalaire pour augmenter le salaire d’un employé par un
        // pourcentage fourni en paramètre

        public void AugmentationSalaire(int pourcentage)
        {
            this.salaire += this.salaire * (pourcentage / 100);
        }

        //- Définir une méthode nommée Egalite permettant de tester l’égalité de l’employé courant avec
        // l’employé passé comme paramètre.Deux employés sont égaux s’ils ont le même code et le
        //même nom de famille.

        public  bool Egalite(Employe emp)
        {
            return emp.Nom.Equals(this.Nom) && emp.Prenom.Equals(this.Prenom);
        }
    }
}
