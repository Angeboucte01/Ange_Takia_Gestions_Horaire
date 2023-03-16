using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre007
{
    internal class Ordinateur
    {
        private int capacite = 120;      //Valeur par defaut c'est 120 

       /* public int getCapacite() { return capacite; }
        public void setCapacite(int capacite) { this.capacite = capacite;}*/
       
        //la capacite doit etre positive si non on affecte 128
        public int Capacite
        {
            get { return capacite; }
            set 
            {
                if (value > 0) capacite = value;
                else capacite = 128;     
            }
            //capacite = value > 0 ? value :128;
        }
        private int ram;
        public int Ram
        {
            get { return ram; }
            set { ram = value>8 ? value : 8; }
        }


        private int tailleEcran;

        public int TailleEcran
        {
            get { return tailleEcran; }
            set { tailleEcran = value> 15 ? value : 15; }
        }
        public bool TypeEcran { get; set; }         //Valeur par defaut c'est 120 
        public  string TypeOrdi { get; set; }         //Valeur par defaut c'est 120



        /*Je veux créer un ordinateur avec une ram,
     * une capacite, 
     * une taille d'ecran,
     * un type d''ecran, 
     * et un type d'ordi*/

        // Il faut créer un constructeur personnalisé


        public Ordinateur(int capacite, int ram, int tailleEcran, bool typeEcran, string typeOrdi) 
        { 
            this.Capacite = capacite;
            this.Ram = ram;
            this.TailleEcran =tailleEcran;
            this.TypeEcran = typeEcran;
            this.TypeOrdi = typeOrdi; 
        }

        public Ordinateur(int capacite, int ram, int tailleEcran, bool typeEcran, string typeOrdi, string marque)

         {
             this.Capacite = capacite;
             this.Ram = ram;
             this.tailleEcran=tailleEcran;
             this.TypeEcran = typeEcran;
             this.TypeOrdi = typeOrdi + "de marque" + marque;
        }
    // je veux un ordinateur specifiant la ram et la capacite

    public Ordinateur(int capacite, int ram)
        {
            Capacite = capacite;
            ram = ram;
        }


        //Ecrire une methode permettant d'afficher un ordinateur
        /*
         * Arguments       : Non car les attributs sont dans les classes
         * Type de retour  : Aucun
         * Role            : Afficher les caracteristiques de l'objet ordinateur 
         */
        public void Afficher()
        {
            Console.WriteLine($"Capacite : {Capacite} Go");
            Console.WriteLine($"RAM : {Ram} Go");
            Console.WriteLine($"Taille écran : {TailleEcran} Pouces");
            Console.WriteLine($"Ecran Tacticle : {TypeEcran} ");
            Console.WriteLine($"Type ordinateur : {TypeOrdi} ");

        }

        //Ecrire une methode permettant d'augmenter la d'un ordinateur
        /*
         * Arguments       : int newRam représentant la valeur a ajouter
         * Type de retour  : Aucun
         * Role            : Augmenter la Ram de l'objet ordinateur 
         */
        public void AugmenterRam(int newRam)
        {
           Ram += newRam;
        }

        //Ecrire une méthode nommée conversion qui permet de retourner la valeur de la Capacité en To 

        /*
        * Arguments       : Aucun
        * Type de retour  : int qui represente la valeur de la capacité en To
        * Role            : Conversion de la capacité en To 
        */

        public int Conversion()
        {
            return capacite/1024;
        }
    }
}
