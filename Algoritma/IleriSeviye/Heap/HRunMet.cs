using System;

namespace Programlama.IleriAlgoritma.Heap
{
    public class HeapRunClass
    {
        public static void HeapRunMethod()
        {
            var list = new List<int>() { 54, 45, 36, 27, 29, 18, 21, 99 };

            var heap = new BinnaryHeap<int>(SortDirction.Asceding, list);
            
            foreach (var item in heap)
            {
                System.Console.Write(item + " ");
            }
            /* var heap = new MinHeap<int>(list);

            System.Console.WriteLine(heap.DeleteMinMax() + " Has been removed");
            System.Console.WriteLine();
            foreach (var item in heap)
            {
                System.Console.WriteLine(item);
            } */

            /* var heap = new MaxHeap<int>(list);

            heap.DeleteMinMax();

            */



        }
    }
}