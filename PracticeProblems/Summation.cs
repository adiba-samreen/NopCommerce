using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Summation
    {
        public int sumForLoop(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        public int sumWhileLoop(int[] arr)
        {
            int sum = 0;
            int i = 0;
            while (i < arr.Length)
            {
                sum += arr[i];
                i++;
            }
            return sum;
        }

        public int sumRecursion(int[] arr, int size)
        {
            if (size == 1)
                return arr[0];

            else
                return arr[size - 1] + sumRecursion(arr, size-1);
        }
    }
}
