using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Player
    {
        public string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
      }
}
