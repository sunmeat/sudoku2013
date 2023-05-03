using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class GridControl
    {
        // -------------------------------------------------------------------------------
        public static void Clear(Grid[,] Grids)
        {
            //
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Grids[i, j].Control = Grid.Flag.OK;
                    Grids[i, j].Show();
                }
            }

        }

        // -------------------------------------------------------------------------------
        public static void Solver(Grid[,] Grids)
        {
            // Проверка - заполнены все сетки.
            Global.StatusGridsFull = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Grids[i, j].Value != 0)
                    {
                        Global.StatusGridsFull++;
                    }

                }
            }

        }

        // -------------------------------------------------------------------------------
        public static void Solver()
        {
            // Проверка - заполнены все сетки.
            Global.StatusGridsFull = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (s_Grids[i, j].Value != 0)
                    {
                        Global.StatusGridsFull++;
                    }

                }
            }

            //
            if (Global.isStatusGridsFull())
            {
                All(s_Grids);
            }

            MessageText.SudokuStatus();
        }

        // -------------------------------------------------------------------------------
        public static bool All(Grid[,] Grids)
        {
            // Проверка всей сетки.
            bool FlagError = false;

            Clear(Grids);

            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    if (Edit(Grids, Row, Column, 0))
                    {
                        FlagError = true;
                    }
                }
            }


            if (FlagError)
            {
                MessageText.SudokuError(); // Есть ошибки.
            }
            else
            {
                if (Global.isStatusGridsFull())
                {
                    MessageText.SudokuVictory(); // Вы выиграли. Судока решена.
                }
                else
                {
                    MessageText.SudokuOk(); // Ошибок нет.
                }
            }

            return FlagError;
        }

        // -------------------------------------------------------------------------------
        public static bool Edit(Grid[,] Grids, int RowIndex, int ColumnIndex, int Mode = 1)
        {
            //
            bool FlagError = false;

            s_RowIndex = RowIndex;
            s_ColumnIndex = ColumnIndex;
            s_Grids = Grids;

            s_Node = Grids[RowIndex, ColumnIndex].Node;
            s_Row = Grids[RowIndex, ColumnIndex].Row;
            s_Column = Grids[RowIndex, ColumnIndex].Column;
            s_Value = Grids[RowIndex, ColumnIndex].Value;

            if (Mode == 1)
            {
                Clear(Grids);
            }

            //if (_Row(Grids))
            //if (_Column(Grids))
            //if (_Node(Grids))
            //if (_Row(Grids) | _Column(Grids))
            if (_Node() | _Column() | _Row())
            {
                FlagError = true;
                Grids[RowIndex, ColumnIndex].Control = Grid.Flag.ERROR;
                MessageText.SudokuError();
            }
            else
            {
                Grids[RowIndex, ColumnIndex].Control = Grid.Flag.OK;
                MessageText.SudokuOk();
            }

            if (Mode == 1)
            {
                Solver();
            }

            Grids[RowIndex, ColumnIndex].Edit();

            //ShowText();

            return FlagError;
        }

        // -------------------------------------------------------------------------------
        private static bool _Row()
        {
            //
            bool FlagError = false;

            for (int i = 0; i < 9; i++)
            {
                if (i != s_ColumnIndex)
                {
                    if (s_Value == s_Grids[s_Row, i].Value && s_Value != 0)
                    {
                        FlagError = true;

                        s_Grids[s_Row, i].Control = Grid.Flag.ERROR;
                    }
                    else
                    {
                        //Grids[s_Row, i].Control = Grid.Flag.OK;
                    }
                }

                s_Grids[s_Row, i].Show();
            }

            //GridDebug.Row(s_Grids, s_Value, s_Row);
            return FlagError;
        }

        // -------------------------------------------------------------------------------
        private static bool _Column()
        {
            //
            bool FlagError = false;

            for (int i = 0; i < 9; i++)
            {
                if (i != s_RowIndex)
                {
                    if (s_Value == s_Grids[i, s_Column].Value && s_Value != 0)
                    {
                        FlagError = true;

                        s_Grids[i, s_Column].Control = Grid.Flag.ERROR;
                    }
                    else
                    {
                        //Grids[i, s_Column].Control = Grid.Flag.OK;
                    }
                }

                s_Grids[i, s_Column].Show();

            }

            //GridDebug.Column(s_Grids, s_Value, s_Column);

            return FlagError;
        }

        // -------------------------------------------------------------------------------
        private static bool _Node()
        {
            //
            bool FlagError = false;

            for (int i = 0; i < 9; i++)
            {
                //
                for (int j = 0; j < 9; j++)
                {
                    if (i != s_RowIndex)
                    {
                        if (s_Value == s_Grids[i, j].Value && s_Value != 0 && s_Node == s_Grids[i, j].Node)
                        {
                            FlagError = true;

                            s_Grids[i, j].Control = Grid.Flag.ERROR;
                        }
                        else
                        {/*
                            if (s_Node == Grids[i, j].Node)
                            {
                                Grids[i, j].Control = Grid.Flag.OK;
                            } // */
                        }
                    }//

                    if (s_Node == s_Grids[i, j].Node)
                    {
                        s_Grids[i, j].Show();
                    }
                }//

            }

            //GridDebug.Node(s_Grids, s_Value, s_Node);

            return FlagError;
        }

        // -------------------------------------------------------------------------------
        private static Grid[,] s_Grids;
        private static int s_RowIndex;
        private static int s_ColumnIndex;

        private static int s_Node;
        private static int s_Row;
        private static int s_Column;
        private static int s_Value;
    }
}
