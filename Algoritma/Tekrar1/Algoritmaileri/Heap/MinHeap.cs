using System;

namespace Programlama.Tekrars1.Heap
{
    public class MinHeap
    {

        private List<int> heap = new List<int>();

        public int Count => heap.Count;

        // Tepe elemanı görmek, pop yapmadan
        public int Peek()
        {
            return heap[0];
        }

        //Swap = iki elemanın yerini değiştir
        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        //Eleman ekle
        public void Insert(int value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);


        }

        // Max elemanı al ve çıkar
        public int PopMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap boş!");

            int min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
                HeapifyDown(0);

            return min;
        }

        // Yukarı taşı (Insert sonrası)
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index] >= heap[parentIndex]) break;
                Swap(index, parentIndex);
                index = parentIndex;
            }

        }

        // Aşağı taşı (pop sonrası)
        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;
                if (left <= lastIndex && heap[left] < heap[smallest])
                    smallest = left;

                if (right <= lastIndex && heap[right] < heap[smallest])
                    smallest = right;

                if (smallest == index) break;

                Swap(index, smallest);
                index = smallest;

            }
        }


        // Heap elemanlarını yazdır
        public void PrintHeap()
        {
            System.Console.WriteLine(string.Join(", ", heap));
        }

    }
}