using System;
using System.Runtime.CompilerServices;

namespace Programlama.IleriAlgoritma
{
    class ListOfTClass
    {
        public static void ListOfTRunMethod()
        {

            PropertiesMethod();
        }


        #region List<T> | Tanım
        /*
        - .Net'te generic, dinamik dizidir.
        - Özellik: Boyutunu otmatik artar ve küçülür
        - Tip güvenli: Sadece belirtilen T tipinde veri tutar
        - Array farkı: Array sabit uznulukludur, List<T> değil

        */
        private static void Tanim()
        {
            //int,string,bool,char,double ...
            var list1 = new List<int>();
            List<int> liste2 = new List<int>();

            //Kapasite belirterek tanımlama -> Başlangıçta kapasiyeti belirler performans için yararlı olabilir
            List<string> listr3 = new List<string>(100);


            // Koleksiyon intializer ile tanımlama -> doğrudan elemanlar ile başlanı
            var list4 = new List<int> { 1, 2, 3, 4, 5 };

            // Başka koleksiyondan tanımlama -> Diziyi veya başka bir IEnumerable<T> kolleksiyonunu List<T>'ye çevirir
            int[] array = { 10, 20, 30 };
            var list5 = new List<int>(array);

            //LINQ Method ile tanımlama -> Enumerable sınıfının metodları ile dinamik üretim yapılabilir
            List<int> list6 = Enumerable.Range(1, 10).ToList();

            // 1. Class içinde property kullanarak listeye eleman ekleme
            School sc = new School();
            sc.Students.Add(new Student("Ali"));
            sc.Students.Add(new Student("Pınar"));

            //2. Object initializer ile direkt liste oluşturma
            var sch = new List<Student>
            {

                new Student("Ayşe"),
                new Student("Hakan")
            };

            //BEST WAY
            var schoh = new School()
            {
                OkulAdi = "Mehmetçik Okulu",
                Students = new List<Student>
                {
                    new Student("Leman"),
                    new Student("Göktuğ")
                }
            };


            // 3. Constructor ile listeyi başlatma (SchoolListWithConstructor)

            var sclwc = new SchoolListWithConstructor(new List<Student> {
                     new Student(" Ahmet" ),
                     new Student(" SERKAN" ),

                     }
                );

            //Method kullanımı

            var lis = GetNum();


        }

        //Class içinde tanımlama -> List<T> sınıf property'si olarak tanımlanır | kullanımı yukarıda
        private class Student
        {
            public string? Name { get; set; }

            public Student(string? name)
            {
                Name = name;
            }
        }
        private class School
        {
            public string? OkulAdi { get; set; }
            public List<Student> Students { get; set; } = new List<Student>();
        }

        //Constructor ile kullanım Class List<T> | kullanımı yukarıda 
        private class SchoolListWithConstructor
        {
            public List<Student> Students { get; set; }

            public SchoolListWithConstructor(List<Student>? student = null)
            {

                Students = student ?? new List<Student>();

                // Uzun versiyon
                /* if (student != null)
                {
                    Students = student;
                }
                else
                {
                    Students = new List<Student>();
               } */
            }
        }

