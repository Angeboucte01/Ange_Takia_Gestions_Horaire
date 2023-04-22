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
    public class Employe
    {
       public int? Id { get; set; }
       public string Nom { get; set; }
       public Disponibilite Lundi { get; set; }

       public Disponibilite Mardi { get; set; }
       public Disponibilite Mercredi { get; set; }
       public Disponibilite Jeudi { get; set; }
       public Disponibilite Vendredi { get; set; }
    }
}
