using System;
namespace Programlama.AlgoritmaTasarimi
{
    class ConstructorsClass
    {
        public static void ConstructorRunMethod()
        {
            Insan k = new Insan("serkan", 30);
            System.Console.WriteLine(k.Adi + " : " + k.Yas);

            Insan k1 = new Insan("Mehmet");
            System.Console.WriteLine(k1.Adi + " : " + k1.Yas);

            Insan k2 = new Insan();
            System.Console.WriteLine(k2.Adi + " : " + k2.Yas);
        }

        #region Tanım
        /*
            Constructors (Yapılandırıcı)

     
        - Temel yapılandırıcıların bildirilmesi için söz dizilimi de bir metot gibidir.
        - Yapılandırıcı metot adı sınıf adı ile aynı olmalıdır.

        - Bir yapılandırıcı metodun geri dönüş tipi aslında sınıfın kendisini ifade ettiğinden geri dönüş tipi belirtilmez.

        - Yapılandırıcı metıtlar da aşırı yüklenebilir.

        - Yapılandırıcı metotlar sınıfın bir örneği oluşturulduğunda otomatik olarak çalışırlar

        - Vs Code ortamında "ctor" yazıldıktan sonra "Tab" tuşuna basılarak yapılandırıcı metot kısa-yol ile oluşturulur.

        - Yapılandırıcı metotta private yada public vb. gibi erişim düzenleyici ifadelerini kullanmak anlamsızdır.

        Amaç:
            --- Nesne il yaratıldığında alanları(fields) başlatmak
            --- Varsayılan değerler atamak
            --- Gerekli bağımlılıkları yüklemek

        Özellikler:
            --- İsim sınıf adıyla aynı olmalıdır
            --- void veya başka bir dönüş tipi yazılamaz
            --- Bir sınıfta birden çık constrcutor (overloading) olabilir.
            


        Tüm Consturctor Tanımlama Yöntemleri
            Default
            
            Parametreli
            
            Overloading
            
            Chaining (this)
            
            Static
            
            Private
            
            Record constructor (C# 9+)
            
            Required property (C# 11+)

        */

        #endregion
    }


    #region  Örnek 1

    class Kisi // Class
    {
        private string? _adi; // filed


        // Constructor: parametre alır, property üzerinden field set üretir
        public Kisi(string Ad) => Adi = Ad; // Kısa yapılandırıcı kullanımı

        //Property: _adi field'ını kontrol eder
        public string Adi { get => _adi!; set => _adi = value; }

    }
    #endregion

    #region Ornek 2

    class Insan
    {
        public string? Adi { get; set; } // prop -> field
        public int Yas { get; set; } // prop -> field

        //Constructor 0
        public Insan()
        {

        }

        //Constructor 1
        public Insan(string adi)
        {
            Adi = adi;
        }

        //Constructor 2
        public Insan(string adi, int yasi)
        {
            Adi = adi;
            Yas = yasi;
        }

        //Static constructor
        //Sınıf düzeyinde çalışır, yalnızca bir kez ve otomatik çağrılır. Nesne oluşturulmasına gerek yoktur.
        static Insan()
        {
            System.Console.WriteLine("Static Constructor çağrıldı");
        }
    }
    #endregion


}