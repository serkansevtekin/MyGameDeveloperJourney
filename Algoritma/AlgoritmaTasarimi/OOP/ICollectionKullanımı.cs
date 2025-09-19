using System;


namespace Programlama.AlgoritmaTasarimi
{
    class ICollectionClass
    {
        public static void ICollectionClassRunMethod()
        {
            ICollection<string> meyveler = new List<String>();
            meyveler.Add("Elma");
            meyveler.Add("Armut");
            meyveler.Add("Muz");

            System.Console.WriteLine("\nİlk Meyve " + meyveler.First()); // indexleme

            System.Console.WriteLine("Koleksiyon Boyutu: {0}", meyveler.Count);

            System.Console.WriteLine("\n2. index silindikten sonra:");

            foreach (var item in meyveler)
            {
                System.Console.WriteLine(item);
            }

            meyveler.Remove("Muz");
            System.Console.WriteLine("Muz sizilndi. Yeni koleksiyon Boyutu: {0}", meyveler.Count);

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