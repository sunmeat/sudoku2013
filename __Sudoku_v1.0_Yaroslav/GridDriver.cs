using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridDriver
    {
        // -------------------------------------------------------------------------------
        public static void Keyboard()
        {
            //
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        _Command(-1);
                        break;

                    case ConsoleKey.RightArrow:
                        _Command(-2);
                        break;

                    case ConsoleKey.UpArrow:
                        _Command(-3);
                        break;

                    case ConsoleKey.DownArrow:
                        _Command(-4);
                        break;

                    case ConsoleKey.D1:
                        _Command(1);
                        break;

                    case ConsoleKey.D2:
                        _Command(2);
                        break;

                    case ConsoleKey.D3:
                        _Command(3);
                        break;

                    case ConsoleKey.D4:
                        _Command(4);
                        break;

                    case ConsoleKey.D5:
                        _Command(5);
                        break;

                    case ConsoleKey.D6:
                        _Command(6);
                        break;

                    case ConsoleKey.D7:
                        _Command(7);
                        break;

                    case ConsoleKey.D8:
                        _Command(8);
                        break;

                    case ConsoleKey.D9:
                        _Command(9);
                        break;

                    case ConsoleKey.D0:
                        _Command(0);
                        break;

                    case ConsoleKey.Delete:
                        _Command(0);
                        break;

                    case ConsoleKey.Backspace:
                        _Command(0);
                        break;

                    case ConsoleKey.Spacebar:
                        _Command(0);
                        break;

                    case ConsoleKey.F2:
                        Global.Game = Global.Mode.EASY;
                        Start();
                        return;

                    case ConsoleKey.F3:
                        Global.Game = Global.Mode.MEDIUM;
                        Start();
                        return;

                    case ConsoleKey.F4:
                        Global.Game = Global.Mode.HARD;
                        Start();
                        return;

                    case ConsoleKey.F5:
                        GameOver();
                        break;

                    case ConsoleKey.F6:
                        Start();
                        return;

                    case ConsoleKey.F7:
                        GridControl.All(s_Grids);
                        //GridControl.All(s_GridsSolver); // Debug
                        break;

                    case ConsoleKey.F8:
                        //Console.SetCursorPosition(37, 37); // Debug
                        //Console.WriteLine("1024");
                        //MessageText.Sudoku(0);
                        //MessageText.Sudoku(2);
                        break;

                    case ConsoleKey.F10:
                        return;

                    case ConsoleKey.Enter:
                        Start();
                        return;

                }
            }
        }

        // -------------------------------------------------------------------------------
        public static void GameOver()
        {
            //
            Show(s_GridsSolver);
            MessageText.SudokuGameOver();

            Console.ReadKey();
            Start();
        }

        // -------------------------------------------------------------------------------
        public static void Start()
        {
            //
            s_RowIndex = 0;
            s_ColumnIndex = 0;

            GridGenerator.Start();
            s_Grids = GridGenerator.Grids;
            s_GridsSolver = GridGenerator.GridsSolver;

            //
            while (isConstant(s_Grids, 0, s_ColumnIndex))
            {
                if (s_ColumnIndex > 8)
                {
                    s_ColumnIndex = 0;
                }
                s_ColumnIndex++;
            }

            //GridDebug.T(s_ColumnIndex, "s_ColumnIndex");
            Show(s_Grids);

            GridControl.Solver(s_Grids);
            MessageText.SudokuMenu();
            MessageText.SudokuStatus();
            MessageText.SudokuNewGame();

            Keyboard();
        }

        // -------------------------------------------------------------------------------
        public static void Show(Grid[,] Grids)
        {
            //
            int Length = 9;
            for (int Row = 0; Row < Length; Row++)
            {
                //
                for (int Column = 0; Column < Length; Column++)
                {
                    Grids[Row, Column].Show();
                }
            }

            Grids[s_RowIndex, s_ColumnIndex].Edit();
        }

        // -------------------------------------------------------------------------------
        public static bool isConstant(Grid[,] Grids)
        {
            //
            if (Grids[s_RowIndex, s_ColumnIndex].Constant == Grid.Const.YES)
            {
                return true;
            }

            return false;
        }

        // -------------------------------------------------------------------------------
        public static bool isConstant(Grid[,] Grids, int RowIndex, int ColumnIndex)
        {
            //
            if (Grids[RowIndex, ColumnIndex].Constant == Grid.Const.YES)
            {
                return true;
            }

            return false;
        }

        // -------------------------------------------------------------------------------
        private static int _Command(int Command)
        {
            //
            Grid[,] Grids = s_Grids;

            Grids[s_RowIndex, s_ColumnIndex].Show();

            if (Command >= 0 && Command <= 9)
            {
                Grids[s_RowIndex, s_ColumnIndex].Value = Command;
            }
            else
            {
                if (Command == -1) // LeftArrow
                {
                    do
                    {
                        s_ColumnIndex--;

                        if (s_ColumnIndex < 0)
                        {
                            s_ColumnIndex = 8;
                        }
                    }
                    while (isConstant(Grids));
                }
                else if (Command == -2)
                {
                    do
                    {
                        s_ColumnIndex++;

                        if (s_ColumnIndex > 8)
                        {
                            s_ColumnIndex = 0;
                        }
                    }
                    while (isConstant(Grids));
                }
                else if (Command == -3) // 
                {
                    do
                    {
                        s_RowIndex--;

                        if (s_RowIndex < 0)
                        {
                            s_RowIndex = 8;
                        }
                    }
                    while (isConstant(Grids));
                }
                else if (Command == -4)
                {
                    do
                    {
                        s_RowIndex++;

                        if (s_RowIndex > 8)
                        {
                            s_RowIndex = 0;
                        }
                    }
                    while (isConstant(Grids));
                }
            }

            GridControl.Edit(Grids, s_RowIndex, s_ColumnIndex);
            return 0;
        }

        // -------------------------------------------------------------------------------
        private static Grid[,] s_Grids;
        private static Grid[,] s_GridsSolver;

        private static int s_RowIndex = 0;
        private static int s_ColumnIndex = 0;
    }
}
