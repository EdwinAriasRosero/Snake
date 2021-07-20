using System;
using System.Collections.Generic;

namespace SnakeConsole
{
    public class Board : IDrawer
    {
        private List<IDrawer> _items;
        private readonly int _width;
        private readonly int _height;

        public Queue<Position> Position { get; set; }

        public Board(int width, int height)
        {
            _width = width;
            _height = height;
            _items = new List<IDrawer>();

            DrawBoard();
        }

        public void AddItem(IDrawer item)
        {
            _items.Add(item);
        }


        private void DrawBoard()
        {
            for (int i = 0; i <= _width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("▀");
            }

            for (int i = 0; i <= _width; i++)
            {
                Console.SetCursorPosition(i, _height);
                Console.Write("▄");
            }

            for (int i = 0; i <= _height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("█");
            }

            for (int i = 0; i <= _height; i++)
            {
                Console.SetCursorPosition(_width, i);
                Console.Write("█");
            }
        }

        public void Draw()
        {
            foreach (IDrawer drawer in _items)
            {
                drawer.Draw();
            }
        }
    }
}