using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Reverse
    {
        public int[] reverseList(int[] arr)
        {
            for (int i=0, j=arr.Length-1; i<j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }
    }
}
