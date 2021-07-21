namespace SnakeConsole
{
    public class Fruit : DrawingObject
    {
        private bool _isDrawed = false;

        public Fruit(int x, int y) : base(new Location(x, y))
        {
        }

        public override void Paint()
        {
            Paint(Location.X, Location.Y, '₧');
        }

        public override void HandleCollision(DrawingObject obj)
        {
            if (!_isDrawed)
            {
                RootObject.RemoveChild(this);
                _isDrawed = true;
            }
        }
    }

}