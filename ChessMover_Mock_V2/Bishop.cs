using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover_Mock
{
    internal class Bishop :Tile
    {
        public Bishop(int row, int col) : base(row, col)
        {
            this.displayChar = 'B';
        }
    }
}
