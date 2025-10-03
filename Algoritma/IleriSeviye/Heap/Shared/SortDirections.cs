using System;

namespace Programlama.IleriAlgoritma.Heap
{
    public enum SortDirction
    {
        Asceding = 0,
        Descending = 1
    }
    public class CustomComparer<T> : IComparer<T> where T : IComparable
    {
        private readonly bool isMax;
        private readonly IComparer<T>? ccomparer;

        public CustomComparer(SortDirction sortDirction, IComparer<T> comparer)
        {
            this.isMax = sortDirction == SortDirction.Descending;
            ccomparer = comparer;
        }

        public int Compare(T? x, T? y)
        {
            return !isMax ? compares(x!, y!): compares(y!, x!);
        }

      

        private int compares(T x, T y) => ccomparer!.Compare(x, y);
    }
}