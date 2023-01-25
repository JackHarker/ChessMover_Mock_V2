using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover_Mock
{
    internal class Rook : Tile
    {
        

        public Rook(int row, int col) : base(row, col) 
        {
            this.displayChar = 'R';
        }
       
    }
}
