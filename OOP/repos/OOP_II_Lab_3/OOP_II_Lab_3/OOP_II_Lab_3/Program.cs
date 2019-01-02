using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace OOP_II_Lab_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Question 1");
            Q_1();
            WriteLine("Question 2");
            Q_2();
        }
        public static void Q_1()
        {
            // If you want a randomly generated jagged array, Uncomment the following Lines
                //string[][][] jaggedArray = ArrayMethods.generateRandomJaggedArray(3);
                //string[][][] headOrTailArray = ArrayMethods.MakeTossingArray(jaggedArray);
            string[][][] headOrTailArray = ArrayMethods.constructJaggedArray();
            ArrayMethods.PrintOutArray(headOrTailArray);
            Question_1.countHeads(headOrTailArray);
            Question_1.countConsecutiveHeads(headOrTailArray);
            Question_1.countConsecutiveTails(headOrTailArray);
        }
        public static void Q_2()
        {
            // If you want a randomly generated multi dimensional array, Uncomment the following Lines 
                //int[,,] m = ArrayMethods.generateRandomMultidimensionalArray();
                //int[,,] multidimensionalArray = ArrayMethods.MakeMultiDimensionalArray(m);
            int[,,] multidimensionalArray = ArrayMethods.constructMultidimentsionalArray();
            ArrayMethods.PrintOutMultiArray(multidimensionalArray);
            Question_2.countSum(multidimensionalArray);
        }
    }
    public class Question_1
    {
        public static void countHeads(string[][][] jaggedArray)
        {
            int headCount = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        if (jaggedArray[i][j][k] == "h") headCount++;
                    }

                }
            }
            WriteLine($"The head count is exactly {headCount}");
        }
        public static void countConsecutiveHeads(string[][][] jaggedArray)
        {
            int countConsecutiveHeads = 0;
            int headCount = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        if (jaggedArray[i][j][k] == "h")
                        {
                            headCount++;
                            if (i == jaggedArray.Length - 1 && headCount == 2)
                            {
                                countConsecutiveHeads++;
                            }
                            if (k == (jaggedArray[i][j].Length - 1))
                            {
                                continue;
                            }
                        }
                        else if (jaggedArray[i][j][k] == "t")
                        {
                            if (headCount == 2)
                            {
                                countConsecutiveHeads++;
                            }
                            headCount = 0;
                        }
                    }
                }
            }
            WriteLine($"The consecutive head count (hh only) is exactly {countConsecutiveHeads}");
        }
        public static void countConsecutiveTails(string[][][] jaggedArray)
        {
            int countConsecutives = 0;
            int headCount = 0;
            int tailCount = 0;
            bool tailBeforeHead = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        if (jaggedArray[i][j][k] == "h")
                        {
                            if (tailCount == 2)
                            {
                                tailBeforeHead = true;
                            }
                            else
                            {
                                tailBeforeHead = false;
                                tailCount = 0;
                            }
                            headCount++;
                            if (k == (jaggedArray[i][j].Length - 1))
                            {
                                continue;
                            }
                        }
                        if (jaggedArray[i][j][k] == "t")
                        {
                            if (tailBeforeHead && headCount == 2)
                            {
                                countConsecutives++;
                            }
                            headCount = 0;
                            tailCount++;
                        }
                    }
                }
            }
            WriteLine($"The consecutive tail and head count (tthh only) is exactly {countConsecutives}");
        }
    }
    public class Question_2
    {
        public static void countSum(int[,,] multidimensionalArray)
        {
            int sum = 0;
            for (int i = 0; i < multidimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multidimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < multidimensionalArray.GetLength(2); k++)
                    {
                        if (multidimensionalArray[i, j, k] % 3 == 0)
                        {
                            sum += multidimensionalArray[i, j, k];
                        }
                    }
                }
            }
            WriteLine($"The sum of the elements in the multidimensional array divisible by 3 is {sum}");
        }
    }

    // Simple class of methods to generate a random array
    public class ArrayMethods
    {
        // If u want a sample jagged array
        public static string[][][] constructJaggedArray()
        {
            string[][][] headTail = new string[2][][];
            headTail[0] = new string[2][];
            headTail[1] = new string[1][];

            headTail[0][0] = new string[6];
            headTail[0][1] = new string[7];

            headTail[1][0] = new string[4];

            headTail[0][0][0] = "h";
            headTail[0][0][1] = "h";
            headTail[0][0][2] = "h";
            headTail[0][0][3] = "t";
            headTail[0][0][4] = "h";
            headTail[0][0][5] = "h";

            headTail[0][1][0] = "t";
            headTail[0][1][1] = "t";
            headTail[0][1][2] = "h";
            headTail[0][1][3] = "h";
            headTail[0][1][4] = "t";
            headTail[0][1][5] = "h";
            headTail[0][1][6] = "h";

            headTail[1][0][0] = "h";
            headTail[1][0][1] = "t";
            headTail[1][0][2] = "h";
            headTail[1][0][3] = "h";
            return headTail;
        }
        // If u want a randomly generated jagged array
        private static readonly Random getrandom = new Random();
        public static string tossCoin()
        {
            string[] coinOdds = { "h", "t", "h", "t", "t", "h", "t", "t", "h", "t", "h" };
            lock (getrandom)
            {
                return coinOdds[getrandom.Next(0, coinOdds.Length)];
            }
        }
        public static string[][][] generateRandomJaggedArray(int dimension)
        {
            string[][][] jaggedArray = new string[dimension][][];
            for (int i = 0; i < dimension; i++)
            {
                Random random = new Random();
                int rand = random.Next(1, 5);
                jaggedArray[i] = new string[rand][];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    int rand2 = random.Next(1, 5);
                    jaggedArray[i][j] = new string[rand2];
                }
            }
            return jaggedArray;

        }
        public static void PrintOutArray(string[][][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Write($"{jaggedArray[i][j][k]} ");
                    }
                }
            }
            WriteLine();
        }
        public static string[][][] MakeTossingArray(string[][][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        jaggedArray[i][j][k] = tossCoin();
                    }

                }
            }
            return jaggedArray;
        }


        // If you want a simple multidimensional array
        public static int[,,] constructMultidimentsionalArray()
        {
            int[,,] multidimensionalArray = new int[3, 2, 1];
            multidimensionalArray[0, 0, 0] = 1;
            multidimensionalArray[0, 1, 0] = 5;
            multidimensionalArray[1, 0, 0] = 10;
            multidimensionalArray[1, 1, 0] = 15;
            multidimensionalArray[2, 0, 0] = 64;
            multidimensionalArray[2, 1, 0] = 120;
            return multidimensionalArray;
        }
        // If u want a randomly generated jagged array
        public static int[,,] generateRandomMultidimensionalArray()
        {
            int[,,] multiDimensionalArray;
            int[] m = new int[3];
            int s = 0;
            lock (getrandom)
            {
                while (s < 3)
                {
                    m[s] = getrandom.Next(1, 5);
                    s++;
                }
            }
            multiDimensionalArray = new int[m[0], m[1], m[2]];

            return multiDimensionalArray;
        }
        public static void PrintOutMultiArray(int[,,] multiDimensionalArray)
        {
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < multiDimensionalArray.GetLength(2); k++)
                    {
                        Write($"{multiDimensionalArray[i,j,k]} ");
                    }
                }
            }
            WriteLine();
        }
        public static int[,,] MakeMultiDimensionalArray(int[,,] multiDimensionalArray)
        {
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < multiDimensionalArray.GetLength(2); k++)
                    {
                        lock (getrandom)
                        {
                            multiDimensionalArray[i, j, k] = getrandom.Next(1, 100);
                        }
                    }
                }
            }
            return multiDimensionalArray;
        }
    }
}
