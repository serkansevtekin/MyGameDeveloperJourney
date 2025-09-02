namespace Programlama.StructNameSpace //Namespace aynı
{
    //Struct Tanımlama - Değer tipli çalışır
    public struct Ogrenci
    {

        //Field + property - özellik

        public int numara { get; private set; }
        public string adi { get; private set; }
        public string soyadi { get; private set; }
        public bool cinsiyet { get; private set; }

        //alternatif kullanım için örnek özellik
        public int yas { get; set; }


        //constructor (yapıcı metot) - struct için parametresiz constructor tanımlanamaz
        //bool consCinsiyet = true -> default değer ataması - opsiyonel parametre en sona yazılır
        public Ogrenci(int consNumara, string consAdi, string consSoyadi, int consYas, bool consCinsiyet = true)
        {

            this.numara = consNumara;
            this.adi = consAdi;
            this.soyadi = consSoyadi;
            this.cinsiyet = consCinsiyet;
            this.yas = consYas;
        }


/* 
        //setter ve getter metotları
        public int publicNumara
        {
            get => numara;
            set => numara = value;
        }
        public string punblicAdi
        {
            get => adi;
            set => adi = value;
        }

        public string publicSoyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }

        public bool publicCinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        
        public int publicYas
        {
            get => yas;
            set => yas = value;
        }
 */

        //Geçersiz kılmak - ezmek - override
        public override string ToString()
        {
            return $"Numara: {numara} Adı: {adi} Soyadı: {soyadi} Yaşı: {yas} Cinsiyeti: {string.Format("{0}", cinsiyet == true ? "Erkek" : "Kadın")}";
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