using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Rect : Widget
    {
        // -------------------------------------------------------------------------------
        public Rect(int Column, int Row, int Width, int Height, ConsoleColor Background = ConsoleColor.White)
        {
            //
            m_Row = Row;
            m_Column = Column;
            m_Width = Width;
            m_Height = Height;
            m_Background = Background;
        }

        // -------------------------------------------------------------------------------
        public override void Show()
        {
            //
            SetCursor();

            for (int i = 0; i <= m_Height; i++)
            {
                for (int j = 0; j <= m_Width; j++)
                {
                    Console.Write(" ");
                }

                Console.SetCursorPosition(m_Column, m_Row + i);
            }

        }

        // -------------------------------------------------------------------------------
        private int m_Width;
        private int m_Height;
    }
}
