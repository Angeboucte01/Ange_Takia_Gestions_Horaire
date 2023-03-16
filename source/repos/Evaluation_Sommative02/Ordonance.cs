using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Sommative02
{
    internal class Ordonance
    {//le nom du médecin prescripteur 
        private string nomMedecin;
        //la liste des médicaments qu’elle contient
        

        public string NomMedecin { get; set; }
        public List<Medicament> ListeMedicament { get; set; }    


        public Ordonance(string nomMedecin, List<Medicament> listeMedicament)
        {
            this.NomMedecin = nomMedecin;
            this.ListeMedicament = listeMedicament;
        }

        /*
        * Arguments        : Medicament
        * Type de retour   : bool
        * Role             :Ajouter un Medicament 
       */

        public void AjouterMédicament(Medicament me)
        {

            bool trouver = false;

            foreach (Medicament medicament in this.ListeMedicament)
            {
                if (medicament.Egalite(me))
                {
                    trouver = true;
                }
            }
            if (!trouver)
            {
                this.ListeMedicament.Add(me);
            }
        }

        /*
        * Arguments        : prix
        * Type de retour   : double
        * Role             :Ajouter un effet indesirable le salaire annuel 
       */
        public double TotalPrix(double prix)
       {
            double total = 0;
            foreach (Medicament medicament in this.ListeMedicament)
            {
                total += medicament.Prix;
            }
            return total;

        }
          //Définir une méthode nommée EffetsIndésirables permettant d’afficher :
          //- Le nombre de médicaments dans l’ordonnance courante.
          //- Tous les effets indésirables de tous les produits contenus dans l’ordonnance courante sans

        public void EffetsIndésirables()
        {
            foreach (Medicament  medicament in this.ListeMedicament )
            {
                medicament.Afficher();
                Console.WriteLine("\n");
            }

            List<string> list = new List<string>();

          


            foreach (Medicament medicament in this.ListeMedicament)
            {
                bool trouver = false;

                for (int i = 0; i < medicament.EffectIndesirable.Count; i++)
                {
                    string effet = medicament.EffectIndesirable[i];
                    if (list.Contains<string>(effet))
                    {
                        trouver = true;
                    }
                    if (!trouver)
                    {
                        list.Add(effet);
                    }
                }
                
            }

            Console.WriteLine($"Ton ordonance contient {this.ListeMedicament.Count} medicaments." );
            Console.WriteLine("Les effets indesirables sont : ");
            foreach(string effet in list)
            {
                Console.WriteLine(" - "+ " "+ effet);
            }



        }

    }
}
