namespace SnakeConsole
{
    public class Board : DrawingObject
    {
        public Board(int width, int height) : base(new Location(1, 1, width, height))
        {
            _drawing.SetBoardDimension(width, height);
        }
    }
}