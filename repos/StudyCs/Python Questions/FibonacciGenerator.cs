using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{


    /*
     * Write a program that generates the fibonacci sequence.
     * Sample: Numbers: 5 -> Result: 0,1,1,2,3
     */
    class FibonacciGenerator
    {
        int numbers;
        public FibonacciGenerator(int n)
        {
            numbers = n;
        }
        public string generate()
        {
            string s = "[ ";
            List<int> l = new List<int> { 0 , 1 };
            for (int i = 2; i < numbers; i++)
            {
                int n = l.ElementAt(l.Count - 1) + l.ElementAt(l.Count - 2);
                l.Add(n);
            }
            foreach (int a in l)
            {
                s += a + " ";
            }
            s += "]";
            return s;
        }
    }
}
