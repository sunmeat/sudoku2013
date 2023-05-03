using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridSolver
    {
        // -------------------------------------------------------------------------------
        public static int[,] Grids
        {
            //
            get { return s_Grids; }
        }

        // -------------------------------------------------------------------------------
        public static int[] GridsSolver
        {
            //
            get { return s_GridsSolver; }
        }

        // -------------------------------------------------------------------------------
        public static bool Start()
        {
            int Index = 0;

            _Clear();
            _Random();

            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    s_GridsSolver[Index] = s_Grids[Row, Column];
                    Index++;
                }
            }

            return _Solver();
        }

        // -------------------------------------------------------------------------------
        private static void _Random()
        {
            //
            int Value;

            for (int i = 0; i < 9; i++)
            {
                bool Random = true;

                do
                {
                    Value = s_Random0.Next(1, 10); //

                    if (Array.IndexOf(s_Init, Value) == -1)
                    {
                        Random = false;
                        s_Init[i] = Value;
                    }
                }
                while (Random);

                s_Grids[0, i] = s_Init[i];
            }

            //
        }

        // -------------------------------------------------------------------------------
        private static bool _Solver()
        {
            //
            bool Ok = false;

            try
            {
                // Error!
                _GeneratorNumber(0);
                //Console.WriteLine("Error!");
            }
            //catch (Exception Ex)
            catch
            {
                // OK!
                //Console.WriteLine(Ex.Message);
                // Console.WriteLine("OK!");
                _Copy();
                Ok = true;
            }

            return Ok;
        }

        // -------------------------------------------------------------------------------
        public static void _GeneratorNumber(int Index)
        {
            if (Index == 81)
            {
                throw new Exception("OK!");
            }

            if (s_GridsSolver[Index] > 0)
            {
                _GeneratorNumber(Index + 1);
                return;
            }

            for (int Number = 1; Number <= 9; Number++)
            {
                if (_Check(Number, Index % 9, Index / 9))
                {
                    s_GridsSolver[Index] = Number;
                    _GeneratorNumber(Index + 1);
                    s_GridsSolver[Index] = 0;
                }
            }
        }

        // -------------------------------------------------------------------------------
        private static bool _Check(int Value, int X, int Y)
        {
            //
            for (int i = 0; i < 9; i++)
            {
                if (s_GridsSolver[Y * 9 + i] == Value || s_GridsSolver[i * 9 + X] == Value)
                {
                    return false;
                }
            }

            int StartX = (X / 3) * 3;
            int StartY = (Y / 3) * 3;

            for (int i = StartY; i < StartY + 3; i++)
            {
                for (int j = StartX; j < StartX + 3; j++)
                {
                    if (s_GridsSolver[i * 9 + j] == Value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // -------------------------------------------------------------------------------
        private static void _Copy()
        {
            //
            int Index = 0;
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    s_Grids[Row, Column] = s_GridsSolver[Index];
                    Index++;
                }
            }

        }

        // -------------------------------------------------------------------------------
        private static void _Clear()
        {
            //
            for (int i = 0; i < 81; i++)
            {
                s_GridsSolver[i] = 0;
            }

            for (int i = 0; i < s_Init.Length; i++)
            {
                s_Init[i] = 0;
            }

            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    s_Grids[Row, Column] = 0;
                }
            }
        }

        private static Random s_Random0 = new Random((int)DateTime.Now.Ticks);
        private static int[] s_Init = new int[10]; //
        private static int[] s_GridsSolver = new int[81];
        private static int[,] s_Grids = new int[9, 9]
            {//0  1  2  3  4  5  6  7  8  
             //{ 9, 1, 5, 7, 4, 2, 8, 6, 3 }, // 0
             //{ 9, 8, 7, 6, 5, 4, 3, 2, 1 }, // 0
             //{ 1, 2, 3, 4, 5, 6, 7, 8, 9 }, // 0
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 0
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 1
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 2
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 3
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 4
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 5
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 6
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 7
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }  // 8
            };
    }
}
