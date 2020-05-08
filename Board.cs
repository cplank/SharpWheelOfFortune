using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Board
    {
        Puzzle puzzle;
        public bool stopGame;

        public Board()
        {
            puzzle = new Puzzle();
            stopGame = false;
        }
        public void validateInput(string input)
        {
            input = input.Trim().ToLower();

            if(input.Length > 1)
            {
                //Need additional validation -> contains only letters
                if (puzzle.checkForSolve(input))
                {
                    Console.WriteLine(Environment.NewLine + "Congratulations! You win!");
                    startNewGame();
                } else
                {
                    Console.WriteLine(Environment.NewLine + "Incorrect! Game over.");
                    startNewGame();
                    
                }
            }
            else if (input.Length == 1)
            {
                char letter = Convert.ToChar(input);
                puzzle.checkGuessedLetter(letter);

            } else
            {
                Console.WriteLine("Your input was invalid. Please try again.");
            }
        }

        public void showPuzzle()
        {
            Console.WriteLine(puzzle.wordToDisplay);
        }

        public void timeToGuess()
        {

            Console.WriteLine(Environment.NewLine + "Guess a letter, or type in a word to solve the puzzle.");
        }    

        void resetGame()
        {
            Console.WriteLine(Environment.NewLine + "Great! Here is your new puzzle." + Environment.NewLine);
            puzzle = new Puzzle();
        }
        
        public void startNewGame()
        {
            Console.WriteLine(Environment.NewLine + "Would you like to play again? Y/N?");
            string input = Console.ReadLine();

            if (input.Equals("y"))
            {
                resetGame();
            } else
            {
                Console.WriteLine(Environment.NewLine + "Game has ended. Press CRTL + C to close the window." + Environment.NewLine);
                stopGame = true;
            }
        }
    }
}
