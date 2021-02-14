using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Exists
    {
        public bool existsInList(int[] arr, int element)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (element == arr[i])
                    return true;
            }

            return false;
        }
    }
}
