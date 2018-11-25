using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Player
    {
        public string playerMarker;

        public string Turn()
        {
            Console.Write($"{playerMarker}'s turn. Enter a space: ");
            string playerSpace = Console.ReadLine();
            return playerSpace; 
        }
    }
}
