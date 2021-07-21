using System.Collections.Generic;

namespace SnakeConsole
{
    public abstract class CompositeObject
    {
        public DrawingObject Parent { get; set; }

        public List<DrawingObject> Children { get; set; }

        public CompositeObject()
        {
            Children = new List<DrawingObject>();
        }

        public void AddChild(DrawingObject asset)
        {
            Children.Add(asset);
        }

        public void RemoveChild(DrawingObject asset)
        {
            if (!Children.Remove(asset))
            {
                foreach (DrawingObject child in Children)
                {
                    child.RemoveChild(asset);
                }

            }
        }
    }
}