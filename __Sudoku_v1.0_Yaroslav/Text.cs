using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Text : Widget
    {
        // -------------------------------------------------------------------------------
        public Text(string Str)
        {
            //
            m_String = Str;
        }

        // -------------------------------------------------------------------------------
        public Text(string Str, int Column, int Row, ConsoleColor Foreground = ConsoleColor.White, ConsoleColor Background = ConsoleColor.Black)
        {
            //
            m_String = Str;
            m_Row = Row;
            m_Column = Column;
            m_Foreground = Foreground;
            m_Background = Background;

        }

        // -------------------------------------------------------------------------------
        public string Value
        {
            //
            get { return m_String; }
            set { m_String = value; }
        }

        // -------------------------------------------------------------------------------
        public override void Show()
        {
            //
            SetCursor();

            Console.Write(m_String);
        }

        // -------------------------------------------------------------------------------
        private string m_String;

    }

}
