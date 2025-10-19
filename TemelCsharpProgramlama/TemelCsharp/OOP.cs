using System;

namespace CSharpProgramlama.TemelCsharpNameSpace
{
    public class OOPClass
    {
        public static void OOpRunMet()
        {
            //Temel();
            //SoruOrnek();
            StaticClassKullanimi();
        }

        private static void StaticClassKullanimi()
        {
            OyunAyari.MaksCan = 200;
            OyunAyari.YazdirAyarlar();
        }

        private static void SoruOrnek()
        {
            Soru soru1 = new Soru()
            {
                SoruMetni = "Hangisi Programlama dili değildir",
                Secenekler = new string[4] { "Phyhon", "C#", "Java", "Html" },
                Cevap = "Html"
            };
            Soru soru2 = new Soru()
            {
                SoruMetni = "Hangisi en popüler Programlama dilidir",
                Secenekler = new string[4] { "Phyhon", "C#", "Java", "Html" },
                Cevap = "C#"
            };
            Soru soru3 = new Soru()
            {
                SoruMetni = "Hangisi en popüler web Programlama platformudur",
                Secenekler = new string[4] { "Asp.Net", "Spring", "Java", "Django" },
                Cevap = "Django"
            };

            Soru soru4 = new Soru("Hanisi ide değildier", new string[4] { "vs.code", "vsSutdio", "Intelhens", "Steam" }
            , "Steam"); // constructor ile kullnım
            var sorular = new Soru[] { soru1, soru2, soru3, soru4 };
            foreach (var soru in sorular)
            {
                System.Console.WriteLine(soru.SoruMetni);
                foreach (var secenek in soru.Secenekler!)
                {
                    System.Console.WriteLine(secenek);
                }
                //cevap kontrol
                System.Console.WriteLine("Cevabınız: ");
                string cevapBin = Console.ReadLine() ?? "";
                if (soru.cevapKontrol(cevapBin))
                {
                    System.Console.WriteLine("doğru");
                }
                else
                {
                    System.Console.WriteLine("yanlış");
                }
            }




            System.Console.WriteLine();
            //Tupple method
            var (metin, secenekler, cevap) = soru1.BilgileriAl();
            System.Console.WriteLine($"Soru: {metin}");
            System.Console.WriteLine($"Seçenekler");
            foreach (var item in secenekler!)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"Cevap: {cevap}");

            System.Console.WriteLine("\n");

            //Tuble ve Foreach
            foreach (var soru in sorular)
            {
                var (met, sec, cev) = soru.BilgileriAl();
                System.Console.WriteLine($"Soru: {met}");
                System.Console.WriteLine("Seçenekler:");
                foreach (var s in sec!)
                {
                    System.Console.WriteLine($"- {s}");
                }
                System.Console.WriteLine($"Cevap: {cevap}");
            }
        }
    }

    /*         private static void Temel()
            {
                //class => object(ogr1,ogr2)

                OgrenciClass ogr1 = new OgrenciClass() { ogrenciNo = "100", adsoyad = "Ada bilgi", sube = "6/A" };
                OgrenciClass ogr2 = new OgrenciClass() { ogrenciNo = "200", adsoyad = "Turan bilgi", sube = "7/A" };
                OgrenciClass ogr3 = new OgrenciClass() { ogrenciNo = "300", adsoyad = "Yeşim bilgi", sube = "8/A" };
                OgrenciClass ogr4 = new OgrenciClass() { ogrenciNo = "400", adsoyad = "Ahmet Turna", sube = "9/A" };


                 OgrenciClass ogr1 = new OgrenciClass();

                   ogr1.ogrenciNo = "100";
                   ogr1.adsoyad = "Ada bilgi";
                   ogr1.sube = "6/A";

                   OgrenciClass ogr2 = new OgrenciClass();

                   ogr2.ogrenciNo = "200";
                   ogr2.adsoyad = "Tigit bilgi";
                   ogr2.sube = "7/A";

                   OgrenciClass ogr3 = new OgrenciClass();
                   ogr3.ogrenciNo = "300";
                   ogr3.adsoyad = "Çınar Turna";
                   ogr3.sube = "8/A"; 


                OgrenciClass[] ogrenciler = new OgrenciClass[] { ogr1, ogr2, ogr3, ogr4 };


                foreach (var ogrenci in ogrenciler)
                {
                    System.Console.WriteLine(ogrenci.BilgileriYazdir());
                }

            System.Console.WriteLine($"{ogr1.ogrenciNo} numaralı öğrencinin adı {ogr1.adsoyad} ve şubesi {ogr1.sube}");
                 System.Console.WriteLine($"{ogr2.ogrenciNo} numaralı öğrencinin adı {ogr2.adsoyad} ve şubesi {ogr2.sube}");
                     System.Console.WriteLine($"{ogr3.ogrenciNo} numaralı öğrencinin adı {ogr3.adsoyad} ve şubesi {ogr3.sube}");
        } */

    /*     public class OgrenciClass
        {
            //property => string , int 

            public string? ogrenciNo { get; set; }
            public string? adsoyad { get; set; }
            public string? sube { get; set; }
            //fields => string , int
           string ogrenciNo;
            string adsoyad;
            string sube;

            //methods => bilgileriyazdir()
            public string BilgileriYazdir()
            {
              return $"{this.ogrenciNo} numaralı öğrencinin adı {this.adsoyad} ve şubesi {this.sube}";
            }

            //constructor

            public OgrenciClass(){}
            public OgrenciClass(string ogrNo, string ogrAdi, string ogrSube)
            {
                this.ogrenciNo = ogrNo;
                this.adsoyad = ogrAdi;
                this.sube = ogrSube;
            }
              }
             */

    public class Soru
    {
        public Soru() { }
        public Soru(string? soruMetni, string[] secenekler, string? cevap)
        {
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }

        //properties
        public string? SoruMetni { get; set; }
        public string[]? Secenekler { get; set; }
        public string? Cevap { get; set; }


        //Tuple döndüren mothod
        public (string? soruMetni, string[]? secenekler, string? cevap) BilgileriAl()
        {
            return (this.SoruMetni, this.Secenekler, this.Cevap);
        }

        //normal method
        public bool cevapKontrol(string cevap)
        {
            return this.Cevap!.ToLower() == cevap.ToLower();
        }

    }


public static class OyunAyari
    {
        //static field
        public static int MaksCan = 100;

        //static method
        public static void YazdirAyarlar()
        {
            System.Console.WriteLine($"MaksCan: {MaksCan}");
        }
    }

}