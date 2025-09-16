using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ModellemeOrnekClass
    {
        public static void ModellemeOrnekRunMethod()
        {
            Arac benimAracim = new Arac("Skoda", "SuperB",
            Renkler.Gri.ToString(), 2020);

            benimAracim.Motor = Motor.Dizel.ToString();
            benimAracim.Hacim = 1.6;

            System.Console.WriteLine($"{benimAracim.Marka}");
            System.Console.WriteLine($"{benimAracim.Model}");
            System.Console.WriteLine($"{benimAracim.Renk}");
            System.Console.WriteLine($"{benimAracim.Yil}");
            System.Console.WriteLine($"{benimAracim.Motor}");//Kalıtım ile
            System.Console.WriteLine($"{benimAracim.Hacim}");//Kalıtım ile

            benimAracim.Temizle();

        }
    }
}