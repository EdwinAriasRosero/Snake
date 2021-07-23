using Engine;

namespace Snake
{
    public class SnakeGrowingObserver : ICollisionableObserver
    {
        private readonly Board _board;
        private readonly SnakeFixture _snake;

        public SnakeGrowingObserver(Board board, SnakeFixture snake)
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
