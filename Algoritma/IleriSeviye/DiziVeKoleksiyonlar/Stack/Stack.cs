using System;

namespace Programlama.IleriAlgoritma
{
    public class IleriStackClass
    {
        public static void IleriStackMainMethod()
        {
           AnaStackKullanim();
           // StackClassUnumAndInterfaceApp();

        }

          private static void AnaStackKullanim()
          {
              // Stack<int> oluştur
              Stack<int> stack = new Stack<int>();

              //Push() -> eleman ekleme
              stack.Push(10);
              stack.Push(20);
              stack.Push(30);
              stack.Push(40);
              stack.Push(50);



              //Count -> eleman sayısı
              System.Console.WriteLine($"Yığındaki eleman sayısı: {stack.Count}");

              //Peek() -> en üstteki elemanı göster
              System.Console.WriteLine($"Peek (en üstteki): {stack.Peek()}");

              //Pop() -> en üstteki elemanı çıkarır
              System.Console.WriteLine($"Pop: {stack.Pop()}");
              System.Console.WriteLine($"Yeni peek: {stack.Peek()}");


              //Contains(T item) -> eleman kontrolü
              System.Console.WriteLine($"20 var mı? {stack.Contains(20)}");//true

              //ToArray() -> stack'i diziye kopyala
              int[] arr = stack.ToArray();
              System.Console.Write("stack<T> -> Array: ");
              foreach (var item in arr)
              {
                  System.Console.Write(item + " ");
              }
              System.Console.WriteLine();


              //Stack<T> -> List<T>
              var liste = new List<int>(stack);
              System.Console.Write("stack<T> -> List<T>: ");
              foreach (var item in liste)
              {
                  System.Console.Write(item + " ");
              }
              System.Console.WriteLine();

              //foreach -> elemanları gezme
              foreach (var item in stack)
              {
                  System.Console.WriteLine(item);
              }


              System.Console.WriteLine($"Bellekte kaplanan alan: {stack.Capacity}");
              //TrimExcess() -> fasla belleği bırakır
              stack.TrimExcess();
              System.Console.WriteLine($"TrimExcess() sonrası bellekte kaplanan alan: {stack.Capacity}");



              //Clear() -> tüm elemanları temizler
              stack.Clear();
              System.Console.WriteLine($"Clear sonrası eleman sayısı: {stack.Count}");
          }

      /*   private static void StackClassUnumAndInterfaceApp()
        {
            var charset = new Char[] { 'a', 'b', 'c', 'd', 'e' };

            var stack1 = new Stack<char>(StackType.LinkedList);
            var stack2 = new Stack<char>(StackType.Array);

            foreach (var item in charset)
            {
                System.Console.WriteLine(item);
                stack1.Push(item);
                stack2.Push(item);
            }

            System.Console.WriteLine("\nPeek");
            System.Console.WriteLine($"Stack1: {stack1.Peek()}");
            System.Console.WriteLine($"Stack2: {stack2.Peek()}");

            System.Console.WriteLine("\nCount");
            System.Console.WriteLine($"Stack1: {stack1.Count}");
            System.Console.WriteLine($"Stack2: {stack2.Count}");

            System.Console.WriteLine("\nPop");
            System.Console.WriteLine($"Stack1: {stack1.Pop} has been removed");
            System.Console.WriteLine($"Stack2: {stack2.Count} has been removed");


        } */
   
    }

