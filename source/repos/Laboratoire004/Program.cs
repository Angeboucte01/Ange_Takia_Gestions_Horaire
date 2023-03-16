using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Créer l’employé (emp1) mohamed salah bouhlel avec un salaire de 4500$ CAD, embauché en 
            // 2005 et habitant 123 Rue Charlemagne, Gatineau, A1B2C3, Canada.
            Adresse adr = new Adresse(123, "Rue Charlemagne", "Gatineau", "QC", "A1B2C3");
            Employe emp1 = new Employe("bouhlel", "mohamed salah", 2005,4500,adr);

            // Créer l’employé (emp2) Eric duval avec un salaire de 2500$CAD et embauché en 2015. 
            Employe emp2 = new Employe("Duval", "Eric", 2015, 2500);

            //Calculer et afficher le salaire annuel de emp1.
            Console.WriteLine("Salaire annuel de Emp1 : " +emp1.SalaireAnnuel());

            //Calculer et afficher le salaire annuel de emp2. 
            Console.WriteLine("Salaire annuel de Emp2 : " + emp2.SalaireAnnuel());

            //Calculer et afficher l’ancienneté de l’employé emp1.
            Console.WriteLine("L'anciennete de Emp1 : " +emp1.Anciennete());

            //Calculer et afficher la prime de l’employé emp2. 
            Console.WriteLine("La prime de Emp1 : " + emp1.Prime());

            //Tester l’égalité de l’employé emp1 avec l’employé emp2. 

            Console.WriteLine("Egalite de Emp1 et Emp2 : " +emp1.Egalite(emp2));
            // emp1== this et emp2=emp
            //Console.WriteLine("Egalite de Emp1 et Emp2 : " + emp2.Egalite(emp1));


            //Afficher les deux employés. 
            emp1.Afficher();
            emp2.Afficher();
            



        }
    }
}
