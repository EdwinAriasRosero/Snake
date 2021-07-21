using System.Collections.Generic;

namespace SnakeConsole
{
    public interface ICollisionableObserver
    {
        void Notify(DrawingObject asset);
    }

    public class CollisionableObserver : ICollisionableObserver
    {
        private List<ICollisionableObserver> _subscribers;

        public CollisionableObserver()
        {
            _subscribers = new List<ICollisionableObserver>();
        }

        public void Subscribe(ICollisionableObserver listener)
        {
            _subscribers.Add(listener);
        }

        public void Notify(DrawingObject asset)
        {
            foreach (ICollisionableObserver listener in _subscribers)
            {
                listener.Notify(asset);
            }
        }
    }
}