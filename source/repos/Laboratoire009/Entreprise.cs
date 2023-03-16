using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal class Entreprise
    {
        List<Employe> employes = new List<Employe>(); 

        public string Nom { get; set; } 
        public string Prenom { get; set; }
        public static int Code { get;  set; }


        public void Ajouter(Employe e)
        {
            employes.Add(e);
        }

        public void Supprimer(Employe e) 
        {
            employes.Remove(e);
        }



        // Cherher un employe a partir de son nom 
        public string Chercher(string nom)
        {
            foreach (Employe employe in employes)
            { 
                if (employe.Nom == nom)
                    nom = employe.Nom;
            }
            return nom;   
        }


       


        //Définir une méthode nommée MontantPrime permettant de calculer la prime des 
        //employés à risque.

        public double MontantPrime()
        {
            double mtnPrime = 0;
            foreach(Employe employe in employes)
            {
                if (employes is IPrimeRisque)
                    mtnPrime += (employe as IPrimeRisque).Risque();
            }
            return mtnPrime;
        }

        //Définir une méthode nommée NombreOuvrier permettant de retourner le nombre d’ouvrier dans l’entreprise.

        public int NombreOuvrier()
        {
            int nombre = 0;
            foreach(Employe employe in employes) {           
                if(employes is Ouvrier)
                    nombre = employes.Capacity;
            }
             
            return nombre;
        }



    }
}
