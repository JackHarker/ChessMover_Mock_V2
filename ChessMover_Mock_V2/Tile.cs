using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover_Mock
{
    internal class Tile
    {
        protected int row;
        protected int col;
        protected char displayChar;

        
        public Tile(int col, int row)
        {
            this.row = row;
            this.col = col;
            
        }
        public Tile(int col, int row, char displayChar) 
        {
            this.row = row;
            this.col = col;
            this.displayChar = displayChar;
        }
        public char GetDisplayChar()
        {
            return displayChar;
        }
        public int GetRow()
        { 
            return row; 
        }
        public int GetCol() 
        { 
            return col; 
        }
    }
}
