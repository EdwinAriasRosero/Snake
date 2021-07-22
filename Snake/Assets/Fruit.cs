namespace SnakeConsole
{
    public class Fruit : DrawingFixture
    {
        public Fruit(IDrawer drawer, int x, int y) : base(drawer, new Location(x, y))
        {
        }

        public override void Paint()
        {
            Paint(Location.X, Location.Y, "▒");
        }

        public override void HandleCollision(DrawingFixture obj, Location location)
        {
            RootObject.Remove(this);
            this.Notify(this);
        }
    }
}