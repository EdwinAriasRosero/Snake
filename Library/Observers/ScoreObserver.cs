namespace SnakeConsole
{
    public class ScoreObserver : ICollisionableObserver
    {
        private readonly Snake _snake;
        private readonly Board _board;
        private readonly IDrawingProvider _drawingProvider;

        public ScoreObserver(IDrawingProvider drawingProvider, Snake snake, Board board)
        {
            _snake = snake;
            _board = board;
            _drawingProvider = drawingProvider;
        }

        public void Notify(DrawingObject asset)
        {
            _drawingProvider.SetText(1, _board.Location.Height + 1, $"Score: {_snake.LocationList.Count}");
        }
    }
}
