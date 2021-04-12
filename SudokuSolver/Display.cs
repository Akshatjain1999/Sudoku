using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class Display
    {
        public static void DisplaySudoku(List<StringBuilder> board)
        {
            
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    Console.Write(board[i][j] + " ");
                    if (j == 2 || j == 5)
                    {
                        Console.Write("|");
                    }
                }

                if (i == 2 || i == 5)
                {
                    Console.WriteLine("\n------+------+-----");
                }
                else
                {
                    Console.WriteLine();
                }

            }

        }

    }
}