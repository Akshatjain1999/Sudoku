using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        private static void Main(string[] args)
        {
            var userInput = new List<StringBuilder>();
            //StreamReader sr = null;
            //var path =
              //  @"c:\users\akshat.jain\documents\visual studio 2015\Projects\SudokuSolver\SudokuSolver\testcase.txt";
            try
            {
                //sr = new StreamReader(path);

                for (var i = 0; i < 9; i++)
                {
                    //var text = sr.ReadLine();
                    var text = Console.ReadLine();
                    if (text != null && text.Length == 9)
                    {
                        var input = new StringBuilder(text);
                        userInput.Add(input);
                    }
                    else
                    {
                        throw new InvalidExpressionException();
                    }
                }

                var solver = new Solve(userInput);
                Console.WriteLine("Your Given Sudoku Board....\n");
                Display.DisplaySudoku(userInput);
                solver.Solver();
                Console.WriteLine("\nAnswer Generate With Our Algorithm....\n");
                Display.DisplaySudoku(solver.Board);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            
            Console.ReadLine();

        }
    }
}
