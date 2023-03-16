




















using System;
using System.Collections.Generic;



namespace Dictionnaire_2._1
{
    class Program
    {
        public static void AjouterElement(Dictionary<int, string> V)
        {
            int cle;
            string val;



            Console.WriteLine(" Donner la clé à ajouter");
            do
            {
                cle = int.Parse(Console.ReadLine());
            }
            while (cle < 0 || V.ContainsKey(cle) == true);



            Console.WriteLine(" Donner la ville à ajouter");
            do
            {
                val = Console.ReadLine();
            }
            while (val == "");



            V.Add(cle, val);



            Console.WriteLine(" La ville a été ajoutée avec succès");



        }



        public static void AjouterPlusieursElements(Dictionary<int, string> V)
        {
            int i, nbr;




            Console.WriteLine(" Donner le nombre de villes à ajouter");
            do
            {
                nbr = int.Parse(Console.ReadLine());
            }
            while (nbr < 0);



            for (i = 0; i < nbr; i++)
            {
                AjouterElement(V);
            }



        }



        public static void AfficherDictionnaire(Dictionary<int, string> V)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("  |  CLÉ  |  VILLE    ");
            Console.WriteLine("----------------------------");
            foreach (KeyValuePair<int, string> valeur in V)  // ON UTILSE KeyValuePair  CAR ON A DES COUPLES D'ELEMENT
            {
                Console.WriteLine("  |  " + valeur.Key + "    |  " + valeur.Value);
            }



            Console.WriteLine("----------------------------");



        }

        //METHODE PERMETTANT DE MODIFIER UNE VALEUR 
        public static void ModifierElement(Dictionary<int, string> V)
        {
            int cle;
            string NouvelleVal;



            Console.WriteLine(" Donner la clé à modifier");
            do
            {
                cle = int.Parse(Console.ReadLine());
            }
            while (V.ContainsKey(cle) == false);



            Console.WriteLine(" Donner nouvelle ville");
            do
            {
                NouvelleVal = Console.ReadLine();
            }
            while (NouvelleVal == "");



            V[cle] = NouvelleVal;



            Console.WriteLine(" La ville a été ajoutée avec succès");



        }
        /// <summary>
        /// Rechercher un element
        /// </summary>
        /// <param name="V"></param>
        public static void RechercherElement(Dictionary<int, string> V)
        {
            int cle;
            Console.WriteLine("Donner la cle à rechercher");
            cle = int.Parse(Console.ReadLine());
            if(V.ContainsKey(cle) == false)
            {
                Console.WriteLine("La clé n'existe pas dans le dictionaire");
            }
            else
            {
                Console.WriteLine("La clé " +cle+ "existe et la ville est :" + V[cle]);
            }
        }

        /// <summary>
        /// supprimer un element
        /// </summary>
        /// <param name="V"></param>
        public static void SupprimerElement(Dictionary<int, string> V)
        {
            int cle;
            Console.WriteLine("Donner la cle à supprimer");
            cle = int.Parse(Console.ReadLine());
            if (V.ContainsKey(cle) == false)
            {
                Console.WriteLine("La clé n'existe pas dans le dictionaire");
            }
            else
            { 
                V.Remove(cle);
                Console.WriteLine("La clé a été supprimé avec succès");
            }
        }

        public static void AfficherEnOrdreDictionnaire(Dictionary<int, string> V)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("  |  CLÉ  |  VILLE    ");
            Console.WriteLine("----------------------------");
            foreach (KeyValuePair<int, string> valeur in V)  // ON UTILSE KeyValuePair  CAR ON A DES COUPLES D'ELEMENT
            {
                Console.WriteLine("  |  " + valeur.Key + "    |  " + valeur.Value);
            }



            Console.WriteLine("----------------------------");



        }


        static void Main(string[] args)
        {
            Dictionary<int, string> Villes = new Dictionary<int, string>() { { 1, "Ottawa" }, { 25, "Gatineau" }, { 34, "Toronto" }, { 4, "Moncton" }, { 59, "Montreal" }, { 6, "Vancouver" } };
            SortedDictionary<int, string> Ville = new SortedDictionary<int, string>() { { 1, "Ottawa" }, { 25, "Gatineau" }, { 34, "Toronto" }, { 4, "Moncton" }, { 59, "Montreal" }, { 6, "Vancouver" } };





            //Console.WriteLine(" La ville :" + Villes[3]);



            //AfficherDictionnaire(Villes);
            //AjouterPlusieursElements(Villes);
            // ModifierElement(Villes);
            //RechercherElement(Villes);
           // SupprimerElement(Villes);
            AfficherDictionnaire(Villes);
            AfficherEnOrdreDictionnaire(Villes);
        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dictionnaire_2._1
//{
//     class Program
//     {
//        //Methode permettant d'ajouter un l'element dans le dictionnaire
//         public static void Ajouterelement(Dictionary<int, string> V)
//         {
//            int cle; string val;

//            do
//            {
//                cle = int.Parse(Console.ReadLine());
//            }
//            while (cle < 0 || V.ContainsKey(cle) == true);
//            Console.WriteLine("Donner la ville à ajouter");
//            do
//            {
//                val = Console.ReadLine();

//            }
//            while (val == "");

//            V.Add(cle, val);
//            Console.WriteLine("La ville a été ajutée avec succès");

//         }

//        //Methode permettant d'ajouter plusieurs l'element dans le dictionnaire
//        public static void AjouterPlusieurselement(Dictionary<int, string> V)
//        {
//            int i, nbre; 
//            Console.WriteLine("Donner le nombres de villes à ajouter");

//            do
//            {
//                nbre = int.Parse(Console.ReadLine());
//            }
//            while (nbre<0);
//              for(i = 0; i < nbre; i++)
//              {
//                Ajouterelement(V);
//              }

//        }




//        //Methode permettant d'afficher le dictionnaire
//        public static void AfficherDictionnaire(Dictionary<int, string> V)
//        {
//            Console.WriteLine("--------------------------");
//            Console.WriteLine("       CLÉ   |    VILLE   ");
//            Console.WriteLine("--------------------------");

//            foreach (KeyValuePair<int, string> valeur in V)  // On utilise KeyValuePair car c'est un couple de donnée qui est retourné
//            {
//                Console.WriteLine("    |   " +valeur.Key + "    |   " +valeur.Value);
//            }


//        }


//        static void Main(string[] args)
//        {
//            //Declaration du dictionnaire il prend une paire de paramètre c'est a dire 2 variables (1er elmt: c'est la clé et est unique 2ieme elmt:valeur)

//            Dictionary<int, string> Villes = new Dictionary<int, string>() { {1,"Ottawa"}, { 2, "Gatineau" }, { 3, "Toronto" }, { 4, "Moncton"}, { 5, "Montréal" }, { 6, "Vancouver" } };

//           // Console.WriteLine("La ville est : " + Villes[3]);

//            AfficherDictionnaire(Villes);
//            AjouterPlusieurselement(Villes);
//            AfficherDictionnaire(Villes);


//        }
//    }
//}
