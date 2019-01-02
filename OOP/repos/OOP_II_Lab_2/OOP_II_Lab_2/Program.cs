using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Lab 2 - Program
 * 
 * Section 2
 * 
 * Group Members:
 *  Khalid Sultan - ATR/8444/09
 *  Gemmechu Mohammed - ATR/1432/09
 * 
 * Advisor:
 *  Mr. Belete (Lab Instructor)
*/

namespace OOP_II_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\n Question 1 : ");
            Question_1();
            WriteLine("\n Question 2 : ");
            Question_2();
            WriteLine("\n Question 3 : ");
            Question_3();
            WriteLine("\n Question 4 : ");
            Question_4();
            WriteLine("\n Question 5 : ");
            Question_5();
            WriteLine("\n Question 6 : ");
            Question_6();
            WriteLine("\n Question 7 : ");
            Question_7();
            WriteLine("\n Question 8 : ");
            Question_8();
            WriteLine("\n Question 9 : ");
            Question_9();
            WriteLine("\n Question 10 : ");
            Question_10();
            WriteLine("\n Question 11 : ");
            Question_11();
            WriteLine("\n Question 12 : ");
            Question_12();
            WriteLine("\n Question 13 : ");
            Question_13();
            WriteLine("\n Question 14 : ");
            Question_14();
            WriteLine("\n Question 15 : ");
            Question_15();
        }

        private static void Question_1()
        {
            Write("Please Give me a value for A : ");
            if (float.TryParse(ReadLine(), out float A)){
                Write("Please Give me a value for B : ");
                if (float.TryParse(ReadLine(), out float B))
                {
                    Write("Please Give me a value for C : ");
                    if (float.TryParse(ReadLine(), out float C))
                    {
                        Write("Please Give me a value for D : ");
                        if (float.TryParse(ReadLine(), out float D))
                        {
                            WriteLine($"The value for the equation {A}+{B}*{C}-{D} is {A + B * C - D}");
                            WriteLine($"The value for the equation {A}+{B}*({C}-{D}) is {A + B * (C - D)}");
                            WriteLine($"The value for the equation ({A}+{B})*{C}-{D} is {(A + B) * C - D}");
                            WriteLine($"The value for the equation {A}+({B}*{C})-{D} is {A + (B * C) - D}");
                            WriteLine("The values are different from one another because C# uses arthimetic operations based on prevalence i.e * and / have higher priority than + and - . It also applies calculations on the brackets first.");
                        }
                        else
                        {
                            WriteLine("Invalid Value for D");
                        }
                    }
                    else
                    {
                        WriteLine("Invalid Value for C");
                    }
                }
                else
                {
                    WriteLine("Invalid Value for B");
                }
            }
            else
            {
                WriteLine("Invalid Value for A");
            }
        }
        private static void Question_2()
        {
            Write("Input First Number : ");
            if (float.TryParse(ReadLine(),out float A)){
                Write("Please Input the Operation you need i.e  + or - or * or / or % : ");
                if (char.TryParse(ReadLine(), out char C))
                {
                    Write("Please Input the Second Number : ");
                    if (float.TryParse(ReadLine(), out float B))
                    {
                        switch (C)
                        {
                            case '+':
                                WriteLine($"The Result of the operation {A}{C}{B} is {A + B}");
                                break;
                            case '-':
                                WriteLine($"The Result of the operation {A}{C}{B} is {A - B}");
                                break;
                            case '*':
                                WriteLine($"The Result of the operation {A}{C}{B} is {A * B}");
                                break;
                            case '/':
                                WriteLine($"The Result of the operation {A}{C}{B} is {A / B}");
                                break;
                            case '%':
                                WriteLine($"The Result of the operation {A}{C}{B} is {A % B}");
                                break;
                            default:
                                Write("Invalid operation given");
                                break;
                        }
                    }
                    else
                    {
                        Write("Invalid input given for the second number");
                    }
                    }
                else
                {
                    Write("Invalid operation given");
                }
            }
            else{
                Write("Invalid input given for the first number");
            }
        }
        private static void Question_3()
        {
            Write("What is the radius of the circle : ");
            if (float.TryParse(ReadLine(),out float radius))
            {
                WriteLine($"The perimeter of the circle is {2*Math.PI*radius} while the area is equal to {Math.PI*Math.Pow(radius,2)}");
            }
            else
            {
                WriteLine("Invalid input given for the radius.");
            }
        }
        private static void Question_4()
        {
            Write("What is your height in centimeters please : ");
            if (float.TryParse(ReadLine(),out float height))
            {
                if (height <= 100)
                {
                    WriteLine("The person is a midget in terms of their height");
                }
                else if (height <= 140)
                {
                    WriteLine("The person is a dwarf in terms of their height");
                }
                else if (height <= 160)
                {
                    WriteLine("The person is shorter than the average individual.");
                }
                else if (height <= 180)
                {
                    WriteLine("The person is average in terms of their height");
                }
                else if (height <= 200)
                {
                    WriteLine("The person is taller than the average individual.");
                }
                else if (height <= 220)
                {
                    WriteLine("The person is gigantic.");
                }
                else
                {
                    WriteLine("This person should not even be alive");
                }

            }
            else
            {

            }
        }
        private static void Question_5()
        {
            Write("Input the first number : ");
            if (float.TryParse(ReadLine(),out float A))
            {
                Write("Input the second number : ");
                if (float.TryParse(ReadLine(), out float B))
                {
                    Write("Input the third number : ");
                    if (float.TryParse(ReadLine(), out float C))
                    {
                        if ((A > B && B > C) || (A > C && C > B))
                        {
                            WriteLine($"The 1st number is greater among three.");
                        }
                        else if ((B > A && A > C) || (B > C && C > A))
                        {
                            WriteLine($"The 2nd number is greater among three.");
                        }
                        else if ((C > B && B > A) || (C > A && A > B))
                        {
                            WriteLine($"The 3rd number is greater among three.");
                        }
                    }
                    else
                    {
                        WriteLine("Invalid input given for the third number.");
                    }
                }
                else
                {
                    WriteLine("Invalid input given for the second number.");
                }
            }
            else
            {
                WriteLine("Invalid input given for the first number.");
            }

        }
        private static void Question_6()
        {
            Write("Input the grade obtained in Physics : ");
            if (int.TryParse(ReadLine(), out int Phy) && Phy>0 && Phy<=100)
            {
                Write("Input the grade obtained in Chemistry : ");
                if (int.TryParse(ReadLine(), out int Chem) && Chem>0 && Chem<=100)
                {
                    Write("Input the grade obtained in Mathematics : ");
                    if (int.TryParse(ReadLine(), out int Math) && Math>0 && Math<=100)
                    {
                        if ((Math >= 65) && (Phy >= 55) && (Chem >= 50))
                        {
                            if (Math + Phy + Chem >= 180)
                            {
                                WriteLine("This candidate is eligible for admission.");
                            }
                            else
                            {
                                WriteLine("This candidate is disqualified from the admission process.");
                            }
                        }
                        else
                        {
                            WriteLine("This candidate is disqualified from the admission process.");
                        }
                    }
                    else
                    {
                        WriteLine("Invalid grade given for Chemistry.");
                    }

                }
                else
                {
                    WriteLine("Invalid grade given for Physics.");
                }

            }
            else
            {
                WriteLine("Invalid grade given for Mathematics.");
            }
        }
        private static void Question_7()
        {
            WriteLine("Input the sides of the triangle separated by spaces : ");
            string s = ReadLine();
            string[] stringArray = s.Split(' ');
            if (int.TryParse(stringArray[0], out int side1) && side1 > 0)
            {
                if (int.TryParse(stringArray[1], out int side2) && side2 > 0 )
                {
                    if (int.TryParse(stringArray[2], out int side3) && side3 > 0 )
                    {
                        if ((side1 == side2) && (side2 == side3))
                        {
                            WriteLine("This is an equilateral triangle");
                        }
                        else if (((side1 == side2) && (side2 != side3)) || (side1 == side3) && (side1 != side2) || (side2 == side3) && (side1 != side3))
                        {
                            WriteLine("This is an isoceles triangle");
                        }
                        else
                        {
                            WriteLine("This is a scalene triangle");
                        }
                    }
                    else
                    {
                        WriteLine("Invalid final side given.");
                    }
                }
                else
                {
                    WriteLine("Invalid second side given.");
                }
            }
            else
            {
                WriteLine("Invalid first side given.");
            }
        }

        private static void Question_8()
        {
            string[] daysInAWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Write("Input the day of the week in number : ");
            if(int.TryParse(ReadLine(),out int day) && day>0 && day<=7)
            {
                WriteLine($"The day of the week for your input of {day} is {daysInAWeek[day - 1]}");

            }
            else
            {
                WriteLine("Invalid day given. Choose from 1 to 7.");
            }
        }
        private static void Question_9()
        {
            Write("Please Input the First Number : ");
            if (float.TryParse(ReadLine(), out float A))
            {
                Write("Please Input the Second Number : ");
                if (float.TryParse(ReadLine(), out float B))
                {
                    while (true)
                    {
                        Write(@"
    Here Are Your Options: 
            1 - Addition
            2 - Subtraction
            3 - Multiplication
            4 - Division
            5 - Modulus(Remainder)
            6 - Exit
    Please Input the Operation you need :");
                        if (int.TryParse(ReadLine(), out int C))
                        {
                            if (C == 1)
                            {
                                WriteLine($"The Addition of {A} and {B} is {A + B}");
                                return;
                            }
                            else if (C == 2)
                            {
                                WriteLine($"The Subtraction of {A} and {B} is {A - B}");
                                return;
                            }
                            else if (C == 3)
                            {
                                WriteLine($"The Multiplication of {A} and {B} is {A * B}");
                                return;
                            }
                            else if (C == 4)
                            {
                                WriteLine($"The Division of {A} and {B} is {A / B}");
                                return;
                            }
                            else if (C == 5)
                            {
                                WriteLine($"The Modulus of {A} and {B} is {A % B}");
                                return;
                            }
                            else if (C == 6)
                            {
                                WriteLine($"You have exited the program successfully.");
                                return;
                            }
                            else
                            {
                                WriteLine("Please Choose from the given options only.");
                                continue;
                            }
                        }
                        else
                        {
                            WriteLine("Invalid operation given");
                        }

                    }
                }
                else
                {
                    WriteLine("Invalid input given for the second number");
                }
            }
            else
            {
                WriteLine("Invalid input given for the first number");
            }
        }
        private static void Question_10()
        {
            Write("Please enter a number : ");
            if(int.TryParse(ReadLine(),out int num))
            {
                WriteLine($"The number variable num is assigned to {num}");
                Write("Please enter a floating point number : ");
                if (float.TryParse(ReadLine(), out float fl))
                {
                    WriteLine($"The float variable fl is assigned to {fl}");
                    Write("Please enter a string : ");
                    string str = ReadLine();
                    WriteLine($"The string str variable is assigned to {str}");
                }
                else
                {
                    WriteLine("That variable can not be parsed into a floating number form.");
                }
            }
            else
            {
                WriteLine("That variable can not be parsed into a number form.");
            }
        }
        private static void Question_11()
        {
            Write("How many Natural numbers do you want the list for : ");
            if(int.TryParse(ReadLine(),out int A))
            {
                int sum = 0;
                Write($"The first {A} natural numbers are ");
                for(int i = 1; i <= A; i++)
                {
                    Write($"{i} ");
                    sum += i;
                }
                WriteLine();
                WriteLine($"and their sum equates to {sum} ");

            }
            else
            {
                WriteLine("Invalid number of natural numbers given.");
            }
        }
        private static void Question_12()
        {
            Write("How many levels do you want the pyramid to have : ");
            if(int.TryParse(ReadLine(), out int levels)&& levels > 0)
            {
                levels *= 2;
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
            }
            else
            {
                WriteLine($"You can not build a pyramid using {levels} levels");
            }
        }
        private static void Question_13()
        {
            Write("Input the number : ");
            if(int.TryParse(ReadLine(),out int perfectOrNot))
            {
                int sum = 0;
                Write($"The positive divisor : ");
                for (int i = 1; i < perfectOrNot; i++)
                {
                    if (perfectOrNot % i == 0)
                    {
                        Write($"{i} ");
                        sum += i;
                    }
                }
                WriteLine();
                WriteLine($"The sum of its divisor is : {sum}");
                if (sum == perfectOrNot)
                {
                    WriteLine($"So, the number is perfect.");
                }
                else
                {
                    WriteLine($"So, the number is not perfect.");
                }
            }
            else
            {
                WriteLine("Invalid Input given for the test.");
            }
        }
        private static void Question_14()
        {
            Write("Input the number of elements to store in the array : ");
            if(int.TryParse(ReadLine(),out int count) && count>0){
                int[] array = new int[count];
                WriteLine($"Input {count} number of elements in the array");
                for(int i = 0; i < count; i++)
                {
                    Write($"element {i} - : ");
                    if (int.TryParse(ReadLine(), out array[i])){
                    }
                    else
                    {
                        WriteLine("Invalid element given");
                        continue;
                    }
                }
                StringBuilder stringBuilder = new StringBuilder();
                foreach(int c in array){
                    stringBuilder.Append(c + " ");
                }
                WriteLine($"The values stored in the array are {stringBuilder}");
                stringBuilder.Clear();
                Array.Reverse(array);
                foreach (int c in array)
                {
                    stringBuilder.Append(c + " ");
                }
                WriteLine($"The values stored in the array in reverse are {stringBuilder}");
            }
            else
            {
                WriteLine("Invalid input for number of elements");
            }
        }
        private static void Question_15()
        {
            Write("Input the number of elements to store in the array : ");
            if (int.TryParse(ReadLine(), out int count) && count > 0)
            {
                int[] array = new int[count];
                WriteLine($"Input {count} number of elements in the array");
                for (int i = 0; i < count; i++)
                {
                    Write($"Element {i} - : ");
                    if (int.TryParse(ReadLine(), out array[i]))
                    {
                    }
                    else
                    {
                        WriteLine("Invalid element given");
                        continue;
                    }
                }
                int sum = 0;
                foreach (int c in array)
                {
                    sum += c;
                }
                WriteLine($"Sum of all elements stored in the array is : {sum}");
            }
            else
            {
                WriteLine("Invalid input for number of elements");
            }

        }
    }
}
