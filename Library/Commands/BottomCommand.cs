namespace SnakeConsole
{
    public class BottomCommand : ICommand
    {
        private readonly Snake _snake;

        public BottomCommand(Snake snake)
        {
            _snake = snake;
        }

        public void Handle()
        {
            _snake.Move(new Location(_snake.Location.X, _snake.Location.Y + 1));
        }
    }
}