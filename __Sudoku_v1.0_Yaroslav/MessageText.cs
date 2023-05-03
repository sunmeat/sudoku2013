using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class MessageText : WindowColor
    {
        // -------------------------------------------------------------------------------
        public static void Sudoku(int Index)
        {
            //
            if (Index >= s_Sudoku.Length || Index < -1)
            {
                Index = 0;
            }

            s_Sudoku[Index].Show();
        }

        // -------------------------------------------------------------------------------
        public static void SudokuMenu()
        {
            //
            for (int i = 4; i <= 10; i++)
            {
                s_Sudoku[i].Show();
            }
        }

        // -------------------------------------------------------------------------------
        public static void SudokuStatus()
        {
            //
            //GridDebug.T(40, 37, Global.StatusGridsFull);

            s_Sudoku[11].Value = "                     ";
            s_Sudoku[12].Value = "                     ";
            s_Sudoku[11].Show();
            s_Sudoku[12].Show();

            s_Sudoku[11].Value = "Заполнено клеток : " + Global.StatusGridsFull;
            s_Sudoku[12].Value = "Режим игры : " + Global.Game;
            s_Sudoku[11].Show();
            s_Sudoku[12].Show();
        }

        // -------------------------------------------------------------------------------
        public static void SudokuVictory()
        {
            //
            s_Sudoku[0].Show();
            s_Sudoku[1].Show();
        }

        // -------------------------------------------------------------------------------
        public static void SudokuOk()
        {
            //
            s_Sudoku[0].Show();
            s_Sudoku[3].Show();
        }

        // -------------------------------------------------------------------------------
        public static void SudokuError()
        {
            //
            s_Sudoku[0].Show();
            s_Sudoku[2].Show();
        }

        // -------------------------------------------------------------------------------
        public static void SudokuGameOver()
        {
            //
            s_Sudoku[13].Value = "                            ";
            s_Sudoku[13].Show();

            s_Sudoku[13].Value = "Вы проиграли :-(";
            s_Sudoku[13].Show();
        }


        // -------------------------------------------------------------------------------
        public static void SudokuNewGame()
        {
            //
            s_Sudoku[14].Value = "                            ";
            s_Sudoku[14].Show();

            s_Sudoku[14].Value = "Новая игра. Желаю Удачи!";
            s_Sudoku[14].Show();
        }

        // -------------------------------------------------------------------------------
        private static int s_Column0 = 1;
        private static int s_Row0 = 37;
        private static int s_Row1 = 38;
        private static int s_Row2 = 39;
        private static int s_Row3 = 41;

        private static Text[] s_Sudoku = { 
         new Text("                           ", s_Column0, s_Row0, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground), // 0
         new Text("Вы выиграли. Судока решена.", s_Column0, s_Row0, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground), // 1
         new Text("Есть ошибки!", s_Column0, s_Row0, s_WindowSudokuRectForeground3, s_WindowSudokuRectBackground), // 2
         new Text("Ошибок нет.", s_Column0, s_Row0, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground),  // 3
         new Text("F2 — Легкая игра (EASY).", s_Column0, s_Row3, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 4
         new Text("F3 — Средняя игра (MEDIUM).", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 5
         new Text("F4 — Тяжелая игра (HARD).", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 6
         new Text("F5 — Сдаюсь. Показать решение.", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 7
         new Text("F6 или [Enter] — Начать новую игру.", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 8
         new Text("F7 — Проверить все поля.", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 9
         new Text("Esc — Выход в меню.", s_Column0, s_Row3 += 1, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground),  // 10
         new Text("Заполнено клеток : ", s_Column0, s_Row1, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground),  // 11
         new Text("Режим игры : ", s_Column0, s_Row2, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground),  // 12
         new Text("Вы проиграли :-(", s_Column0, s_Row0, s_WindowSudokuRectForeground3, s_WindowSudokuRectBackground), // 13
         new Text("Новая игра.", s_Column0, s_Row0, s_WindowSudokuRectForeground2, s_WindowSudokuRectBackground), // 13
         new Text(" ", s_Column0, s_Row0, s_WindowSudokuRectForeground, s_WindowSudokuRectBackground) };
    }
}
