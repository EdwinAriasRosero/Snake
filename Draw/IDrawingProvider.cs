namespace SnakeConsole
{
    public interface IDrawingProvider
    {
        void Draw(DrawingObject parent, int left, int top, string symbol);

        void SetBoardDimension(int width, int height);

        void SetText(int x, int y, string text);
    }
}