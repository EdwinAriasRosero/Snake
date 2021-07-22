using System;

namespace SnakeConsole
{
    public class Drawer : IDrawer
    {
        public void Draw(DrawingFixture parent, int left, int top, string symbol)
        {
            Console.SetCursorPosition(left + 1, top + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = System.ConsoleColor.Yellow;
            Console.Write(symbol);

            Console.SetCursorPosition(0, 0);
        }

        public void SetBoardDimension(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.BackgroundColor = System.ConsoleColor.Yellow;
                    Console.Write("\0");

                }
            }

            Console.SetWindowSize(width, height + 5);
            System.Console.BackgroundColor = System.ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
        }

        public void SetText(int x, int y, string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = System.ConsoleColor.Black;
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            Console.SetCursorPosition(0, 0);
        }
    }
}