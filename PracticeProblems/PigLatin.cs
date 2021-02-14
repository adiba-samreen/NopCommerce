using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class PigLatin
    {
        public string translate(string str)
        {
            string[] words = str.Split(" ");
            StringBuilder res = new StringBuilder();

            for (int i=0; i<words.Length; i++)
            {
                // string currentWord = words[i];
                StringBuilder currentWord = new StringBuilder(words[i]);

                char temp = currentWord[0];

                for (int j = 0; j < currentWord.Length - 1; j++)
                    currentWord[j] = currentWord[j + 1];

                currentWord[currentWord.Length - 1] = temp;
                currentWord.Append("ay");

                res.Append(currentWord + " ");
            }

            return res.ToString();
        }
    }
}
