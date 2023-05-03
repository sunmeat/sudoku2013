using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class WindowF1 : WindowColor
    {
        // -------------------------------------------------------------------------------
        public static void Init()
        {
            //
            int Index = 0;

            string WindowF1Str1 = "Правила игры.";

            string WindowF1Str2 = "Поле игры состоит из 81 клетки. \n"
            + " В каждой клетки может находиться \n"
            + " цифра в интервале [1,9]. ";

            string WindowF1Str3 = "Задача игрока, заполнить все клетки\n"
            + " поля, по следующим правилам.\n"
            + " 1). В каждой строке не должно быть \n повторяющихся цифр.\n"
            + " 2). В каждом столбце не должно быть \n повторяющихся цифр.\n"
            + " 3). В каждом блоке (3х3) не должно \n быть повторяющихся цифр.\n";

            string WindowF1Str4 = "Управление игрой.";

            string WindowF1Str5 = "[1...9] — Ввод цифры.\n\n"
                + " [0, BlackSpace, Delete, \n Пробел] — Удалить цифру. \n\n"
                + " [← → ↑ ↓] — Управление курсором.  \n\n"
                + " [F1] — Помощь. \n\n"
                + " [F2] — Легкая игра. \n\n"
                + " [F3] — Средняя игра. \n\n"
                + " [F4] — Тяжелая игра. \n\n"
                + " [F5] — Сдаюсь. \n Показать правильное решение.\n\n"
                + " [F6, Enter] — Начать новую игру.\n\n"
                + " [F7] — Проверить все поля. \n\n"
                + " [Esc] — Выход. \n\n";

            string WindowAboutStrLine = "___________________________________";
            string WindowAbouStrExit = "Выход в меню, нажмите [Esc, Enter].";

            s_WidgetX[Index] = new Rect(0, 0, Global.WindowWidth, Global.WindowHeight, s_WindowSudokuRectBackground);
            s_WidgetX[Index += 1] = new Text(WindowF1Str1, 11, 1, s_WindowForegroundStrTitle, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowF1Str2, 2, 3, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowF1Str3, 1, 7, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowF1Str4, 10, 16, s_WindowForegroundStrTitle, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowF1Str5, 1, 18, s_WindowForegroundStr, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAboutStrLine, 1, 45, s_WindowForegroundStrExit, s_WindowBackground);
            s_WidgetX[Index += 1] = new Text(WindowAbouStrExit, 1, 46, s_WindowForegroundStrExit, s_WindowBackground);

            //Show(); // Debug
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
    }
}
