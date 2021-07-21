using System.Linq;

namespace SnakeConsole
{
    public class Snake : DrawObject
    {
        public Snake(int x, int y)
        {
            LocationList.Enqueue(new Location(x, y));
        }

        public override void Draw()
        {
            if (LocationList.Count > 1)
            {
                Location lastPosition = LocationList.Dequeue();
                Drawing.Draw(Parent, lastPosition.X, lastPosition.Y, '\0');
            }

            Drawing.Draw(Parent, LocationList.ElementAt(0).X, LocationList.ElementAt(0).Y, '▒');
        }
    }
}