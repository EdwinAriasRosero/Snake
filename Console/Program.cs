using System;

namespace SnakeConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            IDrawingProvider drawingProvider1 = new DrawingProvider();

            Board board = new Board(drawingProvider1, 50, 50);
            Snake snake = new Snake(drawingProvider1, 20, 20);
            FruitFactory fruitFactory = new FruitFactory(drawingProvider1, board, snake);
            Fruit fruit = fruitFactory.Create(10, 10);

            board.Add(snake);
            board.Add(fruit);

            CommandInvoker commandInvoker = new CommandInvoker();
            SnakeCommandFactory snakeCommandFactory = new SnakeCommandFactory(snake);
            ICommand command = snakeCommandFactory.Create('d');

            try
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        command = snakeCommandFactory.Create(Console.ReadKey(true).KeyChar);
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
