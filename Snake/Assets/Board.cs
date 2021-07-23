namespace SnakeConsole
{
    public class Board : DrawingFixture
    {
        public Board(IDrawer drawer, int width, int height) : base(drawer, new Location(1, 1, width, height))
        {
            _drawer.SetBoardDimension(width, height);

            LocationList.Clear();

            for (int i = -1; i <= width; i++)
            {
                for (int j = -1; j <= height; j++)
                {
                    if (i == -1 || j == -1 || i == width || j == height)
                    {
                        LocationList.AddLast(new Location(i, j, width, height));
                    }
                }
            }
        }

        public override void HandleCollision(DrawingFixture obj, Location location)
        {
            throw new CollisionException("board");
        }
    }
}