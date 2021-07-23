using System;
using Engine;
using Snake;

namespace SnakeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawer drawer = new Drawer();
            Board board = new Board(drawer, 30, 30);
            SnakeFixture snake = new SnakeFixture(drawer, 2, 2);
            FruitFactory fruitFactory = new FruitFactory(drawer, board, snake);
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
            catch (CollisionException ex)
            {
                drawer.SetText(1, board.Location.Height + 1, $"GAME OVER............... (Collision {ex.Message})");
                Console.ReadKey();
            }
        }
    }
}
