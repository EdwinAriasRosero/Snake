namespace SnakeConsole
{
    public class Board : DrawingObject
    {
        private bool _isDrawed;

        public Board(int width, int height) : base(new Location(1, 1, width, height))
        {
        }

        public override void Paint()
        {
            if (!_isDrawed)
            {
                for (int i = 0; i <= Location.Width; i++)
                {
                    Paint(i, 0, '▀');
                    Paint(i, Location.Height, '▄');
                }

                for (int i = 0; i <= Location.Height; i++)
                {
                    Paint(0, i, '█');
                    Paint(Location.Width, i, '█');
                }

                _isDrawed = true;
            }
        }
    }
}