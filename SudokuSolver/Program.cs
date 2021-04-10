using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StringBuilder> userInput = new List<StringBuilder>();
            /*StreamReader sr = new StreamReader(@"c:\users\akshat.jain\documents\visual studio 2015\Projects\SudokuSolver\SudokuSolver\testcase.txt");*/
            for (var i = 0; i < 9; i++)
            {
                string text = Console.ReadLine(); /*sr.ReadLine()*/
                StringBuilder input = new StringBuilder(text);
                userInput.Add(input);
            }

            var solver = new Solve(userInput);
            Console.WriteLine("Your Given Sudoku Board....\n");
            solver.Display(false);
            Console.WriteLine("\nAnswer Degenerate With Our Algorithm....\n");
            solver.Display(true);
            Console.ReadLine();


        }
    }
}
