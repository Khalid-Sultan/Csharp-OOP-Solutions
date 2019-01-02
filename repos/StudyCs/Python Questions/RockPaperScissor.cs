using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Python_Questions
{


    /*
     * Make a Rock, Paper, Scissors Game.
     */
    class RockPaperScissor
    {
        string player1Name, player2Name;
        public void playGame()
        {
            Write("Player 1, What is your name : ");
            player1Name = ReadLine();
            Write("Player 2, What is your name : ");
            player2Name = ReadLine();
            Write("{0}, What is your choice? Rock, Paper or Scissor : ", player1Name);
            string player1choice = ReadLine();
            Write("{0}, What is your choice? Rock, Paper or Scissor : ", player2Name);
            string player2choice = ReadLine();
            if (player1choice == player2choice)
            {
                WriteLine("You Both Chose the same. It's a tie.");
            }
            else if (player1choice == "Rock" && player2choice == "Scissors")
            {
                WriteLine("{0} Wins.", player1Name);
            }
            else if (player2choice == "Rock" && player1choice == "Scissors")
            {
                WriteLine("{0} Wins.", player2Name);
            }

            else if (player1choice == "Scissors" && player2choice == "Paper")
            {
                WriteLine("{0} Wins.", player1Name);
            }
            else if (player2choice == "Scissors" && player1choice == "Paper")
            {
                WriteLine("{0} Wins.", player2Name);
            }

            else if (player1choice == "Rock" && player2choice == "Paper")
            {
                WriteLine("{0} Wins.", player1Name);
            }
            else if (player2choice == "Rock" && player1choice == "Paper")
            {
                WriteLine("{0} Wins.", player2Name);
            }

            else
            {
                WriteLine("Invalid Input");
            }
        }
    }
}
