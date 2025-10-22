using System;

namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class Methods
    {
        public static void MethodsRun()
        {
            //parametresiz metot
            Add();

            //Parametreli metot
            int result = Add2(20, 30);
            System.Console.WriteLine(result);

            //Default parametreli metot
            int result2 = Add3(20);
            System.Console.WriteLine(result2);


            //Challange Ref Keyword ->
            int n1 = 100; // değerin set edilmesi zorunlu  "ref" ile
            int n2 = 40;
            int result3 = Add4(ref n1, n2);

            System.Console.WriteLine(result3);
            System.Console.WriteLine(n1);

            //Challange Out Keyword
            int o1; //değeri atamadan gönderebiliri "out". metot içinde set etmek zorundayız
            int o2 = 40;
            int result4 = Add5(out o1, o2);

            System.Console.WriteLine(result4);
            System.Console.WriteLine(o1);

            //Method Overloading

            System.Console.WriteLine(Multiply(2, 4));
            System.Console.WriteLine(Multiply(2, 4, 3));


            //Challange Params Keyword
            System.Console.WriteLine(Add6(1,2,3,4,5,6,7,8,9,10,11));


        }

        /*
        Method -> Bir işi yapan, kodu gurulayan fonksiyon blogudur.
                  Amaç: Kodu tekrar kullanılabilir hale geritmek
        */

        //Parametresiz metot
        static void Add()
        {
            System.Console.WriteLine("Added!!!");
        }


        //Parametreli Metot
        static int Add2(int number1, int number2)
        {
            int sonuc = number1 + number2;
            return sonuc;
        }

        //Default Parametreli Metot (Default değerler herazman en sonda olmalı)
        static int Add3(int number1, int number2 = 30)
        {
            int sonuc = number1 + number2;
            return sonuc;
        }

        //Challange Ref Keyword -> "ref" değer tiplerin referans tip gibi davranmasını sağlar
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Out Keyword ile çalışmak -> "out" 
        static int Add5(out int number1, int number2)
        {
            number1 = 30; // "out" kullanıyorsak metot içinde set etmek zorundayız
            return number1 + number2;
        }

        //Method Overloading (Metotları aşırı yükeleme)
        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        //Aşırı yükelenen method
        static int Multiply(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }
        
        //Params Keyword -> Değişken sayıda parametre alır
        static int Add6(params List<int> numbers)
        {
            return numbers.Sum(); // dizideki bütün sayıları topla
        }
    }

    /*
    
    | Tür        | Açıklama                                            | Örnek                         |
| ---------- | --------------------------------------------------- | ----------------------------- |
| **  Normal  ** | Kopya gönderir                                      | `void Foo(int x)`             |
| **  ref  **    | Referansla gönderir (önceden atanmış olmalı)        | `void Foo(ref int x)`         |
| **  out  **    | Dışarıya değer döndürür (önceden atanması gerekmez) | `void Foo(out int x)`         |
| **  params  ** | Değişken sayıda parametre alır                      | `void Foo(params int[] nums)` |

    */
}