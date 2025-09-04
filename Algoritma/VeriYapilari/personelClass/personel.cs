using System;

namespace Programlama.VeriYapilari
{

    public class Personel
    {
        public int? SicilNo { get; private set; }
        public string? Adi { get; private set; }
        public string? Soyadi { get; private set; }
        public decimal? Maas { get; private set; }

        public Personel(string adi, string soyAdi, decimal maas)
        {
            this.Adi = adi;
            this.Soyadi = soyAdi;
            this.Maas = maas;
        }

        public override string ToString()
        {
            return $"{Adi} {Soyadi} {Maas}";
        }
    }
}