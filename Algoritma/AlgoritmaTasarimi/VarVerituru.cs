using System;

namespace Programlama.AlgoritmaTasarimi
{
    class VarVeriTuruClass
    {
        public static void VarVeriTuruMainMethod()
        {
            //Tanım
            var meyveler = new List<string>() { "elma", "armut", "muz", "üzüm", "şeftali", "ananas" };

            //LINQ kullanılmadan yapma 
            var aIleBasalayanMeyveler = new List<string>();
            foreach (string meyve in meyveler)
            {
                if (meyve[0] == 'a')
                {
                    aIleBasalayanMeyveler.Add(meyve);
                }
            }
            aIleBasalayanMeyveler.ForEach(a => System.Console.WriteLine(a));


            //LinQ
            /*   var meyve = from m in meyveler where m[0] == 'a' select m;

             foreach (string m in meyve)
            {
                Console.Write(m)
            }
             */

        }

        #region Tanım
        /*
            -- Var - Implicity typed ( Örtük tip belirleme )
        - Değişken tanımı yapılırken tip beliritlmede var deyimi kullanılabilir.
        - " var " ifadesi ile tanımlanan değişkenler için ilk değer ataması yapılmalıdır

        - Değişkenin tipi kullanılan veri türüne bağlı olarak C# tarafından otomatik olarak belirlenecektir.

            var x = 23; // Implicity typed ( Örtük tip belirleme )
            int y = 23; // Explicity typed ( Açık tip belirleme )

            -- GetType --
        - Kullanılan ya da tanımlanan veri türünün tipini (type) öğrenmek için "GetType" deyimi kullanılmaktadır.

            -- object ile dynamic arasındaki fark --

        - object -> daha güvenli ama her kullanımda " cast " zorunlu
        - dynamic -> daha esnek ama " hata riski çalışma zamanına kayar "
        */

        #endregion
    }
}