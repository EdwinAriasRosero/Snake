namespace SnakeConsole
{
    public class Snake : DrawingObject
    {
        public Snake(int x, int y) : base(new Location(x, y))
        {
        }

        public override void Paint()
        {
            if (LocationList.Count > 1)
            {
                Location lastPosition = LocationList.Dequeue();
                Paint(lastPosition.X, lastPosition.Y, '\0');
            }

            foreach (Location location in LocationList)
            {
                RootObject
                    .Find(location.X, location.Y)
                    .ForEach(x => x.HandleCollision(x));

                Paint(location.X, location.Y, '▒');
            }

        }
    }
}