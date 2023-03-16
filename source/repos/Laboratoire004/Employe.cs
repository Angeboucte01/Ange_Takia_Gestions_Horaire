using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire004
{
    internal class Employe

        //Defintion des attributs
    {
        private string nom;
        private string prenom;
        private Adresse adresseEmploye;
        private int anneeEmbauche;
        private double salaire;
        public string Nom
        {
            get { return nom; }
            set { nom = value.ToUpper(); }    //Le nom soit en majuscule,
        }


        
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value.ToLower(); }  //Le prénom soit en minuscule
        }


      
        public Adresse AdresseEmploye
        {
            get { return adresseEmploye; }
            set { adresseEmploye = value; }
        }




        //L’année d’embauche soit comprise entre 1995 et 2021. Sinon on affecte la valeur 1995 
                                   // comme valeur par défaut
        public int AnneeEmbauche
        {
            get { return anneeEmbauche; }
            set { anneeEmbauche = value > 1995 && value <= 2022 ? value : 1995; }
        }

       
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value > 2000 ? value : 2000; }  //Le salaire soit supérieur à 2000$CAD. Sinon on affecte la valeur 2000 comme valeur par 
                                                            //défaut.
        }

        //Definition des constructeurs

        public Employe(string Nom, string prenom, int anneeEmbauche, double salaire)
        {
            this.Nom = Nom; 
            Prenom = prenom;
            AnneeEmbauche = anneeEmbauche;
            Salaire = salaire;
        }
        public Employe(string nom, string prenom, int anneeEmbauche, double salaire, Adresse adresse)  /*Appel au constructeur précedent*/: this(nom, prenom, anneeEmbauche, salaire)
        {
            AdresseEmploye= adresse;
        }
        //Créer  une  méthode  nommée  SalaireAnnuel  permettant  de  calculer et de retourner le  salaire  annuel  d’un 
        //employé
        /*
         * Arguments        : auncun
         * Type de retour   : double representant le salaireAnnuel
         * Role             :Calculer le salaire annuel 
        */

        public double SalaireAnnuel()
        {
            return this.Salaire * 12;
        }
        //Créer  une  méthode nommée Ancienneté permettant de calculer l’ancienneté de l’employé. 
        //L’ancienneté est calculée par la formule suivante : 2022 – Année embauche
        /*
        * Arguments        : auncun
        * Type de retour   : int representant le Anciennete
        * Role             :Calculer le Anciennete 
       */
        public int Anciennete()
        {
            return 2022 - this.AnneeEmbauche;
        }

        //- Créer une méthode nommée Prime permettant de calculer la prime accorder à l’employé. La 
        // prime est calculée de la façon suivante : 
        //• Si l’ancienneté< 5 ans alors la prime est égale à 10% du salaire annuel.
        //• Si 5 <= l’ancienneté< 10 ans alors la prime est égale à 15% du salaire annuel.
        //• Si 10 <= l’ancienneté< 15 ans alors la prime est égale à 20% du salaire annuel.
        //• Si l’ancienneté >= 15 ans alors la prime est égale à 25% du salaire annuel.

        /*
         * Arguments        : auncun
         * Type de retour   : double
         * Role             :Calculer la prime 
         */

        public double Prime()
        {
            double prime ; //Variable pour calculer la prime
            int anciennete = this.Anciennete(); //Appel de la methode anciennete pour le calcul
            if(anciennete < 5) prime = this.SalaireAnnuel()*0.1;
            else if (anciennete < 10) prime = this.SalaireAnnuel() * 0.15;
            else if (anciennete < 15) prime = this.SalaireAnnuel() * 0.2;
            else prime = this.SalaireAnnuel() * 0.25;

            return prime;
        }

        /*
         * Arguments        : auncun
         * Type de retour   : Non
         * Role             :Afficher l'employé 
         */

        public void Afficher()
        {
            Console.WriteLine($"Nom     :  {this.Nom}");
            Console.WriteLine($"Prenom  :  {this.Prenom}");
            Console.WriteLine($"Salaire :  {this.Salaire}");
            Console.WriteLine($"Adresse : "); 
            if (AdresseEmploye == null) Console.WriteLine("il n' y'a pas d'adresse enregistrée");
            else AdresseEmploye.Afficher();
            Console.WriteLine($"Tu as {this.Anciennete()} années d'anciennete");
        }
        /*
         * Arguments        : auncun
         * Type de retour   : boolien
         * Role             :elle va permettre de comparer 2 l'employé (meme nom et prenom) : this avec employe courant
         */

        public bool Egalite (Employe emp)
        {
            return emp.Nom.Equals(this.Nom) && emp.Prenom.Equals(this.Prenom);
        }

    }
}

