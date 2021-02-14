using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class AlterCombine
    {
        public int[] altCombineLists(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];

            for (int i=0, j=0; i<res.Length; i+=2, j++)
            {
                res[i] = arr1[j];
                res[i + 1] = arr2[j];
            }

            return res;
        } 
    }
}
