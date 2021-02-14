using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Sort
    {
        public void SelectionSort(int[] arr)
        {
            for (int i=0; i < arr.Length-1; i++)
            {
                int min = i;

                for (int j=i+1; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;
                 
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];

                for (int j=i-1; j >= 0; j--)
                {
                    if (key < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = key;
                    }
                }
            }
        }

        private void merge(int[] arr, int start, int mid, int end)
        {
            int leftSize = mid - start + 1;
            int rightSize = end - mid;

            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            for (int i=0; i < leftSize; i++)
                left[i] = arr[start + i];
            for (int j=0; j < rightSize; j++)
                right[j] = arr[mid + 1 + j];

            int leftIndx = 0;
            int rightIndx = 0;
            int k = start;

            while (leftIndx < leftSize && rightIndx < rightSize)
            {
                if (left[leftIndx] <= right[rightIndx])
                {
                    arr[k] = left[leftIndx];
                    leftIndx++;
                }
                else
                {
                    arr[k] = right[rightIndx];
                    rightIndx++;
                }
                k++;
            }

            while (leftIndx < leftSize)
            {
                arr[k] = left[leftIndx];
                leftIndx++;
                k++;
            }

            while (rightIndx < rightSize)
            {
                arr[k] = right[rightIndx];
                rightIndx++;
                k++;
            }
        }

        public void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;

                MergeSort(arr, left, m);
                MergeSort(arr, m + 1, right);

                merge(arr, left, m, right);
            }
        }

        private int partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left-1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp;
            return i+1;
        }

        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right);
                
                QuickSort(arr, left, pivot - 1);

                QuickSort(arr, pivot + 1, right);
            }
        }

        public void StoogeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            if (arr[left] > arr[right])
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }

            if (right - left + 1 > 2)
            {
                int temp = (right - left + 1) / 3;
 
                StoogeSort(arr, left, right - temp);

                StoogeSort(arr, left + temp, right);

                StoogeSort(arr, left, right - temp);
            }
        }
    }
}
