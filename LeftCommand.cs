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
            if (_snake.Position.ElementAt(0).X > 1)
            {
                _snake.Position.Enqueue(new Position(_snake.Position.ElementAt(0).X - 1, _snake.Position.ElementAt(0).Y));
            }
        }
    }

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
            _snake.Position.Enqueue(new Position(_snake.Position.ElementAt(0).X + 1, _snake.Position.ElementAt(0).Y));
        }
    }

    public class TopCommand : ICommand
    {
        private readonly Snake _snake;
        private readonly Board _board;

        public TopCommand(Board board, Snake snake)
        {
            _snake = snake;
            _board = board;
        }

        public void Handle()
        {
            if (_snake.Position.ElementAt(0).Y > 1)
            {
                _snake.Position.Enqueue(new Position(_snake.Position.ElementAt(0).X, _snake.Position.ElementAt(0).Y - 1));
            }
        }
    }

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
            _snake.Position.Enqueue(new Position(_snake.Position.ElementAt(0).X, _snake.Position.ElementAt(0).Y + 1));
        }
    }

    public class CommandInvoker
    {
        public void Invoke(ICommand command)
        {
            if (command != null)
            {
                command.Handle();
            }
        }
    }
}