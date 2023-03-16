using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuMotCaché
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //Declaration des variables
            int EntierSaisi;
            int BorneInferieur;
            int BorneSuperieur;
            int Tentative = 0;
            string Reponse;

            //Création d'une liste qui contint les parties que l,utilisateur va jouer
           ArrayList PartiesJouées = new ArrayList();

            //Debut du jeu on va utiliser la boucle do........ while car on ne connait pas le nombre de parties que le joueur va effectuer
            //et on joue au moins une fois
            do
            { 

                int nbC = new Random().Next(0, 100);
             ArrayList tentatives = new ArrayList();
                BorneInferieur = 0;
                BorneSuperieur = 100;
                // On va encore utiliser une boucle do....while pour repeter la saisie du nombre jusqu'a trouver le nombre caché
                PartiesJouées:
                do
                {
                    Console.WriteLine("EntierSaisi "+BorneInferieur  +BorneSuperieur);
                    EntierSaisi=Console.ReadLine().ToUpper();
                    //Utilisation de strcture conditionnelle if qui ne fait rien si le l'Entier saisi est en dehors des Bornes
                    if(EntierSaisi>=BorneSuperieur || EntierSaisi<=BorneInferieur) continue ;
                    tentatives++;
                }
                }
                  

                    

        }
    }
}
