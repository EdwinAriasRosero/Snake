using System.Linq;

namespace SnakeConsole
{
    public class BottomCommand : ICommand
    {
        private readonly Snake _snake;
        private readonly Board _board;

        public BottomCommand(Board board, Snake snake)
        {
            _snake = snake;
            _board = board;
        }

        public void Handle()
        {
            _snake.LocationList.Enqueue(new Location(_snake.LocationList.ElementAt(0).X, _snake.LocationList.ElementAt(0).Y + 1));
        }
    }
}