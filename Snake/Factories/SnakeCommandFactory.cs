using Engine;

namespace Snake
{
    public class SnakeCommandFactory
    {
        private readonly SnakeFixture _snake;

        public SnakeCommandFactory(SnakeFixture snake)
        {
            _snake = snake;
        }

        public ICommand Create(char key)
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