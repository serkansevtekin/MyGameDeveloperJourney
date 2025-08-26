using System;

namespace Programlama.OperatorlerNameSpace
{
    public class Operatorler
    {
        public static void OperatorlerMethod()
        {
            /*
            - Aritmetik Operatörler
                  + , - , / , * , %
            
            - İlişkisel Operatörler
                  < , <= , > , >= , == , !=

            -Mantıksal Operatörler
                  && (ve) , || (veya) , ! (değil / not)

               " Doğruluk Tablosu"

            */

            int A = 20, B = 10;

            //Aritmetik Operatörler -> + , - , / , * , %
            ArtimetikOperatorlerMethod(A, B);

            //İlişkisel Operatörler ->  < , <= , > , >= , == , !=
            IliskiselOperatorlerMethod(A, B);

            //Mantıksal Operatörler ->  && (ve) , || (veya) , ! (değil / not)
            MantiksalOperatorlerMethod(A, B);

        }

        private static void MantiksalOperatorlerMethod(int A, int B)
        {
            System.Console.WriteLine(A > B && A > 5);//True
            System.Console.WriteLine(A > B && A < 5);//False
            System.Console.WriteLine(!(A > B && A < 5));//False => !False = True oluyor
            System.Console.WriteLine(A < B || B > 5);// False || True => True
        }

        private static void IliskiselOperatorlerMethod(int A, int B)
        {
            System.Console.WriteLine(A > B);
            System.Console.WriteLine(A < B);
            System.Console.WriteLine(A >= B);
            System.Console.WriteLine(A <= B);
            System.Console.WriteLine(A == B);
            System.Console.WriteLine(A != B);
        }

        private static void ArtimetikOperatorlerMethod(int A, int B)
        {
            System.Console.WriteLine(A + B);
            System.Console.WriteLine(A - B);
            System.Console.WriteLine(A * B);
            System.Console.WriteLine(A / B);
            System.Console.WriteLine(A % B);
        }
    }
    
}