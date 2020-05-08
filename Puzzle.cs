using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Puzzle
    {
        string wordToGuess;
        List<char> wrongGuesses;
        public char[] wordToDisplay;

        public Puzzle()
        {
            wordToGuess = new PuzzleLibrary().getWordForPuzzle();
            wrongGuesses = new List<char>();
            wordToDisplay = Enumerable.Repeat('-', wordToGuess.Length).ToArray();

        }

        public void checkGuessedLetter(char letter)
        {
            bool isMatch = false;
            foreach (char l in wordToGuess)
            {
                if (l.Equals(letter))
                {
                    isMatch = true;
                }       
            }

            if (isMatch)
            {
                changeDisplay(letter);
            } else
            {
                handleWrongGuess(letter);
            }
         }

        public bool checkForSolve(string guess)
        {
            if (wordToGuess.Equals(guess))
            {
                wordToDisplay = wordToGuess.ToCharArray();
                return true;
            } else
            {
                return false;
            }

        }       
        
        void handleWrongGuess(char letter)
        {
            wrongGuesses.Add(letter);
            Console.WriteLine(Environment.NewLine + "Sorry, your guess was incorrect. Try again!" + Environment.NewLine);
        }
       
        void changeDisplay(char letter)
        {
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i].Equals(letter))
                {
                    wordToDisplay[i] = letter;
                    Console.WriteLine(Environment.NewLine + "You guessed correctly!" + Environment.NewLine);
                }
            }
        }

    }
}
