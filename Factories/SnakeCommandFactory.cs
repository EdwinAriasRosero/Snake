namespace SnakeConsole
{
    public class SnakeCommandFactory
    {
        private readonly Snake _snake;

        public SnakeCommandFactory(Snake snake)
        {
            _snake = snake;
        }

        public ICommand Create(char key = '\0')
        {
            ICommand command = null;

            switch (key.ToString().ToLower())
            {
                case "a":
                    command = new LeftCommand(_snake);
                    break;
                case "s":
                    command = new BottomCommand(_snake);
                    break;
                case "w":
                    command = new TopCommand(_snake);
                    break;
                case "d":
                    command = new RightCommand(_snake);
                    break;
            }

            return command;
        }
    }
}