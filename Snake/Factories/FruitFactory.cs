using System;

namespace SnakeConsole
{
    public class FruitFactory
    {
        private readonly Board _board;
        private readonly Snake _snake;
        private readonly IDrawer _drawingProvider;

        public FruitFactory(IDrawer drawer, Board board, Snake snake)
        {
            _board = board;
            _snake = snake;
            _drawingProvider = drawer;
        }

        public Fruit Create(int x, int y)
        {
            Fruit fruit = new Fruit(_drawingProvider, x, y);

            fruit.Subscribe(new SnakeGrowingObserver(_board, _snake));
            fruit.Subscribe(new FruitAggregatorObserver(_board, this));
            fruit.Subscribe(new ScoreObserver(_drawingProvider, _snake, _board));

            return fruit;
        }

        public Fruit Create()
        {
            Fruit fruit = Create(new Random().Next(0, _board.Location.Width - 1), new Random().Next(0, _board.Location.Height) - 1);
            return fruit;
        }
    }
}
