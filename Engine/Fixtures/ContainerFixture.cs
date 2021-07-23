using System.Collections.Generic;

namespace Engine
{
    public abstract class ContainerFixture : CollisionableObserver, ICompositeFixture
    {
        public DrawingFixture Parent { get; set; }

        public List<DrawingFixture> Children { get; set; }

        public ContainerFixture()
        {
            Children = new List<DrawingFixture>();
        }

        public void Add(DrawingFixture asset)
        {
            Children.Add(asset);
        }

        public void Remove(DrawingFixture asset)
        {
            if (!Children.Remove(asset))
            {
                foreach (DrawingFixture child in Children)
                {
                    child.Remove(asset);
                }
            }
        }
    }
}