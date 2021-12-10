using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTIRovki
{
    static class Sorters
    {
        public static void InsertionSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        double temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void InsertionSortWithBinarySearch(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                double x = array[i];
                int j = Math.Abs(Array.BinarySearch(array, 0, i, x) + 1);
                Array.Copy(array, j, array, j + 1, i - j);
                array[j] = x;
            }
        }
        public static void ShellSort(double[] array)
        {
            for (int h = array.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < array.Length; i += 1)
                {
                    double temp = array[i];
                    int j;
                    for (j = i; j >= h && array[j - h] > temp; j -= h)
                    {
                        array[j] = array[j - h];
                    }

                    array[j] = temp;
                }
            }
        }
        public static void BubbleSort(double[] mas)
        {
            uint change_count = 1;
            double dummy;
            while (change_count != 0)
            {
                change_count = 0;
                for (uint i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        dummy = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = dummy;
                        change_count++;
                    }
                }
            }
        }
        public static void QuickSort(double[] mas, int beginning, int ending)
        {
            if (beginning < ending)
            {
                int pivotIndex = Partition(mas, beginning, ending);
                QuickSort(mas, beginning, pivotIndex - 1);
                QuickSort(mas, pivotIndex + 1, ending);
            }
        }
        public static void QuickSort(double[] mas)
        {
            QuickSort(mas, 0, mas.Length - 1);
        }

        private static int Partition(double[] mas, int beginning, int ending)
        {
            int pivot = beginning - 1;
            double temp;
            for (int i = beginning; i < ending; i++)
            {
                if (mas[i] < mas[ending])
                {
                    pivot++;
                    temp = mas[pivot];
                    mas[pivot] = mas[i];
                    mas[i] = temp;
                }
            }
            pivot++;
            temp = mas[pivot];
            mas[pivot] = mas[ending];
            mas[ending] = temp;
            return pivot;
        }
    }
}
