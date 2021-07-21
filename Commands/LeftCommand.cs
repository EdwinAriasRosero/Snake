namespace SnakeConsole
{
    public class LeftCommand : ICommand
    {
        private readonly Snake _snake;

        public LeftCommand(Snake snake)
        {
            _snake = snake;
        }

        public void Handle()
        {
            _snake.Move(new Location(_snake.Location.X - 1, _snake.Location.Y));
        }
    }
}