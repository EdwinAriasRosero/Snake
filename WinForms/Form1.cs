using SnakeConsole;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Infrastructure;

namespace WinForms
{
    public partial class Form1 : Form
    {
        ICommand command;
        SnakeCommandFactory snakeCommandFactory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            command = snakeCommandFactory.Create(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDrawingProvider drawingProvider = new DrawingProvider(this);

            Board board = new Board(drawingProvider, 50, 50);
            Snake snake = new Snake(drawingProvider, 20, 20);
            FruitFactory fruitFactory = new FruitFactory(drawingProvider, board, snake);
            Fruit fruit = fruitFactory.Create(10, 10);

            board.Add(snake);
            board.Add(fruit);

            CommandInvoker commandInvoker = new CommandInvoker();
            snakeCommandFactory = new SnakeCommandFactory(snake);
            command = snakeCommandFactory.Create('d');


            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        commandInvoker.Invoke(command);
                        board.Draw();
                        System.Threading.Thread.Sleep(1000/60);
                    }
                }
                catch (CollistionException ex)
                {
                    drawingProvider.SetText(1, board.Location.Height + 1, $"GAME OVER............... (Collision {ex.Message})");
                }
            });
        }
    }
}
