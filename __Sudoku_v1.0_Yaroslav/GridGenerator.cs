using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridGenerator
    {
        // -------------------------------------------------------------------------------
        public static Grid[,] Grids
        {
            //
            get { return s_Grids; }
        }

        // -------------------------------------------------------------------------------
        public static Grid[,] GridsSolver
        {
            //
            get { return s_GridsSolver; }
        }

        // -------------------------------------------------------------------------------
        public static void Start()
        {
            //
            int ColumnConsole = 2; // Начальная инициализация ячейки по Column.
            int RowConsole = 2; // Начальная инициализация ячейки по Row.

            const int Length = 9;
            s_Grids = new Grid[Length, Length];
            s_GridsSolver = new Grid[Length, Length];
            int[,] GridsSolver;

            //GridsInt = GridDebug.GetGridError(0);
            //GridsInt = GridDebug.GetGridError(1);
            //GridsSolver = GridDebug.GetGridOk(0);
            GridSolver.Start();
            GridsSolver = GridSolver.Grids;

            //
            for (int Row = 0; Row < Length; Row++)
            {
                //
                for (int Column = 0; Column < Length; Column++)
                {
                    s_GridsSolver[Row, Column] = new Grid(s_GridsNode[Row, Column], Row, Column, ColumnConsole, RowConsole, GridsSolver[Row, Column]);
                    s_Grids[Row, Column] = new Grid(s_GridsNode[Row, Column], Row, Column, ColumnConsole, RowConsole, GridsSolver[Row, Column]);
                    ColumnConsole += 4;
                }
                RowConsole += 4;
                ColumnConsole = 2;
            }

            //
            for (int i = 0; i < 9; i++)
            {
                _SetConstant(i, Global.Constant);
            }

            //
            for (int Row = 0; Row < Length; Row++)
            {
                //
                for (int Column = 0; Column < Length; Column++)
                {
                    if (s_GridsSolver[Row, Column].Constant == Grid.Const.YES)
                    {
                        s_Grids[Row, Column].Constant = Grid.Const.YES;
                    }
                    else
                    {
                        s_Grids[Row, Column].Value = 0;
                    }
                }

            }

            //
            //s_Grids = s_GridsSolver; // Debug
        }

        // -------------------------------------------------------------------------------
        private static void _SetConstant(int Node, int Count)
        {
            //
            int Index = 0;
            int Length = 9;
            int Value;
            int[] Constant = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            if (Count > 8 || Count < 0)
            {
                Count = 4;
            }

            //
            for (int i = 0; i < Count; i++)
            {
                bool Random = true;

                do
                {
                    Value = s_Random0.Next(0, 8);

                    if (Array.IndexOf(Constant, Value) == -1)
                    {
                        Random = false;
                        Constant[Value] = Value;
                    }
                }
                while (Random);
            }

            //
            for (int Row = 0; Row < Length; Row++)
            {
                //
                for (int Column = 0; Column < Length; Column++)
                {
                    if (s_GridsSolver[Row, Column].Node == Node)
                    {
                        if (Constant[Index] > -1)
                        {
                            s_GridsSolver[Row, Column].Constant = Grid.Const.YES;
                        }
                        Index++;
                    }

                }
            }
        }

        // -------------------------------------------------------------------------------
        private static Random s_Random0 = new Random();
        private static Grid[,] s_Grids;
        private static Grid[,] s_GridsSolver;

        //s_Grids = new Grid[9, 9];
        //s_GridsSolver = new Grid[9, 9];
        // Маска для узла.
        private static int[,] s_GridsNode = new int[9, 9]
            {//0  1  2  3  4  5  6  7  8  
             { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, // 0
             { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, // 1
             { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, // 2
             { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, // 3
             { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, // 4
             { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, // 5
             { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, // 6
             { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, // 7
             { 6, 6, 6, 7, 7, 7, 8, 8, 8 }  // 8
            };
    }
}
