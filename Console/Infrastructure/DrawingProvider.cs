using System;

namespace SnakeConsole
{
    public class DrawingProvider : IDrawingProvider
    {
        public void Draw(DrawingObject parent, int left, int top, string symbol)
        {
            if (parent != null)
            {
                if (left < 0 || left >= parent.Location.Width || top >= parent.Location.Height || top < 0)
                {
                    throw new CollistionException("Board");
                }
            }

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
                for (int j = 0; j < height; j++)
                {
                    System.Console.SetCursorPosition(i, j);
                    System.Console.BackgroundColor = System.ConsoleColor.Yellow;
                    System.Console.Write("\0");

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