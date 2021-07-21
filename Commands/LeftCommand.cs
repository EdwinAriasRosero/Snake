using System.Linq;

namespace SnakeConsole
{
    public class LeftCommand : ICommand
    {
        private readonly Snake _snake;
        private readonly Board _board;

        public LeftCommand(Board board, Snake snake)
        {
            _snake = snake;
            _board = board;
        }

        public void Handle()
        {
            if (_snake.LocationList.ElementAt(0).X > 1)
            {
                _snake.LocationList.Enqueue(new Location(_snake.LocationList.ElementAt(0).X - 1, _snake.LocationList.ElementAt(0).Y));
            }
        }
    }
}