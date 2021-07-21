using System;

namespace SnakeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(30, 30);
            Snake snake = new Snake(1, 1);
            Fruit fruit = new Fruit(10, 10);

            board.AddChild(snake);
            board.AddChild(fruit);

            CommandInvoker commandInvoker = new CommandInvoker();
            ICommand command = new RightCommand(snake);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    switch (key.KeyChar)
                    {
                        case 'a':
                            command = new LeftCommand(snake);
                            break;
                        case 's':
                            command = new BottomCommand(snake);
                            break;
                        case 'w':
                            command = new TopCommand(snake);
                            break;
                        case 'd':
                            command = new RightCommand(snake);
                            break;
                    }
                }

                commandInvoker.Invoke(command);
                board.Draw();
                System.Threading.Thread.Sleep(50);
            }

        }
    }
}
