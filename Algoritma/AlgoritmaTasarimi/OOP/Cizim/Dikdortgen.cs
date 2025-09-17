using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class Dikdortgen : Sekil // Sekil -> kalıtım (Dikdortgen sınıfı Sekil sınıfından türüyor)
    {   
        // Şekil sınıfındaki ezilebilir metotu eziyoruz
        public override void Ciz() => System.Console.WriteLine($"Dikdörtgen {Pozisyon} - {Boyut}");
    }
}