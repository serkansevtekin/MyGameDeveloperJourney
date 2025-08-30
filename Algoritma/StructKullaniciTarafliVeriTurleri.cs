using System;
namespace Programlama.StructNameSpace
{
    //Struct Tanımlama - Değer tipli çalışır
    public struct Ogrenci
    {

        //Field + property - özellik

        private int numara { get; set; }
        private string adi { get; set; }
        public string soyadi { get; set; }
        public bool cinsiyet { get; set; }

        //alternatif kullanım için örnek özellik
        public int yas { get; set; }


        //constructor (yapıcı metot) - struct için parametresiz constructor tanımlanamaz
        public Ogrenci(int consNumara, string consAdi, string consSoyadi, bool consCinsiyet, int consYas)
        {
            System.Console.WriteLine("Otomatik olarak çalışan constructor metot");
            this.numara = consNumara;
            this.adi = consAdi;
            this.soyadi = consSoyadi;
            this.cinsiyet = consCinsiyet;
            this.yas = consYas;
        }



        //setter ve getter metotları
        public void setNumara(int disaridanNumara) => numara = disaridanNumara;
        public int getNumara() => numara;

        public void setAdi(string disaridanAd) => adi = disaridanAd;
        public string getAdi() => adi;

        public void setSoyadi(string disaridanSoyadi) => soyadi = disaridanSoyadi;
        public string getSoyadi() => soyadi;

        public void setCinsiyet(bool disaridanCinsiyet) => cinsiyet = disaridanCinsiyet;
        public bool getCinsiyet() => cinsiyet;






    }


    //class Tanımı - Referans tipli çalışır
    public class NormalClass
    {
        public static void NormalMainMethod()
        {
       
            //struct kullanımı
            Ogrenci ogr1 = new Ogrenci();
            ogr1.setNumara(10);
            ogr1.setAdi("serkan");
            ogr1.setSoyadi("sevtekin");
            ogr1.setCinsiyet(true);

            Console.WriteLine("Öğrenci Numarası: " + ogr1.getNumara());
            System.Console.WriteLine($"Öğrenci Adı: {ogr1.getAdi()}");
            System.Console.WriteLine("Öğrenci Soyadı: {0}", ogr1.getSoyadi());
            System.Console.WriteLine("Öğrenci Cinsiyeti: {0}", ogr1.getCinsiyet() ? "Erkek" : "Kadın");
            System.Console.WriteLine();


            //Alternatif struct kullanımı
            var ogr2 = new Ogrenci()
            {  
                yas = 25,
            };
            System.Console.WriteLine("2. Öğrenci Yaşı: {0} ", ogr2.yas);
            System.Console.WriteLine();



            //3. struct kullanımı - constructor ile
            var ogr3 = new Ogrenci(30, "Ali", "Avşar", true, 28);//constructor ile değer atama

            Console.WriteLine("Öğrenci Numarası: " + ogr3.getNumara());
            System.Console.WriteLine($"Öğrenci Adı: {ogr3.getAdi()}");
            System.Console.WriteLine("Öğrenci Soyadı: {0}", ogr3.getSoyadi());
            System.Console.WriteLine("Öğrenci Cinsiyeti: {0}", ogr3.getCinsiyet() ? "Erkek" : "Kadın");
            System.Console.WriteLine("3. Öğrenci Yaşı: {0} ", ogr3.yas);
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