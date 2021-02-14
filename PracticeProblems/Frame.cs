using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class Frame
    {
        public void printFrame (string[] str)
        {
            Console.WriteLine("********************");

            for (int i=0; i<str.Length; i++)
                Console.WriteLine("*  " + str[i] + "  *");

            Console.WriteLine("********************");
        }
    }
}
