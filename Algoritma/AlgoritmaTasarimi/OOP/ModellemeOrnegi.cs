using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ModellemeOrnekClass
    {
        public static void ModellemeOrnekRunMethod()
        {
            Arac benimAracim = new Arac("Skoda", "SuperB",
            "Gri", 2020);

            System.Console.WriteLine($"{benimAracim.Marka}");
            System.Console.WriteLine($"{benimAracim.Model}");
            System.Console.WriteLine($"{benimAracim.Renk}");
            System.Console.WriteLine($"{benimAracim.Yil}");
        }
    }
}