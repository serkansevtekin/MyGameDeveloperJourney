using System;

namespace Programlama.ClassNamespace
{
    public class OgretimElemaniClass
    {

        // Properties
        public int SicilNo { get; private set; }
        public string? Adi { get; private set; }
        public string? Soyadi { get; private set; }

        public bool Cinsiyet { get; private set; }

        //Default Constructor
        public OgretimElemaniClass()
        {
            System.Console.WriteLine("Parametresiz Constructor Metodu Çağrıldı");
        }

        //Parametreli Constructor
        public OgretimElemaniClass(int sicilNo, string? adi, string? soyadi, bool cinsiyet)
        {
            this.SicilNo = sicilNo;
            this.Adi = adi;
            this.Soyadi = soyadi;
            this.Cinsiyet = cinsiyet;
        }

        override public string ToString()
        {
            return $"{SicilNo,-5} {Adi,-10} {Soyadi,-10} {string.Format(Cinsiyet == true ? "Erkek" : "Kadın"),-5}";
        }
    }
}