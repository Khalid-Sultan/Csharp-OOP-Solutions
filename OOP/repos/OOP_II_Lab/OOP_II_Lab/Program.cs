using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_II_Lab
{
    class Program
    {
        class Question1
        {
            string name;
            public void WriteOutName()
            {
                WriteLine("What is your name");
                name = ReadLine();
                WriteLine($"Hello {name}");
            }
        }
        class Question2
        {
            int number1, number2;
            public void Add()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine($"The sum is equal to {number1 + number2}");
            }
        }
        class Question3
        {
            int number1, number2;
            public void Divide()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine($"The division is equal to {number1 / number2}");
            }
        }
        class Question4
        {
            public void printOutOperations()
            {
                WriteLine($"{-1 + 4 * 6}");
                WriteLine($"{(35 + 5) % 7}");
                WriteLine($"{14 + -4 * 6 / 11}");
                WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");
            }
        }
        class Question5
        {
            int number1, number2;
            public void swapper()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                int temp = number1;
                number1 = number2;
                number2 = temp;
                WriteLine($"The first number is equal to {number1}");
                WriteLine($"The second is equal to {number2}");
            }
        }
        class Question6
        {
            int number1, number2, number3;
            public void multiply()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine("What is the last number?");
                number3 = int.Parse(ReadLine());
                WriteLine($"The Output is {number1 * number2 * number3}");
            }
        }
        class Question7
        {
            int number1, number2;
            public void operate()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine($"The Addition Output is {number1 + number2}");
                WriteLine($"The Subtraction Output is {number1 - number2}");
                WriteLine($"The Multiplication Output is {number1 * number2}");
                WriteLine($"The Division Output is {number1 / number2}");
                WriteLine($"The Modulus Output is {number1 % number2}");
            }
        }

        class Question8
        {
            int number1;
            public void table()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                for (int i = 0; i <= 12; i++)
                {
                    WriteLine($"{number1} * {i} = {number1 * i}");
                }
            }
        }
        class Question9
        {
            int number1, number2, number3, number4;
            public void average()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine("What is the third number?");
                number3 = int.Parse(ReadLine());
                WriteLine("What is the last number?");
                number4 = int.Parse(ReadLine());
                int product = number1 + number2 + number3 + number4;
                product /= 4;
                WriteLine($"The Output is {product}");
            }
        }
        class Question10
        {
            int number1, number2, number3;
            public void multiply()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                WriteLine("What is the last number?");
                number3 = int.Parse(ReadLine());
                WriteLine($"The Output of ({number1}+{number2})*{number3} is {(number1 + number2) * number3}");
                WriteLine($"The Output of ({number1}*{number2} + {number2}*{number3}  is {number1 * number2 + number2 * number3}");
            }
        }
        class Question11
        {
            public void Aging()
            {
                Write("Enter your age : ");
                int age = int.Parse(ReadLine());
                if (age < 18)
                {
                    WriteLine("Wow You have grown big");
                }
                else if (age < 30)
                {
                    WriteLine($"Wow You look older than {age}");
                }
                else
                {
                    WriteLine("Wow You look like you have another 20 years left in you");
                }
            }
        }
        class Question12
        {
            int number1;
            public void multiple()
            {
                WriteLine("Enter a digit : ");
                number1 = int.Parse(ReadLine());
                WriteLine($"{number1} {number1} {number1} {number1}");
                WriteLine($"{number1}{number1}{number1}{number1}");
                WriteLine($"{number1} {number1} {number1} {number1}");
                WriteLine($"{number1}{number1}{number1}{number1}");
            }
        }
        class Question13
        {
            int number;
            public void rectangler()
            {
                WriteLine("Enter a number: ");
                number = int.Parse(ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0 || i == 4)
                    {
                        WriteLine($"{number}{number}{number}");
                    }
                    else
                    {
                        WriteLine($"{number} {number}");
                    }
                }
            }
        }
        class Question14
        {
            int celsius;
            public void convertToFarenheit()
            {
                WriteLine("Enter the amount of celsius: ");
                celsius = int.Parse(ReadLine());
                WriteLine($"Kelvin = {celsius + 273.15 }");
                WriteLine($"Farenheit = {(celsius * 9 / 5) + 32}");
            }
        }
        class Question15
        {
            int index;
            string word;
            public void removal()
            {
                WriteLine("Enter the word: ");
                word = ReadLine();
                WriteLine("Enter the index: ");
                index = int.Parse(ReadLine());
                if (index < 0)
                {
                    WriteLine("Invalid Index Given.");
                    return;
                }
                else if (index >= word.Length)
                {
                    WriteLine("Invalid Index Given.");
                    return;
                }
                else
                {
                    string s = word.Remove(index, 1);
                    WriteLine($"{s}");
                }
            }
        }
        class Question16
        {
            string word;
            public void swapBeginning()
            {
                WriteLine("Enter the word: ");
                word = ReadLine();
                char[] c = word.ToCharArray();
                int length = c.Length;
                char temp = c[0];
                c[0] = c[length - 1];
                c[length - 1] = temp;
                string s = new string(c);
                WriteLine($"{s}");
            }
        }
        class Question17
        {
            string word;
            public void addCharacter()
            {
                WriteLine("Enter the word: ");
                word = ReadLine();
                StringBuilder s = new StringBuilder();
                s.Append(word.First());
                s.Append(word);
                s.Append(word.Last());
                WriteLine($"{s.ToString()}");
            }
        }
        class Question18
        {
            int number1, number2;
            public void Checker()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                if (number1 < 0 || number2 < 0)
                {
                    WriteLine("True");
                    return;
                }
                else
                {
                    WriteLine("False");
                    return;
                }
            }
        }
        class Question19
        {
            int number1, number2;
            public void DoubleOrTriple()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                if (number1 == number2)
                {
                    WriteLine($"Output is {3 * (number1 + number2)}");
                    return;
                }
                else
                {
                    WriteLine($"Output is {number1 * number2}");
                    return;
                }
            }
        }
        class Question20
        {
            int number1, number2, difference;
            public void AbsoluteDifference()
            {
                WriteLine("What is the first number?");
                number1 = int.Parse(ReadLine());
                WriteLine("What is the second number?");
                number2 = int.Parse(ReadLine());
                if (number1 > number2)
                {
                    difference = number1 - number2;
                    WriteLine($"Output is {2 * Math.Abs(difference)}");
                    return;
                }
                else
                {
                    difference = number1 - number2;
                    WriteLine($"Output is {Math.Abs(difference)}");
                    return;
                }
            }

        }
        static void Main(string[] args)
        {
            Question1 question1 = new Question1();
            Question2 question2 = new Question2();
            Question3 question3 = new Question3();
            Question4 question4 = new Question4();
            Question5 question5 = new Question5();
            Question6 question6 = new Question6();
            Question7 question7 = new Question7();
            Question8 question8 = new Question8();
            Question9 question9 = new Question9();
            Question10 question10 = new Question10();
            Question11 question11 = new Question11();
            Question12 question12 = new Question12();
            Question13 question13 = new Question13();
            Question14 question14 = new Question14();
            Question15 question15 = new Question15();
            Question16 question16 = new Question16();
            Question17 question17 = new Question17();
            Question18 question18 = new Question18();
            Question19 question19 = new Question19();
            Question20 question20 = new Question20();

            WriteLine("Question 1");
            question1.WriteOutName();
            WriteLine("Question 2");
            question2.Add();
            WriteLine("Question 3");
            question3.Divide();
            WriteLine("Question 4");
            question4.printOutOperations();
            WriteLine("Question 5");
            question5.swapper();
            WriteLine("Question 6");
            question6.multiply();
            WriteLine("Question 7");
            question7.operate();
            WriteLine("Question 8");
            question8.table();
            WriteLine("Question 9");
            question9.average();
            WriteLine("Question 10");
            question10.multiply();
            WriteLine("Question 11");
            question11.Aging();
            WriteLine("Question 12");
            question12.multiple();
            WriteLine("Question 13");
            question13.rectangler();
            WriteLine("Question 14");
            question14.convertToFarenheit();
            WriteLine("Question 15");
            question15.removal();
            WriteLine("Question 16");
            question16.swapBeginning();
            WriteLine("Question 17");
            question17.addCharacter();
            WriteLine("Question 18");
            question18.Checker();
            WriteLine("Question 19");
            question19.DoubleOrTriple();
            WriteLine("Question 20");
            question20.AbsoluteDifference();


        }
    }
}
