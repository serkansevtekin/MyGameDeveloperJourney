using System;
using Programlama.VeriYapilari;

namespace Programlama.AlgoritmaTasarimi
{
    class VirtualMethodsClass
    {
        public static void VirtualMethodsRunMain()
        {

            //new -> Yeni bir nesne oluşturmak ve constructor'ını çağırmak için kullanılır.
            
            //1. TanımlamaYol
            var d = new Dikdortgen();
            d.Pozisyon.X = 23;
            d.Pozisyon.Y = 43;
            d.Boyut.Genislik = 100;
            d.Boyut.Yukseklik = 50;
            d.Ciz();


            //2. Tanımlama Yol
            var s = new Sekil
            {
                Pozisyon = { X = 10, Y = 20 },
                Boyut = { Genislik = 200, Yukseklik = 300 }
            };
            s.Ciz();

        }
    }   
    

    #region Tanım
        /*
        C#'ta "Virtual Method" bir sınıfta tanımlanmış, fakat alt sınıflar tarafından isterinse ezilebilecek (override edilebilecek) metotlardır.

            - virtual -> anahtar kelimesi işaretlenir.
            - Taban sınıfta bir varsayılan davranış tanımlar
            - Türetilmiş sınıflarda override kullanılarak yeniden yazılabilir.
            - Eğer alt sınıf metodu ezmezse, taban sınıftaki implementasyon çalışır
            - Fields ve static fonksiyonlar virtual olarak tanımlanamazlar.
        Avantajı:

          -  interface olsa hepsini yazmak zorundasın.

          -  abstract olsa da hepsini override etmek zorundasın.

          -  virtual ile sadece ihtiyacını karşılayan kısmı değiştirirsin.
        */
    #endregion
}