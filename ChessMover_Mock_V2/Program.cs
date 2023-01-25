using System;

namespace ChessMover_Mock
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                ChessBoard chessBoard = new ChessBoard();

                Display display = new Display(chessBoard.GetTiles(), chessBoard.GetMoves());

                Console.ReadKey();
            }
            
        }
    }
}