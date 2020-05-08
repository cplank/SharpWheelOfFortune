using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman! Please enter your name" + Environment.NewLine);
            string playerName = Console.ReadLine();

            Player p1 = new Player(playerName);
            Board game = new Board();

            Console.WriteLine(Environment.NewLine + $"Welcome, {p1.name}! Here is your puzzle." + Environment.NewLine);

            while (!game.stopGame)
            {
                game.showPuzzle();
                game.timeToGuess();
                string guess = Console.ReadLine();
                game.validateInput(guess);

            }


            
        }
    }
}
