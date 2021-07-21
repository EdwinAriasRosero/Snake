using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public abstract class DrawingObject : CompositeObject, ICollisionable
    {
        public LinkedList<Location> LocationList { get; set; }

        public Location Location => LocationList.First();

        protected readonly IDrawingProvider _drawing;

        public DrawingObject RootObject
        {
            get
            {
                DrawingObject rootObject = this;

                while (rootObject.Parent != null)
                {
                    rootObject = rootObject.Parent;
                }

                return rootObject;
            }
        }

        public DrawingObject(IDrawingProvider drawingProvider, Location location)
        {
            LocationList = new LinkedList<Location>();
            LocationList.AddFirst(location);

            _drawing = drawingProvider;
        }

        public List<DrawingObject> Find(int x, int y)
        {
            List<DrawingObject> foundObjects = new List<DrawingObject>();

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
                DrawingObject drawer = Children[i];
                drawer.Parent = this;
                drawer.Paint();
            }
        }

        public virtual void Paint() { }

        public virtual void HandleCollision(DrawingObject obj, Location location) { }
    }

}