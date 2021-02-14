using System;
using System.Collections;
using System.Text;

namespace PracticeProblems
{
    class BaseConvert
    {
        private int converToDecimal (int n, int currentBase)
        {
            int temp = n;
            int sum = 0;
            for (int i=0;  temp > 0; i++)
            {
                sum += (temp % 10) * (int) Math.Pow(currentBase, i);
                temp = temp / 10;
            }
            return sum;
        }

        private int decimalToLower(int n, int targetBase)
        {

            ArrayList res = new ArrayList();

            int temp = n;
            int sum = 0;

            for (int i = 0; temp > 0; i++)
            {
                sum += (temp % targetBase) * (int)Math.Pow(10, i);
                temp = temp / targetBase;
            }

            return sum;
        }

        public int[] convertBase(int[] arr, int b1, int b2)
        {
            int[] res = new int[arr.Length];

            if (b1 == 10)
                for (int i = 0; i < arr.Length; i++)
                    res[i] = decimalToLower(arr[i], b2);

            else if (b2 == 10)
                for (int i = 0; i < arr.Length; i++)
                    res[i] = converToDecimal(arr[i], b1);

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = converToDecimal(arr[i], b1);
                    res[i] = decimalToLower(res[i], b2);
                }
            }

            return res;
        }

    }
}
