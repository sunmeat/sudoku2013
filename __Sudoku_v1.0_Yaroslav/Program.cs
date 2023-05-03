using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        // -------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            bool FlagDebug = false;
            int Width;
            int Height;

            //FlagDebug = true; // Debug!

            if (FlagDebug)
            {
                Width = 100;
                Height = 50;
            }
            else
            {
                Width = Global.WindowWidth + 2;
                Height = Global.WindowHeight + 1;
            }

            Console.Clear();
            Console.Title = "Cудоку — Шаг. Версия 1.0";
            Console.SetWindowSize(Width, Height);
            Console.BufferWidth = Width;
            Console.BufferHeight = Height;
            Console.CursorVisible = false;

            //GridTemplate.Show();
            //GridDriver.Start(); MessageText
            //WindowSudoku.Show(); WindowAbout
            WindowF1.Init();
            WindowMenu.Init();
            WindowAbout.Init();

            //WindowAbout.Show();

            WindowMenu.Show();


            //Console.ReadKey(); 
        }
    }
}
