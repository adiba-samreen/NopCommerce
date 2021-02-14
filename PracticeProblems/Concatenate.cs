using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Concatenate
    {
        public int[] concatLists (int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];

            for (int i=0, j=0; i<res.Length; i++)
            {
                if (i < arr1.Length)
                    res[i] = arr1[i];

                else
                {
                    res[i] = arr2[j];
                    j++;
                }
            }
            return res;
        }
    }
}
