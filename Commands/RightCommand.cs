namespace SnakeConsole
{
    public class RightCommand : ICommand
    {
        private readonly Snake _snake;

        public RightCommand(Snake snake)
        {
            _snake = snake;
        }

        public void Handle()
        {
            _snake.LocationList.Enqueue(new Location(_snake.Location.X + 1, _snake.Location.Y));
        }
    }
}