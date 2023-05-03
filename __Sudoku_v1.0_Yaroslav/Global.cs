using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Global
    {
        // -------------------------------------------------------------------------------
        public static Mode Game
        {
            //
            get { return s_Game; }
            set
            {
                s_Game = value;

                switch (s_Game)
                {
                    case Mode.EASY:
                        s_Constant = 4;
                        break;

                    case Mode.MEDIUM:
                        s_Constant = 3;
                        break;

                    case Mode.HARD:
                        s_Constant = 2;
                        break;
                }

            }
        }

        // -------------------------------------------------------------------------------
        public static int Constant
        {
            //
            get { return s_Constant; }
        }

        // -------------------------------------------------------------------------------
        public static int StatusGridsFull
        {
            //
            get { return s_StatusGridsFull; }
            set { s_StatusGridsFull = value; }
        }

        // -------------------------------------------------------------------------------
        public static int WindowWidth
        {
            //
            get { return s_WindowWidth; }
            set { s_WindowWidth = value; }
        }

        // -------------------------------------------------------------------------------
        public static int WindowHeight
        {
            //
            get { return s_WindowHeight; }
            set { s_WindowHeight = value; }
        }

        // -------------------------------------------------------------------------------
        public static bool isStatusGridsFull()
        {
            // Проверка - заполнены все ячейки сетки.
            if (s_StatusGridsFull == 81)
            {
                return true;
            }
            return false;
        }

        // -------------------------------------------------------------------------------
        public enum Mode { EASY, MEDIUM, HARD };

        private static Mode s_Game = Mode.EASY; //
        private static int s_Constant = 4; // Количество открытых клеток в ноде (зависит от уровня).

        //
        private static int s_StatusGridsFull = 0; // Общие количество заполненных полей в сетке.
        private static int s_WindowWidth = 36;   // 37
        private static int s_WindowHeight = 49;
    }
}
