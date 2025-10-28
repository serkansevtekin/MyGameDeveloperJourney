using System;
using System.Runtime.CompilerServices;
using DelegateOrnek2;

namespace DelegateOrnek3
{
    class DelegateOrnek3Class
    {
        public static void DelegateOrnek3RunMethod()
        {
            // --- Delegates ---
            DelegateKullanim();

            // --- Action ---
            // ActionKullanim();


            // --- Func ---
            // FuncKullanim();

            // --- Predicate ---
            //PredicateKullanimi();

        }

        delegate void MyDelegate1();
        delegate void MyDelegate2(string mesaj);
        delegate int MyDelegate3(int say1, int sayi2);
        delegate List<string> MyDelegate4(List<string> stringList);

        delegate void MyDelegate5();
        delegate void OyuncularDelegate();
        delegate void OyuncuDelegate(Oyuncular oyuncular);

        delegate (int, int) SkorDelegateTuple((int, int) tuple);

        public static void DelegateKullanim()
        {
            MyClass myClass = new MyClass();

            MyDelegate1 myDelegate1 = myClass.Yaz;
            myDelegate1();

            MyDelegate2 myDelegate2 = myClass.Mesaj;
            myDelegate2("Mesaj");

            MyDelegate3 myDelegate3 = myClass.Topla;
            int toplam = myDelegate3(3, 5);
            System.Console.WriteLine("Toplam: " + toplam);

            MyDelegate4 myDelegate4 = myClass.Listele;
            List<string> isim = myDelegate4(new List<string>() { "Sekan", "Leyla", "Hande" });
            foreach (var item in isim)
            {
                System.Console.WriteLine(item);
            }

            MyClass myClass1 = new MyClass("Uyarı Mesaj");
            MyDelegate5 myDelegate5 = myClass1.Uyari;
            myDelegate5();

            Oyuncular o = new Oyuncular("Serkan", 100);
            OyuncularDelegate oyuncu = o.BilgiYaz;
            oyuncu();

            OyuncuDelegate myOyuncuDelegate = o => o.BilgiYaz();
            myOyuncuDelegate(new Oyuncular("Hakan", 20));

            
            
            Oyuncular oyuncular = new Oyuncular("Ayşe", 50);


            //Parametre alan tuple delegate
            SkorDelegateTuple skorDelegateTuple = oyuncular.SkorGuncelle;
            var guncel = skorDelegateTuple((oyuncular.Skor, 100));
            System.Console.WriteLine($"{guncel.Item1}, {guncel.Item2}");
        }

       
   
    }



    class MyClass
    {

        public void Yaz()
        {
            System.Console.WriteLine("Yazı");
        }

        public void Mesaj(string msg)
        {
            System.Console.WriteLine(msg);
        }

        public int Topla(int a, int b)
        {
            return a + b;
        }

        public List<T> Listele<T>(List<T> liste)
        {

            return new List<T>(liste);
        }

        public string? _uyari { get; private set; }

        public MyClass() { }
        public MyClass(string Uyari)
        {
            _uyari = Uyari;
        }

        public void Uyari()
        {
            System.Console.WriteLine(_uyari);
        }
    }

    class Oyuncular
    {
        public string? Ad { get; set; }
        public int Skor { get; set; }

        public Oyuncular(string ad, int skor)
        {
            Ad = ad;
            Skor = skor;
        }

        public void BilgiYaz()
        {
            System.Console.WriteLine($"Oyuncu: {Ad}, Skor: {Skor}");
        }
        
        public (int,int) SkorGuncelle((int,int) skorTuple)
        {
            return (skorTuple.Item1 + 10, skorTuple.Item2 + 5);
        }
    }
}