using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Rotate
    {
        public void rotateK (int[] arr, int k)
        {
            while (k>0)
            {
                int temp = arr[0];

                for  (int j=0; j<arr.Length-1; j++)
                    arr[j] = arr[j+1];

                arr[arr.Length-1] = temp;

                k--;
            }
        }
    }
}
