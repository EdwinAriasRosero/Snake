using System.Linq;

namespace SnakeConsole
{
    public class Fruit : DrawObject
    {
        public Fruit(int x, int y) : base()
        {
            LocationList.Enqueue(new Location(x, y));
        }

        public override void Draw()
        {
            Drawing.Draw(Parent, LocationList.ElementAt(0).X, LocationList.ElementAt(0).Y, '₧');
        }
    }

}