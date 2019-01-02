using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Python_Questions
{
    /*
     * Write a program that checks if a number is prime or not.
     */
    class PrimeOrNot
    {
        int number;
        public PrimeOrNot(int n)
        {
            number = n;
        }
        public bool primeOrNot()
        {
            int factors = 1;
            for (int i = 1; i < number; i++)
            {
                if (number % factors == 0)
                {
                    factors += 1;
                }
                if (factors > 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
