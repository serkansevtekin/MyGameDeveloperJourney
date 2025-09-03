using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Programlama.VeriYapilari
{

    //Interface Tanımı
    public interface ISehir
    {
        void Tanit();
        void NufusBilgisiGetir(int Plakano);
    }
    public class Sehir : ISehir , IComparable<Sehir>
    {
        public int Plakano { get; set; }
        public string? SehirAdi { get; set; }

        public Sehir(int plakaNo, string? sehirAdi)
        {
            this.Plakano = plakaNo;
            this.SehirAdi = sehirAdi!;
        }


        public override string ToString()
        {
            return $"{Plakano,-5} {SehirAdi,5}";
        }


        //ISehir implement
        public void Tanit()
        {
            throw new NotImplementedException();
        }

        public void NufusBilgisiGetir(int Plakano)
        {
            throw new NotImplementedException();
        }


    //IComparable<Sehir> implement -> karşılaştırma yapmak için
        public int CompareTo(Sehir? other)
        {
            if (this.Plakano < other!.Plakano)
            {
                return -1;
            }
            else if (this.Plakano == other!.Plakano)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    class ListKullanimiClass
    {
        public static void ListKullanimiMainMethod()
        {
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };// Liste Tanımlama
            sayilar.Sort();//listeyi sıralama
            sayilar.ForEach(s => Console.WriteLine(s));//Listeyi döndürme ve yazdırma

            System.Console.WriteLine();
            System.Console.WriteLine("Şehirler");
            //Şehir listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")
                
            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();//sırlama

            sehirler.ForEach(sehir => System.Console.WriteLine(sehir));
        }



    }
}