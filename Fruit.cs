using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public class Fruit : IDrawer
    {
        private readonly IDrawing _drawing;

        public Fruit(IDrawing drawing, int x, int y)
        {
            _drawing = drawing;
            Position= new Queue<Position>();
            Position.Enqueue(new Position(x, y));
        }

        public Queue<Position> Position { get; set; }

        public void Draw()
        {
            _drawing.Draw(Position.ElementAt(0).X, Position.ElementAt(0).Y, '₧');
        }
    }

}