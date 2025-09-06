using System;
namespace Programlama.StructNameSpace //Namespace aynı
{


    //class Tanımı - Referans tipli çalışır
    public class NormalClass
    {
        public static void NormalMainMethod()
        {
            //GenelStructBilgisiVeIyilestirmeler();

            //struct -> deger tipli 
            // Değer tipli değişkenler, bellekte stack (yığın) alanında depolanır ve doğrudan değerleriyle çalışırlar.
            // Bu, değer tiplerinin kopyalandığı anlamına gelir; yani bir değer tipi değişkeni başka bir değişkene atadığınızda, 
            // aslında o değerin bir kopyasını oluşturursunuz. Bu nedenle, bir değer tipi değişkenini değiştirdiğinizde, 
            // bu değişiklik yalnızca o değişkeni etkiler ve diğer kopyalar bundan etkilenmez.
            
            Nokta n1 = new Nokta(3, 4);
             System.Console.WriteLine($"n1: {n1}");

            n1.Degistir();
             System.Console.WriteLine($"n1: {n1}");

            Nokta n2 = n1; //n1 in değerini n2 ye atar (kopyalar)
            System.Console.WriteLine($"n2: {n2}");

            n2.publicX = -1 * n2.publicX; //n2 nin x değerini değiştirir
            System.Console.WriteLine($"n1: {n1}");
            System.Console.WriteLine($"n2: {n2}");
        }

        private static void GenelStructBilgisiVeIyilestirmeler()
        {
            /* //struct kullanımı
            Ogrenci ogr1 = new Ogrenci();
            ogr1.publicNumara(10);
            ogr1.publicAdi("serkan");
            ogr1.publicSoyadi("sevtekin");
            ogr1.publicCinsiyet(true);
            ogr1.publicyas = 10;

            //Alternatif struct kullanımı
            var ogr2 = new Ogrenci()
            {
                yas = 25,
            }; */

            /* //3. struct kullanımı - constructor ile
            var ogr3 = new Ogrenci(30, "Ali", "Avşar", 28, false);//constructor ile değer atama

            var ogr4 = new Ogrenci(40, "Asaf", "Karlıdağ", 35);//cinsiyet default deger ne ise o atanır
 */
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10, "Serkan", "Sevtekin", 30, true),
                new Ogrenci(40, "Asaf", "Karlıdağ", 35),
                new Ogrenci(20, "Ayşe", "Yılmaz", 22, false),
                new Ogrenci(25, "Fatma", "Kara", 20, false),
                new Ogrenci(30, "Ali", "Avşar", 28, false)
            };

            // ogrenciListesi.ForEach(item =>System.Console.WriteLine(item));

            foreach (Ogrenci item in ogrenciListesi)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

#region STRUCT (YAPI) Açıklama
/*  
 Yapı (struct), C# programlama dilinde kullanılan bir veri türüdür ve genellikle küçük veri yapıları için kullanılır. 
 Yapılar, değer türleri olarak kabul edilir, yani bellekte doğrudan veri depolarlar ve referans türlerinden farklı olarak 
 bellekteki adresleri üzerinden değil, kendileri üzerinden işlem görürler.

 Yapılar, sınıflara benzer şekilde alanlar (fields), özellikler (properties), yöntemler (methods) ve olaylar (events) içerebilirler. 
 Ancak, yapılar sınıflardan farklı olarak kalıtım (inheritance) desteklemezler ve varsayılan olarak parametresiz yapıcı (constructor) 
 içerirler.

 Interface inheritance (arayüz kalıtımı) destekler, yani bir yapı bir veya daha fazla arayüzü uygulayabilir. 

 Kutulma (boxing) ve kutudan çıkarma (unboxing) işlemleri yapılar için de geçerlidir. Kutulma, bir değer türünün (örneğin, int, float) bir nesne türüne (object) dönüştürülmesi işlemidir. 
 Kutudan çıkarma ise, bir nesne türünden bir değer türüne geri dönüştürülmesi işlemidir. Bu işlemler performans açısından maliyetli olabilir, bu yüzden yapılarla çalışırken dikkatli olunmalıdır.
 

 Yapılar genellikle aşağıdaki durumlarda tercih edilir:
 1. Küçük veri yapıları: Yapılar, küçük veri yapıları için daha verimli olabilir çünkü bellek üzerinde doğrudan depolanırlar.
 2. Performans: Yapılar, değer türleri oldukları için bellek üzerinde daha hızlı erişim sağlarlar.
 3. Değer türü ihtiyaçları: Yapılar, değer türü ihtiyaçlarını karşılamak için kullanılır, örneğin koordinatları temsil eden bir nokta yapısı gibi. . . . . . . . . . .




 /*
        set ve get metotları
        set metodu, bir özelliğe değer atamak için kullanılır.
        get metodu ise, bir özelliğin değerini almak için kullanılır.
        C# dilinde, set ve get metotları genellikle özellikler (properties) aracılığıyla tanımlanır.
        Özellikler, bir sınıfın veya yapının (struct) üyelerine erişimi kontrol etmek için kullanılır.  

        Kapsülleme (Encapsulation) prensibine uygun olarak, bir sınıfın veya yapının iç verilerine doğrudan erişimi engellemek ve
        bu verilere erişimi kontrol etmek için kullanılırlar. Bu sayede, verilerin geçerliliği ve tutarlılığı korunabilir.
   
       
    Erişim belirleyicileri (Access Modifiers) 
        
        public -> Her yerden erişilebilir.
        
        private -> Sadece tanımlandığı sınıf veya yapının (struct) içinde erişilebilir.
        
        protected -> Sadece tanımlandığı sınıf veya yapının (struct) içinde ve ondan türetilen sınıflarda erişilebilir.
        
        internal -> Sadece aynı derleme (assembly) içindeki kodlardan erişilebilir.
        
        protected internal -> Sadece aynı derleme (assembly) içindeki kodlardan ve ondan türetilen sınıflardan erişilebilir.
        
        private protected -> Sadece aynı sınıf veya yapının (struct) içinde ve ondan türetilen sınıflarda erişilebilir, ancak aynı derleme (assembly) içindeki kodlardan erişilemez.
      



        //property - özellik
        public int numara { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        private bool cinsiyet { get; set; }


*/
#endregion