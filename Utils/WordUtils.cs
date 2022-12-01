using System;
using System.Collections.Generic;
using System.Text;

namespace shellsort_project.Utils
{
    class WordUtils
    {
        public string firstCharToUpperCase(string word)
        {
            word = word.ToLower();

            string firstLetter = word[0].ToString().ToUpper();
            return new string(firstLetter + word.Substring(1));

        }
    }
}
