namespace SnakeConsole
{
    public class ScoreObserver : ICollisionableObserver
    {
        private readonly Snake _snake;
        private readonly Board _board;
        private readonly IDrawer _drawingProvider;

        public ScoreObserver(IDrawer drawer, Snake snake, Board board)
        {
            _snake = snake;
            _board = board;
            _drawingProvider = drawer;
        }

        public void Notify(ICollisionable asset)
        {
            _drawingProvider.SetText(1, _board.Location.Height + 1, $"Score: {_snake.LocationList.Count}");
        }
    }
}
