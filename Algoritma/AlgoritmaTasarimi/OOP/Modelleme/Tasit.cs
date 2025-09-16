using System;
namespace Programlama.AlgoritmaTasarimi
{
    public class Tasit
    {
        public string? Motor { get; set; }
        public double Hacim { get; set; }

        public void Temizle() => System.Console.WriteLine("Taşıt temizlendi");
      
    }

    public enum Motor
    {
        Dizel,
        Benzin,
        LPG,
        Elektirik,
        Jet
    }

    public enum Renkler
    {
        Beyaz,
        Siyah,
        Gri,
        Kırmızı,
        Yeşil,
        Mavi
    }
}