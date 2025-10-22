using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Donguler
    {
        public static void DongulerRun()
        {
            // ForDongusu();
            // WhileDongusu();
            // DoWhileDongusu();
            // ForeachDongusu();
           if (OrnekIsPrimeNumber(7))
           {
            System.Console.WriteLine("This is a prime number");
            }
            else
            {
                System.Console.WriteLine("This is not a prine number");
            }
        }

        private static void ForDongusu()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("Finished!");
        }
        private static void WhileDongusu()
        {

            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;
            }
            System.Console.WriteLine($"Now i is {0}", i);
        }
        private static void DoWhileDongusu()
        {
            int i = 0;
            do
            {
                System.Console.WriteLine(i);
                i++;

            } while (i < 100);

        }
        private static void ForeachDongusu()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach(var item in students)
            {
               
                System.Console.WriteLine(item);
            }

        }
        private static bool OrnekIsPrimeNumber(int number)
        {

            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break; // veya i = number - 1
                }
            }
            return result;

        }


    }
}