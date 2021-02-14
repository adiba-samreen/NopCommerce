using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class RunningTotal
    {
        public int[] runningTotalOfList(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                arr[i] += arr[i - 1];

            return arr;
        }
    }
}
