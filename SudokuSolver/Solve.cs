using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Solve
    {
        
        private readonly List<StringBuilder> _board;
        
        // Defining parametric constructor to assign unsolved sudoku to _board variable
        public Solve(List<StringBuilder> input)
        {
            _board = input;
        }
        // Display Function is doing two things, display the unsolved Sudoku in a fashion way
        // And display the solved Sudoku also in a fashion way.
        public void Display(bool result = false)
        {
            if(result)Solver(_board);
            for(int i =0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(_board[i][j] + " ");
                    if (j == 2 || j == 5)
                    {
                        Console.Write("|");
                    }
                }
                if(i==2 || i==5) { Console.WriteLine("\n------+------+-----");}
                else
                {
                    Console.WriteLine();
                }

            }
            
        }
        //Isvalid function is checking the constrains of Sudoku game.
        private  bool IsValid(List<StringBuilder>board,int row, int col, char num)
        {
            // If the new value which to be filled in the empty space is 
            // not present in that row, return true else false.
            for (var i = 0; i < 9; i++)
            {
                if (board[row][i] == num)
                {
                    return false;
                }
            }
            // If the new value which to be filled in the empty space is 
            // not present in that column return true else false.
            for (var i = 0; i < 9; i++)
            {
                if (board[i][col] == num)
                {
                    return false;
                }
            }
            // Now checking in the small 3X3 block whether the new number is 
            // already available in that small box or not.
            var smallBoxRow = row - row % 3;
            var smallBoxCol = col - col % 3;

            for (var r = smallBoxRow; r < smallBoxRow + 3; r++)
            {
                for (var c = smallBoxCol; c < smallBoxCol + 3; c++)
                {
                    if (board[r][c] == num)
                    {
                        return false;
                    }
                }

            }

            return true;
        }
        // main function which implementing the backtracking Algorithm to solve the problem.
        private  bool Solver(List<StringBuilder> board)
        {
            var row = -1;
            var col = -1;
            var isEmpty = true;
            // searching the empty spaces in board ...
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0 ; j < 9 ;j++)
                {
                    if (board[i][j] == '-')
                    {
                        row = i;
                        col = j;
                        isEmpty = false;
                        break;
                    }
                }

                if (!isEmpty)
                {
                    break;
                }
            }

            if (isEmpty)
            {
                return true;
            }
            // now we know the indexes of the empty space in the board,
            // we can apply the algorithm recursively to fill the board.
            for(var num = 1; num <=9; num++)
            {
                if (IsValid(board, row, col, (char) (num + 48)))
                {
                    board[row][col] = (char) (num + 48);
                    if (Solver(board))
                    {
                        return true;
                    }
                    else
                    {
                        board[row][col] = '-';
                    }
                }
            }

            return false;

        }

    }
}