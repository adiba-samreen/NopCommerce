using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class BinarySearch
    {
        public int binarySearch(int[] arr, int item)
        {
            int left = 0;
            int right = arr.Length-1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == item)
                    return mid;

                if (arr[mid] < item)
                    left = mid + 1;

                else
                    right = mid - 1;
            }

            return -1;  // Not found
        }
    }
}
