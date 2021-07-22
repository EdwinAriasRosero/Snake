namespace SnakeConsole
{
    public interface ICollisionable
    {
        void HandleCollision(DrawingFixture obj, Location location);
    }

}