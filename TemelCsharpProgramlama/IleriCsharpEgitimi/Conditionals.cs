using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Conditionals
    {
        public static void ConditionalsRunMethod()
        {
            // if || else if || else
            var number = 91;

            if (number == 10)
            {
                System.Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                System.Console.WriteLine("number is 20");

            }
            else
            {
                System.Console.WriteLine("Number is not 10");
            }




            // Ternary operator (? :)
            System.Console.WriteLine(number == 10 ? "Number is 10 " : "Number is not 10");






            // Örnek (Bir sayının 100 lük dilimlerde nereye geldiği)
            if (number >= 0 && number <= 100)
            {
                System.Console.WriteLine("Number is between 0 - 100");
            }
            else if (number > 100 && number <= 200)
            {
                System.Console.WriteLine("Number is between 100 - 200");

            }
            else if (number > 200 || number < 0)
            {
                System.Console.WriteLine("Number is less 0 or greater than 200");
            }


            // İç içe if

            if (number<100)
            {
                if (number>= 90 && number <95)
                {
                    System.Console.WriteLine("Number is between 90 and 94");
                }
            }







            // Switch
            switch (number)
            {
                case 10:
                    System.Console.WriteLine("number is 10");
                    break;
                case 20:
                    System.Console.WriteLine("number is 20");
                    break;
                case 30:
                    System.Console.WriteLine("number is 30");
                    break;

                default:
                    System.Console.WriteLine("number is not 10 or 20 or 30");
                    break;
            }


        }
    }
}