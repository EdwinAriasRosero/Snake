using System;

namespace SnakeConsole
{
    public class DrawingProvider : IDrawingProvider
    {
        public void Draw(DrawingObject parent, int left, int top, char letter)
        {
            if (parent != null)
            {
                if (left >= parent.Location.Width - 1 || top >= parent.Location.Height - 1 || left < 1 || top < 1)
                {
                    throw new Exception("Game over");
                }
            }

            Console.SetCursorPosition(left + 1, top + 1);
            Console.Write(letter);
        }
    }
}