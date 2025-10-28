using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Delegates
{
    class DelegatesClass
    {
        public static void DelegatesRun()
        {
            //Baslangic();
            FunctKullanimi();
        }
        private static void FunctKullanimi()
        {

            Func<int, int, int> add = FuncClass.Topla;
            System.Console.WriteLine(add(3, 4));

            Func<int> getRendomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            System.Console.WriteLine(getRendomNumber());





            //Lambda
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            System.Console.WriteLine(getRandomNumber2());




            //System.Console.WriteLine(FuncClass.Topla(3,4));
        }

        private static void Baslangic()
        {
            CustomerManger customerManger = new CustomerManger();

            MyDelegate? myDelegate = customerManger.SendMessage;
            myDelegate += customerManger.ShowAlert;

            myDelegate -= customerManger.SendMessage;
            myDelegate!();



            MyDelegate2 myDelegate2 = customerManger.SendMessage2;
            myDelegate2 += customerManger.ShowAlert2;

            myDelegate2("Benim message");// Bu "Hello" delegate eklenen herşe aynı anda gönderir


            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;

            int sonuc = myDelegate3(3, 4);
            System.Console.WriteLine(sonuc);
        }
    } 
    
    #region Delegate Tanım
        /*
        * Tanım: Delegate, metot referansı tutan bir türdür. C#'ta metotları parametre gibi taşımayı sağlar
        * Kullanım Amacı:
                - Metotları değiştirilebilir hale getirmek
                - Olay (event) sisteminin temelini oluşturmak
                - Callback (geri çağırma) mantığını kurmak
        
        * Özellikleri:
                    - Birden fazla metodu aynı delagate'e ekleyebilirsin(+=)
                    - Delegate çağrıldığında tüm metotlar sırayla çalışır
                    - (-=) ile metotları çıkarılabilir
                    - Action, Func, Predicate -> hazır delegate türleri


        * Action:
            - Geri dönüş değeri yok
            - void dönen metotları temsil eder
            - Örnek:
                Action<string> yazdir = msg => Console.WriteLine(msg);
                yazdir("Merhaba");
            
            - Kısaca: delegate void MyDelegate(...) yerine kullanılır

        * Func:
            - Geri dönüş değeri var
            - Son parametre return tipidir
            - Örnek:
                Func<int, int, int> topla = (a,b) => a + b;
                int sonuc = topla(3,5);

        * Predicate:
                - Her zaman bool döner.
                - Genellikle koşul kontrolü için kullanılır
                - Örnek:
                    Predicate<int> ciftMi = x => x % 2 == 0;
                    bool sonuc = ciftMi(4);

        Unity Açısından:
                        - Delegate ve event'ler, bileşenler arası haberleşmede kullanılır.
                        - OnPlayerDeath, OnScoreChange vb. olaylar delegate tabanlıdır.
                        - Performans maliyeti düşüktür; Update içinde kontrol event kullanmak daha verimlidir
        
        
        | Tür       | Geri Dönüş | Örnek İmza          | Kullanım Amacı               |
        | --------- | ---------- | ------------------- | ---------------------------- |
        | Action    | void       | `Action<int>`       | İşlem yap ama değer döndürme |
        | Func      | TReturn    | `Func<int,int,int>` | İşlem yap ve değer döndür    |
        | Predicate | bool       | `Predicate<int>`    | Koşul kontrolü yap           |

        
        */
    #endregion

    #region Baslangic
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    public class CustomerManger
    {
        public void SendMessage()
        {
            System.Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            System.Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            System.Console.WriteLine(message);
        }

        public void ShowAlert2(string allert)
        {
            System.Console.WriteLine(allert);
        }

    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
    #endregion

    #region FuncKullanimi
    public class FuncClass
    {
         public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
    #endregion


}