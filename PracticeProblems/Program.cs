using System;
using System.Collections;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 15, 22, 23, -6, 33 };

            /* 1 */
            Largest largest = new Largest();

            Console.WriteLine("The largest element is: " + largest.findLargest(arr));

            /* 2 */
            Reverse reverse = new Reverse();
            int[] reversedList = reverse.reverseList(arr);

            Console.Write("The reverserd array: ");
            for (int i=0; i<reversedList.Length; i++)
                Console.Write(reversedList[i] + " ");            
            Console.WriteLine();

            /* 3 */
            Exists exists = new Exists();
            int element = 33;

            if (exists.existsInList(arr, element))
                Console.WriteLine(element + " exists in the list");
            else
                Console.WriteLine(element + " does not exist in the list");

            /* 4 */
            Odd odd = new Odd();
            int[] oddElements = odd.oddElements(arr);
            Console.Write("Elements in Odd positions: ");
            for (int i = 0; i < oddElements.Length; i++)
                Console.Write(oddElements[i] + " ");
            Console.WriteLine();

            /* 5 */
            RunningTotal rt = new RunningTotal();
            int[] runningTotal = rt.runningTotalOfList(arr);
            Console.Write("Running Total: ");
            for (int i = 0; i < runningTotal.Length; i++)
                Console.Write(runningTotal[i] + " ");
            Console.WriteLine();

            /* 6 */
            Palindrome palindrome = new Palindrome();
            string str = "12321";

            if (palindrome.isPalindrome(str))
                Console.WriteLine("The string is a palindrome");
            else
                Console.WriteLine("The string is not a palindrome");

            /* 7 */
            Summation sum = new Summation();
            int[] arr2 = { 10, 15, 22, 23, -6, 33 };
            Console.WriteLine("Sum using for loop: " + sum.sumForLoop(arr2));
            Console.WriteLine("Sum using while loop: " + sum.sumWhileLoop(arr2));
            Console.WriteLine("Sum using recursion: " + sum.sumRecursion(arr2, arr2.Length));

            /* 8 */
            PerfectSquares perfectSquares = new PerfectSquares();

            int[] perfectSquaresUptoN = perfectSquares.perfectSquaresUptoN(20);
            Console.Write("Perfect squares upto 20: ");
            for (int i = 0; i < perfectSquaresUptoN.Length; i++)
                Console.Write(perfectSquaresUptoN[i] + " ");
            Console.WriteLine();

            /* 9 */
            Concatenate concatenate = new Concatenate();

            int[] list1 = { 1, 2, 3 };
            int[] list2 = { 4, 5, 6 };
            int[] concatenated = concatenate.concatLists(list1, list2);

            Console.Write("Concatenated List: ");
            for (int i = 0; i < concatenated.Length; i++)
                Console.Write(concatenated[i] + " ");
            Console.WriteLine();

            /* 10 */
            AlterCombine alterCombine = new AlterCombine();
            int[] alterCombinedList = alterCombine.altCombineLists(list1, list2);
            Console.Write("Alternatively List: ");
            for (int i = 0; i < alterCombinedList.Length; i++)
                Console.Write(alterCombinedList[i] + " ");
            Console.WriteLine();

            /* 11 */
            MergeSortedLists mergeSortedLists = new MergeSortedLists();
            int[] sorted1 = {1, 4, 6};
            int[] sorted2 = { 2, 3, 5 };
            int[] sortedRes = mergeSortedLists.mergeLists(sorted1, sorted2);

            Console.Write("Sorted List after Merge: ");
            for (int i = 0; i < sortedRes.Length; i++)
                Console.Write(sortedRes[i] + " ");
            Console.WriteLine();

            /* 12 */
            Rotate rotate = new Rotate();
            rotate.rotateK(sortedRes, 2);
            Console.Write("Rotated list: ");
            for (int i = 0; i < sortedRes.Length; i++)
                Console.Write(sortedRes[i] + " ");
            Console.WriteLine();

            /* 13 */
            Fibonacci fibonacci = new Fibonacci();
            long[] fibo = fibonacci.firstNFibo(100);

            Console.Write("First 100 fibonacci numbers: ");
            for (int i = 0; i < fibo.Length; i++)
                Console.Write(fibo[i] + " ");
            Console.WriteLine();

            /* 14 */
            Digits digits = new Digits();

            ArrayList arrayList = digits.listOfDigits(2342);
            Console.Write("List of digits: ");
            for (int i = 0; i < arrayList.Count; i++)
                Console.Write(arrayList[i] + ", ");
            Console.WriteLine();

            /* 16 */
            BaseConvert baseConvert = new BaseConvert();
            int[] exmpl = { 10, 100, 1000, 11 };
            int[] converted = baseConvert.convertBase(exmpl, 2, 10);
            Console.Write("After Converting base of the elements: ");
            for (int i = 0; i < converted.Length; i++)
                Console.Write(converted[i] + " ");
            Console.WriteLine();

            /* 17 */
            Sort sort = new Sort();
            int[] unsortedArr = {0, 5, 8, -2, 12, 5 };

            sort.StoogeSort(unsortedArr, 0, unsortedArr.Length-1);
            Console.Write("After sorting: ");
            for (int i = 0; i < unsortedArr.Length; i++)
                Console.Write(unsortedArr[i] + ", ");
            Console.WriteLine();

            /* 18 */
            BinarySearch bs = new BinarySearch();
            int find = 12;

            int indx = bs.binarySearch(unsortedArr, find);
            if (indx != -1)
                Console.WriteLine("Element is found at index: " + indx);
            else
                Console.WriteLine("Item not found");

            /* 19 */
            Frame frame = new Frame();
            string[] strList = { "Hello", "World", "in", "a", "frame" };
            frame.printFrame(strList);

            /* 20 */
            PigLatin pigLatin = new PigLatin();
            Console.WriteLine(pigLatin.translate("the quick brown fox"));
        }
    }
}
