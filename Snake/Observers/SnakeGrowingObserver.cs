namespace SnakeConsole
{
    public class SnakeGrowingObserver : ICollisionableObserver
    {
        private readonly Board _board;
        private readonly Snake _snake;

        public SnakeGrowingObserver(Board board, Snake snake)
        {
            _board = board;
            _snake = snake;
        }

        public void Notify(ICollisionable asset)
        {
            _snake.Grow();
        }
    }
}
