namespace Engine
{
    public interface ICollisionableObserver
    {
        void Notify(ICollisionable asset);
    }
}