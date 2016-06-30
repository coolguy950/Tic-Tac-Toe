using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public enum State
    {
        None,
        Player1,
        Player2,
    }

    public class Cell
    {
        public virtual State State { get; set; }

        public virtual bool IsWinningCell { get; set; }
    }
}
