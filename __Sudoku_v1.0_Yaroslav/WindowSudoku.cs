using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class WindowSudoku : WindowColor
    {
        // -------------------------------------------------------------------------------
        public static void Show()
        {
            //
            //GridDebug.L(Global.WindowWidth, Global.WindowHeight);
            s_Rect.Show();
            GridTemplate.Show();
            GridDriver.Start();

        }

        // -------------------------------------------------------------------------------
        private static Widget s_Rect = new Rect(0, 0, Global.WindowWidth, Global.WindowHeight, s_WindowSudokuRectBackground);
    }
}
