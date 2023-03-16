using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssuranceQualité
{
    internal class Debugage
    {
        //1. Créez 2 variables, une nommée Positif et l’autre nommée Negatif, toutes les deux de type Boolean.

        //2. Suivez cette procédure pour définir votre bloc If.
        //Positif et négatif sont à true -> Afficher dans la console : La lumière est allumée.
        //Positif est true mais Negatif est false -> Afficher dans la console : la lumière est éteinte.
        //Positif est faux mais Negatif est vrai -> Afficher dans la console : la lumière est éteinte.
        //Dans les autres cas -> Afficher dans la console : Veuillez brancher les deux cables pour allumer la lumière.

        //3. Soyez certain de faire des tests pour les tout les cas!


       
            static void Main(string[] args)
            {
                // programme corrigé


                int n = 0; // nombre saisi

                int factorielle = 1; // factorielle de n (n!)

                int copieN; // une copie de n



                Console.Out.WriteLine("Entrez un entier > 0");

                n = int.Parse(Console.In.ReadLine());

                copieN = n;



                /*

                 * Pour calculer la factorielle n!, on fait la mult.

                 * n * (n - 1) * (n - 2) * (n - 3)...

                 * dans un boucle while

                 */

                while (n >= 0)

                {

                    factorielle = factorielle * n;

                    n = n - 1;

                }



                Console.Out.WriteLine("La factorielle de " + copieN +

                                      " est " + factorielle);

                Console.In.ReadLine();

            }
        }
    }

