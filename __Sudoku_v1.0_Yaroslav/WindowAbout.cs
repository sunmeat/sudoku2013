using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class WindowAbout : WindowColor
    {
        // -------------------------------------------------------------------------------
        public static void Init()
        {
            //
            int Index = 0;

            string WindowAboutStr1 = "О программе.";

            string WindowAboutStr2 = "Cудоку версия 1.0.";

            string WindowAboutStr3 = "Ярослав, группа СПУ-1221.";

            string WindowAboutStr4 = "Январь - 2014.";

            string WindowAboutStr5 = "***********************************";
            string WindowAboutStrLine = "___________________________________";
            string WindowAbouStrExit = "Выход в меню, нажмите [Esc, Enter].";

            s_WidgetX[Index] = new Rect(0, 0, Global.WindowWidth, Global.WindowHeight, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStr1, 11, 1, s_WindowForegroundStrTitle, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStr2, 2, 3, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStr3, 2, 5, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStr4, 2, 7, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStr5, 1, 9, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStrLine, 1, 45, s_WindowForegroundStrExit, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAbouStrExit, 1, 46, s_WindowForegroundStrExit, s_WindowBackground);

        }

        // -------------------------------------------------------------------------------
        public static void Show()
        {
            //
            Console.ResetColor();
            Console.Clear();

            for (int i = 0; i < WidgetLength; i++)
            {
                s_WidgetX[i].Show();
            }

            _Keyboard();

        }

        // -------------------------------------------------------------------------------
        private static void _Keyboard()
        {
            //
            ConsoleKeyInfo KeyInfo;
            while ((KeyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        return;
                }
            }
        }

        // -------------------------------------------------------------------------------
        const int WidgetLength = 8;
        private static Widget[] s_WidgetX = new Widget[WidgetLength];

        private static Widget s_Rect = new Rect(0, 0, Global.WindowWidth, Global.WindowHeight, s_WindowSudokuRectBackground);
    }
}
