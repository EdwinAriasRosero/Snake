using Engine;

namespace Galaga
{
    public class Invader : DrawingFixture
    {
        public Invader(IDrawer drawer, Location location) : base(drawer, location)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void HandleCollision(DrawingFixture obj, Location location)
        {
            base.HandleCollision(obj, location);
        }

        public override void Move(Location location)
        {
            base.Move(location);
        }

        public override void Paint()
        {
            base.Paint();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}