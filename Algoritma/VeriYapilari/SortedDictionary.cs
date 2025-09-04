using System;

namespace Programlama.VeriYapilari
{
    class SortedDictionaryClass
    {
        public static void SortedDictionaryMainMethod()
        {
            TemelBilgilerMethod();
        }

        private static void TemelBilgilerMethod()
        {
            //Tanımlama Normal Dictinoary
            //Örnek
            var kitapIndex = new SortedDictionary<string, List<int>>()
            {
                {"FTP", new List<int>(){3,5,7}},
                {"HTML",new List<int>(){8,10,12}},
                {"ASP.NET",new List<int>(){50,60}}
            };
            kitapIndex.Add("CSS", new List<int>() { 70, 80, 90 });
            kitapIndex.Add("JQUERY", new List<int>() { 3, 5, 15 });
            kitapIndex.Add("SQL", new List<int>() { 70, 80 });

            //Döngü -> var  = KeyValuePair<string,List<int>> 
            foreach (var kavram in kitapIndex)
            {
                System.Console.WriteLine(kavram.Key);
                kavram.Value.ForEach(s => System.Console.WriteLine($"\t {s} pp"));
                
               /*  foreach (int sayfa in kavram.Value)
                  {
                      System.Console.WriteLine($"\t > {sayfa} pp");
                  } */
            }
        }
        
        #region Temel Bilgiler
        /*
            ** SortedDictonary<TKey,TValue> **

                - Dictionary sınıfında kullanılan metotlar ve özelliklerin tamamı bu kolleksiyon içinde kullanıla bilir
                -TKey - TValue Pairs | Anahtar - Değer çifti -> göre çalışır
                - Ekleme adımında sıralama işlemi de yapıldığı için bir miktar performans kabı gözlemlenebilir.
                -Sırlama işlemi TKey ifadesine göre yapılır



        */
        #endregion
    }
    
}