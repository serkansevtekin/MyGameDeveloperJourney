using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Heap
{
    //Binary Heap için soyut (abstract) temel sınıf
    // Hem minheap hem maxheap bu sınıftan türetilir
    public abstract class BHeap<T> : IEnumerable<T>
    {
        
        //Heap elemanlarını tutan dizi
        public T[] Array { get; private set; }
        
        //Son eklenen pozisyonu gösterir
        private int position;

        // Heap'teki toplam eleman sayısı
        public int Count { get; private set; }

        //Varsayılan constructor (kapasite: 128)
        public BHeap()
        {
            Count = 0;
            position = 0;
            Array = new T[128];
        }

        //Parametreli cunstructor (kullanıcı kapasite belirleyebilir)
        public BHeap(int _size)
        {
            Count = 0;
            Array = new T[_size];
            position = 0;
        }

        //Sol çocuk indexi (2*i+1)
        private int GetLeftChaildIndex(int i) => 2 * i + 1;

        //Sağ çocuk indexi (2*i+2)
        private int GetRightChaildIndex(int i) => 2 * i + 2;

        //Parent indexi ((i-1)/2)
        private int GetParentIndex(int i) => (i - 1) / 2;

        //Sol çocuk var mı?
        private bool HasLeftChild(int i) => GetLeftChaildIndex(i) < position;

        //Sağ çocuk var mı?
        private bool HasRightChild(int i) => GetRightChaildIndex(i) < position;

        //Root mu?
        private bool IsRoot(int i) => i == 0;

        //Sol çocuk getir
        private T GetLeftChild(int i) => Array[GetLeftChaildIndex(i)];

        //Sağ çocuk getir
        private T GetRightChild(int i) => Array[GetRightChaildIndex(i)];

        //Parent'i getir
        private T GetParent(int i) => Array[GetParentIndex(i)];

        //Heap boş mu?
        public bool IsEmpty() => position == 0;

        //Heap'in tepe elemanını döndürür (root)
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty heap!");
            }
            return Array[0];
        }

        //İki elemanın yerlerinin değiştirir
        public void Swap(int first, int second)
        {
            var temp = Array[first];
            Array[first] = Array[second];
            Array[second] = temp;
        }

        //Heap'e eleman ekler
        public void Add(T value)
        {
            if (position == Array.Length)
            {
                throw new IndexOutOfRangeException("Overflow!");
            }
            //yeni elemanı ekle
            Array[position] = value;
            position++;
            Count++;

            //Heap düzenini korumak için yukarıdan aşağıya kontrol
            HeapifyUp();

        }

        //Root elemanı (Min veya Nax) siler
        public T DeleteMinMax()
        {
            if (position == 0)
            {
                throw new IndexOutOfRangeException("Overflow!");
            }
            var temp = Array[0];//Root elemanı kaydet
            Array[0] = Array[position - 1];//son elemanı root'a al
            position--;
            Count--;
            HeapifyDown();//Heap düzenini korumak için aşağıdan yukarıya kontrol
            return temp;

        }
        //Heapify davarnışı (MinHeao/MaxHeap'e göre değişir)
        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();
        
        //IEnumerator implementasyonu (foreach ile gezilebilir)
        public IEnumerator<T> GetEnumerator()
        {
            //Heap içindeki aktif elemalar kadarını (position sayısı kadarını) alır
            //Array'in tamamını değil, sadece kullanılan kısmını döndürür
            //IEnumerable<T>.GetEnumerator() döndürerek foreach ile gezilebilir hale getirir
            return Array.Take(position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}