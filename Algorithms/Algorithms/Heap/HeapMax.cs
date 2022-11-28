using System;
using Algorithms.Exceptions;

namespace Algorithms.Heap
{
    public class HeapMax
    {
        public int[] Heap{ get; private set; }
        public int tail;

        public HeapMax(int capacity)
        {
            Heap = new int[capacity];
            tail = -1;
        }

        private bool IsEmpty()
        {
            return this.tail == -1;
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index <= tail;
        }

        private bool IsLeaf(int index)
        {
            return index > Parent(tail) && index <= tail;
        }

        private int Left(int index)
        {
            return ((2*index) + 1);
        }
        private int Right(int index)
        {
            return (2 * (index + 1));
        }
        private int Parent(int index)
        {
            return ((index - 1) / 2);
        }

        public void InsertHeapMax(int n)
        {
            tail += 1;
            this.Heap[tail] = n;

            int i = tail;
            while(i>0 && this.Heap[Parent(i)] < this.Heap[i])
            {
                int aux = this.Heap[i];

                this.Heap[i] = this.Heap[Parent(i)];
                this.Heap[Parent(i)] = aux;
                i = Parent(i);
            }

        }

        public int Remove()
        {
            if(IsEmpty())
                throw new DomainException("Empty");

            int elementRoot = this.Heap[0];
            this.Heap[0] = this.Heap[tail];
            this.tail -= 1;

            Heapify(0);

            return elementRoot;

        }

        private int MaxValueIndex(int index, int left, int right)
        {
            if (this.Heap[index] > this.Heap[left])
            {
                if(IsValidIndex(right))
                {
                    if (this.Heap[index] < this.Heap[right])
                        return right;
                }

                return index;
            }
            else
            {
                if (IsValidIndex(right))
                {
                    if (this.Heap[left] < this.Heap[right])
                        return right;
                }
                return left;
            }
        }

        private void Swap(int i, int j)
        {
            int aux = this.Heap[i];
            this.Heap[i] = this.Heap[j];
            this.Heap[j] = aux;
        }

        private void Heapify(int index)
        {
            if (IsLeaf(index) || !IsValidIndex(index))
                return;

            int indexMax = MaxValueIndex(index, Left(index), Right(index));

            if(indexMax != index)
            {
                Swap(index, indexMax);
                Heapify(indexMax);
            }
        }

        public void BuildHeap()
        {
            for (int i = Parent(this.tail); i >= 0; i--)
            {
                Heapify(i);
            }
        }

    }
}

