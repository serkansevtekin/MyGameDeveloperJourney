namespace Programlama.IleriAlgoritma.Heap
{
    /// <summary>
    /// MinHeap sınıfı, Bheap sınıfından türetilmiş ve IComparable tiplerini saklayabilen min öncelikli kuyruk
    /// </summary>
    /// <typeparam name="T">IComparable arayüzünü implement eden tipler</typeparam>
    public class MinHeap<T> : BHeap<T>, IEnumerable<T> where T : IComparable
    {

        //MinHeap constructor'ı. Base class constructor'ını çağırır.
        public MinHeap() : base() // BHeap<T> constructor'ını çalıştırır
        {
            //Burada ek initialization gerekirse yapıla bilir
        }

        /// <summary>
        /// Parametreli MinHeap constructor'ı
        /// Base class BHeap'in parametreli constructorun'ını çağırır ve başlangıç boyunutunu (_size)iletir
        /// </summary>
        /// <param name="_size">Heap için başlangıç kapasitesi</param>
        public MinHeap(int _size) : base(_size)
        {

        }

        /// <summary>
        /// Koleksiyon tabanlı MinHeap constructor'ı
        /// Verilen IEnumerable<T> koleksiyonu base class BHeap'in constructor'ına iletir
        /// Böylece tüm elemanlar heap'e eklenmiş olur ve minHeap oluşur.
        /// </summary>
        /// <param name="collection">Heap'e eklenecek başlangıç elemanları</param>
        public MinHeap(IEnumerable<T> collection) : base(collection)
        {

        }



        /// <summary>
        /// Ağaçta elemanı aşağıya doğru heap kurallarına göre yerleştirir
        /// MinHeap için parent-child ilişkisine göre aşağı doğru swap yapılır.
        /// </summary>

        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallIndex = GetLeftChaildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).CompareTo(GetLeftChild(index)) < 0)
                {
                    smallIndex = GetRightChaildIndex(index);
                }
                if (Array[smallIndex].CompareTo(Array[index]) >= 0)
                {
                    break;

                }

                Swap(smallIndex, index);
                index = smallIndex;
            }
        }

        /// <summary>
        /// Ağaçta elemanı yukarı doğru heap kurllarına göre yerleştirir
        /// MinHeap için parent-child ilişkisine göre yukarı doğru swap yapılır
        /// </summary>
        protected override void HeapifyUp()
        {
            var index = position - 1;
            while (!IsRoot(index) && Array[index].CompareTo(GetParent(index)) < 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }


    }



    public class MaxHeap<T> : BHeap<T>, IEnumerable<T> where T : IComparable
    {
        public MaxHeap() : base()
        {

        }
        public MaxHeap(int _size) : base(_size)
        {

        }
        public MaxHeap(IEnumerable<T> colleciton) : base(colleciton)
        {

        }
        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallIndex = GetLeftChaildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).CompareTo(GetLeftChild(index)) > 0)
                {
                    smallIndex = GetRightChaildIndex(index);
                }
                if (Array[smallIndex].CompareTo(Array[index]) < 0)
                {
                    break;

                }

                Swap(smallIndex, index);
                index = smallIndex;
            }
        }

        protected override void HeapifyUp()
        {
             var index = position - 1;
            while (!IsRoot(index) && Array[index].CompareTo(GetParent(index)) > 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }

}