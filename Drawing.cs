using System;

namespace SnakeConsole
{
    public class Drawing : IDrawing
    {
        public void Draw(int left, int top, char letter)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(left + 1, top + 1);
            Console.Write(letter);
        }
    }
}