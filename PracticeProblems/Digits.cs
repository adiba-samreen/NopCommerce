using System;
using System.Collections;
using System.Text;

namespace PracticeProblems
{
    class Digits
    {
        public ArrayList listOfDigits(int n)
        {
            ArrayList res = new ArrayList();

            int temp = n;

            while(temp > 0)
            {
                res.Add(temp%10);
                temp = temp / 10;
            }

            res.Reverse();
            return res;
        }
    }
}
