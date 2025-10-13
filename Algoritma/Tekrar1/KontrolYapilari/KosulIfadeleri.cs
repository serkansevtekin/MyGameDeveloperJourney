using System;

namespace Programlama.Tekrars1
{
    public class KosulIfadeleriCLass
    {
        public static void KosulIfadeleriRunMet()
        {
             System.Console.WriteLine("\n---- If Else If Else---");
            IFelseElseIf(60);

            System.Console.WriteLine("\n---- Switch---");
            SwitchCase(3);
        }

        private static void IFelseElseIf(int healtValue)
        {
      
            if (healtValue <= 0)
            {
                System.Console.WriteLine("GameOver!");
            }
            else if (healtValue < 50)
            {
                System.Console.WriteLine("Healt low! Find a medkit");
            }
            else
            {
                System.Console.WriteLine("You're healthy");
            }
        }

        private static void SwitchCase(int playerHealt)
        {

            // Pattern matching özelliği -> case int n when n < 0:
            //case int n -> playerHealt değerini int türünden n değişkenine ata
            //when < 0 -> sadece n < 0 koşulu doğruysa bu case çalışsın
            //Kısaca: when → ek koşul eklemeye yarıyor.
            switch (playerHealt)
            {
                case int n when n < 0: System.Console.WriteLine("GameOver!"); break;
                case int n when n < 50: System.Console.WriteLine("Healt low! Find a medkit"); break;
                default: System.Console.WriteLine("You're healthy"); break;
            }
            
            switch (playerHealt)
            {
                case 1: System.Console.WriteLine("Player healt " + playerHealt); break;
                case 2:
                case 3:
                case 4: System.Console.WriteLine(" 2 , 3 yada 4 değerinden biri geldi: " + playerHealt); break;
                
            }
        }
    }
    

    
}