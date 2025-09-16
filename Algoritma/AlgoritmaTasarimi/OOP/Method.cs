using System;
namespace Programlama.AlgoritmaTasarimi
{
    class ClassMethods
    {
        /* public static void ClassMethodsMain()
        {

        } */

        // Klasik Yazım
        public bool KareMi(int x, int y)
        {
            return x == y;
        }

        //Expression-Bodied Methods (Kısa yazım)

        public bool KareMiKisa(int x, int y) => x == y;




        /*  Methods (Metodlar)

        Syntax
            [modifiers] return_type MethodName([paramaters])
            {
                // Method body
            }

        - Modifiers (Değiştiriciler):
            public, private , protected, internal, static, virtual, abstract vb.
        
        - return_type (geri dönüş tipi):
            Metodun geriye döndürdüğü veri tipi (int,int[] , string, strin[] , bool, void , vb )
        
        - MethodName (Metodun ismi)

        - parameter (parametreler):
            Metodun aldığo parametreler, tip + isim ile yazılır (int a, string b, bool c, char e, int[] aDizi, vb.)



        //////// Tuple Methods
        - Bir methodun birden fazla değer döndürebilmesi için kullanılan bir yapıdır.
        - C# 7 ve sonrası ile geldi
        - Eski yöntemlde birden fazla değer döndürmek için oyu parametreleri kullanılırdı. Turple daha temiz ve okunaklı

           - Syntax-  ... diye istersen devam ediyor demek
        
           [modifiers] (return_type1, return_type2 ...) MethodName([parameters])
           {
           int deger1=0, deger2=1;
            // Method body
            //ör: deger1 ile return_type1 dönüş tipi aynı olmalı
            return (deger1,deger2, ...);
           }


        örnek kullanım Tuple Elemanlarına İsim Verme

        public static (int toplam, int fark) ToplaVeFark(int a, int b)
        {
            return (a + b, a - b);
        }
        
        // Kullanım main method içi
        var sonuc = ToplaVeFark(10, 4);
        Console.WriteLine(sonuc.toplam); // 14
        Console.WriteLine(sonuc.fark);   // 6


        */
    }
}