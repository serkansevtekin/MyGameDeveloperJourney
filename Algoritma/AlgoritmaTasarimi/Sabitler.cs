using System;

namespace Programlama.AlgoritmaTasarimi
{
    class SabitlerClass
    {
        public static void SabitlerMainMethod()
        {
            // TemeBilgilerMethod();

            OrnekUygulama();
        }

        #region Örnek Uygulama
        private static void OrnekUygulama()
        {
            var mC = new SampleClass(11, 22);
            System.Console.WriteLine($"x = {mC.x} - y = {mC.y}");
            System.Console.WriteLine($"C1 = {SampleClass.C1} - C2 = {SampleClass.C2}");
        }
        class SampleClass
        {
            public int x;
            public int y;
            public const int C1 = 5;
            public const int C2 = C1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

        }


        #endregion

        #region Temel Bigliler
       /*  static void TemeBilgilerMethod()
        {
            //Const Tanım
            const int c1 = 3;

            System.Console.WriteLine(c1);
        }


        // readonly
        readonly int c1;
        SabitlerClass()
        {
            c1 = 3;
        } */
        /* 
Sabitler -> 
*- const -* 

    Temel Noktalar
        - const ile tanımlanan değişkenin değeri derleme zamanında (compile-time) sabittir.
        - Değer bir kere atanır. sonradan değiştirilemez.
        - static gibi davranır, yani sınıf seviyesinde tanımlandığında tüm örnekler arasında ortaktır.
        - Sadece "sabit değerler" atana bilir
        - Staic ile const beraber kullanılmaz
        - Sabit bir değişkene sabit olmayan bir değişken atanamaz
        - Sabitler sabitlere katılabilier.
        - Sabitler oluşturulduğu yerde değeri verilmelidir.

- Readonly - Yapılandırıcı Method için önemli
- Sabit değerleri tanımlama üzere kullanılan anahtar kelimedir.
- Tanımlandığı anda değeri veirlebilir
-İstenilen durumlarda "Class Constructor", yani sınıfın yapılandırıcı metodu içinde de değeri verilebilir.

const vs readonly

    * const -> derleme zamanında sabit, sdece primitive/litral türler(int,double,string vb) için uygundur.

    * readonly -> çalışma zamanında(runtime) atama yapılabilir (constructor'da atanabilir).


*/
        #endregion


    }

}