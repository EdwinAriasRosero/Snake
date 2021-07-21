using System.Linq;

namespace SnakeConsole
{
    public class RightCommand : ICommand
    {
        private readonly Snake _snake;
        private readonly Board _board;

        public RightCommand(Board board, Snake snake)
        {
            _snake = snake;
            _board = board;
        }

        public void Handle()
        {
            _snake.LocationList.Enqueue(new Location(_snake.LocationList.ElementAt(0).X + 1, _snake.LocationList.ElementAt(0).Y));
        }
    }
}