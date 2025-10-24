using System;


namespace CSharpProgramlama.IleriCSharpEgitimi.AccessModifiers
{
     class AccessModifiersClass
    {
        public static void AccessModifiersRun()
        {

        }
    }

    class Customer
    {
        protected int id { get; set; }
        public void Save()
        {
            
        }
    }
    class Student : Customer
    {
        public void Save2()
        {


        }
    }

    internal class Course
    {
        public string? Name { get; set; }

        private class NestedClass // class'larda sdece private iç içe class kullanımında kullanıla bilir
        {
           
        }
    }
    /// private -> sadece tanımlandığı block'ta geçerli
    /// protected -> private gibi kullanıla biliyor ve inheritance olan yerdede kullanılıyor
    /// public class -> public referans verildiğinde sadece classı başka bir projeden erişilecekse kullanılmalıdır. 
                    //   Her hangi bir erişim kısıtlaması yoktur
    /// internal class-> Sadece mevcut projede her yerde kullan. (class default olarak internal dır)
    /// readonly -> anahtar sözcüğüyle sadece okuma izni verebilirsin.
    /*
    
    | Belirleyici            | Nereden erişilir                                     | Açıklama                       |
    | ---------------------- | ---------------------------------------------------- | ------------------------------ |
    | **public**             | Her yerden                                           | En geniş erişim.               |
    | **private**            | Sadece tanımlandığı sınıf içinden                    | En kısıtlı erişim. Varsayılan. |
    | **protected**          | Türetilmiş (kalıtım alan) sınıflardan                | Kalıtım için kullanılır.       |
    | **internal**           | Aynı assembly (proje) içinden                        | Farklı projeden erişilemez.    |
    | **protected internal** | Aynı assembly + türetilmiş sınıflardan               | İki erişim türünün birleşimi.  |
    | **private protected**  | Sadece aynı assembly içindeki türetilmiş sınıflardan | En dar birleşik erişim.        |
    
    */
}