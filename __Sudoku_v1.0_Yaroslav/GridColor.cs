using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridColor
    {
        // -------------------------------------------------------------------------------
        public static void Show()
        {
            //
            Color(SHOW, SHOW_BACKGROUND);
        }

        // -------------------------------------------------------------------------------
        public static void Edit()
        {
            //
            Color(EDIT, EDIT_BACKGROUND);
        }

        // -------------------------------------------------------------------------------
        public static void Constant()
        {
            //
            Color(CONSTANT, CONSTANT_BACKGROUND);
        }

        // -------------------------------------------------------------------------------
        public static void GridTemplate()
        {
            //
            Color(GRID, GRID_BACKGROUND);
        }

        // -------------------------------------------------------------------------------
        public static void Error()
        {
            //
            Color(ERROR, ERROR_BACKGROUND);
        }

        // -------------------------------------------------------------------------------
        public static void ErrorEdit()
        {
            //
            Color(ERROR_EDIT, ERROR_BACKGROUND_EDIT);
        }

        // -------------------------------------------------------------------------------
        public static void ErrorConstant()
        {
            //
            Color(ERROR_CONSTANT, ERROR_BACKGROUND_CONSTANT);
        }

        // -------------------------------------------------------------------------------
        public static void Color(ConsoleColor Foreground, ConsoleColor Background)
        {
            //
            Console.ForegroundColor = Foreground;
            Console.BackgroundColor = Background;
        }

        //const ConsoleColor GRID = ConsoleColor.Green;
        //const ConsoleColor GRID_BACKGROUND = ConsoleColor.Black;

        //const ConsoleColor GRID = ConsoleColor.DarkGray;
        const ConsoleColor GRID = ConsoleColor.Black;
        const ConsoleColor GRID_BACKGROUND = ConsoleColor.White;

        const ConsoleColor SHOW = ConsoleColor.Blue;
        const ConsoleColor SHOW_BACKGROUND = ConsoleColor.White;

        const ConsoleColor CONSTANT = ConsoleColor.Black;
        const ConsoleColor CONSTANT_BACKGROUND = ConsoleColor.White;

        const ConsoleColor EDIT = ConsoleColor.DarkBlue;
        const ConsoleColor EDIT_BACKGROUND = ConsoleColor.Green;

        const ConsoleColor ERROR = ConsoleColor.Yellow;
        const ConsoleColor ERROR_BACKGROUND = ConsoleColor.Red;

        const ConsoleColor ERROR_EDIT = ConsoleColor.Red;
        const ConsoleColor ERROR_BACKGROUND_EDIT = ConsoleColor.Green;

        const ConsoleColor ERROR_CONSTANT = ConsoleColor.Red;
        const ConsoleColor ERROR_BACKGROUND_CONSTANT = ConsoleColor.Yellow;

        //

    }
}
