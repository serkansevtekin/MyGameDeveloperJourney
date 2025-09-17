using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"X: {X} , Y: {Y}";
    }

    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public override string ToString() => $"Genişlik: {Genislik} , Yukseklik: {Yukseklik}";
       
    }
    // Şekil sınıfı -> Base class (tüm şekillerin temel sınıfı)
    public class Sekil
    {
        //Constructor içinde nesne oluşturmadan
        //Pozisyon property'si, default olarak yeni Pozisyon nesnesine atanıyor -> auto-property with initializer
        public Pozisyon Pozisyon { get; } = new Pozisyon();

        //Boyut property'si, default olarak yeni Pozisyon nesnesine atanıyor -> auto-property with initializer
        public Boyut Boyut { get; } = new Boyut();

        /* //auto-property with initializer [OLMADAN] Constructor ile
        
        // Auto-property, initializer yok
        
        public Pozisyon Pozisyon { get; }
        public Boyut Boyut{ get; }

        // Constructor içinde nesneleri oluşturutoruz
        public Sekil()
        {
            Pozisyon = new Pozisyon();
            Boyut = new Boyut();
        } */


        //virtual -> Ezilebilir method olduğunu belirtiyoruz
        public virtual void Ciz() => System.Console.WriteLine($"Şekil {Pozisyon}  - {Boyut}");
    }
}