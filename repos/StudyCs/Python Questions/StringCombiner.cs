using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{
    /*
     * Consider dividing a string into two halves. 
     * If the length is even, the front and back halves are the same length.
     * If odd, we'll say the extra character goes in the front.
     * Sample: String a : abcd, String b : efghi -> Result : abefgcdhi
     * 
     */
    class StringCombiner
    {
        string firstWord, secondWord;
        public StringCombiner(string a, string b)
        {
            firstWord = a;
            secondWord = b;
        }
        public string combine()
        {
            string result, firstWordFirstHalf, firstWordSecondHalf, secondWordFirstHalf, secondWordSecondHalf;
            if (firstWord.Length % 2 == 0)
            {
                firstWordFirstHalf = firstWord.Substring(0, firstWord.Length / 2);
                firstWordSecondHalf = firstWord.Substring(firstWord.Length / 2);
            }
            else
            {
                firstWordFirstHalf = firstWord.Substring(0, (firstWord.Length / 2) + 1);
                firstWordSecondHalf = firstWord.Substring((firstWord.Length / 2) + 1);
            }
            if (secondWord.Length % 2 == 0)
            {
                secondWordFirstHalf = secondWord.Substring(0, secondWord.Length / 2);
                secondWordSecondHalf = secondWord.Substring(secondWord.Length / 2);
            }
            else
            {
                secondWordFirstHalf = secondWord.Substring(0, (secondWord.Length / 2) + 1);
                secondWordSecondHalf = secondWord.Substring((secondWord.Length / 2) + 1);
            }
            result = firstWordFirstHalf + secondWordFirstHalf + firstWordSecondHalf + secondWordSecondHalf;
            return result;
        }
    }

}
