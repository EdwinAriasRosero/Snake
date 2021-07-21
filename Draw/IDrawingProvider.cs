namespace SnakeConsole
{
    public interface IDrawingProvider
    {
        void Draw(DrawingObject parent, int left, int top, char letter);
    }
}