namespace SnakeConsole
{
    public class Fruit : DrawingObject
    {
        private bool _isDrawed = false;

        public Fruit(IDrawingProvider drawingProvider, int x, int y) : base(drawingProvider, new Location(x, y))
        {
        }

        public override void Paint()
        {
            //if (!_isDrawed)
            //{
                Paint(Location.X, Location.Y, "▒");
                _isDrawed = true;
            //}
        }

        public override void HandleCollision(DrawingObject obj, Location location)
        {
            RootObject.Remove(this);
            this.Notify(this);
        }
    }
}