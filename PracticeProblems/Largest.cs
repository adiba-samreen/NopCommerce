using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Largest
    {
        public int findLargest(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return -9999;

            else
            {
                int largest = arr[0];

                for (int i = 1; i < arr.Length; i++)
                    if (largest < arr[i])
                        largest = arr[i];

                return largest;
            }
        }
    }
}
