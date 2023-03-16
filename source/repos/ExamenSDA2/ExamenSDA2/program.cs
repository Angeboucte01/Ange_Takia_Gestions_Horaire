using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSDA2
{
    // Nom: Boucte Ange Pascal
    internal class program
    {
        //EXERCICE 1
        //Methode permettant de remplir l'ensemble et de mettre les nombres paires dans resulatat2 et les nombres impaires dans resulat1
        static void RemplirEnsemble(HashSet<int> Valeurs, Stack<int> resultat1, Stack<int> resultat2)
        {
            int valeurAremplir;
            do
            {
                Console.WriteLine("Donner une valeur strictement positive à remplir dans l'intervalle 100 et 200");
                valeurAremplir = int.Parse(Console.ReadLine());
            }
            while (valeurAremplir <= 100 && valeurAremplir >= 200);

            for(int i = 0; i < Valeurs.Count; i++)
            {
                Valeurs.Add(valeurAremplir);
            }

           for(int i = 0; i < Valeurs.Count; i++)
            {
                if(valeurAremplir %2! == 0)
                {
                    resultat1.Push(valeurAremplir);
                    
                }
                else
                {
                    resultat2.Push(valeurAremplir);
                }
            }

        }

        static void AfficherResulatat1(Stack<int> resultat1)
        {
            Console.WriteLine("-------Resultat 1----------");
            foreach(var val1 in resultat1)
            {
                Console.WriteLine(""+val1);
            }
        }

        static void AfficherResulatat2(Stack<int> resultat2)
        {
            Console.WriteLine("-------Resultat 2----------");
            foreach (var val2 in resultat2)
            {
                Console.WriteLine("" + val2);
            }
        }

        





        //EXERCICE2




        static void Main(string[] args)
        {
            //Declaration de l'ensemble non ordonné nommé Valeurs
             HashSet<int> Valeurs = new HashSet<int>();


            Stack<int> resultat1 = new Stack<int>();
            Stack<int> resultat2 = new Stack<int>();
            //RemplirEnsemble(Valeurs);




            //EXERCICE 2
            //Declaration des structures
            string[] s = { "HP", "DELL", "ACER", "LENOVO", "SAMGUNG", "APPLE", "ASUS", "LG" };

            LinkedList<string> Marque = new LinkedList<string>(s);
            Queue<string> FileMarque = new Queue<string>(s);
            SortedSet<string> strings = new SortedSet<string>();


            AfficherListe(Marque);
            AfficherFIle(FileMarque);
            VerserDansLaFile(FileMarque,strings);


        }



        //Methode permettant d'afficher la file 

        static void AfficherFIle(Queue<string> FileMarque)
        {
            Console.WriteLine("-------------------Pile-----------------------");

            Console.Write("{");
            foreach (string s in FileMarque)
                Console.WriteLine(s);
            Console.Write("}");
        }

       //Methode permettant de verser  la file dans un Sorted
        static void VerserDansLaFile(Queue<string> FileMarque, SortedSet<string> strings)
        {
            foreach (string s in FileMarque)
            {
                FileMarque.Enqueue(s);
            }
        }
        //Methode permettant de faire l'union entre une liste non trié et une liste trié pour avoir une liste trié
        static void Union(LinkedList<string> Marque, SortedSet<string> strings, Queue<string> FileMarque)
        {
          strings.Union(Marque);
            VerserDansLaFile(FileMarque, strings);
        }
        //Methode permettant d'afficher la liste chaine
        static void AfficherListe(LinkedList<string> Marque)
        {
            Console.WriteLine("------------------------Liste chainée--------------------");
            Console.WriteLine("Marque ------>");
            foreach (string s in Marque)
                Console.WriteLine(s);
            Console.WriteLine("NULL");
        }



    }
}
