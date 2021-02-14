using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Palindrome
    {
        public bool isPalindrome(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                if (str[i] != str[j])
                    return false;

            return true;
        }
    }
}
