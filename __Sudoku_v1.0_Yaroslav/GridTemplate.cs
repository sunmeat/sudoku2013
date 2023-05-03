using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridTemplate
    {
        // -------------------------------------------------------------------------------
        public static void Show()
        {
            //
            GridColor.GridTemplate();
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("╔═══╤═══╤═══╦═══╤═══╤═══╦═══╤═══╤═══╗");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╠═══╪═══╪═══╬═══╪═══╪═══╬═══╪═══╪═══╣");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╠═══╪═══╪═══╬═══╪═══╪═══╬═══╪═══╪═══╣");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╟───┼───┼───╫───┼───┼───╫───┼───┼───╢");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("║ 1 │ 2 │ 3 ║ 4 │ 5 │ 6 ║ 7 │ 8 │ 9 ║");
            Console.WriteLine("║   │   │   ║   │   │   ║   │   │   ║");
            Console.WriteLine("╚═══╧═══╧═══╩═══╧═══╧═══╩═══╧═══╧═══╝");
        }

    }
}
