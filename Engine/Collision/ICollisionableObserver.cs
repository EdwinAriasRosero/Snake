namespace SnakeConsole
{
    public interface ICollisionableObserver
    {
        void Notify(ICollisionable asset);
    }
}