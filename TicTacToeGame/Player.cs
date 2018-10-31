using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Player
    {
        public string Name { get; set; }       
        public int score { get; set; }
        public bool IsWinner { get; set; }
        public Player()
        {
            score = 0;          
        }
    }
}
