using System;


namespace Programlama.AlgoritmaTasarimi
{
    class IListClass
    {
        public static void IListClassRunMethod()
        {
            IList<string> sehirler = new List<String>();
            sehirler.Add("İzmir");
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");

            System.Console.WriteLine("\nİlk Şehir " + sehirler[0]); // indexleme

            sehirler.Insert(0, "Bursa"); // 0. indexe ekleme

            foreach (var item in sehirler)
            {
                System.Console.WriteLine(item);
            }

            sehirler.RemoveAt(2); // 2. İndexteki elemanı silme

            System.Console.WriteLine("\n2. index silindikten sonra:");
            
            foreach (var item in sehirler)
            {
                System.Console.WriteLine(item);
            }

        }
        
        #region IList<T> Tanım
            /*
            - ICollection<T>'yi genişletir, yani tüm ICollection özelliklerine sahiptir.
            - Sıralı koleksiyon sağlar; indexleme ile elemanlara erişebilirsin(myList[0] gibi)
            - Belirli bir konuma eleman ekleme veya çıkarma imkanı vardır. (Insert, RemoveAt)
            */
        #endregion
    }
}