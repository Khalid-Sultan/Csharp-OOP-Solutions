using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Python_Questions
{


    /*
     * Make a program that prints out a diamond pattern.
     */
    class DiamondPattern
    {
        public void doPattern(int levels)
        {
            // top half
            for (int i = 0; i < levels; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int j1 = levels; j1 > i - 1; j1--)
                {
                    Write(" ");
                }
                for (int j2 = 0; j2 <= i; j2++)
                {
                    Write("* ");
                }
                for (int j3 = levels; j3 > i - 1; j3--)
                {
                    Write(" ");
                }
                WriteLine();
            }
            // bottom half
            for (int i = levels; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int j1 = levels; j1 > i - 1; j1--)
                {
                    Write(" ");
                }
                for (int j2 = 0; j2 <= i; j2++)
                {
                    Write("* ");
                }
                for (int j3 = levels; j3 > i - 1; j3--)
                {
                    Write(" ");
                }
                WriteLine();
            }
        }
    }


}
