using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Odd
    {
        public int[] oddElements(int[] arr)
        {
            int[] res = new int[(int) Math.Ceiling(arr.Length/2.0)];

            for(int i=0, j=0; i<arr.Length; i+=2, j++)
            {
                res[j] = arr[i];
            }

            return res;
        }
    }
}
