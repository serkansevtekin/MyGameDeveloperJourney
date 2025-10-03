using System;
using System.Collections;

namespace Programlama.IleriAlgoritma.Heap
{
    public class BinnaryHeap<T> : IEnumerable<T> where T : IComparable
    {

        //Heap elemanlarını tutan dizi
        public T[] Array { get; private set; }

        //Son eklenen pozisyonu gösterir
        private int position;

        // Heap'teki toplam eleman sayısı
        public int Count { get; private set; }

        private readonly IComparer<T>? comparer;
        private readonly bool isMax;

        //Varsayılan constructor (kapasite: 128)
        public BinnaryHeap()
        {
            Count = 0;
            position = 0;
            Array = new T[128];
        }

        //Parametreli cunstructor (kullanıcı kapasite belirleyebilir)
        public BinnaryHeap(int _size)
        {
            Count = 0;
            Array = new T[_size];
            position = 0;
        }

        //BHeap koleksiyon tabanlı constructor'ı
        //Verilen IEnumerable<T> collection içindeki elemanları heap'e ekler
        public BinnaryHeap(IEnumerable<T> collection)
        {
            //Başlangıç heap boş
            Count = 0;

            //Heap dizisini collection boyutuna göre ayarla
            Array = new T[collection.ToArray().Length];

            position = 0;//Dizide ekleme pozisyonu başlangıcı

            //Collection içindeki her elemanı heap'e ekle
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public BinnaryHeap(SortDirction sortDirction = SortDirction.Asceding) : this(sortDirction, null, null)
        {

        }
        public BinnaryHeap(SortDirction sortDirction = SortDirction.Asceding, IEnumerable<T>? initial = null) : this(sortDirction, initial, null)
        {

        }

        public BinnaryHeap(SortDirction sortDirction = SortDirction.Asceding,IComparer<T>? comparer = null) : this(sortDirction, null, comparer)
        {

        }

        public BinnaryHeap(SortDirction sortDirction, IEnumerable<T>? initial, IComparer<T>? comparer)
        {
            position = 0;
            Count = 0;
            this.isMax = sortDirction == SortDirction.Descending;
            if (comparer != null)
            {
                this.comparer = new CustomComparer<T>(sortDirction, comparer);

            }
            else
            {
                this.comparer = new CustomComparer<T>(sortDirction, Comparer<T>.Default);
            }
            if (initial != null)
            {
                var items = initial as T[] ?? initial.ToArray();
                Array = new T[items.Count()];
                foreach (var item in items)
                {
                    Add(item);
                }
            }
            else
            {
                Array = new T[128];

            }
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
        protected void HeapifyUp()
        {
            var index = position - 1;
            while (!IsRoot(index) && comparer!.Compare(Array[index], GetParent(index))<0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
        protected void HeapifyDown()
        {
            var index = 0;
            while (HasLeftChild(index))
            {
                var smallIndex = GetLeftChaildIndex(index);
                if (HasRightChild(index) && comparer!.Compare(GetRightChild(index), GetLeftChild(index)) < 0)
                {
                    smallIndex = GetRightChaildIndex(index);
                }
                if (comparer!.Compare(Array[smallIndex], Array[index]) >= 0)
                {
                    break;
                }
                Swap(smallIndex, index);
                index = smallIndex;
            }
         }
        public IEnumerator<T> GetEnumerator()
        {
            return Array.Take(position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}