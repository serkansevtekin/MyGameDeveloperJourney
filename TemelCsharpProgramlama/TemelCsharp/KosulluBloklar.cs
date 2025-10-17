using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class KosulBloc
    {
        public static void KosulBlocRun()
        {
            IfElse();
        }

        private static void IfElse()
        {
            string userName = "serkan";
            string password = "123";
            if (userName == "serkan" )
            {
                if (password == "123")
                {
                    System.Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    System.Console.WriteLine("Parola hatalı");
                }
               
            }
            else
            {
                System.Console.WriteLine("Giriş Başarısız UserName Hatalı");
            }



        }
        private static void SwihCase()
        {
            
        }
    }
}