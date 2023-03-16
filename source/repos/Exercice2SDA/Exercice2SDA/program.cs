using System;


namespace Exercice2SDA
{
     class program
     {
        public static int Somme(int n)
        {
            int sommeChriffresPaires = 0;
            if ( n < 2)
            {
                sommeChriffresPaires = n;
            }
            else if ((n % 10) + Somme(n / 10)%2 != 0)
            {
                sommeChriffresPaires = (n % 10) + Somme(n / 10);
            }
            return sommeChriffresPaires;
        }
        static void Main(string[] args)
        {
            int num = 24765;
            int result = Somme(num);
            Console.WriteLine(result);

        }
     }
}
