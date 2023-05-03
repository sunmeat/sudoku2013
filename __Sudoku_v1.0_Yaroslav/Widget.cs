using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    abstract class Widget
    {
        //public abstract void Show(); 

        // -------------------------------------------------------------------------------
        public virtual void Show()
        {
            //

        }

        // -------------------------------------------------------------------------------
        public int Column
        {
            //
            get { return m_Column; }
            set { m_Column = value; }
        }

        // -------------------------------------------------------------------------------
        public int Row
        {
            //
            get { return m_Row; }
            set { m_Row = value; }
        }

        // -------------------------------------------------------------------------------
        public ConsoleColor Foreground
        {
            //
            get { return m_Foreground; }
            set { m_Foreground = value; }
        }

        // -------------------------------------------------------------------------------
        public ConsoleColor Background
        {
            //
            get { return m_Background; }
            set { m_Background = value; }
        }

        // -------------------------------------------------------------------------------
        public void Color(ConsoleColor Foreground, ConsoleColor Background)
        {
            //
            m_Foreground = Foreground;
            m_Background = Background;
        }

        // -------------------------------------------------------------------------------
        public void SetCursor()
        {
            //
            SetCursor(m_Column, m_Row);
        }

        // -------------------------------------------------------------------------------
        public void SetCursor(int Column, int Row)
        {
            //
            Console.ForegroundColor = m_Foreground;
            Console.BackgroundColor = m_Background;

            Console.SetCursorPosition(Column, Row);
        }

        // -------------------------------------------------------------------------------
        protected int m_Row = 0;
        protected int m_Column = 0;

        protected ConsoleColor m_Foreground = ConsoleColor.Black;
        protected ConsoleColor m_Background = ConsoleColor.White; //
    }


}
