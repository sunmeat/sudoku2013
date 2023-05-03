using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridDebug
    {
        // -------------------------------------------------------------------------------
        public static void L(int Row, int Column = 0)
        {
            //
            Console.SetCursorPosition(0, 46);
            Console.WriteLine("Row={0}, Column={1}", Row, Column);
        }

        // -------------------------------------------------------------------------------
        public static void T(int Value, string Str = "X")
        {
            //
            Console.SetCursorPosition(0, 46);
            Console.WriteLine("{0}={1}", Str, Value);
        }

        // -------------------------------------------------------------------------------
        public static void T(int Column, int Row, int Value, string Str = "X")
        {
            //
            Console.SetCursorPosition(Column, Row);
            Console.WriteLine("{0}={1}", Str, Value);
        }

        // -------------------------------------------------------------------------------
        public static void Row(Grid[,] Grids, int Value, int Row)
        {
            //
            int X = 40;
            int Y = 0;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("s_Value={0}", Value);
            Y += 2;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("Row={0}", Row);

            Y += 1;
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("                      ");
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("[{0},{1}]={2}  {3}:{4}",
                    Row, i, Grids[Row, i].Control, Value, Grids[Row, i].Value);
                Y++;
            }
        }

        // -------------------------------------------------------------------------------
        public static void Node(Grid[,] Grids, int Value, int Node)
        {
            //
            int Index = 0;
            int X = 40;
            int Y = 15;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("s_Value={0}", Value);
            Y += 2;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("Node={0}", Node);

            Y += 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Node == Grids[i, j].Node)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine("                                    ");
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine("{0} [{1},{2}]={3}  Node={4}  {5}:{6}",
                            Index, i, j, Grids[i, j].Control, Grids[i, j].Node, Value, Grids[i, j].Value);
                        Y++;
                        Index++;
                    }//
                }
            }
        }

        // -------------------------------------------------------------------------------
        public static int[,] GetGridError(int Command = 0)
        {
            //
            switch (Command)
            {
                case 0:
                    return s_GridsError0;
                case 1:
                    return s_GridsError1;
            }

            return s_GridsError0;
        }

        // -------------------------------------------------------------------------------
        public static int[,] GetGridOk(int Command = 0)
        {
            //
            switch (Command)
            {
                case 0:
                    return s_GridsOk0;
                case 1:
                    return s_GridsOk0;
            }

            return s_GridsOk0;
        }

        private static int[,] s_GridsOk0 = new int[9, 9]
            {//0  1  2  3  4  5  6  7  8 
             { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, // 0
             { 4, 5, 6, 7, 8, 9, 1, 2, 3 }, // 1
             { 7, 8, 9, 1, 2, 3, 4, 5, 6 }, // 2
             { 2, 3, 4, 5, 6, 7, 8, 9, 1 }, // 3
             { 5, 6, 7, 8, 9, 1, 2, 3, 4 }, // 4
             { 8, 9, 1, 2, 3, 4, 5, 6, 7 }, // 5
             { 3, 4, 5, 6, 7, 8, 9, 1, 2 }, // 6
             { 6, 7, 8, 9, 1, 2, 3, 4, 5 }, // 7
             { 9, 1, 2, 3, 4, 5, 6, 7, 8 }  // 8
            };

        private static int[,] s_GridsError0 = new int[9, 9]
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

        private static int[,] s_GridsError1 = new int[9, 9]
            {//0  1  2  3  4  5  6  7  8  
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 0
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 1
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 2
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 3
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 4
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 5
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 6
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, // 7
             { 0, 1, 2, 3, 4, 5, 6, 7, 8 }  // 8
            };
    }
}
