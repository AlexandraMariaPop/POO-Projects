using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class GenericHeapSort<T> where T:IComparable<T>
    {
        public static int Parent(int i)
        {
            return i / 2;
        }
        public static int Left(int i)
        {
            return 2 * i + 1;
        }
        public static int Right(int i)
        {
            return 2 * i + 2;
        }
        public void Max_Heapify(T[] A, int i, int heapsize)
        {
            int l = Left(i);
            int r = Right(i);
            int largest = i;
            if (l <= heapsize)
            {  //&& (A[l] > A[i]))
                int compare = A[l].CompareTo(A[i]);
                if(compare>0)
                largest = l;
            }
            if (r <= heapsize)
            {//&& (A[r] > A[largest]))
                int compare = A[r].CompareTo(A[largest]);
                if(compare>0)
                largest = r;
            }
            if (largest != i)
            {
                Swap(ref A[i], ref A[largest]);
                Max_Heapify(A, largest, heapsize);
            }

        }
        public void Build_Max_Heap(T[] A, int size)
        {
            int heapsize = A.Length - 1;
            for (int i = heapsize / 2; i >= 0; i--)
            {
                Max_Heapify(A, i, size);
            }
        }
        public void HeapSort(T[] A)
        {
            int heapsize = A.Length - 1;
            Build_Max_Heap(A, heapsize);

            for (int i = heapsize; i >= 1; i--)
            {
                Swap(ref A[0], ref A[i]);
                heapsize--;
                Max_Heapify(A, 0, heapsize);
            }
        }

        private void Swap(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }
    }
}
