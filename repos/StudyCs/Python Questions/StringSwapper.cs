using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{
    /*
     * Write a program that takes two strings a and b and 
     * prints the two strings concatenated,
     * but with the first two characters of each word swapped 
     * with the other word’s first two characters.
     * Sample: String a : Dog, String b : dinner -> Result : dig donner
     */
    class StringSwapper
    {
        string firstWord, secondWord;
        public StringSwapper(string a, string b)
        {
            firstWord = a;
            secondWord = b;
        }
        public string swap()
        {
            string result = secondWord.Substring(0, 2) + firstWord.Substring(2) + " " + firstWord.Substring(0, 2) + secondWord.Substring(2);
            return result;
        }

    }
}
