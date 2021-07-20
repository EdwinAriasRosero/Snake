using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public class Snake : IDrawer
    {
        public Queue<Position> Position { get; set; }
        private readonly IDrawing _drawing;

        public Snake(IDrawing drawing)
        {
            _drawing = drawing;
            Position = new Queue<Position>();
            Position.Enqueue(new Position(1, 1));
        }

        public void Draw()
        {
            if (Position.Count > 1)
            {
                Position lastPosition = Position.Dequeue();
                _drawing.Draw(lastPosition.X, lastPosition.Y, '\0');
            }

            _drawing.Draw(Position.ElementAt(0).X, Position.ElementAt(0).Y, '▒');
        }
    }
}