        //Method içinde döndürme -> Method Çıktısı doğrudan List<T> olabilir
        public static List<int> GetNum()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };
            return list;
        }

        #endregion


        #region List<T> | Properties

        /*
         - Count -> Listedeki eleman sayısı
         - Copacity -> İç depolama kapasites,
         - Item[Int32] -> (indexer) Belirtilen index ile erişim
            */

        #endregion


        #region List<T> | Methods

        /*
        - Add(T item) -> Listeye eleman ekler
        - AddRange(IEnumerable<T> collecyion) -> koleksiyon ekler
        - AsReadOnly() -> Salt okunur liste döner
        - BinarySearch(T item) -> ikili arama.
        - Clear() -> tüm elemanları siler
        - Contains(T item) -> içeriyor mu? kontrol eder
        - ConvertAll<TOutput>(Convert<T,TOutput>) -> Tip dönüştürür
        - CopyTo(T[] Array) -> Diziyi Kopyalar
        - Exists(Predicate<T>) -> Koşulu sağlayan var mı?
        - Find(Predicate<T>) -> ilk eşleşeni bulur
        - FindAll(Predicate<T>) -> Tüm eşleşenleri döner
        - FindIndex(Int32, Predicate<T>) -> İlk eşleşenin indexi
        - FindLast(Predicate<T>) -> Son eşleşen döner
        - FindLastIndex(Predicate<T>) -> Son eşleşenin indexi
        - ForEach(Action<T>) -> Her elemana işlem uygular
        - GetEnumerator() -> Enumerator döner
        - GetRange(Int32, Int32) -> Belirli aralıktaki elemanlar
        - IndexOf(T item) -> ilk index
        - LastIndexOf(T item) -> Son index
        - Insert(Int32, T item) -> Belirtilen indexe ekler
        - Remove(T item) -> ilk bulduğunu siler
        - RemoveAt(Int32) -> index'e göre siler
        - RomoveAll(Predicate<T>) -> Koşula uyanları siler
        - RemoveRange(Int32, Int32) -> Aralıktakileri siler
        - Reverse() -> Ters çevir
        - Sort() -> Sırala
        - ToArray() -> Diziye Dönüştür
        - TrimExcess() -> Kapasiyeyi düşürür (performans için iyi)
        - TrueForAll(Predicat<T>) -> Tüm elemanlar koşulu sağlıyor mu
        

            */

        private static void PropertiesMethod()
        {
            List<int> numbers = new List<int>();

            // Add / AddRange
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.AddRange(new int[] { 3, 4, 5, 6, 7, 8, 9 });//verileri koleksiyon olarak ekleme



            System.Console.WriteLine();



            //dizideki elemanları yazdır ve aralarına "," koy
            System.Console.WriteLine("Add / AddRange: " + string.Join(",", numbers));



            System.Console.WriteLine();



            // Find / FindAll / Exists
            int firstEven = numbers.Find(n => n % 2 == 0); // ilk çif sayı bul ve değerini ver
            List<int> allEven = numbers.FindAll(n => n % 2 == 0); // Tüm çift sayıları bul ve yeni listeye ata
            bool hasGreaterThan5 = numbers.Exists(n => n > 5); // Listede 5 ten büyük sayı var mı? Ture / false
            System.Console.WriteLine($"Find: {firstEven} | FindAll: {string.Join(",", allEven)} | Exist > 5: {hasGreaterThan5} ");

            System.Console.WriteLine();



            // ForEach
            System.Console.Write("ForEach: ");
            numbers.ForEach(n => System.Console.Write(n + " "));
            System.Console.WriteLine();


            System.Console.WriteLine();

            // Sort / Revers
            numbers.Sort();//Sırala
           System.Console.WriteLine("Sort: " + string.Join(",", numbers));

            numbers.Reverse();//Ters çevir
           System.Console.WriteLine("Reverse: " + string.Join(",", numbers));



            System.Console.WriteLine();

            // Contains / BinarySearch
            System.Console.WriteLine("Contains 3? "+ numbers.Contains(3)); // dizi içinde 3 var mı? True | false

            // Listeyi varsayılan karşılaştırıcı (IComparable<T>) ile arar.
            // Liste önceden sıralanmış olmalı, yoksa sonuç yanlış olur.
            numbers.Sort();
            int index = numbers.BinarySearch(4);
            System.Console.WriteLine("BinnarySearch 4 index: "+ index);

            System.Console.WriteLine();

            // AsReadOnly
            var readOnly = numbers.AsReadOnly();
            System.Console.WriteLine("AsReadOnly: "+ string.Join(", ", readOnly));
            

            System.Console.WriteLine();

            // ConvertAll
            var stringss = numbers.ConvertAll(n => "Num: " + n);
            System.Console.WriteLine("ConvertAll: "+ string.Join(", ",stringss));

            System.Console.WriteLine();

            //CopyTo
            int[] array = new int[numbers.Count];
            numbers.CopyTo(array);
            System.Console.WriteLine("CopTo: "+ string.Join(", ",array));
            
            System.Console.WriteLine();


            // GetEnumerator
            var enumerator = numbers.GetEnumerator();
            System.Console.Write("GetEnumerator: ");
            while (enumerator.MoveNext())
            {
                System.Console.Write(enumerator.Current + " ");
            }
            System.Console.WriteLine();

            // GetRange
            var subList = numbers.GetRange(1, 3);
            System.Console.WriteLine("GetRange: "+ string.Join(", ",subList));

            System.Console.WriteLine();

            // TrimExcess
            numbers.TrimExcess();
            System.Console.WriteLine("TrimExcess done");

            System.Console.WriteLine();

            //TrueForAll
            bool allPositive = numbers.TrueForAll(n => n > -1);// Listedeki tüm sayılar -1 den büyükse ture değilse false döner
            System.Console.WriteLine("TrueForAll > -1? " + allPositive); 

            System.Console.WriteLine();
            

            // Remove / RemoveAll
            numbers.Remove(2); // 2'yi sil
            numbers.RemoveAll(n => n % 2 == 0); // Çift sayıları sil
            System.Console.WriteLine("Remove / RemoveRange: " + string.Join(",", numbers));


        }




        #endregion


        #region List<T> | LINQ

        /*
        - Aggregate -> Elemanları birleştirerek tek değer üretir
        - All -> tüm elemanlar koşulu sağlıyor mu
        - Any -> en az bir eleman koşulu sağlıyor mu
        - Append -> Sona eleman ekler
        - Avarage -> ortalama değer
        - Cast -> tip dönüşüm
        - Concat -> kolleksiyon birleştirir
        - Contains -> Eleman içeriyor mu
        - Count -> Eleman sayıso dönöer
        - DefaultIfEpty -> Boşşsa varsayılan döner
        - Distinct -> Tekrarsız elemanlar
        - ElementAt -> Belirtilen index'teki eleman
        - Except -> iki küme farkı
        - First -> ilk eleman
        - GroupBy -> Gruplama yapma
        - GroupJoin -> Gruplu join
        - Intersect -> Kesişim
        - Join -> Inner join
        - Last -> Son eleman
        - LongCount -> long, türünde sayı döner
        - Max -> En büyük değer
        - Min -> En küçük değer
        - OfType -> Belirtilen tiptekileri seçer
        - OrderBy -> artan sıralama
        - OrderByDescending -> azalan sıralama
        - Prepend -> Başa eleman ekler
        - Range -> Belirli aralıkta sayı üretir
        - Repeat -> belirli değeri tekrar eder
        - Reverse -> Ters çevirir
        - Select -> Porjeksiyon
        - SelectMany -> İç kolleksiyonları açar
        - SequenceEqual -> iki kolleksion aynı mı
        - Single -> tek eleman döner
        - Skip -> ilk n elemanı atlar
        - SkipWhile -> koşula uyan elemanları atlar
        - Sum Toplar -> Toplam
        - Take -> ilk n eleman
        - TakeLast -> Son n eleman
        - TakeWhile -> Eleman koşul sağladıkça alır
        - ThenBy -> ikincil sıralama
        - ThenByDescending -> ikincil sıralama tersten
        - ToArray -> Array üretir
        - ToDictionary -> Dictionary Üretir
        - ToHashSet -> HashSet Üretir
        - ToList -> Liste üretir
        - ToLookup -> Lookup üretir
        - Union -> Birleşim
        - Where -> Filitreleme
        - Zip -> İki kolleksiyonu eşleştirir
       
            */

        #endregion
    }

}
