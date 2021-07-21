namespace SnakeConsole
{
    public class TopCommand : ICommand
    {
        private readonly Snake _snake;

        public TopCommand(Snake snake)
        {
            _snake = snake;
        }

        public void Handle()
        {
            _snake.Move(new Location(_snake.Location.X, _snake.Location.Y - 1));
        }
    }
}