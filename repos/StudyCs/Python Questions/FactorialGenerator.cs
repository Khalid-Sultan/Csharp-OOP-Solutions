using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{

    /*
     * Write a Program that generates the factorial of a given number.
     * 
     */
    class FactorialGenerator
    {
        int number;
        public FactorialGenerator(int n)
        {
            number = n;
        }
        public int generateFactorial()
        {
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
