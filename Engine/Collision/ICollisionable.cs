namespace Engine
{
    public interface ICollisionable
    {
        void HandleCollision(DrawingFixture obj, Location location);
    }

}