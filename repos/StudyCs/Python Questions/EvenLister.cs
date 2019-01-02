using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{

    /* 
     * Write a code that takes a list and print out only even elements of the list
     * Sample : a = [1,4,9,16,25,36,49,64,81,100] -> Result : [4,16,36,64,100]
     *
     */
    class EvenLister
    {
        List<int> evenList;
        string result = "[ ";
        public EvenLister(List<int> l)
        {
            evenList = l;
        }
        public string EvenExtractor()
        {
            for (int i = 0; i < evenList.Count; i++)
            {
                if (evenList.ElementAt(i) % 2 != 0) evenList.Remove(evenList.ElementAt(i));
            }
            for (int i = 0; i < evenList.Count; i++)
            {
                result += evenList.ElementAt(i) + " ";
            }
            result += "]";
            return result;
        }
    }
}
