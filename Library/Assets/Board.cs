namespace SnakeConsole
{
    public class Board : DrawingObject
    {
        public Board(IDrawingProvider drawingProvider, int width, int height) : base(drawingProvider, new Location(1, 1, width, height))
        {
            _drawing.SetBoardDimension(width, height);
        }
    }
}