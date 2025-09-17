using System;

namespace Programlama.AlgoritmaTasarimi
{
    class ListClassOrnegiClass
    {
        public static void ListClassOrnegiRunMethod()
        {
            List<Arac> filo = new List<Arac>();//Araç tipinde boş liste oluşturduk

            filo.Add(new Arac
            {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renkler.Beyaz.ToString(),
                Yil = 2020,
                Motor = Motor.Jet.ToString(),
                Hacim = 1.6
            });
            filo.Add(new Arac
            {
                Marka = "Opel",
                Model = "Corsa",
                Renk = Renkler.Gri.ToString(),
                Yil = 2021,
                Motor = Motor.Elektirik.ToString(),
                Hacim = 1.4
            });
            filo.Add(new Arac
            {
                Marka = "Renault",
                Model = "Fluence",
                Renk = Renkler.Siyah.ToString(),
                Yil = 2017,
                Motor = Motor.Elektirik.ToString(),
                Hacim = 1.4
            });



            filo.RemoveAll(a => a.Marka == "Opel");// Opel marka aracı sil
            foreach (Arac item in filo)
            {
                item.ToString();
            }
        }
    }
}