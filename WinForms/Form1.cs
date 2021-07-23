using Snake;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Infrastructure;
using Engine;

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
            IDrawer drawer = new Drawer(this);

            Board board = new Board(drawer, 50, 50);
            SnakeFixture snake = new SnakeFixture(drawer, 20, 20);
            FruitFactory fruitFactory = new FruitFactory(drawer, board, snake);
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
                catch (CollisionException ex)
                {
                    drawer.SetText(1, board.Location.Height + 1, $"GAME OVER............... (Collision {ex.Message})");
                }
            });
        }
    }
}
