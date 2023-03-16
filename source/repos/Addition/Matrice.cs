using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Matrice
    {
        private int NombreLigne;
        private int NombreColonne;
        private double [,] TableauMatrice ;
        public  void setNombreLigne(int n)
        {
           this.NombreLigne = n;
        }
        public int getNombreLigne()
        {
            return this.NombreLigne; 
            
        }

        public void setNombreColonne(int m)
        { 
            this.NombreColonne = m;
        }

        public int getNombreColonne() 
        {
            return this.NombreColonne;
        }

        //public int Nombre { set; get; }

        //Creation du constructeur 
        public Matrice(int n, int m)
        {
            this.NombreLigne=n;
            this.NombreColonne=m;
        }
        //Creation des methodes
        public void RemplirMatrice()
        {
            this.TableauMatrice = new double[this.NombreLigne,this.NombreColonne];  
            Console.WriteLine("Remplissez la matrice");
            for (int i = 0; i <this.NombreLigne; i++) //Navigation par ligne
            {
                for (int j = 0; j < this.NombreColonne; j++) //Navigation par colonne
                {
                    Console.WriteLine("La valeur a la ligne " +i+ " et a la colonne " +j);

                    this.TableauMatrice[i,j] = double.Parse(Console.ReadLine());
                }

            }

        }

        public void AfficherMatrice()
        {
            Console.WriteLine("Voici la forme de la matrice");

            for (int i = 0; i < this.NombreLigne; i++) //Navigation par ligne
            {
                for (int j = 0; j < this.NombreColonne; j++) //Navigation par colonne
                {
                    Console.Write(this.TableauMatrice[i,j] +" ");
                }
                Console.WriteLine();

            }
        }
    }

}
