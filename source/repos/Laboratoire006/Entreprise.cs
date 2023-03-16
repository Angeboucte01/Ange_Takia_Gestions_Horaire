using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire006
{
    internal class Entreprise
    {
        public  string Nom { get; set; }    
        public List<Employe> Employes { get; set; } =  new List<Employe>();


        //definition du constructeur
        //Définir un constructeur permettant d’initialiser une entreprise par son nom.
        public Entreprise(string nom)
        {
            this.Nom = nom;
        }

        //- Définir une méthode nommée AddEmploye permettant d’ajouter un employé à l’entreprise

        public void AddEmploye(Employe emp)
        {
         this.Employes.Add(emp);    
        }

        //- Surcharger la méthode AddEmploye pour ajouter un employé à l’entreprise en donnant son
        // nom et son prénom
        public void AddEmploye(string nom, string prenom)
        {
            this.AddEmploye(new Employe(nom, prenom));
        }
        //Surcharger la méthode AddEmploye pour ajouter un employé à l’entreprise en donnant son
        // nom, son prénom, son salaire et son année d’embauche
        public void AddEmploye(string nom, string prenom, double salaire, int anneeEmbauche)
        {
            this.AddEmploye(new Employe(nom, prenom, salaire, anneeEmbauche));
        }

        public void AddEmploye(string nom, string prenom, double salaire, int anneeEmbauche,string motDePasse)
        {
            this.AddEmploye(new Employe(nom, prenom, salaire, anneeEmbauche, motDePasse));
        }
        //- Définir une méthode nommée FindEmploye permettant de chercher un employé dans
        // l’entreprise en fournissant son code.La méthode retourne null si le code ne correspond à aucun
       //employé sinon elle retourne l’employé en question.

        public Employe FindEmploye(int code)
        {
            foreach(Employe emp in Employes)
                if(emp.Code == code) return emp;
            return null;
        }
        //Surcharger la méthode FindEmploye permettant de chercher un employé dans l’entreprise en
        //fournissant son nom et son prénom.La méthode retourne null si le nom et le prénom ne
        //orrespondent à aucun employé.Sinon elle retourne le premier employé dont le nom et prénom
        //ont été fournis.

        public Employe FindEmploye(string  nom, string prenom)
        {
            foreach(Employe emp in Employes)
                if(emp.Nom==nom && emp.Prenom==prenom)  return emp;
            return null ;
        }

        //Définir une méthode nommée DelEmploye permettant de supprimer un employé de
        //l’entreprise en fournissant son code.La méthode retourne un booléen indiquant si l’opération
       //de suppression a réussi ou non.

        public bool DelEmploye(int code)
        {
           return this.Employes.Remove(this.FindEmploye(code)); 
        }

        //- Surcharger la méthode DelEmploye pour supprimer un employé en fournissant son nom et son
        //prénom.La méthode retourne un booléen indiquant si l’opération de suppression a réussi ou
        //non
        public bool DelEmploye(string  nom, string prenom)
        {
            return this.Employes.Remove(this.FindEmploye(Nom==nom && Prenom== prenom));
        }

    }





}
