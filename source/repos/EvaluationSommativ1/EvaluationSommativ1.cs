using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommativ1
{
    class Program
    {
        static void Main(string[] args)
        {
            JeuxAleatoire();
        }
        static void JeuxAleatoire()
        {
            string str;
            List<int> PremiereListeduJeux = new List<int>();
            List<int> DeuxiemeListeduJeux = new List<int>();
            //Utilisation de la boucle do while car on ne connait pas le nombre d'execution et on ne s'sest pas si n execute d'adord
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Jeu d'entertainment sur les opérateurs d'addition, soustraction et multiplication.");
                Console.WriteLine("Réalisé par :Bocte Ange Pascal");
                Console.WriteLine("Numéro d'inscription : 2702318");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("********************Partie 1*************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Tu veux t'entrainer sur quel opérateur ?");
                Console.WriteLine("Addition : +");
                Console.WriteLine("Soustraction : -");
                Console.WriteLine("Multiplication : *");
                Console.WriteLine("Mixte : M");
                char charactere ;
                Console.Write("Merci de faire ton choix : ");
                charactere = Console.ReadLine()[0];
                int count;
                Console.Write("Donner le nombre de questions d'entertainement : ");
                count = Convert.ToInt32(Console.ReadLine());
                int[] TableauDejeux = new int[count * 3];
                int PremierEntier, DeuxiemeEntier, ResultatOperation, NombreEntierNul = 0, incorrect = 0;
                char DebutFonction, resultat;

                Random rnd = new Random();


                


                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"********** Question {i + 1} **********");
                    PremierEntier = rnd.Next(15);
                    DeuxiemeEntier = rnd.Next(15);
                    Console.Write($"{PremierEntier} {charactere} {DeuxiemeEntier} = ");
                    ResultatOperation = Convert.ToInt32(Console.ReadLine());
                    if (charactere == '+')
                    {
                        if (PremierEntier + DeuxiemeEntier != ResultatOperation)
                        {
                            TableauDejeux[NombreEntierNul] = PremierEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = DeuxiemeEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = ResultatOperation;
                            NombreEntierNul++;
                            incorrect++;
                        }
                    }
                    else if (charactere == '-')
                    {
                        if (PremierEntier - DeuxiemeEntier != ResultatOperation)
                        {
                            TableauDejeux[NombreEntierNul] = PremierEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = DeuxiemeEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = ResultatOperation;
                            NombreEntierNul++;
                            incorrect++;
                        }
                    }
                    else if (charactere == '*')
                    {
                        if (PremierEntier * DeuxiemeEntier != ResultatOperation)
                        {
                            TableauDejeux[NombreEntierNul] = PremierEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = DeuxiemeEntier;
                            NombreEntierNul++;
                            TableauDejeux[NombreEntierNul] = ResultatOperation;
                            NombreEntierNul++;
                            incorrect++;
                        }
                    }

                }
                Console.WriteLine("***********************************************");
                Console.WriteLine($"Le resultat du QUIZ est {incorrect}/{count}");
                Console.WriteLine("Reponses incorrectes :");
                for (int i = 0; i < NombreEntierNul; i += 3)
                {
                    PremierEntier = TableauDejeux[i];
                    DeuxiemeEntier = TableauDejeux[i + 1];
                    ResultatOperation = TableauDejeux[i + 2];
                    Console.WriteLine($"{PremierEntier} {charactere} {DeuxiemeEntier} = {ResultatOperation} La bonne reponse {PremierEntier + DeuxiemeEntier}");
                }
                PremiereListeduJeux.Add(incorrect);
                DeuxiemeListeduJeux.Add(count);
                Console.WriteLine("Veux tu continuer ton entrainment (Oui / Non) ?");
                str = Console.ReadLine();
            } while (str != "Oui");
            Console.WriteLine("==============================================");
            int sum = 0;
            for (int i = 0; i < PremiereListeduJeux.Count; i++)
            {
                sum += (PremiereListeduJeux[i] * 100 / DeuxiemeListeduJeux[i]);
            }
            sum /= DeuxiemeListeduJeux.Count;
            Console.WriteLine($"La moyenne de tes est : {sum} / 100");
            for (int i = 0; i < PremiereListeduJeux.Count; i++)
            {
                Console.WriteLine($"Resultant partie {i + 1} : {PremiereListeduJeux[i]} / {DeuxiemeListeduJeux[i]} ==>  {(PremiereListeduJeux[i] * 100 / DeuxiemeListeduJeux[i])} %");
            }
            Console.WriteLine("Bravo! Tu as bien travaillé tu peux reposer :-)");
            Console.WriteLine("================================================");
        }
    }

}


