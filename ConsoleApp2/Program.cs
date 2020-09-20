using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Adrian Wojciechowski
 * Quicksort algorithm
 * 
 * Speed:
 * Worst case O(n^2)
 * Average case O(n*log(n))
 * 
 * Memory:
 * O(n)
 */

namespace Quick_Sort
{
    class Program
    {
        private static void quicksort(int[] t, int begin, int end)
        {
            if (begin >= end)
                return;
            int i = partition(t, begin, end);
            quicksort(t, begin, i);
            quicksort(t, i + 1, end);
        }

        private static int partition(int[] t, int begin, int end)
        {
            int pivot = t[begin];
            int j = begin;
            int pos = begin;
            for (int i = begin + 1; i <= end; i++)
            {
                if (t[i] < pivot)
                {
                    if (t[j] == pivot)
                        pos = i;
                    int temp = t[i];
                    t[i] = t[j];
                    t[j] = temp;
                    j++;
                }
            }
            t[pos] = t[j];
            t[j] = pivot;
            return j;
        }

        static void Main(string[] args)
        {
            int[] t = { 3, 1, 5, 4, 2 };
            quicksort(t, 0, 4);
            foreach (int x in t)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}