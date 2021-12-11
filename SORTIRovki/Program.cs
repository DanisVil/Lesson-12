using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTIRovki
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10] { 5, 4, 6, 9, 1, 3, 2, 7, 8, 10 };
            //Console.WriteLine(Array.BinarySearch(array, 0, 8, 7));
            Sorters.HeapSort(array);
            foreach (double number in array)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
