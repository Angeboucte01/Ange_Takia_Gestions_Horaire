using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    /// <summary>
    ///  Classe employé qui contient le nom, prenom, id et les disponibilités de l'employé
    /// </summary>
    public class Employer
    {
        // Attributs
        public int id_employe;                          // L'Id de l'employé
        public string nom_employe = "";                 // Le nom de l'employé
        public string prenom_employe = "";              // Le prenom de l'employé
        public List<Disponibilite> disponibilites;       // La liste des disponibilités de l'employé

        /// <summary>
        /// Constructeur Employer qui initialise l'id, le nom et le prenom de l'employé
        /// </summary>
        /// <param name="id"></param>
        /// <param name="n"></param>
        /// <param name="p"></param>
        public Employer(int id, string n, string p)
        {
            id_employe = id;
            nom_employe = n;
            prenom_employe = p;
            disponibilites = new List<Disponibilite>();
        }

        /// <summary>
        /// Methode qui permet d'avoir un employé à partir de son id
        /// </summary>
        public int IdEmploye
        {
            get { return id_employe; }
        }

        /// <summary>
        /// Methode qui permet de supprimer un emplyé
        /// </summary>
        public void SupprimerEmploye()
        {
            // Code pour supprimer l'employé de la base de données
        }
        /// <summary>
        /// Methode qui permet d'ajouter un employé
        /// </summary>
        public void AjouterEmploye()
        {
            // Code pour ajouter l'employé à la base de données
        }
    }
}
