namespace SnakeConsole
{
    public class ScoreObserver : ICollisionableObserver
    {
        private readonly Snake _snake;
        private readonly Board _board;

        public ScoreObserver(Snake snake, Board board)
        {
            _snake = snake;
            _board = board;
        }

        public void Notify(DrawingObject asset)
        {
            IDrawingProvider drawingProvider = new DrawingProvider();
            drawingProvider.SetText(1, _board.Location.Height + 1, $"Score: {_snake.LocationList.Count}");
        }
    }
}
