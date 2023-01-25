using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover_Mock
{
    internal class ChessBoard
    {
        Tile[,] chessBoardArray = new Tile[20, 20];

        Random luckyBox = new Random();

        Tile playerPiece;

        Tile targetPiece;

        Tile[] obstacles = new Tile[20];

        List<Tile> possiblePlayerMoves = new List<Tile>();
        public ChessBoard()
        {
            playerPiece= new Rook(luckyBox.Next(chessBoardArray.GetLength(0)), 
                luckyBox.Next(chessBoardArray.GetLength(1)));

            targetPiece = new Tile(luckyBox.Next(chessBoardArray.GetLength(0)), 
                luckyBox.Next(chessBoardArray.GetLength(1)), 'T');

            for (int i = 0; i < obstacles.Length; i++) 
            {
                obstacles[i] = new Tile(luckyBox.Next(chessBoardArray.GetLength(0)),
                luckyBox.Next(chessBoardArray.GetLength(1)), (char)9689);
            }

            UpdateBoard();
            CheckMoves();
            ShortestRoute();
            
        }
        public void UpdateBoard()
        {
            
            bool blackSquare = true;

            for (int i = 0; i < chessBoardArray.GetLength(1); i++)
            {
                for (int j = 0; j < chessBoardArray.GetLength(0); j++)
                {
                    if (blackSquare)
                    {
                        chessBoardArray[i, j] = new Tile(i, j, (char)9632);
                    }
                    else
                    {
                        chessBoardArray[i, j] = new Tile(i, j, (char)9633);
                    }

                    blackSquare = !blackSquare;
                }
                if (chessBoardArray.GetLength(0) % 2 == 0)
                {
                    blackSquare = !blackSquare;
                }
            }

            chessBoardArray[playerPiece.GetCol(), playerPiece.GetRow()] = playerPiece;
            chessBoardArray[targetPiece.GetCol(), targetPiece.GetRow()] = targetPiece;

            for (int i = 0; i < obstacles.Length; i++)
            {
                chessBoardArray[obstacles[i].GetCol(), obstacles[i].GetRow()] = obstacles[i];
            }

            
        }
        public void ShortestRoute()
        {
            //Create your algorithm here!
        }
        public void CheckMoves()
        {
           
            if (playerPiece.GetDisplayChar() == 'R')
            {
                CheckRookMoves();
            }
            else if (playerPiece.GetDisplayChar() == 'B')
            {
                CheckBishopMoves();
            }
            
        }
        private void CheckRookMoves()
        {
            for (int i = playerPiece.GetCol()+1; i < chessBoardArray.GetLength(0); i++)
            {
                if (chessBoardArray[i, playerPiece.GetRow()].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, playerPiece.GetRow(), (char)9632));
                }
              
            }
            for (int i = playerPiece.GetCol() -1; i >= 0; i--)
            {
                if (chessBoardArray[i, playerPiece.GetRow()].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, playerPiece.GetRow(), (char)9632));
                }
            }
            for (int i = playerPiece.GetRow() + 1; i < chessBoardArray.GetLength(1); i++)
            {
                if (chessBoardArray[playerPiece.GetCol(), i].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(playerPiece.GetCol(), i, (char)9632));
                }
            }
            for (int i = playerPiece.GetRow() - 1; i >= 0; i--)
            {
                if (chessBoardArray[playerPiece.GetCol(), i].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(playerPiece.GetCol(), i, (char)9632));
                }
            }
        }
        private void CheckBishopMoves()
        {
            for (int i = playerPiece.GetCol()+1, j = playerPiece.GetRow()+1; i <chessBoardArray.GetLength(0) && j < chessBoardArray.GetLength(1); i++, j++)
            {
                if (chessBoardArray[i, j].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, j, (char)9632));
                }
            }
            for (int i = playerPiece.GetCol() -1, j = playerPiece.GetRow() + 1; i >=0 && j < chessBoardArray.GetLength(1); i--, j++)
            {
                if (chessBoardArray[i, j].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, j, (char)9632));
                }
            }
            for (int i = playerPiece.GetCol() + 1, j = playerPiece.GetRow() -1; i < chessBoardArray.GetLength(0) && j >=0; i++, j--)
            {
                if (chessBoardArray[i, j].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, j, (char)9632));
                }
            }
            for (int i = playerPiece.GetCol() - 1, j = playerPiece.GetRow() - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (chessBoardArray[i, j].GetDisplayChar() == (char)9689)
                {
                    break;
                }
                else
                {
                    possiblePlayerMoves.Add(new Tile(i, j, (char)9632));
                }
            }

        }
        public Tile[,] GetTiles()
        {
            return chessBoardArray;
        }
        public List<Tile> GetMoves()
        {
            return possiblePlayerMoves;
        }
        
    }
}
