using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public class Snake : DrawingObject
    {
        private Location _previousPosition;

        public Snake(int x, int y) : base(new Location(x, y))
        {
        }

        public override void Paint()
        {
            var snakeHead = LocationList.First();
            RootObject
                .Find(snakeHead.X, snakeHead.Y)
                .ForEach(x => x.HandleCollision(x, snakeHead));

            Location headLocation = LocationList.First();
            Paint(headLocation.X, headLocation.Y, "▒");

            if (_previousPosition != null)
            {
                Paint(_previousPosition.X, _previousPosition.Y, "\0");
            }
        }

        public void Move(Location location)
        {
            LocationList.AddFirst(location);
            _previousPosition = LocationList.Last();
            LocationList.RemoveLast();
        }

        public void Grow()
        {
            LocationList.AddLast(_previousPosition);
            _previousPosition = null;
        }

        public override void HandleCollision(DrawingObject obj, Location location)
        {
            List<Location> bodyPositions = LocationList.Skip(1).ToList();

            if (bodyPositions.Any(body => body.X == location.X && body.Y == location.Y))
            {
                throw new CollistionException("Snake");
            }
        }
    }
}