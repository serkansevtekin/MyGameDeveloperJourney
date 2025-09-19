using System;
using System.Collections;

namespace Programlama.AlgoritmaTasarimi
{
    class IEnumerationAndIEnumerableClass
    {
        public static void IEnumerationAndIEnumerableRunMain()
        {
            //  IEnumeratorKullanimi();

            MyCollection col = new MyCollection();
            foreach (int item in col)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            //Tam Generic Collection Kullanımı

            System.Console.WriteLine("Tam Generic Collection Kullanımı string");

            var stringCol = new TamGenericCollection<string>() { "Kemal", "Ahmet", "Mehmet", "Kemal" };
            foreach (string item in stringCol)
            {
                System.Console.WriteLine(item);
            }

            //birde int için yapalım
            System.Console.WriteLine("\nTam Generic Collection Kullanımı int");

            TamGenericCollection<int> intCol = new TamGenericCollection<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 11, 12, 12, 14, 15 };
            foreach (int item in intCol)
            {
                System.Console.WriteLine(item);
            }

        }

        #region Ornek 1 |  
        internal static void IEnumeratorKullanimi()
        {

            //string bir kolleksiyon olarak kullanıyorzu
            string s = "Merhaba";

            //GetEnumerator() çağrısı ile bu kolleksiyonun üzeride gezici (iterator) alıyorsun
            //Bu dönen şeyin tipi IEnumerator
            //Bunu rator değişkenine atıyorum
            //Yani rator, artık kolleksiyonun içindeki elemanları gezinecek bir nesne
            IEnumerator rator = s.GetEnumerator();
            try
            {
                //while döngüsü: kooeksiyonda ilerlemek için MoveNext() çağrılır
                //MoveNext() true döndükçe sıradki elemana geçilir
                while (rator.MoveNext())
                {
                    //Current: o anki elemanı döner
                    //IEnumerator.Current object döndürür, bu yüzden char'a cast ediyoruz
                    char c = (char)rator.Current;

                    // Her karakteri ekrana yazdırıyoruz
                    System.Console.Write(c + " . ");
                }
            }
            finally // finally bloğu, try bloğu içinde bir hata olsun ya da olmasın, her zaman çalıştırılan kod bloğudur.
            {
                // Döngü veya işlem bittiğinde enumerator IDisposable implement ediyor.
                //Böylece gereksiz kaynaklar serbest bırakılır
                //Preformans Artışı

                //Uzun yazım
                //rator nesenesini IDisposable tipine çevirmeye çalışıyoruz
                IDisposable? disposableRator = rator as IDisposable;

                //Eğer rator IDisposable implement ediyorsa (null değilse) Dispose() çağır
                if (disposableRator != null)
                {
                    disposableRator.Dispose();
                }


                //Kısa yazım
                //  (rator as IDisposable)?.Dispose(); 
            }
        }
        #endregion
    }

    #region Ornek 2 Generic olmayan | IEnumerable

    // internal : sadece aynı assembly içinden erişilebilir
    //MyCollection sadece okuma ve gezinme destekliyor,
    internal class MyCollection : IEnumerable
    {
        // Kolleksiyon verisi, burada basit bir int array
        int[] data = { 1, 2, 3, 4 };

        //IEnumerable arayünü implement etmek için GetEnumerator metodu
        public IEnumerator GetEnumerator()
        {
            // foreach ile array'in içindeki elemanları tek tek dolaşıyoruz
            foreach (int item in data)
            {
                // yield return ile enumerator'a sıradaki elemanı veriyoruz
                yield return item;
            }
        }
    }
    #endregion

    #region Ornek 3 Generic version | IEnumerable
    internal class MyGenericCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    #endregion


    #region ORNEK TAM GENERİC VERSİON ONEMLİ | IEnumerable
    /*
    Generic Collection Wrapper (Generic Collection Class)
        - Bir generic class (T parametreli) oluşturuyorsun
        - İçinde bir kolleksiyon (List<T>, Dictionary<TKey,TValue>, HashSet<T> vb.) tutuyorsun
        //Bu sınıf kolleksiyonun arayüzü sarmalıyor (wrap ediyor) ve ekstra davranış eklemeni sağlıyor

    ANA KISIM
    internal class TamGenericCollection<T> : IEnumerable<T>
    {
         private List<T> data;w
         ...
    }

        
    */
    // Generic bir koleksiyon sınıf oluşturuyoruz
    // T = koleksiyonun eleman tipi (int, string, obje vb)
    internal class TamGenericCollection<T> : IEnumerable<T>
    {
        private List<T> data; // Elemanları saklamak için List<T> kullanıyoruz

        //Costructor: sınıf örneği oluşturulduğunda List<T> de başlatılır
        public TamGenericCollection()
        {
            data = new List<T>();
        }

        //eleman ekleme metodu
        public void Add(T item)
        {
            //Basit bir validasyon: Aynı elemanı birden fazla eklememek için
            if (!data.Contains(item))
            {
                //eğer yoksa burası çalışıp Add metotu ile data listesine eleman eklenecek
                data.Add(item);
            }
        }
        // IEnumerable<T> implementasyonu: Generic enumerator
        //data.GetEnumerator() çağrısı ile data listesinin enumerator’ını alıyoruz, böylece dışardan TamGenericCollection de foreach ile gezilebilir.
        //GetEnumerator() listeyi değil, listeyi gezmeyi sağlayan enumerator nesnesini döndürür.
        //Sen enumerator üzerinden sırayla elemanları alırsın, ama listeyi direkt elde etmezsin
        public IEnumerator<T> GetEnumerator() => data.GetEnumerator(); // data.GetEnumerator() → data listesini gezmeyi sağlayan nesne verir.

        // IEnumerable implementasyonu: Non - generi enumerator
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    #endregion

    #region Tanım
    /*
    IEnumerable ve IEnumerator aslında kolleksiyonların foeach ile dönemsinin sağlayan iki temel interface. Ama aralarındaki farkı net bilmek çok önemli

        IEnumerable:
            - IEnumerable, "Benim içimde gezinebilirsin" demek.       
            - İçinde sadece GetEnumerator() metodu var.
            - Yeni foreach çalışığında, ilk yaptığı şey.

        IEnumerator:
            - IEnumerator, gezintiyi konrole eden şey.
            - Yani koleksiyonun elemanlarını sırasıyla dolaşır.
            - İçinde:
                * Current -> Şu anki eleman
                * MoveNext() -> Sonraki elemana geç
                * Reset() -> başa dön (çoğu zaman kullanılmaz)

    Unity ile Bağlantısı
        - Unity'de IEnumerator çok sık karşına çıkar çünkü corotine'ler (StartCoroutine) IEnumerator döner.

                using UnityEngine;
                using System.Collections;

                public class Example : MonoBehaviour
                {
                    void Start()
                    {
                        StartCoroutine(MyRoutine());
                    }

                    IEnumerator MyRoutine()
                    {
                        Debug.Log("Step 1");
                        yield return new WaitForSeconds(2);
                        Debug.Log("Step 2");
                    }
                }
        - Yukarıda IEnumerator, Unity'ye "adım adım çalıştırılabilecek bir iş" veriyor
        - yeild return ile Unity her frame konrol ediyor, zaman dolduğunda sıradaki adıma geçiyor

        🔑 Özet:

            - IEnumerable → foreach için kapıyı açar, bir enumerator döner.
            - IEnumerator → foreach’in adım adım nasıl ilerleyeceğini söyler.
            - Unity’de IEnumerator → coroutine’ler için kullanılır.

    */
    #endregion
}