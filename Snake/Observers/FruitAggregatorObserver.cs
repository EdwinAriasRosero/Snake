namespace SnakeConsole
{
    public class FruitAggregatorObserver : ICollisionableObserver
    {
        private readonly Board _board;
        private readonly FruitFactory _fruitFactory;

        public FruitAggregatorObserver(Board board, FruitFactory fruitFactory)
        {
            _board = board;
            _fruitFactory = fruitFactory;
        }

        public void Notify(DrawingFixture asset)
        {
            Fruit fruit = _fruitFactory.Create();
            _board.Add(fruit);
        }
    }
}