    #region Stack (Yığın) | Tanım
    /*
     ***** LIFO ( Last In First Out ) : Son giren ilk çıkar
     ***** FILO ( First In Last Out ) : İlk giren son çıkar

    Properties
       -Count -> eleman sayısı döner

    Methods
       - push() -> yeni eleman ekler (üste koyar).
       - pop() -> en üstteki elemanı çıkarır ve döndürür
       - peek() -> en üsteki elemanı döndürür
       - Contains(T item) Stack içinde belirtilen eleman varmı kontol
       - Clear() -> tüm elemanları temizler
       - ToArray() -> Stack içeriğini diziye kopyalar
       - TrimExcess() -> Fazladan ayrılan belleği serbest bırakır
       - GetEnumerator() -> foreach ile gezmeye imkan verir.


    -- Yığınların sadece son elemanlarına erişim sağlanır
    -- Bu nedenle LIFO ve FIFO veri yapısı kullanılır
    -- System.Collection.Generic sınıfı altında yer alır.
    -- Generic -> Boxing ve Unboxing yoktur. Bu nedenle daha hazlıdır.
    -- T -> Type(tip) -> Stack<int> , Stack<string> -> tip güvenliği

    Özetle:
     Stack<T> genelde geçici veri saklama, geri dönüşlü işlemler, özyinileme, gezinti (geri/ileri) ve algoritma (DFS, parantez dengeleme) için kullanılır.
     Oyunlarda ise özellikle undo, inventory, stacking mekaniği için çok uygundur. 

     */
    #endregion

    //Genel Stack sınıfı, T tipinde veri tutar
  /*   public class Stack<T>
    {
        //İçerde hangi stack implementasyınunu kullanığımızı tutar
        private readonly IStack<T> stack1;

        //Stack'teki eleman sayısını verir
        public int Count => stack1.Count;

        //Constructor: hangi veri yapısını kullanacağımızı belirler
        public Stack(StackType type = StackType.Array)
        {   //List<T> tabanlı stack kullan
            if (type == StackType.Array)
            {
                stack1 = new ArrayStack<T>();
            }
            else
            {//LinkedList tabanlı stack kullan
                stack1 = new LinkedListStack<T>();
            }
        }

        //
        //En üstteki elemanı çıkar ve döndür
        public T Pop()
        {
            return stack1.Pop();
        }

        // En üstteki elemanı göster
        public T Peek()
        {
            return stack1.Peek();
        }
        //Yeni eleman ekle
        public void Push(T value)
        {
            stack1.Push(value);
        }
    }
    //LinkedList tabanlı Stack implementasyonu
    internal class LinkedListStack<T> : IStack<T>
    {

        private readonly LinkedList<T> LisLinked = new LinkedList<T>();
        //Stack'teki eleman sayısı
        public int Count { get; private set; }

        //Üstteki eleamnı göster
        public T Peek()
        {

            if (Count == 0)
            {
                throw new Exception("Empty stack!");
            }

            return LisLinked.First!.Value;


        }
        // Üstteki elemanı çıkar ve döndür
        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Empty stack!");
            }
            T temp = LisLinked.First!.Value;
            LisLinked.RemoveFirst();
            Count--;
            return temp;


        }
        //Stack'e yeni eleman ekle
        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            LisLinked.AddFirst(value);
            Count++;

        }
    }

    //Array<T> tabanlı Stack implementasyonu
    internal class ArrayStack<T> : IStack<T>
    {

        private readonly List<T> List = new List<T>();
        //Stackteki eleman sayısı
        public int Count { get; private set; }


        //Üstteki elemanı gör
        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Empty stack!");
            }
            return List[List.Count - 1];
        }

        //Üstteki elemanı çıkar
        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Empty stack!");
            }

            var temp = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            Count--;
            return temp;
        }

        //Stack' yeni eleman ekle
        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            List.Add(value);
            Count++;
        }
    }

    //stack'in temel işlevlerini tanımlayan interface
    public interface IStack<T>
    {
        int Count { get; } // eleman sayısı
        void Push(T value); // eleman ekleme
        T Peek();           // Üstteki elemanı görme
        T Pop();            // üstteki elemanı çıkarma


    }

    // Stack'in hangi tipte olacağını belirten enum
    public enum StackType
    {
        Array = 0,      //List<T> tabanlı stack
        LinkedList = 1  // LinkedList<T> tabanlı stack
    }
 */
}