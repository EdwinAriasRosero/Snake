using System;

namespace SnakeConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(50, 50);
            Snake snake = new Snake(20, 20);
            FruitFactory fruitFactory = new FruitFactory(board, snake);
            Fruit fruit = fruitFactory.Create(10, 10);

            board.Add(snake);
            board.Add(fruit);

            CommandInvoker commandInvoker = new CommandInvoker();
            ICommand command = new RightCommand(snake);

            try
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);

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
            catch (CollistionException ex)
            {
                IDrawingProvider drawingProvider = new DrawingProvider();
                drawingProvider.SetText(1, board.Location.Height + 1, $"GAME OVER............... (Collision {ex.Message})");

                Console.ReadKey();
            }


        }
    }
}
