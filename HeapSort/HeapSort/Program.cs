using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = {55, 31, 5, 79, 1, 21, 22, 19, 66, 35 };
            Heap hp = new Heap();
            hp.HeapSort(v);
            for (int i = 0; i <v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.ReadKey();
        }
    }
}
