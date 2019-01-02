using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{
    /* Take two lists, and write a program that returns a list 
     * that contains only the elements that are common between the lists (without duplicates). 
     * Make sure your program works on two lists of different sizes.
     * Sample : list1 is [1,2,3,4,5,6], list2 is [1,3,4,6,7,9] -> Result : [1,3,4,6]
     */
    class DuplicateExtractor
    {
        private List<int> list1;
        private List<int> list2;

        public DuplicateExtractor(List<int> list1, List<int> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
        }

        public string ExtractDuplicates()
        {
            List<int> newList = new List<int>();
            String s = "[ ";
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1.ElementAt(i) == list2.ElementAt(j))
                    {
                        if (!newList.Contains(list1.ElementAt(i)))
                        {
                            newList.Add(list1.ElementAt(i));
                        }
                    }
                }
            }
            foreach (int i in newList)
            {
                s += i + " ";
            }
            s += "]";
            return s;
        }
    }
}
