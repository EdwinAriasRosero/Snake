using System.Collections.Generic;

namespace SnakeConsole
{

    public class Board : DrawObject
    {
        private List<IDrawer> _items;

        public Board(int width, int height)
        {
            LocationList = new Queue<Location>();
            LocationList.Enqueue(new Location(1, 1, width, height));
            _items = new List<IDrawer>();

            DrawBoard();
        }

        public void AddItem(IDrawer item)
        {
            _items.Add(item);
        }

        private void DrawBoard()
        {
            for (int i = 0; i <= Location.Width; i++)
            {
                Drawing.Draw(Parent, i, 0, '▀');
            }

            for (int i = 0; i <= Location.Width; i++)
            {
                Drawing.Draw(Parent, i, Location.Height, '▄');
            }

            for (int i = 0; i <= Location.Height; i++)
            {
                Drawing.Draw(Parent, 0, i, '█');
            }

            for (int i = 0; i <= Location.Height; i++)
            {
                Drawing.Draw(Parent, Location.Width, i, '█');
            }
        }

        public override void Draw()
        {
            foreach (DrawObject drawer in _items)
            {
                drawer.Parent = this;
                drawer.Draw();
            }
        }
    }
}