using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Python_Questions
{
    /* 
     * Generate a random number between 1 and 9 (including 1 and 9). 
     * Ask the user to guess the number, 
     * then tell them whether they guessed too low, too high, or exactly right
     * 
     */
    class RandomGenerator
    {
        int i;
        public RandomGenerator()
        {
            Random rand = new Random();
            i = rand.Next(1, 9);
        }
        public void GuessNumber()
        {
            while (true)
            {
                Write("Please Guess A Number between 1 and 9 ");
                string guess = ReadLine();
                string actualGuess = i.ToString();
                if (actualGuess == guess)
                {
                    WriteLine("You Guessed Correct. Congratulations.");
                    break;
                }
                else if (int.Parse(actualGuess) > int.Parse(guess))
                {
                    WriteLine("You Guessed Lower than the Number. Try Again.");
                    continue;
                }
                else if (int.Parse(actualGuess) < int.Parse(guess))
                {
                    WriteLine("You Guessed Higher than the Number. Try Again.");
                    continue;
                }
                else if (guess == "exit")
                {
                    WriteLine("You Gave Up. Good Bye.");
                    break;
                }
                else
                {
                    WriteLine("You Guessed Incorrect. Try Again.");
                    continue;
                }
            }
        }
    }
}
