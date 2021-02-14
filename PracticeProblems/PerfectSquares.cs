using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class PerfectSquares
    {
        int[] on_all(int[] arr, Func<int, int> f) // f takes 1 int and returns 1 int
        {
            int[] res = new int[arr.Length];

            for (int i=0; i<arr.Length; i++)
                res[i] = f(arr[i]);

            return res;
        }

        int square (int n)
        {
            return n * n;
        }

        public int[] perfectSquaresUptoN (int n)
        {
            int[] arr = new int[n];
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            res = on_all(arr, square);

            return res;
        }
    }
}
