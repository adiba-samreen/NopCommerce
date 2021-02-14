using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Fibonacci
    {
        public long[] firstNFibo(int n)
        {
            long[] res = new long[n];

            res[0] = 1; 

            if (n >= 2)
            {
                res[1] = 1;

                for (int i=2; i<n; i++)
                    res[i] = res[i - 2] + res[i - 1];
            }


            return res;
        }
    }
}
