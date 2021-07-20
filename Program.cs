﻿using System;
using System.Threading;

namespace SnakeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawing drawing = new Drawing();
            Board board = new Board(30, 30);
            Snake snake = new Snake(drawing);
            Fruit fruit = new Fruit(drawing, 10, 10);

            board.AddItem(snake);
            board.AddItem(fruit);

            board.Draw();

            CommandInvoker commandInvoker = new CommandInvoker();
            ICommand command = new RightCommand(board, snake);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    switch (key.KeyChar)
                    {
                        case 'a':
                            command = new LeftCommand(board, snake);
                            break;
                        case 's':
                            command = new BottomCommand(board, snake);
                            break;
                        case 'w':
                            command = new TopCommand(board, snake);
                            break;
                        case 'd':
                            command = new RightCommand(board, snake);
                            break;
                    }
                }

                commandInvoker.Invoke(command);
                board.Draw();
                System.Threading.Thread.Sleep(200);
            }

        }
    }
}