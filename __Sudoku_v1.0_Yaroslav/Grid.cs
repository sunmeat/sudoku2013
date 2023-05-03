using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Grid
    {
        // -------------------------------------------------------------------------------
        public Grid()
        {
            //
            _Set(0, 0, 0, 0, 0, 0);
        }

        // -------------------------------------------------------------------------------
        public Grid(int Node, int Row, int Column, int X, int Y, int Value)
        {
            //
            _Set(Node, Row, Column, X, Y, Value);
        }

        // -------------------------------------------------------------------------------
        public int Node
        {
            //
            get { return m_Node; }
        }

        // -------------------------------------------------------------------------------
        public int Row
        {
            //
            get { return m_Row; }
        }

        // -------------------------------------------------------------------------------
        public int Column
        {
            //
            get { return m_Column; }
        }

        // -------------------------------------------------------------------------------
        public int Value
        {
            //
            get { return m_Value; }
            set
            {
                m_Value = value;

                if (0 == value)
                {
                    m_Control = Flag.OK;
                }
            }
        }

        // -------------------------------------------------------------------------------
        public void Show(int Command = 0)
        {
            //
            Console.SetCursorPosition(m_X, m_Y);

            if (Command == 1)
            {
                if (m_Control == Flag.ERROR)
                {
                    GridColor.ErrorEdit();
                }
                else
                {
                    GridColor.Edit();
                }
            }
            else
            {
                if (m_Constant == Const.YES & m_Control == Flag.OK)
                {
                    GridColor.Constant();
                }
                else if (m_Constant == Const.YES & m_Control == Flag.ERROR)
                {
                    GridColor.ErrorConstant();
                }
                else
                {
                    if (m_Control == Flag.OK)
                    {
                        GridColor.Show();
                    }
                    else
                    {
                        GridColor.Error();
                    }
                }
            }


            if (m_Value == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(m_Value);
            }

            Console.ResetColor();
        }

        // -------------------------------------------------------------------------------
        public void Edit()
        {
            //
            //Debug();
            Show(1);
            Console.SetCursorPosition(m_X, m_Y);
        }

        // -------------------------------------------------------------------------------
        public void Debug()
        {
            //
            GridColor.Show();
            Console.SetCursorPosition(0, 45);
            string Line1 = "m_Node={0}, m_Row={1}, m_Column={2}, m_X={3}, m_Y={4}, m_Value={5}, m_Control={6}, m_Constant={7}";
            Console.WriteLine(
                String.Format(Line1, m_Node, m_Row, m_Column, m_X, m_Y, m_Value, m_Control, m_Constant));
        }

        // -------------------------------------------------------------------------------
        private void _Set(int Node, int Row, int Column, int X, int Y, int Value)
        {
            //
            m_Node = Node;
            m_Row = Row;
            m_Column = Column;
            m_Y = Y;
            m_X = X;
            m_Value = Value;
            m_Control = Flag.OK;
            m_Constant = Const.NO;
        }

        // -------------------------------------------------------------------------------
        public Flag Control
        {
            //
            get { return m_Control; }
            set { m_Control = value; }
        }

        // -------------------------------------------------------------------------------
        public Const Constant
        {
            //
            get { return m_Constant; }
            set { m_Constant = value; }
        }

        // -------------------------------------------------------------------------------
        public enum Flag { OK, ERROR };
        public enum Const { YES, NO };

        private Flag m_Control; // Флаг - ошибки ячейки сетки.
        private Const m_Constant; // Константная ячейка (пользователь не может её менять).
        private int m_Node; // Номер ноды (нумерация от 0 до 8).
        private int m_Row;  // Номер строки.
        private int m_Column; // Номер колонки.
        private int m_X; // Координата ячейки по X.
        private int m_Y; // Координата ячейки по Y.
        private int m_Value; // Значение ячейки.
    }
}
