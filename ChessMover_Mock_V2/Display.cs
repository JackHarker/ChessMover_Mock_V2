using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover_Mock
{
    internal class Display
    {
        Tile[,] chessBoardArray = new Tile[20, 20];

        List<Tile> possiblePlayerMoves = new List<Tile>();
        public Display(Tile[,] tileArray, List<Tile> moves)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            chessBoardArray = tileArray;
            possiblePlayerMoves = moves;
            DrawChessBoard();

        }

        public void DrawChessBoard()
        {

            for (int i = 0; i < chessBoardArray.GetLength(1); i++)
            {
                for (int j = 0; j < chessBoardArray.GetLength(0); j++)
                {
                    if (chessBoardArray[i, j].GetDisplayChar() == 'R' ||
                        chessBoardArray[i, j].GetDisplayChar() == 'B')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (chessBoardArray[i, j].GetDisplayChar() =='T')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (chessBoardArray[i, j].GetDisplayChar() == (char)9689)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    

                    Console.SetCursorPosition(i * 2, j);
                    Console.WriteLine(chessBoardArray[i, j].GetDisplayChar());
                    Console.ResetColor();
                    

                }

            }
            if (possiblePlayerMoves != null)
            {
                for (int i = 0; i < possiblePlayerMoves.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(possiblePlayerMoves[i].GetCol()*2, possiblePlayerMoves[i].GetRow());
                    Console.WriteLine(possiblePlayerMoves[i].GetDisplayChar());
                    Console.ResetColor();
                }

                //Console.WriteLine(possiblePlayerMoves.Count);

            }
        }

    }
}