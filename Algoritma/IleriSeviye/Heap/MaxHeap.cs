namespace Programlama.IleriAlgoritma.Heap
{
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