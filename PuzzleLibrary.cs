using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class PuzzleLibrary
    {
        List<string> wordBank = new List<string> { "curiosity", "exploration", "possibility", "discovery"};

       public string getWordForPuzzle()
        {
            Random rndm = new Random();
            int randomWord = rndm.Next(0, wordBank.Count);
            return wordBank[randomWord];
        }
    }
}
