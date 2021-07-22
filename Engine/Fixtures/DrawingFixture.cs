using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public abstract class DrawingFixture : ContainerFixture, ILocalizable, ICollisionable
    {
        public LinkedList<Location> LocationList { get; set; }

        public Location Location => LocationList.First();

        protected readonly IDrawer _drawing;

        public DrawingFixture RootObject
        {
            get
            {
                DrawingFixture rootObject = this;

                while (rootObject.Parent != null)
                {
                    rootObject = rootObject.Parent;
                }

                return rootObject;
            }
        }

        public DrawingFixture(IDrawer drawer, Location location)
        {
            LocationList = new LinkedList<Location>();
            LocationList.AddFirst(location);

            _drawing = drawer;
        }

        public List<DrawingFixture> Find(int x, int y)
        {
            List<DrawingFixture> foundObjects = new List<DrawingFixture>();

            if (LocationList.Any(loc => loc.X == x && loc.Y == y))
            {
                foundObjects.Add(this);
            }

            Children.ForEach(child => foundObjects.AddRange(child.Find(x, y)));

            return foundObjects;
        }

        public void Paint(int left, int top, string symbol)
        {
            _drawing.Draw(Parent, left, top, symbol);
        }

        public void Draw()
        {
            Paint();
            DrawChildren();
        }

        private void DrawChildren()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                DrawingFixture drawer = Children[i];
                drawer.Parent = this;
                drawer.Paint();
            }
        }

        public virtual void Move(Location location) { }

        public virtual void Paint() { }

        public virtual void HandleCollision(DrawingFixture obj, Location location) { }
    }

}