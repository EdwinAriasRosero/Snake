using System.Collections.Generic;

namespace SnakeConsole
{
    public abstract class CompositeObject : CollisionableObserver
    {
        public DrawingObject Parent { get; set; }

        public List<DrawingObject> Children { get; set; }

        public CompositeObject()
        {
            Children = new List<DrawingObject>();
        }

        public void Add(DrawingObject asset)
        {
            Children.Add(asset);
        }

        public void Remove(DrawingObject asset)
        {
            if (!Children.Remove(asset))
            {
                foreach (DrawingObject child in Children)
                {
                    child.Remove(asset);
                }

            }
        }
    }
}