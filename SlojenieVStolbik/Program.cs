using System;

namespace SlojenieVStolbik
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max, Min;
            int Lenght1 = 0;
            int Lenght2 = 0;
            Console.WriteLine("Введите первое число");
            int Chislo1 = int.Parse(Console.ReadLine());
            int forlenght1 = Chislo1;
            Console.WriteLine("Введите второе число");
            int Chislo2 = int.Parse(Console.ReadLine());
            int forlenght2 = Chislo2;


            while (forlenght1 >= 1)
            {
                forlenght1 = forlenght1 / 10;
                Lenght1++;
            }


            while (forlenght2 >= 1)
            {
                forlenght2 = forlenght2 / 10;
                Lenght2++;
            }


            if (Lenght1 > Lenght2)

            {
                Max = Lenght1;
                //Min = Lenght2;
            }
            else
            {
                Max = Lenght2;
                //Min = Lenght1;

            }




            int[] arr1 = new int[Max];
            for (int i = arr1.Length - 1; i >= 0; i --)
            {

                arr1[i] = Chislo1 % 10;
                Chislo1 /= 10;

            }

            int[] arr2 = new int[Max];
            for (int i = arr2.Length - 1; i >= 0; i--)
            {

                arr2[i] = Chislo2 % 10;
                Chislo2 /= 10;

            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("--------------------------------");


            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

           


           int[] rez = new int[Max];

            for (int i = 0; i < rez.Length; i++)
                {
                  rez[i] = arr1[i] + arr2[i];
                }
            Console.WriteLine("--------------------------------");

           /* for (int i = Max-1; i > 1; i--)
            {
                rez[i] = (arr1[i] + arr2[i])%10;
                rez[i - 1] += (arr1[i] + arr2[i]) / 10;
            }*/

            for (int i = 0; i < rez.Length; i++)
            {
                Console.WriteLine(rez[i]);
            }
            
        }
        
        
    }
}
