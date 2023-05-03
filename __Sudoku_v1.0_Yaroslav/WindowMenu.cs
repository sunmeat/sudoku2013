using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class WindowMenu : WindowColor
    {
        // -------------------------------------------------------------------------------
        public static void Show()
        {
            //
            Console.ResetColor();
            Console.Clear();

            s_Rect.Show();
            s_NameRect.Show();
            s_NameRect2.Show();
            s_Name.Show();
            _ButtonShow();
            _Keyboard();

        }

        // -------------------------------------------------------------------------------
        public static void Init()
        {
            //
            int Width = 26;
            int Height = 3;
            int Index = 0;

            int Column = 5;
            int Row = 6;
            int OffsetRow = Height + 1;

            ConsoleColor ButtonOff = ConsoleColor.White;
            //ConsoleColor ButtonOn = ConsoleColor.Red;
            //ConsoleColor ButtonTextOn = ConsoleColor.Yellow;
            ConsoleColor ButtonTextOff = ConsoleColor.DarkMagenta;
            ConsoleColor NameRect = ConsoleColor.DarkMagenta;

            ConsoleColor ButtonOn = ConsoleColor.DarkBlue;
            ConsoleColor ButtonTextOn = ConsoleColor.Yellow;

            string WindowMenuStrName = "Cудоку — Шаг.";
            string WindowMenuStr1 = "F1 — Помощь";
            string WindowMenuStr2 = "F2 — Легкая игра";
            string WindowMenuStr3 = "F3 — Средняя игра";
            string WindowMenuStr4 = "F4 — Тяжелая игра";
            string WindowMenuStr5 = "О программе";
            string WindowMenuStr6 = "Выход";

            s_NameRect = new Rect(0, 0, Global.WindowWidth, Height, NameRect);
            s_NameRect2 = new Rect(0, Global.WindowHeight - Height, Global.WindowWidth, Height, NameRect);
            s_Name = new Text(WindowMenuStrName, 12, 1, ConsoleColor.Yellow, NameRect);

            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr1, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr1, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);

            ++Index;
            Row += OffsetRow;
            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr2, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr2, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);

            ++Index;
            Row += OffsetRow;
            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr3, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr3, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);

            ++Index;
            Row += OffsetRow;
            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr4, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr4, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);

            ++Index;
            Row += OffsetRow;
            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr5, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr5, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);

            ++Index;
            Row += OffsetRow;
            s_ButtonOff[Index] = new Rect(Column, Row, Width, Height, ButtonOff);
            s_ButtonOn[Index] = new Rect(Column, Row, Width, Height, ButtonOn);
            s_ButtonTextOff[Index] = new Text(WindowMenuStr6, (s_ButtonOff[Index].Column + 2), (s_ButtonOff[Index].Row + 1), ButtonTextOff, s_ButtonOff[Index].Background);
            s_ButtonTextOn[Index] = new Text(WindowMenuStr6, (s_ButtonOn[Index].Column + 2), (s_ButtonOn[Index].Row + 1), ButtonTextOn, s_ButtonOn[Index].Background);


        }

        // -------------------------------------------------------------------------------
        private static void _ButtonShow()
        {
            //
            for (int i = 0; i < WidgetLength; i++)
            {
                if (i == s_MenuIndex)
                {
                    s_ButtonOn[i].Show();
                    s_ButtonTextOn[i].Show();
                }
                else
                {
                    s_ButtonOff[i].Show();
                    s_ButtonTextOff[i].Show();
                }
            }

        }

        // -------------------------------------------------------------------------------
        private static void _Enter()
        {
            //
            switch (s_MenuIndex)
            {
                case 0:
                    WindowF1.Show();
                    WindowMenu.Show();
                    break;

                case 1:
                    Global.Game = Global.Mode.EASY;
                    WindowSudoku.Show();
                    WindowMenu.Show();
                    break;

                case 2:
                    Global.Game = Global.Mode.MEDIUM;
                    WindowSudoku.Show();
                    WindowMenu.Show();
                    break;

                case 3:
                    Global.Game = Global.Mode.HARD;
                    WindowSudoku.Show();
                    WindowMenu.Show();
                    break;

                case 4:
                    WindowAbout.Show();
                    WindowMenu.Show();
                    break;

                case 5:
                    s_FlagExit = true;
                    return;
            }
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
                    case ConsoleKey.UpArrow:
                        s_MenuIndex--;
                        if (s_MenuIndex < 0)
                        {
                            s_MenuIndex = (WidgetLength - 1);
                        }
                        _ButtonShow();
                        break;

                    case ConsoleKey.DownArrow:
                        s_MenuIndex++;
                        if (s_MenuIndex >= WidgetLength)
                        {
                            s_MenuIndex = 0;
                        }
                        _ButtonShow();
                        break;

                    case ConsoleKey.Enter:
                        _Enter();
                        break;

                    case ConsoleKey.F1:
                        s_MenuIndex = 0;
                        _Enter();
                        break;

                    case ConsoleKey.F2:
                        s_MenuIndex = 1;
                        _Enter();
                        break;

                    case ConsoleKey.F3:
                        s_MenuIndex = 2;
                        _Enter();
                        break;

                    case ConsoleKey.F4:
                        s_MenuIndex = 3;
                        _Enter();
                        break;

                }

                //
                if (s_FlagExit)
                {
                    break;
                }

            }
        }

        // -------------------------------------------------------------------------------
        const int WidgetLength = 6;

        private static int s_MenuIndex = 0;
        private static Widget[] s_ButtonOff = new Widget[WidgetLength];
        private static Widget[] s_ButtonOn = new Widget[WidgetLength];
        private static Widget[] s_ButtonTextOff = new Widget[WidgetLength];
        private static Widget[] s_ButtonTextOn = new Widget[WidgetLength];

        private static Widget s_Rect = new Rect(0, 0, Global.WindowWidth, Global.WindowHeight, s_WindowSudokuRectBackground);
        private static Text s_Name;
        private static Rect s_NameRect;
        private static Rect s_NameRect2;

        private static bool s_FlagExit = false;
    }

}
