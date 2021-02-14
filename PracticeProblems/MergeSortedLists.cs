using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class MergeSortedLists
    {
        public int[] mergeLists (int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];

            for (int i=0, a1Indx=0, a2Indx=0; i<res.Length; i++)
            {
                if (a1Indx >= arr1.Length)
                {
                    res[i] = arr2[a2Indx];
                    a2Indx++;
                }
                else if (a2Indx >= arr2.Length)
                {
                    res[i] = arr1[a1Indx];
                    a1Indx++;
                }
                else if (arr1[a1Indx] < arr2[a2Indx])
                {
                    res[i] = arr1[a1Indx];
                    a1Indx++;
                }
                else
                {
                    res[i] = arr2[a2Indx];
                    a2Indx++;
                }
            }

            return res;
        }
    }
}
