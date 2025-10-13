using System;
using Programlama.IleriAlgoritma.Heap;

namespace Programlama.IleriAlgoritma.Sort
{
    public class SortingAlgorithms
    {
        public static void SortingAlgorithmisRunMethod()
        {
            //PriorityQueue veya .Sort() kullanmak hespinden iyi

            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (int item in arr)
            {
                System.Console.Write($"{item}  ");
            }

            System.Console.WriteLine("\n");

            //SelectionSort.Sort<int>(arr);
            // BubbleSort.Sort(arr);

            //InsertionSort.Sort<int>(arr, SortDirction.Asceding);
            QuickSort.Sort(arr);
            foreach (int item in arr)
            {
                System.Console.Write($"{item}  ");
            }

        }


    }

    #region Selection sort [Seçmeli sıralama]
    public class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[minIndex];
                    }
                }

                SortingSwap.Swap<T>(array, i, minIndex);
            }
        }
    }
    #endregion
    #region Swap
    public class SortingSwap
    {

        public static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

    }
    #endregion

    #region Bubble Sort [Kabarcık Sıralama]
    public class BubbleSort
    {
        /// <summary>
        /// Time Complexity : O(n2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        SortingSwap.Swap(array, j, j + 1);
                    }
                }
            }
        }
    }
    #endregion

    #region Insertion Sort [Araya eklemeli liste]
    public class InsertionSort
    {
        public static T[] Sort<T>(T[] arr, SortDirction sortDirction = SortDirction.Asceding) where T : IComparable
        {
            var comparer = new CustomComparer<T>(sortDirction, Comparer<T>.Default);
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (comparer.Compare(arr[j], arr[j - 1]) < 0)
                    {
                        SortingSwap.Swap(arr, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }
    }
    #endregion


    #region Quick sort [hızlı sıralama algoritması]
    public class QuickSort
    {
        public static void Sort<T>(T[] arr) where T: IComparable
        {
            Sort(arr,0,arr.Length -1); 
        }
        private static void Sort<T>(T[] arr , int lower, int upper) where T: IComparable
        {
            if (lower < upper)
            {
                int ParititionIndex = Paritition<T>(arr, lower, upper);
                Sort(arr, lower, ParititionIndex);
                Sort(arr, ParititionIndex + 1, upper);
            }
        }
        private static int Paritition<T>(T[] arr, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = arr[lower];
            do
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i >= j)
                {
                    break;
                }
                SortingSwap.Swap(arr, i, j);
            } while (i <= j);
            return j;
        }
  

    }
    #endregion
}