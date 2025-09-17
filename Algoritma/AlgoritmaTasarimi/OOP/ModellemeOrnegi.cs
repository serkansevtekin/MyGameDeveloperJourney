using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ModellemeOrnekClass
    {
        public static void ModellemeOrnekRunMethod()
        {
           

            Arac benimAracim = new Arac
            {
               
                Marka = "Skoda",
                Model = "Superb",
                Renk = Renkler.Gri.ToString(),
                Yil = 2020,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            }; // nesne oluşturma

            Arac seninAracin = new Arac
            {
                Marka = "Mercedes",
                Model = "Maybac",
                Renk = Renkler.Beyaz.ToString(),
                Yil = 2025,
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.5
            };


            benimAracim.ToString();
            System.Console.WriteLine();

            seninAracin.ToString();
            System.Console.WriteLine();

            benimAracim.Temizle();

        }
    }
}